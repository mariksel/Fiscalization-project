using Fiscalization.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiscalization.Models
{
    public class SameTax
    {
        public int NumOfItems { get; set; }
        public decimal PriceBefVAT { get; set; }
        public decimal VATRate { get; set; }
        public bool VATRateSpecified { get; set; }
        public ExemptFromVATSameTaxItem ExemptFromVAT { get; set; }
        public bool ExemptFromVATSpecified { get; set; }
        public decimal VATAmt { get; set; }
        public bool VATAmtSpecified { get; set; }
    }
}
