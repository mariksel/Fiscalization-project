using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class AccountingCustomerParty
    {
        public Party Party { get; set; }

        public AccountingCustomerParty(string nuis)
        {
            Party = new Party(nuis);
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
