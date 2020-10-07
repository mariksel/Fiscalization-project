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
        FiscalizationClient Client = new FiscalizationClient();
        public FiscalizationService(string certificatePath)
        {
            FiscalizationSigner.SetKeyStoreLocation(certificatePath);
        }
        public async Task RegisterInvoiceAsync(Invoice invoice)
        {

            InvoiceValidator validator = new InvoiceValidator();
            var result = validator.Validate(invoice);

            if (!result.IsValid)
                throw new ValidationException(result.ToString());

            var dateNow = GetDateTimeNow();

            var rInvoice = new RegisterInvoiceRequest
            {
                Header = new RegisterInvoiceRequestHeaderType
                {
                    UUID = invoice.UUID,
                    SendDateTime = dateNow,
                    SubseqDelivType = SubseqDelivTypeSType.SERVICE,
                    SubseqDelivTypeSpecified = false,

                },
                Invoice = new InvoiceType
                {
                    IsIssuerInVAT = invoice.IsIssuerInVAT,
                    IIC = invoice.IIC,
                    IICSignature = invoice.IICSignature,
                    PayMethods = invoice.PayMethods,
                    SameTaxes = invoice.SameTaxes,
                    Buyer = invoice.Buyer,
                    TypeOfInv = invoice.TypeOfInv,
                    BusinUnitCode = invoice.BusinUnitCode,
                    Currency = invoice.Currency,
                    InvNum = invoice.InvNum,
                    InvOrdNum = invoice.InvOrdNum,
                    IssueDateTime = invoice.IssueDateTime,
                    Items = invoice.Items.Select(item => item.ToInvoiceItemType()).ToArray(),
                    OperatorCode = invoice.OperatorCode,
                    PayDeadlineSpecified = invoice.PayDeadlineSpecified,
                    Seller = invoice.Seller.ToSellerType(),
                    SoftCode = invoice.SoftCode,
                    TCRCode = invoice.TCRCode,
                    TotPrice = invoice.TotPrice,
                    TotVATAmtSpecified = invoice.TotVATAmtSpecified,
                    TotPriceWoVAT = invoice.TotPriceWoVAT,
                    TotVATAmt = invoice.TotVATAmt,
                    BadDebtInv = invoice.BadDebtInv,
                    ConsTaxes = invoice.ConsTaxes,
                    CorrectiveInv = invoice.CorrectiveInv,
                    Fees = invoice.Fees,
                    GoodsExAmt = invoice.GoodsExAmt,
                    GoodsExAmtSpecified = invoice.GoodsExAmtSpecified,
                    ImpCustDecNum = invoice.ImpCustDecNum,
                    IsReverseCharge = invoice.IsReverseCharge,
                    IsSimplifiedInv = invoice.IsSimplifiedInv,
                    MarkUpAmt = invoice.MarkUpAmt,
                    MarkUpAmtSpecified = invoice.MarkUpAmtSpecified,
                    PayDeadline = invoice.PayDeadline,
                    SumInvIICRefs = invoice.SumInvIICRefs,
                    SupplyDateOrPeriod = invoice.SupplyDateOrPeriod,
                    TaxFreeAmt = invoice.TaxFreeAmt,
                    TaxFreeAmtSpecified = invoice.TaxFreeAmtSpecified,
                    TypeOfSelfIss = invoice.TypeOfSelfIss,
                    TypeOfSelfIssSpecified = invoice.TypeOfSelfIssSpecified
                },
            };


            var response = (await Client.registerInvoiceAsync(rInvoice)).RegisterInvoiceResponse;

           
        }

        public async Task RegisterInvoiceSameTimeAsync(Invoice invoice)
        {

        }

        public async Task RegisterInvoiceLaterTimeAsync(Invoice invoice, SubseqDelivTypeSType problemType)
        {

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
