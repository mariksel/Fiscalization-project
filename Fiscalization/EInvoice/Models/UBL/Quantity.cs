using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.Models.UBL
{
    public class Quantity
    {
        public string unitCode { get; set; }
        public string unitCodeListID { get; set; }
        public string unitCodeListAgencyID { get; set; }
        public string unitCodeListAgencyName { get; set; }
        public decimal Value { get; set; }
    }
}
