using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class ReceiptDocumentReference : DocumentReference
    {

        public override DocumentReferenceType ToDocumentReferenceType()
        {
            return base.ToDocumentReferenceType();
        }
    }
}
