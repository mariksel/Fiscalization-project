using Fiscalization.Models;
using FiscalizationService.SOAP;
using NUnit.Framework;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Fiscalization.Test
{
    public class Tests
    {
        FiscalizationService Service = new FiscalizationService(Path.Combine(Environment.CurrentDirectory, "smartwork.p12"));
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RegisterInvoice()
        {
            var invoice = new Invoice
            {

                InvNum = "1/2020/cc123cc123",
                OperatorCode = "oo123oo123",
                InvOrdNum = 1,
                TypeOfInv = InvoiceSType.CASH,
                BusinUnitCode = "bb123bb123",
                SoftCode = "ss123ss123",
                TCRCode = "cc123cc123",
                IsIssuerInVAT = true,
                Seller = new Seller
                {
                    IDNum = "L71928020R",
                    Name = "Seller Name"
                },
                PayMethods = new PayMethodType[]
                {
                    new PayMethodType()
                },
                Items = new InvoiceItem[]
                {
                    new InvoiceItem
                    {
                        N = "Emri i artikullit",
                        U = "kg",

                    }
                }
            };

             Service.RegisterInvoiceAsync(invoice).Wait();

            Assert.Pass();
        }
    }
}