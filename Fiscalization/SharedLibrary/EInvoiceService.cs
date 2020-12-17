using EInvoice;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SharedLibrary
{
    public class EInvoiceService
    {

        public EInvoiceService()
        {
            FiscalizationSigner.SetKeyStoreLocation(FiscalizationSigner.KEYSTORE_LOCATION);
        }

        public static DateTime GetDateTimeNow()
        {
            var date = DateTime.Now;
            date = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second, DateTimeKind.Local);
            return date;
        }

        public async Task<GetTaxpayersResponse> GetTaxPayers(string value, ItemChoiceType1 filterType)
        {
            EInvoiceClient Client = new EInvoiceClient();
            var date = EInvoiceService.GetDateTimeNow();


            var request = new GetTaxpayersRequest
            {
                Header = new GetTaxpayersRequestHeaderType
                {
                    SendDateTime = date,
                    UUID = "a737f2f9-214d-4841-a3d9-331e7b2b3618"
                },
                Filter = new TaxpayerFilterType
                {
                    //Item = "L41316032F",
                    //ItemElementName = ItemChoiceType1.Tin
                    Item = value,
                    ItemElementName = filterType
                }
            };

            var res = (await Client.getTaxpayersAsync(request)).GetTaxpayersResponse;
            return res;
        }
    }

    public class EInvoiceClient : EinvoiceServicePortTypeClient
    {
        public EInvoiceClient()
        {
            var endpointBehavior = new XMLSignerEndpointBehavior();
            Endpoint.EndpointBehaviors.Add(endpointBehavior);
        }
    }

    public class XMLSignerEndpointBehavior : IEndpointBehavior
    {
        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {
            // throw new NotImplementedException();
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            SignerMessageInspector msi = new SignerMessageInspector();
            clientRuntime.ClientMessageInspectors.Add(msi);
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
            //throw new NotImplementedException();
        }

        public void Validate(ServiceEndpoint endpoint)
        {
            //throw new NotImplementedException();
        }
    }

    public class SignerMessageInspector : IClientMessageInspector
    {
        public void AfterReceiveReply(ref Message reply, object correlationState)
        {

        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            request.Headers.RemoveAt(0);
            request = InterceptAndSign(request);
            return null;
        }

        private Message InterceptAndSign(Message message)
        {
            //https://adamstorr.azurewebsites.net/blog/debugging-wcf-messages-before-serialization

            // read the message into an XmlDocument as then you can work with the contents 
            // Message is a forward reading class only so once read that's it. 
            MemoryStream ms = new MemoryStream();
            XmlWriter writer = XmlWriter.Create(ms);
            message.WriteMessage(writer);
            writer.Flush();
            ms.Position = 0;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.PreserveWhitespace = true;
            xmlDoc.Load(ms);

            string xmlSOAPNotSigned = xmlDoc.OuterXml;

            var signedXML = FiscalizationSigner.SignRequest(xmlSOAPNotSigned);
            Debug.WriteLine(signedXML);

            // Sign the XML as text
            //string xmlSOAPSigned = UtilFiscalization.SignXMRequest(xmlSOAPNotSigned);



            // Convert XML text to XmlDocument
            xmlDoc = new XmlDocument();
            xmlDoc.PreserveWhitespace = true;
            xmlDoc.LoadXml(signedXML);

            // as the message is forward reading then we need to recreate it before moving on 
            ms = new MemoryStream();
            xmlDoc.Save(ms);
            ms.Position = 0;
            XmlReader reader = XmlReader.Create(ms);
            Message newMessage = Message.CreateMessage(reader, int.MaxValue, message.Version);
            newMessage.Properties.CopyProperties(message.Properties);
            message = newMessage;
            return message;
        }


    }

    public class FiscalizationSigner
    {
        public static String KEYSTORE_LOCATION = Path.Combine(Environment.CurrentDirectory, "eltonzhuleku.p12");
        private const String KEYSTORE_PASS = "123456";


        private static RSA _privateKey;
        public static RSA privateKey
        {
            get
            {
                if (_privateKey is null)
                    throw new NullReferenceException();
                return _privateKey;
            }
            set => _privateKey = value;
        }
        public static KeyInfo keyInfo { get; set; }



        public static void SetKeyStoreLocation(string keyStorePath)
        {
            KEYSTORE_LOCATION = keyStorePath;

            byte[] fileBytes = null;
            using (var memoryStream = new MemoryStream())
            {
                File.OpenRead("eltonzhuleku.p12").CopyTo(memoryStream);
                fileBytes = memoryStream.ToArray();
            }

            //string certDataString = "MIIFZzCCBE+gAwIBAgIKQ5SSV+aFmNiPizANBgkqhkiG9w0BAQsFADBLMQswCQYDVQQGEwJBTDENMAsGA1UEChMETkFJUzEtMCsGA1UEAxMkTkFJUyBDbGFzcyAzIENlcnRpZmljYXRpb24gQXV0aG9yaXR5MB4XDTIwMDQwNzA4NTAzOVoXDTIxMDQwNzA4NTAzOVowfzELMAkGA1UEBhMCQUwxDzANBgNVBAcTBlRpcmFuZTEWMBQGA1UEChMNRWx0b24gWmh1bGVrdTENMAsGA1UEDBMEVGVzdDEjMCEGA1UEAxMaRWx0b24gWmh1bGVrdSBGaXNrYWxpemltaTExEzARBgNVBAQTCkw0MTMxNjAzMkYwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQC/wjYnXUn8M7EyjFl1Iv7e8psMjIMWi/jNv46JJj5HYc3IabWHmOMfDP+h8G/01XQEeenUsaE7dnbnKSQUjgDPpK9D+RZx2634EMxNb7D6nZLsmtRV0EfsoERJZkeTnFWerCbCkmiG2MvBhMDQ21wv3M/kYOZ1P1jBmMNhRI0NF6rvRVio7PyJULpc4Iyho5E6fMnMJGj9KomghM34L3puGMT9DOH26wjjF75yYv3myvBSNM7JaR5sY223BPcTzMeoisZD4L867wS8yrwrXsyd89GmH4ZZpeETQU7YN5G4UCYYC2I021QaDZjXZj1d6XNLfmb4P0uTh6TwwWkgZpaJAgMBAAGjggIXMIICEzBmBggrBgEFBQcBAQRaMFgwJAYIKwYBBQUHMAGGGGh0dHA6Ly9vY3NwLmFrc2hpLmdvdi5hbDAwBggrBgEFBQcwAoYkaHR0cDovL2NlcnRzLmFrc2hpLmdvdi5hbC9jbGFzczMuY3J0MA4GA1UdDwEB/wQEAwIE8DAfBgNVHSMEGDAWgBSHJqj72ytRmznQmNb0xjNWR1zYBTAdBgNVHQ4EFgQUEMmYro8YGQ1regg5jZ5M4i1E2DcwSwYDVR0gBEQwQjBABgwrBgEEAYKxbAoBAQMwMDAuBggrBgEFBQcCARYiaHR0cDovL3d3dy5ha3NoaS5nb3YuYWwvcmVwb3NpdG9yeTCBpwYDVR0fBIGfMIGcMIGZoIGWoIGThiJodHRwOi8vY3JsLmFrc2hpLmdvdi5hbC9jbGFzczMuY3Jshm1sZGFwOi8vbGRhcC5ha3NoaS5nb3YuYWwvQ049TkFJUyBDbGFzcyAzIENlcnRpZmljYXRpb24gQXV0aG9yaXR5LE89TkFJUyxDPUFMP2NlcnRpZmljYXRlUmV2b2NhdGlvbkxpc3Q7YmluYXJ5MEMGA1UdEQQ8MDqgIwYKKwYBBAGCNxQCA6AVDBNlX3podWxla3VAeWFob28uY29tgRNlX3podWxla3VAeWFob28uY29tMB0GA1UdJQQWMBQGCCsGAQUFBwMCBggrBgEFBQcDBDANBgkqhkiG9w0BAQsFAAOCAQEAGDkjgyJApAFq3e5r7MPVMVH7vrEsE+efL4gzBRbGuRqCPZIs9VmW2FhfF/VwYNBEDYow5t11L3FsK/VIQQquU2StzbAIUWZt5ypy5ravTcy6qCzuE+MByL4BufDTpAP+EgPWUkq/Pn4Su1T9X6BttUSEJtlfgrjtwuXFXxz5wh4dWxWitool3NIgRNgpUeTJmwiG9Z2T8WX6OodZ2eqFg68GKr8P0SgCV1k94iv820omaKv0RXqZ5w4L+pLLFf1iKqxaxgb7TnL3TKEjq4mzhl5akmyNXIPcva6hrL8Nea6AxGFFr/hlb0CuRzbt6RnI9RUhs9ugp7fi/GOSxhhVnA==";

            fileBytes = Convert.FromBase64String(certDataString);

            using (X509Certificate2 keyStore = new X509Certificate2(fileBytes, KEYSTORE_PASS, 
                X509KeyStorageFlags.Exportable))
            {
                var dataString = Convert.ToBase64String(keyStore.RawData);

                try
                {
                    // Load a private from a key store
                    privateKey = keyStore.GetRSAPrivateKey();

                    var data = privateKey.ExportRSAPrivateKey();
                    var xml = privateKey.ToXmlString(true);

                    var rsa = RSA.Create();
                    rsa.ImportRSAPrivateKey(data, out int read);
                    var newdata = rsa.ExportRSAPrivateKey();
                    var xml2 = rsa.ToXmlString(true);

                    privateKey = rsa;

                    rsa.FromXmlString("<RSAKeyValue><Modulus>v8I2J11J/DOxMoxZdSL+3vKbDIyDFov4zb+OiSY+R2HNyGm1h5jjHwz/ofBv9NV0BHnp1LGhO3Z25ykkFI4Az6SvQ/kWcdut+BDMTW+w+p2S7JrUVdBH7KBESWZHk5xVnqwmwpJohtjLwYTA0NtcL9zP5GDmdT9YwZjDYUSNDReq70VYqOz8iVC6XOCMoaOROnzJzCRo/SqJoITN+C96bhjE/Qzh9usI4xe+cmL95srwUjTOyWkebGNttwT3E8zHqIrGQ+C/Ou8EvMq8K17MnfPRph+GWaXhE0FO2DeRuFAmGAtiNNtUGg2Y12Y9XelzS35m+D9Lk4ek8MFpIGaWiQ==</Modulus><Exponent>AQAB</Exponent><P>/PRreBJLEizFKSiElqch8MCl1iQk8O2F3fu7/VvbDczSM5Mrb+qCabkulSYrA9Ezkqwt2O1T+kALXnIsJVktTkboyquGan+O+V+6SjW5HcH3Pt+bALfqBfvIF06Zb01US3727zAzAlTo7QWJ7e6tOg6251chOm3h2r3VivYgFVM=</P><Q>whExEKaWev/HHT3KEDhUEOz4rDJlwHKPp8xuflV+qa2yhhgz2soDpoasI1GBekU3Skpb/BqhshkaJs6fSgkkdOohH6GKc49TspHZoxojzgUtBIZ9KYUMSgzNpFosjRQCWBc+ftBt0rRTfEK2vo3V0f8aSNdfxbxRG+D5MZmabTM=</Q><DP>gIdhI/2Hj5CYDbW8yR/bKw14NjrfWlwWLRkACFhoEbcFB5e79n3eDgI+HSLrsGDYJ6q9EQBmLz3jiPXSYJfTYXa+SlylS+/MogF2EscBbJFmI9hSVicdDjVFEjKp29gbANFef2KqSIEEaYrq7q7b7igT37Bx/dJfdFoI6zbsTmk=</DP><DQ>IRUVLCV52ZXot49k9sbjbc83xQMCXYAqBQzQeTDR2tMFb96IWG+/l4+1oH+wdst91Wg/rgZMMjQdRShL9y7/y/5tjxrWo0R3nCVI2IkIOYKgXfkfNQi9Q5JTLAVDOvmCPMoZmTymvBiJctFcnbdID/hQ3sH4TZkAqqP7Vv08Wgk=</DQ><InverseQ>bBkMJH7yImiZ6qp6Zgf3Jm0ERWZefhaDHEA2ERlc4kS5Dk86UBdKxi1+6zEoEQSbkONKkZxZe0p0yY7sOmOvI3rjOpW7qhhzDRKh1uVe5Miz2mo9s4S+K4KMf7obbCEGXaPM0kkQUp6QAZR4tx17+xhVBm69nvoknFQz6f4KGkQ=</InverseQ><D>S+z8/jcc3UQmbCpQHWY+3k3XAG/+U4YWfHjVWg6PaDocfbcFTmxFuXyvFxKZcaq2pjMTV8kBWwb762lJxO24+n5tew98SJa/2lHkYuDPhVuw2ggv/M5cPB/1Cc76lkK3T/0/15ia1JGwk64ZnljMtpLKqdWISnJLlVQEQFYhN0Yvw7O4qYYNkQCkHcQE4g6iIRe92Z2Eqyiv/hE9NJjc+Q7sMGn4UyyhmhjGbk+maf4wjAI1o9gvGdlQWsdKqAZabWrTLXV/5a351nScESPqv4MtAsMnQKBvYHcw7v8dL3PZrcjmSWvD9getuhMYu3aNeElGQTkcqNcDsqTQmPPZdQ==</D></RSAKeyValue>");

                    keyInfo = new KeyInfo();
                    KeyInfoX509Data keyInfoData = new KeyInfoX509Data();
                    keyInfoData.AddCertificate(keyStore);
                    keyInfo.AddClause(keyInfoData);

                    var kifxml = keyInfo.GetXml().OuterXml;
                    var xmlel = new XmlDocument();
                    xmlel.LoadXml(kifxml);
                    keyInfo.LoadXml((XmlElement)xmlel.FirstChild);
                    kifxml = keyInfo.GetXml().OuterXml;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }




        public static string GenerateIIC(string iicInput)
        {
            // Create IIC signature according to RSASSA-PKCS-v1_5
            byte[] iicSignature = privateKey.SignData(Encoding.ASCII.GetBytes(iicInput), HashAlgorithmName.SHA256,
           RSASignaturePadding.Pkcs1);
            string iicSignatureString = BitConverter.ToString(iicSignature).Replace("-", string.Empty);
            Console.WriteLine("The IIC signature is: " + iicSignatureString);
            // Hash IIC signature with MD5 to create IIC
            byte[] iic = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(iicSignature);
            string iicString = BitConverter.ToString(iic).Replace("-", string.Empty);


            return iicString;
        }

        public const String XML_SCHEMA_NS = "https://Einvoice.tatime.gov.al/EinvoiceService/schema";
        public const String XML_REQUEST_ID = "Request";
        public const String XML_SIG_METHOD = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256";
        public const String XML_DIG_METHOD = "http://www.w3.org/2001/04/xmlenc#sha256";



        public static string SignRequest(string requestXML)
        {

            // Convert string XML to object
            XmlDocument request = new XmlDocument();
            request.LoadXml(requestXML);


            // Set the body id - not in used but could be useful at a later stage of this project
            XmlNamespaceManager ns = new XmlNamespaceManager(request.NameTable);
            ns.AddNamespace("s", "http://schemas.xmlsoap.org/soap/envelope/");
            XmlElement body = request.DocumentElement.SelectSingleNode(@"//s:Body", ns) as XmlElement;
            if (body == null)
                throw new ApplicationException("No body tag found");
            body.RemoveAllAttributes();  // no need to have namespace

            var signature = GetSignature(request, "#" + XML_REQUEST_ID);

            body.FirstChild.AppendChild(signature);

            return request.InnerXml;
        }

        public static string SignXmlMessage(string unsignedXml)
        {
            XmlDocument request = new XmlDocument();
            request.LoadXml(unsignedXml);

            var invoiceElm = ((XmlElement)request.GetElementsByTagName("Invoice").Item(0));
            invoiceElm.SetAttribute("Id", "Message");

            var signature = GetSignature(request, "#Message");

            invoiceElm.AppendChild(signature);

            invoiceElm.RemoveAttribute("Id");

            return request.InnerXml;
        }

        public static XmlElement GetSignature(XmlDocument doc, string uri)
        {

            // Create signature reference
            Reference reference = new Reference("");
            reference.AddTransform(new XmlDsigEnvelopedSignatureTransform(false));
            reference.AddTransform(new XmlDsigExcC14NTransform(false));
            reference.DigestMethod = XML_DIG_METHOD;
            reference.Uri = uri;
            // Create signature
            SignedXml xml = new SignedXml(doc);
            xml.SigningKey = privateKey;
            xml.SignedInfo.CanonicalizationMethod = SignedXml.XmlDsigExcC14NTransformUrl;
            xml.SignedInfo.SignatureMethod = XML_SIG_METHOD;
            xml.KeyInfo = keyInfo;
            xml.AddReference(reference);
            xml.ComputeSignature();


            XmlElement signature = xml.GetXml();


            return signature;
        }

        public static string SignIICSignature(string iicInput)
        {
            // Create IIC signature according to RSASSA-PKCS-v1_5
            byte[] iicSignature = privateKey.SignData(Encoding.ASCII.GetBytes(iicInput), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

            string iicSignatureString = BitConverter.ToString(iicSignature).Replace("-", string.Empty);

            return iicSignatureString;

        }

    }
}
