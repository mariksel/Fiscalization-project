using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.UnqualifiedDataTypes;

namespace EInvoice.Models.UBL
{
    public class BinaryObject
    {
        public string format { get; set; }
        public string mimeCode { get; set; }
        public string encodingCode { get; set; }
        public string characterSetCode { get; set; }
        public string uri { get; set; }
        public string filename { get; set; }
        public byte[] Value { get; set; }

        public BinaryObjectType ToBinaryObjectType()
        {
            return new BinaryObjectType
            {
                format = format,
                mimeCode = mimeCode,
                encodingCode = encodingCode,
                characterSetCode = characterSetCode,
                uri = uri,
                filename = filename,
                Value = Value
            };
        }
    }
}
