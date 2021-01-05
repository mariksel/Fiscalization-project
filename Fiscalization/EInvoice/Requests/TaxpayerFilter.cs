using EInvoice.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.Requests
{
    public class TaxpayerFilter
    {
        public string Item { get; set; }
        public TaxpayerFilterItemChoice ItemElementName { get; set; }
    }
}
