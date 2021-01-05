using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Policy;
using System.Text;

namespace EInvoice.Enums
{
    public enum PaymentMeansCode
    {
        /// <summary>10</summary>
        [Description("10")]
        Cash,
        /// <summary>30</summary>
        [Description("30")]
        CashTransfer,
        /// <summary>48</summary>
        [Description("48")]
        BankCard,
        /// <summary>49</summary>
        [Description("49")]
        DirectDebit,
    }
}
