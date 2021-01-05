using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.Requests
{
    public class RegisterEInvoiceRequestHeader
    {
        public string UUID { get; set; }
        public DateTime SendDateTime { get; set; }
    }
}
