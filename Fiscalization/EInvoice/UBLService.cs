using EInvoice.Models.UBL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using UblSharp;
using UblSharp.CommonExtensionComponents;

namespace EInvoice
{
    public class UBLService
    {
        public string CreateXML(UBLInvoice ublInvoice)
        {
            var ublInvoiceType = ublInvoice.ToInvoiceType();
            ublInvoiceType.UBLExtensions = new List<UBLExtensionType>
                {
                    new UBLExtensionType
                    {
                        ExtensionContent = CreateSignatureExtension()
                    }
                };
            ublInvoiceType.UBLExtensions.First().Xmlns = null;
            var xml = ublInvoiceType.ToXDocument();
            var xmlText = xml.ToString();
            return xmlText;
        }





        private XmlElement CreateSignatureExtension()
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(ExtensionContent));

            var contentExt = new ExtensionContent
            {
                UBLDocumentSignatures = new UBLDocumentSignatures
                {
                    SignatureInformation = new SignatureInformation
                    {

                    }
                }
            };
            XmlDocument xmlDocExt = new XmlDocument();
            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, contentExt);

                    var xmlExt = sww.ToString();

                    xmlDocExt.LoadXml(xmlExt);
                }
            }
            return (XmlElement)xmlDocExt.GetElementsByTagName("SignatureInformation").Item(0);
        }

        [XmlRoot(ElementName = "ExtensionContent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        [Serializable()]
        public class ExtensionContent
        {
            [XmlElement(ElementName = "UBLDocumentSignatures", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonSignatureComponents-2")]
            public UBLDocumentSignatures UBLDocumentSignatures { get; set; }

            [XmlElement(ElementName = "any_element", Namespace = "otherNS")]
            public Any_element Any_element { get; set; }
        }

        [XmlRoot(ElementName = "UBLDocumentSignatures", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonSignatureComponents-2")]
        [Serializable()]
        public class UBLDocumentSignatures
        {
            //[XmlElement(ElementName = "SignatureInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2")]
            [XmlElement(ElementName = "SignatureInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2")]
            public SignatureInformation SignatureInformation { get; set; }
        }

        [XmlRoot(ElementName = "SignatureInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2")]
        [Serializable()]
        public class SignatureInformation
        {
            [XmlElement(ElementName = "any_element", Namespace = "otherNS")]
            public Any_element Any_element { get; set; }

            [XmlText]
            public string Text { get; set; }

            [XmlAttribute(AttributeName = "xmlns")]
            public string Xmlns { get; set; }

        }

        [XmlRoot(ElementName = "any_element", Namespace = "otherNS")]
        [Serializable()]
        public class Any_element
        {
            [XmlAttribute(AttributeName = "xmlns")]
            public string Xmlns { get; set; }
            [XmlText]
            public string Text { get; set; }
        }
    }
}
