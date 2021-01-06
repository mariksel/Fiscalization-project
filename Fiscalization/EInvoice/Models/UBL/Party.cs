using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class Party
    {
        public Identifier EndpointID { get;  } = new Identifier { schemeID = "0088" };
        public PartyIdentification PartyIdentification { get;  }
        public PartyLegalEntity PartyLegalEntity { get; set; }
        /// <summary>
        /// Buyer's/Seller's Trade Name
        /// The name by which the Buyer/Seller is recognized, other than the formal Buyer/Seller Name (also known as the Company Name).
        /// This can be used if it differs from the Buyer/Seller name.
        /// </summary>
        public PartyName PartyName { get; set; }
        public PartyTaxScheme PartyTaxScheme { get; set; }

        public Party(string nuis, string name, PostalAddress postalAddress)
        {
            PartyName = new PartyName
            {
                Name = name
            };
            EndpointID.Value = nuis;
            PartyIdentification = new PartyIdentification
            {
                schemeID = EndpointID.schemeID,
                ID = $"0088:{nuis}" 
            };
            PartyLegalEntity = new PartyLegalEntity
            {
                RegistrationName = name,
                CompanyID = $"AL{nuis}"
            };
            PartyTaxScheme = new PartyTaxScheme
            {
                CompanyID = $"AL{nuis}",
            };
            PostalAddress = postalAddress;
        }

        public PostalAddress PostalAddress { get; set; }
        public Contact Contact { get; set; }

        public PartyType ToPartyType()
        {
            return new PartyType{
                EndpointID = EndpointID.ToIdentifierType(),
                PartyIdentification = new List<PartyIdentificationType> { PartyIdentification.ToPartyIdentificationType() },
                PartyLegalEntity = new List<PartyLegalEntityType> { PartyLegalEntity.ToPartyLegalEntityType() },
                PartyName = new List<PartyNameType> { PartyName?.ToPartyNameType() },
                PartyTaxScheme = new List<PartyTaxSchemeType> { PartyTaxScheme.ToPartyTaxSchemeType() },
                PostalAddress = PostalAddress.ToAddressType()
            };
        }
    }
}
