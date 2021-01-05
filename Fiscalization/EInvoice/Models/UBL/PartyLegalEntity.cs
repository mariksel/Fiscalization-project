using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;
using UblSharp.UnqualifiedDataTypes;

namespace EInvoice.Models.UBL
{
    public class PartyLegalEntity
    {
        /// <summary>
        /// Buyer/Seller’s Name
        /// Complete formal name by which the Seller is entered in the national register of legal persons, 
        /// either as a taxpayer or otherwise trading as a person or persons.
        /// </summary>
        public string RegistrationName { get; set; }
        /// <summary>
        /// Buyer/Seller's Legal Registration Identifier
        /// Officially issued identifier which serves to identify the Seller as a legal entity or a natural person.
        /// If no identification scheme is specified, it must be known to the Buyer and Seller.
        /// </summary>
        public string CompanyID { get; set; }
        /// <summary>
        /// Identifier of Identification Scheme for a Buyer/Seller’s legal registration Identifier.
        /// If used, the identification scheme is selected from the list published by the ISO 6523 maintenance agency.
        /// </summary>
        public string schemeID { get; set; }
        /// <summary>
        /// Additional legal information about the Buyer/Seller
        /// 
        /// </summary>
        public string CompanyLegalForm { get; set; }

        public PartyLegalEntityType ToPartyLegalEntityType()
        {
            return new PartyLegalEntityType
            {
                RegistrationName = RegistrationName,
                CompanyID = new IdentifierType {
                    Value = CompanyID,
                    schemeID = schemeID
                },
                CompanyLegalForm = CompanyLegalForm
            };
        }
    }
}
