using EnumsNET;
using Fiscalization.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.UnqualifiedDataTypes;

namespace EInvoice.Models.UBL
{
    public class Quantity
    {
        public UnitCode unitCode { get; set; }
        public string unitCodeListID { get; set; }
        public string unitCodeListAgencyID { get; set; }
        public string unitCodeListAgencyName { get; set; }
        public decimal Value { get; set; }

        public static implicit operator Quantity(decimal value) => new Quantity { Value = value };

        public QuantityType ToQuantityType()
        {
            return new QuantityType
            {
                unitCode = unitCode.AsString(),
                unitCodeListID = unitCodeListID,
                unitCodeListAgencyID = unitCodeListAgencyID,
                unitCodeListAgencyName = unitCodeListAgencyName,
                Value = Value
            };
        }
    }
}
