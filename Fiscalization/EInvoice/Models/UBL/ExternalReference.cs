using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class ExternalReference
    {
        /// <summary>
        /// URL (Uniform Resource Locator) identifying where external documents are located.
        /// Resource location mode, including its primary access mechanism, e.g., http://or ftp//.
        /// The external location of the document must be used if the Buyer requires additional supporting information about an invoice.
        /// External documents are not part of the invoice.There are risks in accessing external documents.
        /// </summary>
        public string URI { get; set; }

        public ExternalReferenceType ToExternalReferenceType()
        {
            return new ExternalReferenceType
            {
                URI = URI
            };
        }
    }
}
