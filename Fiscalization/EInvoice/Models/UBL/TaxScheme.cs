using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class TaxScheme
    {
        public Identifier ID { get; set; }

        public TaxSchemeType ToTaxSchemeType()
        {
            return new TaxSchemeType
            {
                ID = ID.ToIdentifierType(),
            };
        }
    }
}
