using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using UblSharp;
using UblSharp.CommonAggregateComponents;
using UblSharp.UnqualifiedDataTypes;

namespace EInvoice.Models
{
    public static class UBL
    {
        public const string CBC = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2";
        public const string CAC = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2";
    }
    [XmlTypeAttribute("EInvoice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:EInvoice-2")]
    public class EInvoiceDocument : BaseDocument
    {
        public const string cbc = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2";
        public const string cac = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2";



        /// <summary>
        /// <cbc:Note>Unstructured text notes#AAI#</cbc:Notes>
        /// </summary>
        [XmlElement("Note", Namespace = cbc)]
        public TextType Note { get; set; }


        /// <summary>
        /// The date is entered in the format yyyy-MM-dd .
        /// <cbc:IssueDate>2018-01-31</cbc:IssueDate>
        /// </summary>
        [XmlElement("IssueDate", Namespace = cbc)]
        public DateType IssueDate { get; set; }

        /// <summary>
        /// <cbc:InvoiceTypeCode>380</cbc:InvoiceTypeCode>
        /// </summary>
        [XmlElement("InvoiceTypeCode", Namespace = cbc)]
        public CodeType InvoiceTypeCode { get; set; }

        /// <summary>
        /// <cbc:DocumentCurrencyCode>HRK</cbc:DocumentCurrencyCode>
        /// </summary>
        [XmlElement("DocumentCurrencyCode", Namespace = cbc)]
        public CodeType DocumentCurrencyCode { get; set; }

        /// <summary>
        /// <cbc:TaxCurrencyCode>HRK</cbc:TaxCurrencyCode>
        /// </summary>
        [XmlElement("TaxCurrencyCode", Namespace = cbc)]
        public CodeType TaxCurrencyCode { get; set; }

        /// <summary>
        /// <cbc:TaxPointDate>2018-01-31</cbc:TaxPointDate>
        /// </summary>
        [XmlElement("TaxPointDate", Namespace = cbc)]
        public DateType TaxPointDate { get; set; }

        /// <summary>
        /// <Cac:InvoicePeriod> <Cbc:DescriptionCode>3</cbc:DescriptionCode> </Cac:InvoicePeriod>
        /// </summary>
        //[XmlElement("InvoicePeriod2", Namespace = cac)]
        public PeriodType InvoicePeriod { get; set; }

        /// <summary>
        /// Payment due date. 
        /// <cbc:DueDate>2018-02-28</cbc:DueDate>
        /// </summary>
        [XmlElement("DueDate", Namespace = cbc)]
        public DateType DueDate { get; set; }

        /// <summary>
        /// Identifikuesi i caktuar nga Blerësi për qëllime të “internal routing”.
        /// <cbc:BuyerReference>buyer-0001</cbc:BuyerReference>
        /// </summary>
        [XmlElement("BuyerReference", Namespace = cac)]
        public string BuyerReference { get; set; }

        /// <summary>
        /// Identifikimi i projektit me të cilin lidhet fatura. 
        /// <Cac:ProjectReference> <Cbc:ID>Project-0001</cbc:ID> </Cac:ProjectReference>
        /// </summary>
        [XmlElement("ProjectReference", Namespace = cac)]
        public ProjectReferenceType ProjectReference { get; set; }

        /// <summary>
        /// Identifikimi i kontratës.
        /// <Cac:ContractDocumentReference> <Cbc:ID>contract-0001</cbc:ID> </Cac:ContractDocumentReference>
        /// </summary>
        [XmlElement("ContractDocumentReference", Namespace = cac)]
        public DocumentReferenceType ContractDocumentReference { get; set; }

        /// <summary>
        /// Identifikuesi i porosisë të blerjes të caktuar, lëshuar nga Blerësi..
        /// <Cac:OrderReference> <Cbc:ID>Order-0001</cbc:ID> </Cac:OrderReference>
        /// </summary>
        [XmlElement("OrderReference", Namespace = cac)]
        public OrderFormReference OrderFormReference { get; set; }

        /// <summary>
        /// Identifikuesi i Referencës së Porosisë të Shitjeve lëshuar nga Shitësi.
        /// <Cac:OrderReference> <Cbc:SalesOrderID>sales-order-0001</cbc:SalesOrderID> </Cac:OrderReference>
        /// </summary>
        [XmlElement("OrderReference", Namespace = cac)]
        public SaleOrderReference SaleOrderReference { get; set; }

        /// <summary>
        /// Identifikuesi i referencës së faturës..
        /// <Cac:ReceiptDocumentReference> <Cbc:ID>receipt-0001</cbc:ID> </Cac:ReceiptDocumentReference>
        /// </summary>
        [XmlElement("ReceiptDocumentReference", Namespace = cac)]
        public ReceiptDocumentReference ReceiptDocumentReference { get; set; }

        /// <summary>
        /// Identifikuesi i referencës së shënimit të transportit.
        /// <Cac:DespatchDocumentReference> <Cbc:ID>delivery-0001</cbc:ID> </Cac:DespatchDocumentReference>
        /// </summary>
        [XmlElement("DespatchDocumentReference", Namespace = cac)]
        public DespatchDocumentReference DespatchDocumentReference { get; set; }
    }

    [XmlType("InvoicePeriod", Namespace = UBL.CAC)]
    public class InvoicePeriod
    {
        /// <summary>
        /// <Cbc:DescriptionCode>3</cbc:DescriptionCode>
        /// </summary>
        [XmlElement("DescriptionCode", Namespace = UBL.CBC)]
        public CodeType DescriptionCode { get; set; }
    }

    public class ProjectReference
    {
        /// <summary>
        /// <Cbc:ID>Project-0001</cbc:ID>
        /// </summary>
        [XmlElement("ID", Namespace = UBL.CBC)]
        public TextType ID { get; set; }
    }

    public class ContractReference
    {
        /// <summary>
        /// <Cbc:ID>contract-0001</cbc:ID>
        /// </summary>
        [XmlElement("ID", Namespace = UBL.CBC)]
        public TextType ID { get; set; }
    }

    public class OrderFormReference
    {
        /// <summary>
        /// <Cbc:ID>Order-0001<</cbc:ID>
        /// </summary>
        [XmlElement("ID", Namespace = UBL.CBC)]
        public TextType ID { get; set; }
    }

    public class SaleOrderReference
    {
        /// <summary>
        /// <Cbc:SalesOrderID>sales-order-0001</cbc:SalesOrderID>
        /// </summary>
        [XmlElement("SalesOrderID", Namespace = UBL.CBC)]
        public TextType SalesOrderID { get; set; }
    }

    public class ReceiptDocumentReference
    {
        /// <summary>
        /// <Cbc:ID>receipt-0001</cbc:ID>
        /// </summary>
        [XmlElement("ID", Namespace = UBL.CBC)]
        public TextType ID { get; set; }
    }
    public class DespatchDocumentReference
    {
        /// <summary>
        /// <Cbc:ID>delivery-0001</cbc:ID>
        /// </summary>
        [XmlElement("ID", Namespace = UBL.CBC)]
        public TextType ID { get; set; }
    }

}
