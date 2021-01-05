using EInvoice.Models.UBL;
using EInvoice.Requests;
using EInvoice.SOAP;
using Fiscalization.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice
{
    public class EInvoiceFactory
    {
        protected UBLService UBLService { get; }
        public EInvoiceFactory(UBLService uBLService)
        {
            UBLService = UBLService;
        }

        /// <summary> Invoicing the supply of goods and services ordered on a contract basis </summary>
        public RegisterEInvoiceRequest EInviceP1(Invoice invoice, DateTime issuedDate, DateTime dueDate, DateTime taxPointDate, InvoicePeriod invoicePeriod,
             DateTime? sendDateTime = null)
        {
            var supplyerParty = new AccountingSupplierParty(invoice.Seller.IDNum);
            supplyerParty.Party.PostalAddress = new PostalAddress
            {
                StreetName = invoice.Seller.Address,
                CityName = invoice.Seller.Town,
                Country = new Country
                {
                    IdentificationCode = invoice.Seller.Country
                }
            };
            var customerParty = new AccountingCustomerParty(invoice.Buyer.IDNum);
            customerParty.Party.PostalAddress = new PostalAddress
            {
                StreetName = invoice.Buyer.Address,
                CityName = invoice.Buyer.Town,
                Country = new Country
                {
                    IdentificationCode = invoice.Buyer.Country
                }
            };
            var taxTotal = new TaxTotal(new TaxSubtotal { 
                //TaxAmount = 
            });
            var ubl = new UBLInvoice
            {
                ProfileID = Enums.ProfileIDCode.P1,
                ID = invoice.InvNum,
                Issued = issuedDate,
                Dued = dueDate,
                DocumentCurrencyCode = invoice.Currency.Code,
                TaxCurrencyCode = invoice.Currency.Code,
                TaxPointDate = taxPointDate,
                InvoicePeriod = invoicePeriod,
                InvoiceTypeCode = Enums.InvoiceTypeCode.CommercialInvoice,
                AccountingSupplierParty = supplyerParty,
                AccountingCustomerParty = customerParty,
                PaymentMeans = new PaymentMeans
                {
                    PaymentMeansCode = Enums.PaymentMeansCode.BankCard,

                },
                TaxTotal = 
            };
            return Create(ubl, sendDateTime);
        }

        public RegisterEInvoiceRequest Create(UBLInvoice ublInvoice, DateTime? sendDateTime = null)
        {
            var ublInvoiceXml = UBLService.CreateXML(ublInvoice);
            return RegisterEInvoiceRequest.Create(ublInvoiceXml, sendDateTime);
        }
    }
}
