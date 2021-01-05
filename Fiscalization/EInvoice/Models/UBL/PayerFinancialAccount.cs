using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class PayerFinancialAccount
    {
        /// <summary>
        /// Debit Account Identifier
        /// Account which is charged directly by debit.
        /// </summary>
        public Identifier ID { get; set; }

        public FinancialAccountType ToFinancialAccountType()
        {
            return new FinancialAccountType
            {
                ID = ID.ToIdentifierType()
            };
        }
    }
}
