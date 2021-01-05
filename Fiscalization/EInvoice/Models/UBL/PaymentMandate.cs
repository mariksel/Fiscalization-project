using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class PaymentMandate
    {
        public Identifier ID { get; set; }
        public PayerFinancialAccount PayerFinancialAccount { get; set; }

        public PaymentMandateType ToPaymentMandateType()
        {
            return new PaymentMandateType
            {
                ID = ID.ToIdentifierType(),
                PayerFinancialAccount = PayerFinancialAccount.ToFinancialAccountType()
            };
        }
    }
}
