using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    /// <summary>
    /// BG-22 Total amounts
    /// </summary>
    public class LegalMonetaryTotal
    {
        /// <summary>
        /// Total of all Net Amounts for Invoice Items
        /// </summary>
        public Amount LineExtensionAmount { get; set; }
        /// <summary>
        /// Total of all Document-level discounts on an invoice.
        /// Item-level discounts are included in the net amount of an itemized invoice and are summed into the total net amount of the invoice.
        /// </summary>
        public Amount AllowanceTotalAmount { get; set; }
        /// <summary>
        /// Total of all document-level Charges on an invoice.
        /// Item-level Charges are included in the net amount of an itemized invoice and are summed into the total net amount of the invoice.
        /// </summary>
        public Amount ChargeTotalAmount { get; set; }
        /// <summary>
        /// Total amount of an invoice, not including VAT.
        /// The total amount of an invoice without VAT is the total net amount of the invoice items, 
        /// minus the total of the document-level discounts and plus the total of document-level Charges.
        /// </summary>
        public Amount TaxExclusiveAmount { get; set; }
        /// <summary>
        /// The total amount of an invoice with VAT included.
        /// The total amount of VAT invoiced is the total amount of and invoice without VAT, 
        /// plus the total VAT amount for the invoice.
        /// </summary>
        public Amount TaxInclusiveAmount { get; set; }
        /// <summary>
        /// Total of prepaid amounts.
        /// This amount is deducted from the total amount of the VAT invoice for the calculation of the due payment amount.
        /// </summary>
        public Amount PrepaidAmount { get; set; }
        /// <summary>
        /// Amount which must be added to total in order to round off the payment amount.
        /// </summary>
        public Amount PayableRoundingAmount { get; set; }
        /// <summary>
        /// Amount Due for Payment
        /// Remaining payment amount
        /// This amount is the total amount of the invoice with VAT deducted for the prepaid amount. 
        /// The amount is zero in the case of a fully paid invoice. 
        /// The amount may be negative, in which case the Seller owes that amount to the Buyer.
        /// </summary>
        public Amount PayableAmount { get; set; }

        public MonetaryTotalType ToMonetaryTotalType()
        {
            return new MonetaryTotalType
            {
                LineExtensionAmount = LineExtensionAmount.ToAmountType(),
                AllowanceTotalAmount = AllowanceTotalAmount.ToAmountType(),
                ChargeTotalAmount = ChargeTotalAmount.ToAmountType(),
                TaxExclusiveAmount = TaxExclusiveAmount.ToAmountType(),
                TaxInclusiveAmount = TaxInclusiveAmount.ToAmountType(),
                PrepaidAmount = PrepaidAmount.ToAmountType(),
                PayableRoundingAmount = PayableRoundingAmount.ToAmountType(),
                PayableAmount = PayableAmount.ToAmountType(),
            };
        }

    }
}
