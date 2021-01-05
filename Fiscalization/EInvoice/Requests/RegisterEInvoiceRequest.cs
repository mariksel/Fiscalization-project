using System;
using System.Collections.Generic;
using System.Text;
using Fiscalization;

namespace EInvoice.Requests
{
    public class RegisterEInvoiceRequest
    {

        public static RegisterEInvoiceRequest Create(string ublInvlice, DateTime? sendDateTime = null)
        {
            sendDateTime = sendDateTime ?? DateTime.Now;
            var ublInvliceSigned = FiscalizationSigner.SignUBLInvoice(ublInvlice);
            return new RegisterEInvoiceRequest
            {
                Header = new RegisterEInvoiceRequestHeader
                {
                    UUID = Guid.NewGuid().ToString(),
                    SendDateTime = Fiscalization.FiscalizationService.GetDateTime(sendDateTime.Value)
                },
                EInvoiceEnvelope = new EInvoiceEnvelope
                {
                    Item = EInvoiceService.EncodeTo64(ublInvliceSigned)
                }
            };
        }
        public RegisterEInvoiceRequestHeader Header { get; set; }
        public EInvoiceEnvelope EInvoiceEnvelope { get; set; }
    }
}
