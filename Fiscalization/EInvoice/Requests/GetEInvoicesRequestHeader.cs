using System;

namespace EInvoice.Requests
{
    public class GetEInvoicesRequestHeader
    {
        public string UUID { get; set; }
        public DateTime SendDateTime { get; set; }
    }
}
