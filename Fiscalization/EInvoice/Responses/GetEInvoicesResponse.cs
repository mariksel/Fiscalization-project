using EInvoice.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.Responses
{
    public class GetEInvoicesResponse: IResponse
    {
        public bool Success { get; set; } = true;
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public GetEInvoiceResponseHeader Header { get; set; }
        public EInvoiceModel[] Einvoices { get; set; }
        
    }
}
