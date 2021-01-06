using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class AddressLine
    {
        /// <summary>
        /// An additional address field that can be used to provide further details that complement the main address field.
        /// </summary>
        public string Line { get; set; }

        public AddressLineType ToAddressLineType()
        {
            return new AddressLineType
            {
                Line = Line
            };
        }
    }
}
