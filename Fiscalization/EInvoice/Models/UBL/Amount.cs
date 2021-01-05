using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.UnqualifiedDataTypes;

namespace EInvoice.Models.UBL
{
    public class Amount
    {
        public string currencyID { get; set; }
        public decimal Value { get; set; }

        public static Amount operator *(Amount a, decimal d)
        => new Amount
        {
            currencyID = a.currencyID,
            Value = a.Value * d
        };

        public AmountType ToAmountType()
        {
            return new AmountType
            {
                Value = Value,
                currencyID = currencyID
            };
        }
    }
}
