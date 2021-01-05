using EnumsNET;
using Fiscalization.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiscalization.Requests
{
    public class RegisterInvoiceRequestHeader
    {
        public string UUID { get; set; }
        public DateTime SendDateTime { get; set; }

        public bool SubseqDelivTypeSpecified { get; private set; } = false;
        private SubsequentDeliveryType _subseqDelivType;
        public SubsequentDeliveryType SubseqDelivType { 
            get => _subseqDelivType;
            set
            {
                if (value.IsDefined())
                {
                    _subseqDelivType = value;
                    SubseqDelivTypeSpecified = true;
                }
            } 
        }
    }
}
