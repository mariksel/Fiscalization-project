using Fiscalization.Enums;
using Fiscalization.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiscalization.Requests
{
    public class RegisterInvoiceRequest
    {
        //public static RegisterInvoiceRequest CreateRegisterNonCashInvoiceRequest()
        public static RegisterInvoiceRequest CreateRegisterInvoiceRequest(DateTime senddateTime,
            SubsequentDeliveryType subseqDelivType, Invoice invoice)
        {
            var request = new RegisterInvoiceRequest
            {
                Header = new RegisterInvoiceRequestHeader
                {
                    UUID = Guid.NewGuid().ToString(),
                    SendDateTime = FiscalizationService.GetDateTime(senddateTime),
                    SubseqDelivType = subseqDelivType
                },
                Invoice = invoice
            };
            return request;
        }
        public RegisterInvoiceRequestHeader Header { get; set; }
        public Invoice Invoice { get; set; }
    }
}
