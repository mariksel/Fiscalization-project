using System.ComponentModel;

namespace EInvoice.Enums
{
    public enum InvoicePeriodCode
    {
        /// <summary> 3 </summary>
        [Description("3")]
        InvoiceIssueDate,
        /// <summary> 35 </summary>
        [Description("35")]
        DateOfActualDelivery,
        /// <summary> 432 </summary>
        [Description("432")]
        PaymentDate
    }
}
