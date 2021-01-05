using Fiscalization.Models;
using Fiscalization.Validators;
using FiscalizationService.SOAP;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fiscalization
{
    public class FiscalizationService
    {
        FiscalizationClient Client { get; }
        public FiscalizationService(CertificateConfigurations certConfigs, FiscalizationClient client )
        {
            Client = client;
            FiscalizationSigner.SetKeyStoreLocation(certConfigs.Path);
        }
        public async Task<RegisterInvoiceResponse> RegisterInvoiceAsync(Requests.RegisterInvoiceRequest request)
        {
            return await Client.RegisterInvoiceAsync(request);
        }


        public async Task RegisterTCRAsync()
        {

        }

        public async Task RegisterCashDepositAsync()
        {

        }

        public async Task RegisterWTNAsync()
        {

        }

        public static string GetDatetimeISO8601(DateTime date)
        {
            return date.ToString("yyyy-MM-dd'T'HH:mm:ssK", CultureInfo.InvariantCulture);
            //2019-01-24T22:00:58+01:00
            //2019-01-24T22:00:58-01:00
            //2020-04-24T23:15:51+02:00
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

        public static string GenerateVerifyURL(RegisterInvoiceRequest rInvoice)
        {
            // This is QR Code
            string baseUrl = @"https://efiskalizimi-app-test.tatime.gov.al/invoice-check/#/verify?";

            baseUrl += "iic=" + rInvoice.Invoice.IIC + "&";

            baseUrl += "tin=" + rInvoice.Invoice.Seller.IDNum + "&";

            baseUrl += "crtd=" + GetDatetimeISO8601(rInvoice.Header.SendDateTime) + "&";

            baseUrl += "ord=" + Regex.Match(rInvoice.Invoice.InvNum, @"\A([0-9]{0,10})", RegexOptions.Singleline).Value + "&";

            baseUrl += "bu=" + rInvoice.Invoice.BusinUnitCode + "&";

            baseUrl += "cr=" + rInvoice.Invoice.TCRCode + "&";

            baseUrl += "sw=" + rInvoice.Invoice.SoftCode + "&";

            baseUrl += "prc=" + rInvoice.Invoice.TotPrice.ToString("F", CultureInfo.InvariantCulture);

            return baseUrl;
        }
    }

}
