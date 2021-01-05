using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;
using UblSharp.UnqualifiedDataTypes;

namespace EInvoice.Models.UBL
{
    /// <summary>
    /// BG-24 Additional supporting documents
    /// </summary>
    public class DocumentReference
    {
        /// <summary>
        /// The Item identifier upon which the invoice given by the Seller is based
        /// This can be a subscriber number, a phone number, a spatial measurement, a vehicle, a person, etc. as required.
        /// With DocumentTypeCode=130
        /// </summary>
        public Identifier ID { get; set; }
        public string DocumentDescription { get; set; }
        public Attachment Attachment { get; set; }
        /// <summary>
        /// Issue date of previous invoice [yyyy-MM-dd]
        /// The date of issue of the previous invoice must be specified if the previous invoice identifier is not unique.
        /// </summary>
        public DateTime Issued { get; set; }

        public virtual DocumentReferenceType ToDocumentReferenceType()
        {
            return new DocumentReferenceType
            {
                ID = ID.ToIdentifierType(),
                DocumentDescription = new List<TextType> { DocumentDescription },
                Attachment = Attachment.ToAttachmentType(),
                IssueDate = Issued.ToString("yyyy-MM-dd")
            };
        }
    }
}
