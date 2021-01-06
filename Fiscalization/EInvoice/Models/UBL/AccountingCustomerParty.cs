using Fiscalization.Models;
using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class AccountingCustomerParty
    {
        public Party Party { get; set; }

        public AccountingCustomerParty(Buyer buyer)
        {
            var postalAddress = new PostalAddress
            {
                StreetName = buyer.Address,
                CityName = buyer.Town,
                //PostalZone = seller.
                //CountrySubentity = "Tirana",

                
            };
            if (buyer.Country.HasValue)
                postalAddress.Country = new Country
                {
                    IdentificationCode = buyer.Country.Value
                };
            Party = new Party(buyer.IDNum, buyer.Name, postalAddress);
        }
        public CustomerPartyType ToSupplierPartyType()
        {
            return new CustomerPartyType
            {
                Party = Party.ToPartyType()
            };
        }
    }
}
