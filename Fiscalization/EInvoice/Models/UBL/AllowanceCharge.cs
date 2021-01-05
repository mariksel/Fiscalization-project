using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;
using UblSharp.UnqualifiedDataTypes;

namespace EInvoice.Models.UBL
{
    /// <summary>
    /// BG-20 Document-level discounts
    /// BG-21 Document-level charges
    /// </summary>
    public class AllowanceCharge
    {
        /// <summary>
        /// Document-level discounts = false;
        /// Document-level charges = true;
        /// </summary>
        public bool ChargeIndicator { get; set; }
        /// <summary>
        /// Amount of Document-level Discount
        /// Amount of discount, without VAT.
        /// </summary>
        public Amount Amount { get; set; }
        /// <summary>
        /// Basis of Document-level Discount
        /// The basis which, together with the percentage of document-level discounts, 
        /// is used to calculate the amount of a document-level discount.
        /// </summary>
        public Amount BaseAmount { get; set; }
        /// <summary>
        /// Percentage of Document-level Discount
        /// The percentage which, together with the basis of a document-level discount, 
        /// is used to calculate a document-level discount amount.
        /// </summary>
        public int MultiplierFactorNumeric { get; set; }
        /// <summary>
        /// Reason for Document-level Discount
        /// </summary>
        public string AllowanceChargeReason { get; set; }
        /// <summary>
        /// Code for Reason for Document-level Discount
        /// Use UNTDID 5189 list entries [6]. 
        /// The code which describes reason for the document-level discount, 
        /// and the reason for the document-level discount must apply to the same document-level discount reason.
        /// </summary>
        public string AllowanceChargeReasonCode { get; set; }
        public TaxCategory TaxCategory { get; set; }

        public AllowanceChargeType ToAllowanceChargeType()
        {
            return new AllowanceChargeType
            {
                ChargeIndicator = ChargeIndicator,
                Amount = Amount.ToAmountType(),
                BaseAmount = BaseAmount.ToAmountType(),
                MultiplierFactorNumeric = MultiplierFactorNumeric,
                AllowanceChargeReason = new List<TextType> { AllowanceChargeReason },
                AllowanceChargeReasonCode = AllowanceChargeReasonCode,
                TaxCategory = new List<TaxCategoryType> { TaxCategory.ToTaxCategoryType() }
            };
        }
    }
}
