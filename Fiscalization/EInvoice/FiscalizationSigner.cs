using System;
using System.Data.SqlTypes;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;
using System.Linq;

namespace EInvoice
{
    public class FiscalizationSigner
    {
        private static String KEYSTORE_LOCATION = Path.Combine(Environment.CurrentDirectory, "smartwork.p12");
        private const String KEYSTORE_PASS = "123456";


        private static RSA _privateKey;
        private static RSA privateKey {
            get
            {
                if (_privateKey is null)
                    throw new NullReferenceException();
                return _privateKey;
            }
            set => _privateKey = value; 
        }
        private static KeyInfo keyInfo { get; set; }

        public static void SetKeyStoreLocation(string keyStorePath)
        {
            KEYSTORE_LOCATION = keyStorePath;

            using (X509Certificate2 keyStore = new X509Certificate2(KEYSTORE_LOCATION, KEYSTORE_PASS))
            {
                try
                {
                    // Load a private from a key store
                    privateKey = keyStore.GetRSAPrivateKey();

                    keyInfo = new KeyInfo();
                    KeyInfoX509Data keyInfoData = new KeyInfoX509Data();
                    keyInfoData.AddCertificate(keyStore);
                    keyInfo.AddClause(keyInfoData);
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
