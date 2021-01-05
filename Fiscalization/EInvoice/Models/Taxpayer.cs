using EInvoice.Enums;
using EnumsNET;
using Fiscalization.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.Models
{
    public class Taxpayer
    {
        public string Name { get; set; }
        public string Tin { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }

        public bool CountrySpecified { get; private set; } = false;
        private CountryCode _country;
        public CountryCode Country { 
            get => _country;
            set
            {
                if (value.IsDefined())
                {
                    _country = value;
                    CountrySpecified = true;
                }
            } 
        }
    }
}
