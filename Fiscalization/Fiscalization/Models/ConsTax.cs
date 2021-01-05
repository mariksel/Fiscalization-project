using System;
using System.Collections.Generic;
using System.Text;

namespace Fiscalization.Models
{
    public class ConsTax
    {
        public int NumOfItems { get; set; }
        public decimal PriceBefConsTax { get; set; }
        public decimal ConsTaxRate { get; set; }
        public decimal ConsTaxAmt { get; set; }
    }
}
