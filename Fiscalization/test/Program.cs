using Fiscalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.ServiceReference1;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new FiscalizationServicePortTypeClient();
            var endpointBh = new XMLSignerEndpointBehavior();
            client.Endpoint.EndpointBehaviors.Add(endpointBh);

            var now = DateTime.Now;
            var date = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second, DateTimeKind.Local);

            var rInvoice = new RegisterInvoiceRequest
            {
                //Id = "id10",
                //Version = 1,
                Header = new RegisterInvoiceRequestHeaderType
                {
                    UUID = "d3bdf243-f687-4485-8d64-c819329e9e0b",
                    SendDateTime = date,
                    SubseqDelivType = SubseqDelivTypeSType.SERVICE,
                    SubseqDelivTypeSpecified = false,

                },
                Invoice = new InvoiceType
                {
                    IsIssuerInVAT = true,
                    IIC = FiscalizationSignin.GenerateIIC(),
                    IICSignature = FiscalizationSignin.SignIICSignature("I12345678I"),
                    PayMethods = new PayMethodType[]
                    {
                        new PayMethodType
                        {
                            Amt = 20.00M,
                            Type = PaymentMethodTypeSType.BANKNOTE
                        }
                    },
                    //SameTaxes = new SameTaxType[]
                    //{
                    //    new SameTaxType
                    //    {
                    //        NumOfItems = 1,
                    //        PriceBefVAT = 16.00M,
                    //        VATAmt = 4.00M,
                    //        VATRate = 25.00M
                    //    }
                    //},
                    //Buyer = new BuyerType
                    //{
                    //    Address = "bayer address",
                    //    Country = CountryCodeSType.ALB,
                    //    CountrySpecified = true,
                    //    IDNum = "L91806031N",
                    //    IDType = IDTypeSType.NUIS,
                    //    IDTypeSpecified = true,
                    //    Name = "bayer name",
                    //    Town = "bayer town"
                    //},
                    TypeOfInv = InvoiceSType.CASH,
                    BusinUnitCode = "bb123bb123",
                    Currency = new CurrencyType
                    {
                        Code = CurrencyCodeSType.EUR,
                        ExRate = 1.24,
                        IsBuying = true
                    },
                    InvNum = "1/2020",
                    InvOrdNum = 1,
                    IssueDateTime = date,
                    Items = new InvoiceItemType[]{
                        new InvoiceItemType
                        {
                           C = "501234567890",
                           PA = 20.00M,
                           PB = 16.00M,
                           Q = 1.0,
                           R = 0,
                           RR = true,
                           UPB = 16.00M,
                           UPA = 20.00M,
                           VA = 4.00M,
                           VR = 25.00M,
                           EXSpecified = false,
                           INSpecified = false,
                           N = "Item name",
                           U = "pieces",
                           EX = ExemptFromVATSType.TAX_FREE
                        }
                    },
                    OperatorCode = "oo123oo123",
                    PayDeadlineSpecified = false,
                    Seller = new SellerType
                    {
                       Address = "seller address",
                       Country = CountryCodeSType.ALB,
                       CountrySpecified = true,
                       IDNum = "L41316032F",
                       IDType = IDTypeSType.NUIS,
                       Name = "Seller name",
                       Town = "seller town",
                       
                    },
                    SoftCode = "ss123ss123",
                    TCRCode = "cc123cc123",
                    TotPrice = 20.00M,
                    //TotVATAmtSpecified = false,
                    //TotPriceWoVAT = 16.00M,
                    //TotVATAmt = 4,

                },
            };
   

            var response = client.registerInvoice(rInvoice);
            

            var url = FiscalizationService.GenerateVerifyURL(rInvoice);
        }
    }
}
