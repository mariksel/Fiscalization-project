using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace EInvoice.Models
{
    public class PaymentMeansCode
    {
        public const string Cash = "10";
        public const string CashTransfer = "30";
        public const string BankCard = "48";
        public const string DirectDebit = "49";
    }
}
