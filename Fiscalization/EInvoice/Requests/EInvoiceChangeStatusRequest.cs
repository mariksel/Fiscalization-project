using EInvoice.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.Requests
{
    public class EInvoiceChangeStatusRequest
    {
        public EInvoiceChangeStatusRequestHeader Header { get; set; }
        public string[] EICs { get; set; }
        public EInvoiceStatusChange EInStatus { get; set; }
    }
}
