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
            UBLService = uBLService;
        }

        /// <summary> Invoicing the supply of goods and services ordered on a contract basis </summary>
        public RegisterEInvoiceRequest EInviceP1(Invoice invoice, DateTime issuedDate, DateTime dueDate, DateTime taxPointDate,
             string FIC, DateTime? sendDateTime = null)
        {
            var supplyerParty = new AccountingSupplierParty(invoice.Seller)
            {
            };

            var customerParty = new AccountingCustomerParty(invoice.Buyer);
 

            var ubl = new UBLInvoice(invoice, FIC)
            {
                ProfileID = Enums.ProfileIDCode.P1,
                ID = invoice.InvNum,
                Issued = issuedDate,
                Dued = dueDate,
                DocumentCurrencyCode = invoice.Currency.Code,
                TaxCurrencyCode = invoice.Currency.Code,
                TaxPointDate = taxPointDate,
                //InvoicePeriod = new InvoicePeriod { StartDate = taxPointDate.Date },
                InvoiceTypeCode = Enums.InvoiceTypeCode.CommercialInvoice,
                AccountingSupplierParty = supplyerParty,
                AccountingCustomerParty = customerParty,
                PaymentMeans = new PaymentMeans
                {
                    PaymentMeansCode = Enums.PaymentMeansCode.BankCard,

                },
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
