using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;
using UblSharp.UnqualifiedDataTypes;

namespace EInvoice.Models.UBL
{
    public class PaymentTerms
    {
        /// <summary>
        /// A textual description of payment terms that applies to the amount due for payment (including a description of possible penalties).
        /// This element can include multiple rows and more conditions (payments).
        /// </summary>
        public string Note { get; set; }

        public PaymentTermsType ToPaymentTermsType()
        {
            return new PaymentTermsType
            {
                Note =new List<TextType> { Note }
            };
        }
    }
}
