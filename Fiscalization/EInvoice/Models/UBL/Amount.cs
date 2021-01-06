using EnumsNET;
using Fiscalization.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.UnqualifiedDataTypes;

namespace EInvoice.Models.UBL
{
    public class Amount
    {
        public CurrencyCode currencyID { get; set; }
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
                Value = decimal.Round(Value, 2),
                currencyID = currencyID.AsString()
            };
        }
    }
}
