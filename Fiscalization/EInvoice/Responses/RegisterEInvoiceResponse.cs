using EInvoice.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.Responses
{
    public class RegisterEInvoiceResponse : IResponse
    {
        public bool Success { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }

        public RegisterEInvoiceResponseHeader Header { get; set; }
        public string EIC { get; set; }
        public Warning[] Warnings { get; set; }
    }
}
