using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class BillingReference
    {
        /// <summary>
        /// A set of business terms that provide information about one or more previous invoices.
        /// Used in case: 
        /// - a previous invoice has been corrected 
        /// - previous partial invoices are referred to on the final invoice 
        /// - previous advance payments are referenced to on the final invoice
        /// </summary>
        public InvoiceDocumentReference InvoiceDocumentReference { get; set; }

        public BillingReferenceType ToBillingReferenceType()
        {
            return new BillingReferenceType
            {
                InvoiceDocumentReference = InvoiceDocumentReference.ToDocumentReferenceType()
            };
        }
    }
}
