using EInvoice.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.Responses
{
    public class EInvoiceChangeStatusResponse: IResponse
    {
        public bool Success { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public EInvoiceChangeStatusResponseHeader Header { get; set; }
        public ResponseCode ResponseCode { get; set; }
        
    }
}
