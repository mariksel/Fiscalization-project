using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.Requests
{
    public class EInvoiceChangeStatusRequestHeader
    {
        public string UUID { get; set; }
        public DateTime SendDateTime { get; set; }
    }
}
