using EInvoice.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EInvoice.Models
{
    public class EInvoiceModel
    {
        public PDF Pdf { get; set; }
        public string EIC { get; set; }
        public string DocNumber { get; set; }
        public DocumentType DocType { get; set; }
        public DateTime RecDateTime { get; set; }
        public DateTime DueDateTime { get; set; }
        public EInvoiceStatus Status { get; set; }
        public decimal Amount { get; set; }
        public PartyType PartyType { get; set; }

        public class PDF
        {
            private string _EIC { get; }
            private byte[] _data { get; }
            public PDF(byte[] data, string EIC)
            {
                _data = data;
                _EIC = EIC;
            }
            public string GetTempFile()
            {
                var path = Path.Combine(Path.GetTempPath(), $"{Path.GetTempFileName()}.pdf");
                using FileStream stream = File.Create(path);
                stream.Write(_data, 0, _data.Length);
                
                return path;
            }

        }

        
    }
}
