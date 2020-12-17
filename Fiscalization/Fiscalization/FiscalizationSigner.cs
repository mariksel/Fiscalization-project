using System;
using System.Data.SqlTypes;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;

namespace Fiscalization
{
    public class FiscalizationSigner
    {
        private static String KEYSTORE_LOCATION = Path.Combine(Environment.CurrentDirectory, "smartwork.p12");
        private const String KEYSTORE_PASS = "123456";

        private static RSA privateKey { get; set; }
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




        
        public const String XML_SCHEMA_NS = "https://eFiskalizimi.tatime.gov.al/FiscalizationService/schema";
        public const String XML_REQUEST_ID = "Request";
        public const String XML_SIG_METHOD = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256";
        public const String XML_DIG_METHOD = "http://www.w3.org/2001/04/xmlenc#sha256";

       

        public static string SignRequest(string requestXML)
        {



            // Convert string XML to object
            XmlDocument request = new XmlDocument();
            request.LoadXml(requestXML);

            // Create signature reference
            Reference reference = new Reference("");
            reference.AddTransform(new XmlDsigEnvelopedSignatureTransform(false));
            reference.AddTransform(new XmlDsigExcC14NTransform(false));
            reference.DigestMethod = XML_DIG_METHOD;
            reference.Uri = "#" + XML_REQUEST_ID;
            // Create signature
            SignedXml xml = new SignedXml(request);
            xml.SigningKey = privateKey;
            xml.SignedInfo.CanonicalizationMethod = SignedXml.XmlDsigExcC14NTransformUrl;
            xml.SignedInfo.SignatureMethod = XML_SIG_METHOD;
            xml.KeyInfo = keyInfo;
            xml.AddReference(reference);
            xml.ComputeSignature();
            // Add signature element to the request
            XmlElement signature = xml.GetXml();

            // Set the body id - not in used but could be useful at a later stage of this project
            XmlNamespaceManager ns = new XmlNamespaceManager(request.NameTable);
            ns.AddNamespace("s", "http://schemas.xmlsoap.org/soap/envelope/");
            XmlElement body = request.DocumentElement.SelectSingleNode(@"//s:Body", ns) as XmlElement;
            if (body == null)
                throw new ApplicationException("No body tag found");
            body.RemoveAllAttributes();  // no need to have namespace



            // Append the Signature element to the First child of the Body.
            // The first child of Body is actually the Request. This is where the sign xml element should be placed
            body.FirstChild.AppendChild(signature);

            //body.AppendChild(signature);
            // Convert signed request to string and print
            //StringWriter sw = new StringWriter();
            //XmlTextWriter xw = new XmlTextWriter(sw);
            //request.WriteTo(xw);

            return request.InnerXml;


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


        public static string SignIICSignature(string iicInput)
        {
            // Create IIC signature according to RSASSA-PKCS-v1_5
            byte[] iicSignature = privateKey.SignData(Encoding.ASCII.GetBytes(iicInput), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

            string iicSignatureString = BitConverter.ToString(iicSignature).Replace("-", string.Empty);

            return iicSignatureString;

        }

    }
}
