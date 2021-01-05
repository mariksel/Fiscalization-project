using EInvoice.Models;
using EInvoice.Requests;
using EInvoice.Responses;
using EInvoice.SOAP;
using Fiscalization.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EInvoice
{
    public class EInvoiceService
    {
        protected EInvoiceClient Client { get; }
        public EInvoiceService(CertificateConfigurations certConfigs, EInvoiceClient client)
        {
            Client = client;
            FiscalizationSigner.SetKeyStoreLocation(certConfigs.Path);
        }

        public async Task<RegisterEInvoiceResponse> RegisterEinvoiceAsync(RegisterEInvoiceRequest request)
        {
            return await Client.RegisterEInvoiceAsync(request);
        }

        public async Task<GetEInvoicesResponse> GetEInvoicesAsync(GetEInvoicesRequest request)
        {
            return await Client.GetEInvoicesAsync(request);
        }

        public async Task<Responses.GetTaxpayersResponse> GetTaxPayersAsync(Requests.GetTaxpayersRequest request)
        {
            var res = await Client.GetTaxpayersAsync(request);
            return res;
        }

        public async Task<EInvoiceChangeStatusResponse> EInvoiceChangeStatusAsync(EInvoiceChangeStatusRequest request)
        {
            return await Client.EInvoiceChangeStatusAsync(request);
        }


        public static DateTime GetDateTimeNow()
        {
            var date = DateTime.Now;
            date = GetDateTime(date);
            return date;
        }
        public static DateTime GetDateTime(DateTime date)
        {
            date = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second, DateTimeKind.Local);
            return date;
        }

        static public byte[] EncodeTo64(string toEncode)
        {

            byte[] toEncodeAsBytes = Encoding.BigEndianUnicode.GetBytes(toEncode);
            byte[] toEncodeAsBytes2 = ASCIIEncoding.ASCII.GetBytes(toEncode);

            return toEncodeAsBytes;

        }
    }
}
