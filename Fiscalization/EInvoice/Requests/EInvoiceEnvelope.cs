using EInvoice.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.Requests
{
    public class EInvoiceEnvelope
    {
        public byte[] Item { get; set; }
        public ItemChoice ItemElementName { get; } = ItemChoice.UblInvoice;
    }
}
