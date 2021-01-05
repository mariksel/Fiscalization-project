using EInvoice.Enums;
using EnumsNET;
using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;
using UblSharp.UnqualifiedDataTypes;

namespace EInvoice.Models.UBL
{
    /// <summary>
    /// BG-16 Payment instructions
    /// </summary>
    public class PaymentMeans
    {
        /// <summary>
        /// The way, expressed as a code, in which payment is expected or has already been made.
        /// </summary>
        public PaymentMeansCode PaymentMeansCode { get; set; }
        /// <summary>
        /// The way, expressed as text, for which payment is expected or already made.
        /// Such as cash, transfer from accounts, direct debit, credit card etc.
        /// </summary>
        public string InstructionNote { get; set; }
        /// <summary>
        /// The text value used to establish a link between payment and the invoices issued by the Seller.
        /// </summary>
        public string PaymentID { get; set; }
        public PayeeFinancialAccount PayeeFinancialAccount { get; set; }
        public CardAccount CardAccount { get; set; }
        /// <summary>
        /// This group may be used for prior notification on an invoice that payment will be made through SEPA 
        /// or other direct debit means initiated by the Seller, in accordance with the SEPA or other direct debit scheme.
        /// </summary>
        public PaymentMandate PaymentMandate { get; set; }

        public PaymentMeansType ToPaymentMeansType()
        {
            return new PaymentMeansType
            {
                PaymentMeansCode = PaymentMeansCode.AsString(EnumFormat.Description),
                InstructionNote = new List<TextType> { InstructionNote },
                PaymentID = new List<IdentifierType> { PaymentID },
                PayeeFinancialAccount = PayeeFinancialAccount.ToFinancialAccountType(),
                CardAccount = CardAccount.ToCardAccountType(),
                PaymentMandate = PaymentMandate.ToPaymentMandateType()
            };
        }
    }
}
