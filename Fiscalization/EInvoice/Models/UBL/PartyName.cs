using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class PartyName
    {
        
        public string Name { get; set; }

        public PartyNameType ToPartyNameType()
        {
            return new PartyNameType
            {
                Name = Name
            };
        }
    }
}
