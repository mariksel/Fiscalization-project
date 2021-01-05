using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.Models.UBL
{
    public class Price
    {
        public Amount PriceAmount { get; set; }
        public AllowanceCharge AllowanceCharge { get; set; }
        public Quantity BaseQuantity { get; set; }
    }
}
