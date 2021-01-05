using EInvoice.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.Responses
{
    public class GetTaxpayersResponse: IResponse
    {
        public bool Success { get; set; } = true;
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public GetTaxpayersResponseHeader Header { get; set; }

        public Taxpayer[] Taxpayers { get; set; }

    }
}
