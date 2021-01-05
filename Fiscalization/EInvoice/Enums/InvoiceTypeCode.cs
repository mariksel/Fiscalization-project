using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.UnqualifiedDataTypes;
using EnumsNET;
using System.ComponentModel;

namespace EInvoice.Enums
{
    public enum InvoiceTypeCode
    {
        /// <summary>82</summary>
        [Description("82")]
        InvoiceForMeasuredServices,
        /// <summary>325</summary>
        [Description("325")]
        PreInvoice,
        /// <summary>326</summary>
        [Description("326")]
        PartialInvoice,
        /// <summary>380</summary>
        [Description("380")]
        CommercialInvoice,
        /// <summary>381</summary>
        [Description("381")]
        Approval,
        /// <summary>383</summary>
        [Description("383")]
        Debit,
        /// <summary>384</summary>
        [Description("384")]
        CorrectiveInvoice,
        /// <summary>386</summary>
        [Description("386")]
        AdvancePaymentInvoice,
        /// <summary>394</summary>
        [Description("394")]
        LeasingInvoice,

    }
}
