using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class TaxTotal
    {
        public TaxTotal(TaxSubtotal[] taxSubtotal)
        {
            TaxSubtotal = taxSubtotal;
            TaxAmount = new Amount
            {
                currencyID = taxSubtotal.First().TaxAmount.currencyID,
                Value = TaxSubtotal.Sum(m => m.TaxAmount.Value)
            };
        }
        /// <summary>
        /// Total VAT amount for account.
        /// The total amount of VAT is calculated as the sum of all taxes of all VAT categories.
        /// </summary>
        public Amount TaxAmount { get; set; }
        /// <summary>
        /// DISTRIBUTION OF VAT
        /// A set of business terms that provide information on the distribution of VAT by different categories, rates, and reasons for exemption
        /// </summary>
        public TaxSubtotal[] TaxSubtotal { get; set; }

        public TaxTotalType ToTaxTotalType()
        {
            return new TaxTotalType
            {
                TaxAmount = TaxAmount.ToAmountType(),
                TaxSubtotal = TaxSubtotal.Select(m => m.ToTaxSubtotalType()).ToList()
            };
        }
    }
}
