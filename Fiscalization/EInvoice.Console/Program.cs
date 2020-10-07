using EInvoice.Models;
using EInvoice.SOAP;
using System;
using System.IO;
using System.Threading.Tasks;
using UblSharp;

namespace EInvoice.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var date = EInvoiceService.GetDateTimeNow();

            var dcm = new EInvoiceDocument
            {
                //ID = "1",
                InvoiceTypeCode = InvoiceTypeCode.CommercialInvoice,
                IssueDate = date,
                DocumentCurrencyCode = "HRK"
            };
            var xml = dcm.ToXDocument();
            var xmlText = xml.ToString();

            var service = new EInvoiceService(Path.Combine(Environment.CurrentDirectory, "smartwork.p12"));

            var invoice = new RegisterEinvoiceRequest{
                Header = new RegisterEinvoiceRequestHeaderType
                {
                    SendDateTime = date,
                    UUID = "a737f2f9-214d-4841-a3d9-331e7b2b3618"
                },
                EinvoiceEnvelope = new EinvoiceEnvelopeType {
                    ItemElementName = ItemChoiceType.UblInvoice,
                    Item = EInvoiceService.EncodeTo64(xmlText)
                }
            };

            var response = await service.RegisterEinvoiceAsync(invoice);
            
        }
    }
}
