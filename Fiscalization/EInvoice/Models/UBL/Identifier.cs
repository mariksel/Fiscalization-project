using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.UnqualifiedDataTypes;

namespace EInvoice.Models.UBL
{
    public class Identifier
    {
        public string schemeID { get; set; }
        public string Value { get; set; }

        public static implicit operator Identifier(string value) => new Identifier { Value = value };

        public IdentifierType ToIdentifierType()
        {
            return new IdentifierType
            {
                Value = Value,
                schemeID = schemeID
            };
        }
    }
}
