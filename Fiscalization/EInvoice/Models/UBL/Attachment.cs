using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class Attachment
    {
        public ExternalReference ExternalReference { get; set; }
        public BinaryObject EmbeddedDocumentBinaryObject { get; set; }

        public AttachmentType ToAttachmentType()
        {
            return new AttachmentType
            {
                ExternalReference = ExternalReference.ToExternalReferenceType(),
                EmbeddedDocumentBinaryObject = EmbeddedDocumentBinaryObject.ToBinaryObjectType()
            };
        }
    }
}
