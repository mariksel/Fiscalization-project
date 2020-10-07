using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.UnqualifiedDataTypes;

namespace EInvoice.Models
{
    public class InvoiceTypeCode
    {
        public const string InvoiceForMeasuredServices = "82";
        public const string PreInvoice = "325";
        public const string PartialInvoice = "326";
        public const string CommercialInvoice = "380";
        public const string Approval = "381";
        public const string Debit = "383";
        public const string CorrectiveInvoice = "384";
        public const string AdvancePaymentInvoice = "386";
        public const string LeasingInvoice = "394";

    }
}
