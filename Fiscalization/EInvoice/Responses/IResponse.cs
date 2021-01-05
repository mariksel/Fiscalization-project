using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.Responses
{
    public interface IResponse
    {
        bool Success { get; set; }
        string ErrorCode { get; set; }
        string ErrorMessage { get; set; }
    }
}
