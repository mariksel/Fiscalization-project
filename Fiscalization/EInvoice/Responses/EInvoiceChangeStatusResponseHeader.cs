using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.Responses
{
    public class EInvoiceChangeStatusResponseHeader
    {
        public string UUID { get; set; }
        public string RequestUUID { get; set; }
        public DateTime SendDateTime { get; set; }
    }
}
