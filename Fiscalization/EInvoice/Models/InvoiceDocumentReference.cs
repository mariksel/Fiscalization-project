using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using UblSharp.CommonAggregateComponents;
using UblSharp.UnqualifiedDataTypes;

namespace EInvoice.Models
{
    [XmlInclude(typeof(InvoiceDocumentReference))]
    public class InvoiceDocumentReference: DocumentReferenceType
    {
        [XmlElement("Issued", Namespace = UBL.CBC)]
        public DateType Issued { get; set; }
    }
}
