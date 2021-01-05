using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class TaxTotal
    {
        public TaxTotal(TaxSubtotal taxSubtotal)
        {
            TaxSubtotal = taxSubtotal;
            TaxAmount = TaxSubtotal.TaxAmount;
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
        public TaxSubtotal TaxSubtotal { get; set; }

        public TaxTotalType ToTaxTotalType()
        {
            return new TaxTotalType
            {
                TaxAmount = TaxAmount.ToAmountType(),
                TaxSubtotal = new List<TaxSubtotalType> { TaxSubtotal.ToTaxSubtotalType() }
            };
        }
    }
}
