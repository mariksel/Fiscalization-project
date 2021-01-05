using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;
using UblSharp.UnqualifiedDataTypes;

namespace EInvoice.Models.UBL
{
    public class PartyIdentification
    {
        /// <summary>
        /// Buyer/Seller Identifier
        /// For many systems, Seller's identifier is key information. 
        /// Multiple vendor identifiers can be assigned or specified. 
        /// They can be distinguished by using different identification schemes. 
        /// If no Scheme is specified, it must be known to Buyer and Seller.
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Identifier of the identification scheme of the Buyer/Seller identifier.
        /// If used, the identifier of the identification scheme will be selected from the list published by the ISO 6523 maintenance agency.
        /// </summary>
        public string schemeID { get; set; }

        public PartyIdentificationType ToPartyIdentificationType()
        {
            return new PartyIdentificationType
            {
                ID = new IdentifierType
                {
                    Value = ID,
                    schemeID = schemeID
                }
            };
        }
    }
}
