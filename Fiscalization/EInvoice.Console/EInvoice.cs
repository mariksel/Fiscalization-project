using System;
using System.Xml.Serialization;
using System.Collections.Generic;

  
namespace FiscalizationV1.ubl
{
    [XmlRoot(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class ID 
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "InvoicedQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class InvoicedQuantity 
    {
        [XmlAttribute(AttributeName = "unitCode")]
        public string unitCode { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class Name
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ExtensionAgencyID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [Serializable()]
    public class ExtensionAgencyID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ExtensionAgencyName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [Serializable()]
    public class ExtensionAgencyName
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ExtensionVersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [Serializable()]
    public class ExtensionVersionID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ExtensionAgencyURI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [Serializable()]
    public class ExtensionAgencyURI
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ExtensionURI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [Serializable()]
    public class ExtensionURI
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ExtensionReasonCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [Serializable()]
    public class ExtensionReasonCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ExtensionReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [Serializable()]
    public class ExtensionReason
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlText]
        public string Text { get; set; }
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


    [XmlRoot(ElementName = "UBLExtension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [Serializable()]
    public class UBLExtension
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID { get; set; }
        [XmlElement(ElementName = "Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Name Name { get; set; }
        [XmlElement(ElementName = "ExtensionAgencyID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        public ExtensionAgencyID ExtensionAgencyID { get; set; }
        [XmlElement(ElementName = "ExtensionAgencyName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        public ExtensionAgencyName ExtensionAgencyName { get; set; }
        [XmlElement(ElementName = "ExtensionVersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        public ExtensionVersionID ExtensionVersionID { get; set; }
        [XmlElement(ElementName = "ExtensionAgencyURI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        public ExtensionAgencyURI ExtensionAgencyURI { get; set; }
        [XmlElement(ElementName = "ExtensionURI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        public ExtensionURI ExtensionURI { get; set; }
        [XmlElement(ElementName = "ExtensionReasonCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        public ExtensionReasonCode ExtensionReasonCode { get; set; }
        [XmlElement(ElementName = "ExtensionReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        public ExtensionReason ExtensionReason { get; set; }
        [XmlElement(ElementName = "ExtensionContent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        public ExtensionContent ExtensionContent { get; set; }
    }

    [XmlRoot(ElementName = "UBLExtensions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [Serializable()]
    public class UBLExtensions
    {
        [XmlElement(ElementName = "UBLExtension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        public List<UBLExtension> UBLExtension { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "UBLVersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class UBLVersionID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CustomizationID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class CustomizationID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ProfileID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class ProfileID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ProfileExecutionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class ProfileExecutionID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CopyIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class CopyIndicator
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class UUID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class IssueDate
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class IssueTime
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class DueDate
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "InvoiceTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class InvoiceTypeCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class Note
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxPointDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class TaxPointDate
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DocumentCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class DocumentCurrencyCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class TaxCurrencyCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PricingCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class PricingCurrencyCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PaymentCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class PaymentCurrencyCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PaymentAlternativeCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class PaymentAlternativeCurrencyCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AccountingCostCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class AccountingCostCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AccountingCost", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class AccountingCost
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "LineCountNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class LineCountNumeric
    {
        [XmlAttribute(AttributeName = "format")]
        public string Format { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "BuyerReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class BuyerReference
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "StartDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class StartDate
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "StartTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class StartTime
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "EndDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class EndDate
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "EndTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class EndTime
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DurationMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class DurationMeasure
    {
        [XmlAttribute(AttributeName = "unitCode")]
        public string UnitCode { get; set; }
        [XmlAttribute(AttributeName = "unitCodeListVersionID")]
        public string UnitCodeListVersionID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DescriptionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class DescriptionCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class Description
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "InvoicePeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class InvoicePeriod
    {
        [XmlElement(ElementName = "StartDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public StartDate StartDate { get; set; }
        [XmlElement(ElementName = "StartTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public StartTime StartTime { get; set; }
        [XmlElement(ElementName = "EndDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EndDate EndDate { get; set; }
        [XmlElement(ElementName = "EndTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EndTime EndTime { get; set; }
        [XmlElement(ElementName = "DurationMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DurationMeasure DurationMeasure { get; set; }
        [XmlElement(ElementName = "DescriptionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<DescriptionCode> DescriptionCode { get; set; }
        [XmlElement(ElementName = "Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Description> Description { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "SalesOrderID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class SalesOrderID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CustomerReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class CustomerReference
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "OrderTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class OrderTypeCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DocumentTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class DocumentTypeCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DocumentType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class DocumentType
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "XPath", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class XPath
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "LanguageID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class LanguageID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "LocaleCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class LocaleCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "VersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class VersionID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DocumentStatusCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class DocumentStatusCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DocumentDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class DocumentDescription
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "EmbeddedDocumentBinaryObject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class EmbeddedDocumentBinaryObject
    {
        [XmlAttribute(AttributeName = "mimeCode")]
        public string MimeCode { get; set; }
        [XmlAttribute(AttributeName = "format")]
        public string Format { get; set; }
        [XmlAttribute(AttributeName = "encodingCode")]
        public string EncodingCode { get; set; }
        [XmlAttribute(AttributeName = "characterSetCode")]
        public string CharacterSetCode { get; set; }
        [XmlAttribute(AttributeName = "uri")]
        public string Uri { get; set; }
        [XmlAttribute(AttributeName = "filename")]
        public string Filename { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "URI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class URI
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "DocumentHash", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class DocumentHash
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "HashAlgorithmMethod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class HashAlgorithmMethod
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ExpiryDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class ExpiryDate
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ExpiryTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class ExpiryTime
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MimeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class MimeCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "FormatCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class FormatCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "EncodingCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class EncodingCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CharacterSetCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class CharacterSetCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "FileName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class FileName
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ExternalReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class ExternalReference
    {
        [XmlElement(ElementName = "URI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public URI URI { get; set; }
        [XmlElement(ElementName = "DocumentHash", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentHash DocumentHash { get; set; }
        [XmlElement(ElementName = "HashAlgorithmMethod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HashAlgorithmMethod HashAlgorithmMethod { get; set; }
        [XmlElement(ElementName = "ExpiryDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExpiryDate ExpiryDate { get; set; }
        [XmlElement(ElementName = "ExpiryTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExpiryTime ExpiryTime { get; set; }
        [XmlElement(ElementName = "MimeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MimeCode MimeCode { get; set; }
        [XmlElement(ElementName = "FormatCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FormatCode FormatCode { get; set; }
        [XmlElement(ElementName = "EncodingCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EncodingCode EncodingCode { get; set; }
        [XmlElement(ElementName = "CharacterSetCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CharacterSetCode CharacterSetCode { get; set; }
        [XmlElement(ElementName = "FileName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FileName FileName { get; set; }
    }

    [XmlRoot(ElementName = "Attachment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class Attachment
    {
        [XmlElement(ElementName = "EmbeddedDocumentBinaryObject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EmbeddedDocumentBinaryObject EmbeddedDocumentBinaryObject { get; set; }
        [XmlElement(ElementName = "ExternalReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExternalReference ExternalReference { get; set; }
    }

    [XmlRoot(ElementName = "MarkCareIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class MarkCareIndicator
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MarkAttentionIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class MarkAttentionIndicator
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "WebsiteURI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class WebsiteURI
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "LogoReferenceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class LogoReferenceID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "EndpointID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class EndpointID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "IndustryClassificationCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class IndustryClassificationCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PartyIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class PartyIdentification
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID { get; set; }
    }

    [XmlRoot(ElementName = "PartyName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class PartyName
    {
        [XmlElement(ElementName = "Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Name Name { get; set; }
    }

    [XmlRoot(ElementName = "AddressTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class AddressTypeCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AddressFormatCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class AddressFormatCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Postbox", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class Postbox
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Floor", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class Floor
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Room", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class Room
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "StreetName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class StreetName
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AdditionalStreetName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class AdditionalStreetName
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "BlockName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class BlockName
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "BuildingName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class BuildingName
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "BuildingNumber", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class BuildingNumber
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "InhouseMail", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class InhouseMail
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Department", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class Department
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MarkAttention", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class MarkAttention
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MarkCare", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class MarkCare
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PlotIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class PlotIdentification
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CitySubdivisionName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class CitySubdivisionName
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CityName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class CityName
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PostalZone", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class PostalZone
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CountrySubentity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class CountrySubentity
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CountrySubentityCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class CountrySubentityCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Region", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class Region
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "District", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class District
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TimezoneOffset", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class TimezoneOffset
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Line", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class Line
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AddressLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class AddressLine
    {
        [XmlElement(ElementName = "Line", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Line Line { get; set; }
    }

    [XmlRoot(ElementName = "IdentificationCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class IdentificationCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Country", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class Country
    {
        [XmlElement(ElementName = "IdentificationCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentificationCode IdentificationCode { get; set; }
    }

    [XmlRoot(ElementName = "CoordinateSystemCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class CoordinateSystemCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "LatitudeDegreesMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class LatitudeDegreesMeasure
    {
        [XmlAttribute(AttributeName = "unitCode")]
        public string UnitCode { get; set; }
        [XmlAttribute(AttributeName = "unitCodeListVersionID")]
        public string UnitCodeListVersionID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "LatitudeMinutesMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class LatitudeMinutesMeasure
    {
        [XmlAttribute(AttributeName = "unitCode")]
        public string UnitCode { get; set; }
        [XmlAttribute(AttributeName = "unitCodeListVersionID")]
        public string UnitCodeListVersionID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "LatitudeDirectionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class LatitudeDirectionCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "LongitudeDegreesMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class LongitudeDegreesMeasure
    {
        [XmlAttribute(AttributeName = "unitCode")]
        public string UnitCode { get; set; }
        [XmlAttribute(AttributeName = "unitCodeListVersionID")]
        public string UnitCodeListVersionID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "LongitudeMinutesMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class LongitudeMinutesMeasure
    {
        [XmlAttribute(AttributeName = "unitCode")]
        public string UnitCode { get; set; }
        [XmlAttribute(AttributeName = "unitCodeListVersionID")]
        public string UnitCodeListVersionID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "LongitudeDirectionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class LongitudeDirectionCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AltitudeMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class AltitudeMeasure
    {
        [XmlAttribute(AttributeName = "unitCode")]
        public string UnitCode { get; set; }
        [XmlAttribute(AttributeName = "unitCodeListVersionID")]
        public string UnitCodeListVersionID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "LocationCoordinate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class LocationCoordinate
    {
        [XmlElement(ElementName = "CoordinateSystemCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CoordinateSystemCode CoordinateSystemCode { get; set; }
        [XmlElement(ElementName = "LatitudeDegreesMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatitudeDegreesMeasure LatitudeDegreesMeasure { get; set; }
        [XmlElement(ElementName = "LatitudeMinutesMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatitudeMinutesMeasure LatitudeMinutesMeasure { get; set; }
        [XmlElement(ElementName = "LatitudeDirectionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatitudeDirectionCode LatitudeDirectionCode { get; set; }
        [XmlElement(ElementName = "LongitudeDegreesMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LongitudeDegreesMeasure LongitudeDegreesMeasure { get; set; }
        [XmlElement(ElementName = "LongitudeMinutesMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LongitudeMinutesMeasure LongitudeMinutesMeasure { get; set; }
        [XmlElement(ElementName = "LongitudeDirectionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LongitudeDirectionCode LongitudeDirectionCode { get; set; }
        [XmlElement(ElementName = "AltitudeMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AltitudeMeasure AltitudeMeasure { get; set; }
    }

    [XmlRoot(ElementName = "PostalAddress", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class PostalAddress
    {
        [XmlElement(ElementName = "AddressTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AddressTypeCode AddressTypeCode { get; set; }
        [XmlElement(ElementName = "AddressFormatCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AddressFormatCode AddressFormatCode { get; set; }
        [XmlElement(ElementName = "Postbox", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Postbox Postbox { get; set; }
        [XmlElement(ElementName = "Floor", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Floor Floor { get; set; }
        [XmlElement(ElementName = "Room", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Room Room { get; set; }
        [XmlElement(ElementName = "StreetName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public StreetName StreetName { get; set; }
        [XmlElement(ElementName = "AdditionalStreetName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdditionalStreetName AdditionalStreetName { get; set; }
        [XmlElement(ElementName = "BlockName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BlockName BlockName { get; set; }
        [XmlElement(ElementName = "BuildingName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BuildingName BuildingName { get; set; }
        [XmlElement(ElementName = "BuildingNumber", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BuildingNumber BuildingNumber { get; set; }
        [XmlElement(ElementName = "InhouseMail", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InhouseMail InhouseMail { get; set; }
        [XmlElement(ElementName = "Department", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Department Department { get; set; }
        [XmlElement(ElementName = "MarkAttention", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MarkAttention MarkAttention { get; set; }
        [XmlElement(ElementName = "MarkCare", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MarkCare MarkCare { get; set; }
        [XmlElement(ElementName = "PlotIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PlotIdentification PlotIdentification { get; set; }
        [XmlElement(ElementName = "CitySubdivisionName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CitySubdivisionName CitySubdivisionName { get; set; }
        [XmlElement(ElementName = "CityName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CityName CityName { get; set; }
        [XmlElement(ElementName = "PostalZone", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PostalZone PostalZone { get; set; }
        [XmlElement(ElementName = "CountrySubentity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CountrySubentity CountrySubentity { get; set; }
        [XmlElement(ElementName = "CountrySubentityCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CountrySubentityCode CountrySubentityCode { get; set; }
        [XmlElement(ElementName = "Region", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Region Region { get; set; }
        [XmlElement(ElementName = "District", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public District District { get; set; }
        [XmlElement(ElementName = "TimezoneOffset", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimezoneOffset TimezoneOffset { get; set; }
        [XmlElement(ElementName = "AddressLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<AddressLine> AddressLine { get; set; }
        [XmlElement(ElementName = "Country", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Country Country { get; set; }
        [XmlElement(ElementName = "LocationCoordinate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<LocationCoordinate> LocationCoordinate { get; set; }
    }

    [XmlRoot(ElementName = "Conditions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class Conditions
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "LocationTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class LocationTypeCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }


    [XmlRoot(ElementName = "InformationURI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class InformationURI
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PhysicalLocation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class PhysicalLocation
    {
        [XmlElement(ElementName = "Conditions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Conditions> Conditions { get; set; }
        [XmlElement(ElementName = "LocationTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LocationTypeCode LocationTypeCode { get; set; }
        [XmlElement(ElementName = "InformationURI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InformationURI InformationURI { get; set; }
        [XmlElement(ElementName = "Address", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public string Address { get; set; }
        [XmlElement(ElementName = "SubsidiaryLocation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<string> SubsidiaryLocation { get; set; }
    }

    [XmlRoot(ElementName = "RegistrationName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class RegistrationName
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CompanyID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class CompanyID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxLevelCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class TaxLevelCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ExemptionReasonCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class ExemptionReasonCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ExemptionReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class ExemptionReason
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class TaxTypeCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class CurrencyCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class TaxScheme
    {
        [XmlElement(ElementName = "TaxTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxTypeCode TaxTypeCode { get; set; }
        [XmlElement(ElementName = "CurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrencyCode CurrencyCode { get; set; }
        [XmlElement(ElementName = "JurisdictionRegionAddress", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<string> JurisdictionRegionAddress { get; set; }
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID { get; set; }
    }

    [XmlRoot(ElementName = "PartyTaxScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class PartyTaxScheme
    {
        [XmlElement(ElementName = "RegistrationName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationName RegistrationName { get; set; }
        [XmlElement(ElementName = "CompanyID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyID CompanyID { get; set; }
        [XmlElement(ElementName = "TaxLevelCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxLevelCode TaxLevelCode { get; set; }
        [XmlElement(ElementName = "ExemptionReasonCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExemptionReasonCode ExemptionReasonCode { get; set; }
        [XmlElement(ElementName = "ExemptionReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<ExemptionReason> ExemptionReason { get; set; }
        [XmlElement(ElementName = "RegistrationAddress", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public string RegistrationAddress { get; set; }
        [XmlElement(ElementName = "TaxScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxScheme TaxScheme { get; set; }
    }

    [XmlRoot(ElementName = "RegistrationDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class RegistrationDate
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RegistrationExpirationDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class RegistrationExpirationDate
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CompanyLegalFormCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class CompanyLegalFormCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CompanyLegalForm", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class CompanyLegalForm
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SoleProprietorshipIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class SoleProprietorshipIndicator
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CompanyLiquidationStatusCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class CompanyLiquidationStatusCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CorporateStockAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class CorporateStockAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlAttribute(AttributeName = "currencyCodeListVersionID")]
        public string CurrencyCodeListVersionID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "FullyPaidSharesIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class FullyPaidSharesIndicator
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CorporateRegistrationTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class CorporateRegistrationTypeCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CorporateRegistrationScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class CorporateRegistrationScheme
    {
        [XmlElement(ElementName = "CorporateRegistrationTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CorporateRegistrationTypeCode CorporateRegistrationTypeCode { get; set; }
    }

    [XmlRoot(ElementName = "Telephone", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class Telephone
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Telefax", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class Telefax
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ElectronicMail", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class ElectronicMail
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ChannelCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class ChannelCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Channel", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class Channel
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Value", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class Value
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "OtherCommunication", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class OtherCommunication
    {
        [XmlElement(ElementName = "ChannelCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChannelCode ChannelCode { get; set; }
        [XmlElement(ElementName = "Channel", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Channel Channel { get; set; }
        [XmlElement(ElementName = "Value", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Value Value { get; set; }
    }

    [XmlRoot(ElementName = "Contact", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class Contact
    {
        [XmlElement(ElementName = "Telephone", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Telephone Telephone { get; set; }
        [XmlElement(ElementName = "Telefax", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Telefax Telefax { get; set; }
        [XmlElement(ElementName = "ElectronicMail", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ElectronicMail ElectronicMail { get; set; }
        [XmlElement(ElementName = "OtherCommunication", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<OtherCommunication> OtherCommunication { get; set; }
    }

    [XmlRoot(ElementName = "FirstName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class FirstName
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "FamilyName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class FamilyName
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Title", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class Title
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MiddleName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class MiddleName
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "OtherName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class OtherName
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "NameSuffix", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class NameSuffix
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "JobTitle", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class JobTitle
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "NationalityID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class NationalityID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "GenderCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class GenderCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "BirthDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class BirthDate
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "BirthplaceName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class BirthplaceName
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "OrganizationDepartment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class OrganizationDepartment
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AliasName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class AliasName
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AccountTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class AccountTypeCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AccountFormatCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class AccountFormatCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PaymentNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class PaymentNote
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "FinancialInstitutionBranch", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class FinancialInstitutionBranch
    {
        [XmlElement(ElementName = "FinancialInstitution", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public string FinancialInstitution { get; set; }
    }

    [XmlRoot(ElementName = "FinancialAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class FinancialAccount
    {
        [XmlElement(ElementName = "AliasName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AliasName AliasName { get; set; }
        [XmlElement(ElementName = "AccountTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountTypeCode AccountTypeCode { get; set; }
        [XmlElement(ElementName = "AccountFormatCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountFormatCode AccountFormatCode { get; set; }
        [XmlElement(ElementName = "PaymentNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<PaymentNote> PaymentNote { get; set; }
        [XmlElement(ElementName = "FinancialInstitutionBranch", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public FinancialInstitutionBranch FinancialInstitutionBranch { get; set; }
    }

    [XmlRoot(ElementName = "ValidatorID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class ValidatorID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ValidationResultCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class ValidationResultCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ValidationDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class ValidationDate
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ValidationTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class ValidationTime
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ValidateProcess", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class ValidateProcess
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ValidateTool", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class ValidateTool
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ValidateToolVersion", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class ValidateToolVersion
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ServiceTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class ServiceTypeCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ServiceType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class ServiceType
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MandateDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class MandateDocumentReference
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID { get; set; }
    }

    [XmlRoot(ElementName = "PowerOfAttorney", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class PowerOfAttorney
    {
        [XmlElement(ElementName = "NotaryParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public string NotaryParty { get; set; }
        [XmlElement(ElementName = "AgentParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public string AgentParty { get; set; }
        [XmlElement(ElementName = "WitnessParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<string> WitnessParty { get; set; }
        [XmlElement(ElementName = "MandateDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<MandateDocumentReference> MandateDocumentReference { get; set; }
    }

    [XmlRoot(ElementName = "Party", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class Party
    {

        [XmlElement(ElementName = "EndpointID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EndpointID EndpointID { get; set; }

        [XmlElement(ElementName = "PowerOfAttorney", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<PowerOfAttorney> PowerOfAttorney { get; set; }

        [XmlElement(ElementName = "PartyIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyIdentification PartyIdentification { get; set; }

        [XmlElement(ElementName = "PartyName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyName PartyName { get; set; }

        [XmlElement(ElementName = "PostalAddress", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PostalAddress PostalAddress { get; set; }

        [XmlElement(ElementName = "PartyTaxScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyTaxScheme PartyTaxScheme { get; set; }

        [XmlElement(ElementName = "PartyLegalEntity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyLegalEntity PartyLegalEntity { get; set; }

        [XmlElement(ElementName = "Contact", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Contact Contact { get; set; }

        [XmlElement(ElementName = "Person", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Person Person { get; set; }


    }


    [XmlRoot(ElementName = "ServiceProviderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class ServiceProviderParty
    {
        [XmlElement(ElementName = "ServiceTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ServiceTypeCode ServiceTypeCode { get; set; }
        [XmlElement(ElementName = "ServiceType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<ServiceType> ServiceType { get; set; }
        [XmlElement(ElementName = "Party", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Party Party { get; set; }
        [XmlElement(ElementName = "SellerContact", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public string SellerContact { get; set; }
    }

    [XmlRoot(ElementName = "AgentParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class AgentParty
    {
        [XmlElement(ElementName = "ServiceProviderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<ServiceProviderParty> ServiceProviderParty { get; set; }
    }

    [XmlRoot(ElementName = "SignatoryParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class SignatoryParty
    {
        [XmlElement(ElementName = "AgentParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AgentParty AgentParty { get; set; }
    }

    [XmlRoot(ElementName = "ResultOfVerification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class ResultOfVerification
    {
        [XmlElement(ElementName = "ValidatorID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidatorID ValidatorID { get; set; }
        [XmlElement(ElementName = "ValidationResultCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidationResultCode ValidationResultCode { get; set; }
        [XmlElement(ElementName = "ValidationDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidationDate ValidationDate { get; set; }
        [XmlElement(ElementName = "ValidationTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidationTime ValidationTime { get; set; }
        [XmlElement(ElementName = "ValidateProcess", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidateProcess ValidateProcess { get; set; }
        [XmlElement(ElementName = "ValidateTool", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidateTool ValidateTool { get; set; }
        [XmlElement(ElementName = "ValidateToolVersion", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidateToolVersion ValidateToolVersion { get; set; }
        [XmlElement(ElementName = "SignatoryParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatoryParty SignatoryParty { get; set; }
    }

    [XmlRoot(ElementName = "IdentityDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class IdentityDocumentReference
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID { get; set; }
        [XmlElement(ElementName = "ResultOfVerification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ResultOfVerification ResultOfVerification { get; set; }
    }

    [XmlRoot(ElementName = "Person", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class Person
    {
        [XmlElement(ElementName = "FirstName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FirstName FirstName { get; set; }
        [XmlElement(ElementName = "FamilyName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FamilyName FamilyName { get; set; }
        [XmlElement(ElementName = "Title", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Title Title { get; set; }
        [XmlElement(ElementName = "MiddleName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MiddleName MiddleName { get; set; }
        [XmlElement(ElementName = "OtherName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OtherName OtherName { get; set; }
        [XmlElement(ElementName = "NameSuffix", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameSuffix NameSuffix { get; set; }
        [XmlElement(ElementName = "JobTitle", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public JobTitle JobTitle { get; set; }
        [XmlElement(ElementName = "NationalityID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NationalityID NationalityID { get; set; }
        [XmlElement(ElementName = "GenderCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GenderCode GenderCode { get; set; }
        [XmlElement(ElementName = "BirthDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BirthDate BirthDate { get; set; }
        [XmlElement(ElementName = "BirthplaceName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BirthplaceName BirthplaceName { get; set; }
        [XmlElement(ElementName = "OrganizationDepartment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OrganizationDepartment OrganizationDepartment { get; set; }
        [XmlElement(ElementName = "FinancialAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public FinancialAccount FinancialAccount { get; set; }
        [XmlElement(ElementName = "IdentityDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<IdentityDocumentReference> IdentityDocumentReference { get; set; }
        [XmlElement(ElementName = "ResidenceAddress", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public string ResidenceAddress { get; set; }
    }

    [XmlRoot(ElementName = "HeadOfficeParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class HeadOfficeParty
    {
        [XmlElement(ElementName = "Contact", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Contact Contact { get; set; }
        [XmlElement(ElementName = "Person", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Person> Person { get; set; }
    }

    [XmlRoot(ElementName = "PartecipationPercent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class PartecipationPercent
    {
        [XmlAttribute(AttributeName = "format")]
        public string Format { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ShareholderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class ShareholderParty
    {
        [XmlElement(ElementName = "PartecipationPercent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PartecipationPercent PartecipationPercent { get; set; }
    }

    [XmlRoot(ElementName = "PartyLegalEntity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class PartyLegalEntity
    {
        [XmlElement(ElementName = "RegistrationName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationName RegistrationName { get; set; }
        [XmlElement(ElementName = "RegistrationDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationDate RegistrationDate { get; set; }
        [XmlElement(ElementName = "CompanyID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyID CompanyID { get; set; }
        [XmlElement(ElementName = "RegistrationExpirationDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationExpirationDate RegistrationExpirationDate { get; set; }
        [XmlElement(ElementName = "CompanyLegalFormCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyLegalFormCode CompanyLegalFormCode { get; set; }
        [XmlElement(ElementName = "CompanyLegalForm", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyLegalForm CompanyLegalForm { get; set; }
        [XmlElement(ElementName = "SoleProprietorshipIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SoleProprietorshipIndicator SoleProprietorshipIndicator { get; set; }
        [XmlElement(ElementName = "CompanyLiquidationStatusCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyLiquidationStatusCode CompanyLiquidationStatusCode { get; set; }
        [XmlElement(ElementName = "CorporateStockAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CorporateStockAmount CorporateStockAmount { get; set; }
        [XmlElement(ElementName = "FullyPaidSharesIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FullyPaidSharesIndicator FullyPaidSharesIndicator { get; set; }
        [XmlElement(ElementName = "CorporateRegistrationScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CorporateRegistrationScheme CorporateRegistrationScheme { get; set; }
        [XmlElement(ElementName = "HeadOfficeParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public HeadOfficeParty HeadOfficeParty { get; set; }
        [XmlElement(ElementName = "ShareholderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<ShareholderParty> ShareholderParty { get; set; }
    }

    [XmlRoot(ElementName = "IssuerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class IssuerParty
    {
        [XmlElement(ElementName = "MarkCareIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MarkCareIndicator MarkCareIndicator { get; set; }
        [XmlElement(ElementName = "MarkAttentionIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MarkAttentionIndicator MarkAttentionIndicator { get; set; }
        [XmlElement(ElementName = "WebsiteURI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public WebsiteURI WebsiteURI { get; set; }
        [XmlElement(ElementName = "LogoReferenceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LogoReferenceID LogoReferenceID { get; set; }
        [XmlElement(ElementName = "EndpointID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EndpointID EndpointID { get; set; }
        [XmlElement(ElementName = "IndustryClassificationCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndustryClassificationCode IndustryClassificationCode { get; set; }
        [XmlElement(ElementName = "PartyIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<PartyIdentification> PartyIdentification { get; set; }
        [XmlElement(ElementName = "PartyName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<PartyName> PartyName { get; set; }
        [XmlElement(ElementName = "Language", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public string Language { get; set; }
        [XmlElement(ElementName = "PostalAddress", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PostalAddress PostalAddress { get; set; }
        [XmlElement(ElementName = "PhysicalLocation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PhysicalLocation PhysicalLocation { get; set; }
        [XmlElement(ElementName = "PartyTaxScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<PartyTaxScheme> PartyTaxScheme { get; set; }
        [XmlElement(ElementName = "PartyLegalEntity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<PartyLegalEntity> PartyLegalEntity { get; set; }
    }

    [XmlRoot(ElementName = "DocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class DocumentReference
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID { get; set; }
        [XmlElement(ElementName = "DocumentTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentTypeCode DocumentTypeCode { get; set; }
        [XmlElement(ElementName = "DocumentType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentType DocumentType { get; set; }
        [XmlElement(ElementName = "XPath", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<XPath> XPath { get; set; }
        [XmlElement(ElementName = "LanguageID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LanguageID LanguageID { get; set; }
        [XmlElement(ElementName = "LocaleCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LocaleCode LocaleCode { get; set; }
        [XmlElement(ElementName = "VersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public VersionID VersionID { get; set; }
        [XmlElement(ElementName = "DocumentStatusCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentStatusCode DocumentStatusCode { get; set; }
        [XmlElement(ElementName = "DocumentDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<DocumentDescription> DocumentDescription { get; set; }
        [XmlElement(ElementName = "Attachment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Attachment Attachment { get; set; }
        [XmlElement(ElementName = "ValidityPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public string ValidityPeriod { get; set; }
        [XmlElement(ElementName = "IssuerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public IssuerParty IssuerParty { get; set; }
    }

    [XmlRoot(ElementName = "OrderReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class OrderReference
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID { get; set; }
        [XmlElement(ElementName = "SalesOrderID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SalesOrderID SalesOrderID { get; set; }
        [XmlElement(ElementName = "CustomerReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CustomerReference CustomerReference { get; set; }
        [XmlElement(ElementName = "OrderTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OrderTypeCode OrderTypeCode { get; set; }
        [XmlElement(ElementName = "DocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReference DocumentReference { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "InvoiceDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class InvoiceDocumentReference
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID { get; set; }
        [XmlElement(ElementName = "IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueDate IssueDate { get; set; }
        [XmlElement(ElementName = "IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueTime IssueTime { get; set; }
    }

    [XmlRoot(ElementName = "SelfBilledInvoiceDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class SelfBilledInvoiceDocumentReference
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID { get; set; }
    }

    [XmlRoot(ElementName = "CreditNoteDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class CreditNoteDocumentReference
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID { get; set; }
    }

    [XmlRoot(ElementName = "SelfBilledCreditNoteDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class SelfBilledCreditNoteDocumentReference
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID { get; set; }
    }

    [XmlRoot(ElementName = "DebitNoteDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class DebitNoteDocumentReference
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID { get; set; }
    }

    [XmlRoot(ElementName = "ReminderDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class ReminderDocumentReference
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID { get; set; }
    }

    [XmlRoot(ElementName = "AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class AdditionalDocumentReference
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID { get; set; }

        [XmlElement(ElementName = "DocumentType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentType DocumentType { get; set; }

        [XmlElement(ElementName = "Attachment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Attachment Attachment { get; set; } 
    }

    [XmlRoot(ElementName = "Amount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class Amount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlAttribute(AttributeName = "currencyCodeListVersionID")]
        public string CurrencyCodeListVersionID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ChargeIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class ChargeIndicator
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AllowanceChargeReasonCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class AllowanceChargeReasonCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "AllowanceChargeReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class AllowanceChargeReason
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MultiplierFactorNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class MultiplierFactorNumeric
    {
        [XmlAttribute(AttributeName = "format")]
        public string Format { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PrepaidIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class PrepaidIndicator
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SequenceNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class SequenceNumeric
    {
        [XmlAttribute(AttributeName = "format")]
        public string Format { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "BaseAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class BaseAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlAttribute(AttributeName = "currencyCodeListVersionID")]
        public string CurrencyCodeListVersionID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PerUnitAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class PerUnitAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlAttribute(AttributeName = "currencyCodeListVersionID")]
        public string CurrencyCodeListVersionID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Percent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class Percent
    {
        [XmlAttribute(AttributeName = "format")]
        public string Format { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "BaseUnitMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class BaseUnitMeasure
    {
        [XmlAttribute(AttributeName = "unitCode")]
        public string UnitCode { get; set; }
        [XmlAttribute(AttributeName = "unitCodeListVersionID")]
        public string UnitCodeListVersionID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxExemptionReasonCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class TaxExemptionReasonCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxExemptionReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class TaxExemptionReason
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TierRange", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class TierRange
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TierRatePercent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class TierRatePercent
    {
        [XmlAttribute(AttributeName = "format")]
        public string Format { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxCategory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class TaxCategory
    {

        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID { get; set; }
        [XmlElement(ElementName = "Percent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Percent Percent { get; set; }
        [XmlElement(ElementName = "BaseUnitMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BaseUnitMeasure BaseUnitMeasure { get; set; }
        [XmlElement(ElementName = "TaxExemptionReasonCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxExemptionReasonCode TaxExemptionReasonCode { get; set; }
        [XmlElement(ElementName = "TaxExemptionReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<TaxExemptionReason> TaxExemptionReason { get; set; }
        [XmlElement(ElementName = "TierRange", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TierRange TierRange { get; set; }
        [XmlElement(ElementName = "TierRatePercent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TierRatePercent TierRatePercent { get; set; }
        [XmlElement(ElementName = "TaxScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxScheme TaxScheme { get; set; }

    }

    [XmlRoot(ElementName = "TaxAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class TaxAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlAttribute(AttributeName = "currencyCodeListVersionID")]
        public string CurrencyCodeListVersionID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "RoundingAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class RoundingAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlAttribute(AttributeName = "currencyCodeListVersionID")]
        public string CurrencyCodeListVersionID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxEvidenceIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class TaxEvidenceIndicator
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxIncludedIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class TaxIncludedIndicator
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxableAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class TaxableAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlAttribute(AttributeName = "currencyCodeListVersionID")]
        public string CurrencyCodeListVersionID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CalculationSequenceNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class CalculationSequenceNumeric
    {
        [XmlAttribute(AttributeName = "format")]
        public string Format { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TransactionCurrencyTaxAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class TransactionCurrencyTaxAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlAttribute(AttributeName = "currencyCodeListVersionID")]
        public string CurrencyCodeListVersionID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxSubtotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class TaxSubtotal
    {
        [XmlElement(ElementName = "TaxableAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxableAmount TaxableAmount { get; set; }
        [XmlElement(ElementName = "TaxAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxAmount TaxAmount { get; set; }
        [XmlElement(ElementName = "CalculationSequenceNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CalculationSequenceNumeric CalculationSequenceNumeric { get; set; }
        [XmlElement(ElementName = "TransactionCurrencyTaxAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TransactionCurrencyTaxAmount TransactionCurrencyTaxAmount { get; set; }
        [XmlElement(ElementName = "TaxCategory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxCategory TaxCategory { get; set; }
    }

    [XmlRoot(ElementName = "TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class TaxTotal
    {
        [XmlElement(ElementName = "TaxAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxAmount TaxAmount { get; set; }
        [XmlElement(ElementName = "RoundingAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RoundingAmount RoundingAmount { get; set; }
        [XmlElement(ElementName = "TaxEvidenceIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxEvidenceIndicator TaxEvidenceIndicator { get; set; }
        [XmlElement(ElementName = "TaxIncludedIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxIncludedIndicator TaxIncludedIndicator { get; set; }
        [XmlElement(ElementName = "TaxSubtotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<TaxSubtotal> TaxSubtotal { get; set; }
    }

    [XmlRoot(ElementName = "PaymentMeansCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class PaymentMeansCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PaymentDueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class PaymentDueDate
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PaymentChannelCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class PaymentChannelCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "InstructionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class InstructionID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "InstructionNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class InstructionNote
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PaymentID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class PaymentID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "PrimaryAccountNumberID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class PrimaryAccountNumberID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "NetworkID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class NetworkID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CardTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class CardTypeCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ValidityStartDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class ValidityStartDate
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "IssuerID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class IssuerID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "IssueNumberID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class IssueNumberID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CV2ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class CV2ID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CardChipCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class CardChipCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ChipApplicationID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class ChipApplicationID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "HolderName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class HolderName
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CardAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class CardAccount
    {
        [XmlElement(ElementName = "PrimaryAccountNumberID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrimaryAccountNumberID PrimaryAccountNumberID { get; set; }
        [XmlElement(ElementName = "NetworkID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetworkID NetworkID { get; set; }
        [XmlElement(ElementName = "CardTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CardTypeCode CardTypeCode { get; set; }
        [XmlElement(ElementName = "ValidityStartDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidityStartDate ValidityStartDate { get; set; }
        [XmlElement(ElementName = "IssuerID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssuerID IssuerID { get; set; }
        [XmlElement(ElementName = "IssueNumberID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueNumberID IssueNumberID { get; set; }
        [XmlElement(ElementName = "CV2ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CV2ID CV2ID { get; set; }
        [XmlElement(ElementName = "CardChipCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CardChipCode CardChipCode { get; set; }
        [XmlElement(ElementName = "ChipApplicationID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChipApplicationID ChipApplicationID { get; set; }
        [XmlElement(ElementName = "HolderName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HolderName HolderName { get; set; }
    }

    [XmlRoot(ElementName = "AccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class AccountID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CreditAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class CreditAccount
    {
        [XmlElement(ElementName = "AccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountID AccountID { get; set; }
    }

    [XmlRoot(ElementName = "MandateTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class MandateTypeCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MaximumPaymentInstructionsNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class MaximumPaymentInstructionsNumeric
    {
        [XmlAttribute(AttributeName = "format")]
        public string Format { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MaximumPaidAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class MaximumPaidAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlAttribute(AttributeName = "currencyCodeListVersionID")]
        public string CurrencyCodeListVersionID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "SignatureID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class SignatureID
    {
        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID { get; set; }
        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID { get; set; }
        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName { get; set; }
        [XmlAttribute(AttributeName = "schemeVersionID")]
        public string SchemeVersionID { get; set; }
        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string SchemeDataURI { get; set; }
        [XmlAttribute(AttributeName = "schemeURI")]
        public string SchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Content", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class Content
    {
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Clause", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class Clause
    {
        [XmlElement(ElementName = "Content", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Content> Content { get; set; }
    }

    [XmlRoot(ElementName = "PaymentMandate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class PaymentMandate
    {
        [XmlElement(ElementName = "MandateTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MandateTypeCode MandateTypeCode { get; set; }
        [XmlElement(ElementName = "MaximumPaymentInstructionsNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumPaymentInstructionsNumeric MaximumPaymentInstructionsNumeric { get; set; }
        [XmlElement(ElementName = "MaximumPaidAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumPaidAmount MaximumPaidAmount { get; set; }
        [XmlElement(ElementName = "SignatureID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SignatureID SignatureID { get; set; }
        [XmlElement(ElementName = "PayerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public string PayerParty { get; set; }
        [XmlElement(ElementName = "PaymentReversalPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public string PaymentReversalPeriod { get; set; }
        [XmlElement(ElementName = "Clause", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Clause> Clause { get; set; }
    }

    [XmlRoot(ElementName = "FinancingInstrumentCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class FinancingInstrumentCode
    {
        [XmlAttribute(AttributeName = "listID")]
        public string ListID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID { get; set; }
        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName { get; set; }
        [XmlAttribute(AttributeName = "listName")]
        public string ListName { get; set; }
        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID { get; set; }
        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI { get; set; }
        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ContractDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class ContractDocumentReference
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID { get; set; }
    }

    [XmlRoot(ElementName = "TradeFinancing", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class TradeFinancing
    {
        [XmlElement(ElementName = "FinancingInstrumentCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FinancingInstrumentCode FinancingInstrumentCode { get; set; }
        [XmlElement(ElementName = "ContractDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ContractDocumentReference ContractDocumentReference { get; set; }
        [XmlElement(ElementName = "FinancingParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public string FinancingParty { get; set; }
        [XmlElement(ElementName = "FinancingFinancialAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public string FinancingFinancialAccount { get; set; }
    }

    [XmlRoot(ElementName = "PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class PaymentMeans
    {
        [XmlElement(ElementName = "PaymentMeansCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentMeansCode PaymentMeansCode { get; set; }
        [XmlElement(ElementName = "PaymentDueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentDueDate PaymentDueDate { get; set; }
        [XmlElement(ElementName = "PaymentChannelCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentChannelCode PaymentChannelCode { get; set; }
        //[XmlElement(ElementName = "InstructionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        //public InstructionID InstructionID { get; set; }
        [XmlElement(ElementName = "InstructionNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<InstructionNote> InstructionNote { get; set; }
        [XmlElement(ElementName = "PaymentID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<PaymentID> PaymentID { get; set; }
        //[XmlElement(ElementName = "CardAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public CardAccount CardAccount { get; set; }
        //[XmlElement(ElementName = "PayerFinancialAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public string PayerFinancialAccount { get; set; }
        //[XmlElement(ElementName = "PayeeFinancialAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public string PayeeFinancialAccount { get; set; }
        //[XmlElement(ElementName = "CreditAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public CreditAccount CreditAccount { get; set; }
        //[XmlElement(ElementName = "PaymentMandate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public PaymentMandate PaymentMandate { get; set; }
        //[XmlElement(ElementName = "TradeFinancing", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        //public TradeFinancing TradeFinancing { get; set; }
    }

    [XmlRoot(ElementName = "AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class AllowanceCharge
    {
        [XmlElement(ElementName = "ChargeIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChargeIndicator ChargeIndicator { get; set; }
        [XmlElement(ElementName = "AllowanceChargeReasonCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AllowanceChargeReasonCode AllowanceChargeReasonCode { get; set; }
        [XmlElement(ElementName = "AllowanceChargeReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<AllowanceChargeReason> AllowanceChargeReason { get; set; }
        [XmlElement(ElementName = "MultiplierFactorNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MultiplierFactorNumeric MultiplierFactorNumeric { get; set; }
        [XmlElement(ElementName = "PrepaidIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrepaidIndicator PrepaidIndicator { get; set; }
        [XmlElement(ElementName = "SequenceNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SequenceNumeric SequenceNumeric { get; set; }
        [XmlElement(ElementName = "Amount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Amount Amount { get; set; }
        [XmlElement(ElementName = "BaseAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BaseAmount BaseAmount { get; set; }
        [XmlElement(ElementName = "PerUnitAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PerUnitAmount PerUnitAmount { get; set; }
        [XmlElement(ElementName = "TaxCategory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<TaxCategory> TaxCategory { get; set; }
        [XmlElement(ElementName = "TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxTotal TaxTotal { get; set; }
        [XmlElement(ElementName = "PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<PaymentMeans> PaymentMeans { get; set; }
    }

    [XmlRoot(ElementName = "BillingReferenceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class BillingReferenceLine
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID { get; set; }
        [XmlElement(ElementName = "Amount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Amount Amount { get; set; }
        [XmlElement(ElementName = "AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<AllowanceCharge> AllowanceCharge { get; set; }
    }

    [XmlRoot(ElementName = "BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class BillingReference
    {
        [XmlElement(ElementName = "InvoiceDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public InvoiceDocumentReference InvoiceDocumentReference { get; set; }
        [XmlElement(ElementName = "SelfBilledInvoiceDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SelfBilledInvoiceDocumentReference SelfBilledInvoiceDocumentReference { get; set; }
        [XmlElement(ElementName = "CreditNoteDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CreditNoteDocumentReference CreditNoteDocumentReference { get; set; }
        [XmlElement(ElementName = "SelfBilledCreditNoteDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SelfBilledCreditNoteDocumentReference SelfBilledCreditNoteDocumentReference { get; set; }
        [XmlElement(ElementName = "DebitNoteDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DebitNoteDocumentReference DebitNoteDocumentReference { get; set; }
        [XmlElement(ElementName = "ReminderDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ReminderDocumentReference ReminderDocumentReference { get; set; }
        [XmlElement(ElementName = "AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AdditionalDocumentReference AdditionalDocumentReference { get; set; }
        [XmlElement(ElementName = "BillingReferenceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<BillingReferenceLine> BillingReferenceLine { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "AccountingSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class AccountingSupplierParty
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }

        [XmlElement(ElementName = "Party", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Party Party { get; set; }
    }

    [XmlRoot(ElementName = "AccountingCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class AccountingCustomerParty
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlElement(ElementName = "Party", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Party Party { get; set; }
    }

    [XmlRoot(ElementName = "PayableAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class PayableAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlAttribute(AttributeName = "currencyCodeListVersionID")]
        public string CurrencyCodeListVersionID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }


    [XmlRoot(ElementName = "PayableAlternativeAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class PayableAlternativeAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlAttribute(AttributeName = "currencyCodeListVersionID")]
        public string CurrencyCodeListVersionID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }


    [XmlRoot(ElementName = "LegalMonetaryTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class LegalMonetaryTotal
    {
        [XmlElement(ElementName = "LineExtensionAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineExtensionAmount LineExtensionAmount { get; set; }
        [XmlElement(ElementName = "TaxExclusiveAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxExclusiveAmount TaxExclusiveAmount { get; set; }
        [XmlElement(ElementName = "TaxInclusiveAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxInclusiveAmount TaxInclusiveAmount { get; set; }

        [XmlElement(ElementName = "PayableAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PayableAmount PayableAmount { get; set; }

        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "LineExtensionAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class LineExtensionAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlAttribute(AttributeName = "currencyCodeListVersionID")]
        public string CurrencyCodeListVersionID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }


    [XmlRoot(ElementName = "TaxExclusiveAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class TaxExclusiveAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlAttribute(AttributeName = "currencyCodeListVersionID")]
        public string CurrencyCodeListVersionID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TaxInclusiveAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class TaxInclusiveAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID { get; set; }
        [XmlAttribute(AttributeName = "currencyCodeListVersionID")]
        public string CurrencyCodeListVersionID { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Item", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class Item
    {
        [XmlElement(ElementName = "Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Name Name { get; set; }

        [XmlElement(ElementName = "SellersItemIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SellersItemIdentification SellersItemIdentification { get; set; }

        [XmlElement(ElementName = "ClassifiedTaxCategory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ClassifiedTaxCategory ClassifiedTaxCategory { get; set; }

    }

    [XmlRoot(ElementName = "SellersItemIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class SellersItemIdentification
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID { get; set; } 

        [XmlElement(ElementName = "ClassifiedTaxCategory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ClassifiedTaxCategory ClassifiedTaxCategory { get; set; }
    }

    [XmlRoot(ElementName = "Price", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class Price
    {
        [XmlElement(ElementName = "PriceAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceAmount PriceAmount { get; set; }

        [XmlElement(ElementName = "BaseQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BaseQuantity BaseQuantity { get; set; }
    }

    [XmlRoot(ElementName = "PriceAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class PriceAmount
    {
        [XmlAttribute(AttributeName = "currencyID")]
        public string currencyID { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "BaseQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    [Serializable()]
    public class BaseQuantity
    {
        [XmlAttribute(AttributeName = "unitCode")]
        public string unitCode { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "ClassifiedTaxCategory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class ClassifiedTaxCategory
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID { get; set; }

        [XmlElement(ElementName = "Percent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Percent Percent { get; set; }

        [XmlElement(ElementName = "TaxScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxScheme TaxScheme { get; set; }

    }


    [XmlRoot(ElementName = "InvoiceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [Serializable()]
    public class InvoiceLine
    {
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID { get; set; }

        [XmlElement(ElementName = "InvoicedQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InvoicedQuantity InvoicedQuantity { get; set; }

        [XmlElement(ElementName = "LineExtensionAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineExtensionAmount LineExtensionAmount { get; set; }
        [XmlElement(ElementName = "Item", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Item Item { get; set; }

        [XmlElement(ElementName = "Price", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Price Price { get; set; }

        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }


 
    [XmlRoot(ElementName = "Invoice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
    [Serializable()]
    public class Invoice 

    {
        [XmlElement(ElementName = "UBLExtensions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        public UBLExtensions UBLExtensions { get; set; }
        [XmlElement(ElementName = "UBLVersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UBLVersionID UBLVersionID { get; set; }
        [XmlElement(ElementName = "CustomizationID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CustomizationID CustomizationID { get; set; }
        [XmlElement(ElementName = "ProfileID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProfileID ProfileID { get; set; }
        [XmlElement(ElementName = "ProfileExecutionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProfileExecutionID ProfileExecutionID { get; set; }
        [XmlElement(ElementName = "ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ID ID { get; set; }
        [XmlElement(ElementName = "CopyIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CopyIndicator CopyIndicator { get; set; }
        [XmlElement(ElementName = "UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UUID UUID { get; set; }
        [XmlElement(ElementName = "IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueDate IssueDate { get; set; }
        [XmlElement(ElementName = "IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueTime IssueTime { get; set; }
        [XmlElement(ElementName = "DueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DueDate DueDate { get; set; }
        [XmlElement(ElementName = "InvoiceTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InvoiceTypeCode InvoiceTypeCode { get; set; }
        [XmlElement(ElementName = "Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Note> Note { get; set; }
        [XmlElement(ElementName = "TaxPointDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxPointDate TaxPointDate { get; set; }
        [XmlElement(ElementName = "DocumentCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentCurrencyCode DocumentCurrencyCode { get; set; }
        [XmlElement(ElementName = "TaxCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxCurrencyCode TaxCurrencyCode { get; set; }
        [XmlElement(ElementName = "PricingCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PricingCurrencyCode PricingCurrencyCode { get; set; }
        [XmlElement(ElementName = "PaymentCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentCurrencyCode PaymentCurrencyCode { get; set; }
        [XmlElement(ElementName = "PaymentAlternativeCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentAlternativeCurrencyCode PaymentAlternativeCurrencyCode { get; set; }
        [XmlElement(ElementName = "AccountingCostCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountingCostCode AccountingCostCode { get; set; }
        [XmlElement(ElementName = "AccountingCost", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountingCost AccountingCost { get; set; }
        [XmlElement(ElementName = "LineCountNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineCountNumeric LineCountNumeric { get; set; }
        [XmlElement(ElementName = "BuyerReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BuyerReference BuyerReference { get; set; }
        [XmlElement(ElementName = "InvoicePeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<InvoicePeriod> InvoicePeriod { get; set; }
        [XmlElement(ElementName = "OrderReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public OrderReference OrderReference { get; set; }
        [XmlElement(ElementName = "BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<BillingReference> BillingReference { get; set; }
        [XmlElement(ElementName = "AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<AdditionalDocumentReference> AdditionalDocumentReference { get; set; }

        [XmlElement(ElementName = "AccountingSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AccountingSupplierParty AccountingSupplierParty { get; set; }
        [XmlElement(ElementName = "AccountingCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AccountingCustomerParty AccountingCustomerParty { get; set; }

        [XmlElement(ElementName = "PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<PaymentMeans> PaymentMeans { get; set; }

        [XmlElement(ElementName = "TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxTotal TaxTotal { get; set; }

        [XmlElement(ElementName = "LegalMonetaryTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public LegalMonetaryTotal LegalMonetaryTotal { get; set; }
      
        [XmlElement(ElementName = "InvoiceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<InvoiceLine> InvoiceLine { get; set; }
     

        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

}
