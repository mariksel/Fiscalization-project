using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class ContractDocumentReference
    {
        /// <summary>
        /// Identification of the contract.
        /// The contract identifier must be unique in the context of a specific trade relationship and for a certain period of time
        /// </summary>
        public string ID { get; set; }

        public DocumentReferenceType ToDocumentReferenceType()
        {
            return new DocumentReferenceType
            {
                ID = ID
            };
        }
    }
}
