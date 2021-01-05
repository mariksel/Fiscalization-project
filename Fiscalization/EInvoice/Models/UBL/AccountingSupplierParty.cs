using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class AccountingSupplierParty
    {
        public AccountingSupplierParty(string nuis)
        {
            Party = new Party(nuis);
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
