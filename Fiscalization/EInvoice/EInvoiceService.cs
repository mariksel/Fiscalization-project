using EInvoice.SOAP;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EInvoice
{
    public class EInvoiceService
    {
        EInvoiceClient Client = new EInvoiceClient();
        public EInvoiceService(string certificatePath)
        {
            
            FiscalizationSigner.SetKeyStoreLocation(certificatePath);
        }

        public async Task<RegisterEinvoiceResponse> RegisterEinvoiceAsync(RegisterEinvoiceRequest rEInvoice)
        {
            

            return (await Client.registerEinvoiceAsync(rEInvoice))
                .RegisterEinvoiceResponse;
        }


        public static DateTime GetDateTimeNow()
        {
            var date = DateTime.Now;
            date = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second, DateTimeKind.Local);
            return date;
        }

        static public byte[] EncodeTo64(string toEncode)
        {

            byte[] toEncodeAsBytes = ASCIIEncoding.ASCII.GetBytes(toEncode);

            return toEncodeAsBytes;

        }
    }
}
