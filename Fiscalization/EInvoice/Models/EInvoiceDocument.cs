using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using UblSharp;
using UblSharp.UnqualifiedDataTypes;

namespace EInvoice.Models
{
    [System.Xml.Serialization.XmlTypeAttribute("EInvoice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:EInvoice-2")]
    public class EInvoiceDocument : BaseDocument
    {
        public const string cbc = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2";
        public const string cac = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2";



        //[XmlElement("ID", Namespace = cbc)]
        //public new int ID { get; set; }

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
    }
}
