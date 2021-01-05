using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.Requests
{
    public class GetTaxpayersRequestHeader
    {
        public string UUID { get; set; } = Guid.NewGuid().ToString();
        public DateTime SendDateTime { get; set; } = EInvoiceService.GetDateTimeNow();
    }
}
