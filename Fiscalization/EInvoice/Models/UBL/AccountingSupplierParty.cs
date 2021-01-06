using Fiscalization.Models;
using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class AccountingSupplierParty
    {
        public AccountingSupplierParty(Seller seller)
        {
            var postalAddress = new PostalAddress
            {
                StreetName = seller.Address,
                CityName = seller.Town,
                //PostalZone = seller.
                //CountrySubentity = "Tirana",

            };
            if (seller.Country.HasValue)
                postalAddress.Country = new Country
                {
                    IdentificationCode = seller.Country.Value
                };

            Party = new Party(seller.IDNum, seller.Name, postalAddress);
        }
        public Party Party { get; set; }

        public SupplierPartyType ToSupplierPartyType()
        {
            return new SupplierPartyType
            {
                Party = Party.ToPartyType()
            };
        }
    }
}
