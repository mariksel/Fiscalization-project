using EInvoice;
using EnumsNET;
using Fiscalization;
using Fiscalization.Enums;
using Fiscalization.Models;
using Fiscalization.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EInvoice_UI.Frmw
{
    public partial class Form1 : Form
    {
        public static string CERT = "eltonzhuleku.p12";
        //public static string CERT = "cimi.p12";
        EInvoiceServiceFactory _factory = new EInvoiceServiceFactory(Path.Combine(Environment.CurrentDirectory, CERT));
        FiscalizationFactory _fisFactory = new FiscalizationFactory(Path.Combine(Environment.CurrentDirectory, CERT));
        public Form1()
        {
            InitializeComponent();
            call();
        }

        async void call()
        {
            var service = _factory.EInvoiceService;
            var eInvoiceFac = _factory.EInvoiceFactory;
            Invoice _invoice;

            var date = DateTime.Now;
            var fisService = _fisFactory.GetFiscaliztionService();
            var items = new InvoiceItem[]
            {
                new InvoiceItem
                {
                    BarCode = "5301000171376",
                    C = "code1",
                    N = "Item 1",
                    Q = 2,
                    VR = 10,
                    U = "kg",
                    UPB = 10,
                }
            };
            var seller = Seller.CreateSeller("L41316032F", "Elton", "Tiran Albania", "Tiran", CountryCode.ALB);
            var payMethods = new PayMethod[] {
                new PayMethod
                {
                    Type = PaymentMethodType.OTHER,
                    Amt = items.Sum(i => i.PA)
                }
            };
            _invoice = Invoice.CreateInvoice(seller, date, Fiscalization.Enums.InvoiceType.NONCASH, "wo765uk675", "dt947iw604", "eq535yw328", "au254tb295",
                100, items, payMethods, true);
            _invoice.IsEinvoice = true;
            _invoice.Buyer = new Buyer
            {
                IDNum = "L82118024B",
                Address = "Tiran Albania",
                IDType = IDType.NUIS,
                Name = "CIMI",
                Country = CountryCode.ALB
            };
            _invoice.Currency = new Currency
            {
                Code = CurrencyCode.ALL,
                ExRate = 1
            };
            var req1 = RegisterInvoiceRequest.CreateRegisterInvoiceRequest(date, SubsequentDeliveryType.SERVICE, _invoice);
            var res1 = await fisService.RegisterInvoiceAsync(req1);
            var FIC = res1.FIC;


            var req = eInvoiceFac.EInviceP1(_invoice, date, date, date, FIC);

            var res = await service.RegisterEinvoiceAsync(req);




            Invoice _invoice2 = null;

            items[0].UPB = -items[0].UPB;
            var items2 = new InvoiceItem[]
            {
                items[0]
            };
            var payMethods2 = new PayMethod[] {
                new PayMethod
                {
                    Type = PaymentMethodType.OTHER,
                    Amt = items2.Sum(i => i.PA)
                }
            };
            _invoice2 = Invoice.CreateCorrectiveInvoice(_invoice.IIC, date, seller, date, Fiscalization.Enums.InvoiceType.NONCASH, "wo765uk675", "dt947iw604", "eq535yw328", "au254tb295",
                100, items2, payMethods2, true);
            _invoice2.IsEinvoice = true;
            _invoice2.Buyer = _invoice.Buyer;
            _invoice2.Currency = new Currency
            {
                Code = CurrencyCode.ALL,
                ExRate = 1
            };
            var req12 = RegisterInvoiceRequest.CreateRegisterInvoiceRequest(date, SubsequentDeliveryType.SERVICE, _invoice2);
            var res12 = await fisService.RegisterInvoiceAsync(req12);

            var req2 = eInvoiceFac.EInviceP10(_invoice.IIC, date, _invoice2, date, date, date, res12.FIC);

            var res2 = await service.RegisterEinvoiceAsync(req2);
        }
    }
}
