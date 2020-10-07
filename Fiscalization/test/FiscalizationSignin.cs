using System;
using System.Data.SqlTypes;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;
using test.ServiceReference1;

namespace Fiscalization
{
    class FiscalizationSignin
    {
        private static String KEYSTORE_LOCATION = Path.Combine(Environment.CurrentDirectory, "smartwork.p12");
        private const String KEYSTORE_PASS = "123456";


        public static string GenerateIIC()
        {
            String iicInput = "I12345678I";

            using (X509Certificate2 keyStore = new X509Certificate2(KEYSTORE_LOCATION, KEYSTORE_PASS))
            {
                try
                {
                    // Load a private from a key store
                    RSA privateKey = keyStore.GetRSAPrivateKey();
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
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return null;
        }

        public const String XML_SCHEMA_NS = "https://eFiskalizimi.tatime.gov.al/FiscalizationService/schema";
        public const String XML_REQUEST_ID = "Request";
        public const String XML_SIG_METHOD = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256";
        public const String XML_DIG_METHOD = "http://www.w3.org/2001/04/xmlenc#sha256";
        private const String REQUEST_TO_SIGN =
        "<RegisterInvoiceRequest " +
        " xmlns=\"https://eFiskalizimi.tatime.gov.al/FiscalizationService/schema\" " +
        " xmlns:ns2=\"http://www.w3.org/2000/09/xmldsig#\" " +
        " Id=\"Request\" " +
        " Version=\"3\">\r\n" +
        " <Header>...</Header>\r\n" +
        " <Invoice>...</Invoice>\r\n" +
        "</RegisterInvoiceRequest>";

        public static string GenerateSignature()
        {
            using (X509Certificate2 keyStore = new X509Certificate2(KEYSTORE_LOCATION, KEYSTORE_PASS))
            {
                try
                {
                    // Load a private from a key store
                    RSA privateKey = keyStore.GetRSAPrivateKey();
                    // Convert string XML to object
                    XmlDocument request = new XmlDocument();
                    request.LoadXml(REQUEST_TO_SIGN);
                    // Create key info element
                    KeyInfo keyInfo = new KeyInfo();
                    KeyInfoX509Data keyInfoData = new KeyInfoX509Data();
                    keyInfoData.AddCertificate(keyStore);
                    keyInfo.AddClause(keyInfoData);
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
                    request.DocumentElement.AppendChild(signature);
                    // Convert signed request to string and print
                    StringWriter sw = new StringWriter();
                    XmlTextWriter xw = new XmlTextWriter(sw);
                    request.WriteTo(xw);
                    

                    return sw.ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            return null;
        }

        public static string SignRequest(string requestXML)
        {
            using (X509Certificate2 keyStore = new X509Certificate2(KEYSTORE_LOCATION, KEYSTORE_PASS))
            {

                // Load a private from a key store
                RSA privateKey = keyStore.GetRSAPrivateKey();
                // Convert string XML to object
                XmlDocument request = new XmlDocument();
                request.LoadXml(requestXML);
                // Create key info element
                KeyInfo keyInfo = new KeyInfo();
                KeyInfoX509Data keyInfoData = new KeyInfoX509Data();
                keyInfoData.AddCertificate(keyStore);
                keyInfo.AddClause(keyInfoData);
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
        }

        public static string SignIICSignature(string iicInput)
        {
            using (X509Certificate2 keyStore = new X509Certificate2(KEYSTORE_LOCATION, KEYSTORE_PASS))
            {
                try
                {
                    // Load a private from a key store
                    RSA privateKey = keyStore.GetRSAPrivateKey();

                    // Create IIC signature according to RSASSA-PKCS-v1_5
                    byte[] iicSignature = privateKey.SignData(Encoding.ASCII.GetBytes(iicInput), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

                    string iicSignatureString = BitConverter.ToString(iicSignature).Replace("-", string.Empty);

                    return iicSignatureString;
                }
                catch (Exception)
                {
                    //throw;
                }
            }
            return string.Empty;
        }

        //public static SignatureType GenerateSignatureType()
        //{
        //    KeyInfoX509Data keyInfoData = null;
        //    byte[] certificate = null;
        //    using (X509Certificate2 keyStore = new X509Certificate2(KEYSTORE_LOCATION, KEYSTORE_PASS))
        //    {
        //        try
        //        {
        //            // Load a private from a key store
        //            RSA privateKey = keyStore.GetRSAPrivateKey();
        //            certificate = keyStore.RawData;
        //            keyStore.PrivateKey



        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }

        //    }
        //    return new SignatureType
        //    {
        //        Id = "1",
        //        KeyInfo = new KeyInfoType
        //        {
        //            Id = "1",
        //            ItemsElementName = new ItemsChoiceType2[] {ItemsChoiceType2.X509Data},
        //            Items = new X509DataType[] { 
        //                new X509DataType{
        //                    ItemsElementName = new ItemsChoiceType[] { ItemsChoiceType.X509Certificate},
        //                    Items = new object[]{ certificate}
        //                }
        //            }
        //        },
        //        SignedInfo = new SignedInfoType
        //        {
        //            CanonicalizationMethod = new CanonicalizationMethodType
        //            {
        //                Algorithm = ""http://www.w3.org/2001/10/xml-exc-c14n#"
        //            },
        //            SignatureMethod = new SignatureMethodType
        //            {
        //               Algorithm = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256"
        //            },
        //            Reference = new ReferenceType[] {
        //                new ReferenceType{
        //                    URI = "#Response",
        //                    Transforms = new  TransformType[]{
        //                        new TransformType{ Algorithm = "http://www.w3.org/2000/09/xmldsig#enveloped-signature"},
        //                        new TransformType{ Algorithm = "http://www.w3.org/2001/10/xml-exc-c14n#"},
        //                    },
        //                    DigestMethod = new DigestMethodType { Algorithm = "http://www.w3.org/2001/04/xmlenc#sha256"},

        //                },
        //            },

        //        },
        //        SignatureValue = new SignatureValueType
        //        {

        //        }
        //    };
        //}
    }
}
