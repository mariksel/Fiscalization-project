using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    /// <summary>
    /// BG-23 Distribution of VAT
    /// </summary>
    public class TaxSubtotal
    {
        /// <summary>
        /// Base Amount of VAT Category
        /// The total of all taxable amounts subject to a particular VAT category code and VAT category rate (if VAT rate applies).
        /// The net total of all items, minus discounts, plus document-level Charges that are subject to specific 
        /// VAT category codes and VAT rate categories (if VAT rate applies)
        /// </summary>
        public Amount TaxableAmount { get; set; }
        /// <summary>
        /// Amount of VAT Category
        /// Total VAT amount for a particular VAT category.
        /// Calculated by multiplying the taxable amount of VAT with the VAT rate category rate for the relevant VAT category.
        /// </summary>
        public Amount TaxAmount => TaxableAmount * (decimal)(TaxCategory.Percent / 100.0);
        public TaxCategory TaxCategory { get; set; }

        public TaxSubtotalType ToTaxSubtotalType()
        {
            return new TaxSubtotalType
            {
                TaxableAmount = TaxableAmount.ToAmountType(),
                TaxAmount = TaxAmount.ToAmountType(),
                TaxCategory = TaxCategory.ToTaxCategoryType()
            };
        }
    }
}
