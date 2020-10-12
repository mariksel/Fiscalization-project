using EInvoice.Models;
using EInvoice.SOAP;
using FiscalizationService.SOAP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UblSharp;
using UblSharp.CommonAggregateComponents;
using UblSharp.UnqualifiedDataTypes;

namespace EInvoice.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var date = EInvoiceService.GetDateTimeNow();

            var invoiceDoc = new UblSharp.InvoiceType
            {
                ID = "20-221-1",
                IssueDate = date,
                InvoiceTypeCode = InvoiceTypeCode.CommercialInvoice,
                DocumentCurrencyCode = CurrencyCodeSType.EUR.ToString(),
                TaxCurrencyCode = CurrencyCodeSType.EUR.ToString(),
                TaxPointDate = date,
                InvoicePeriod = new List<PeriodType>{
                    new PeriodType { DescriptionCode = new List<CodeType> { InvoicePeriodCode.InvoiceIssueDate } }
                },
                DueDate = date,
                BuyerReference = "buyer-0001",
                ProjectReference = new List<ProjectReferenceType>{
                    new ProjectReferenceType { ID = "Project-0001" }
                },
                ContractDocumentReference = new List<DocumentReferenceType>{
                    new DocumentReferenceType { ID = "contract-0001" }
                },
                OrderReference = new  OrderReferenceType { ID = "contract-0001" },
                ReceiptDocumentReference = new List<DocumentReferenceType>{
                    new DocumentReferenceType { ID = "receipt-0001" }
                },
                DespatchDocumentReference = new List<DocumentReferenceType>{
                    new DocumentReferenceType { ID = "delivery-0001" }
                },
                OriginatorDocumentReference = new List<DocumentReferenceType>{
                    new DocumentReferenceType { ID = "bid-0001" }
                },
                AdditionalDocumentReference = new List<DocumentReferenceType>{
                    new DocumentReferenceType {
                            ID = new IdentifierType{
                                schemeID ="AGU",
                                Value = "bid-0001"
                            },
                            DocumentTypeCode = "130"
                        }
                },
                AccountingSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType{
                        PartyLegalEntity = new List<PartyLegalEntityType>
                        {
                            new PartyLegalEntityType
                            {
                                RegistrationName = "Company Ltd.",
                                CompanyID = "012345678",
                                CompanyLegalForm = "Company Ltd. established at the Commercial Court in Tirana, share capital of 20,000.00 ALL, Director Behar Shehu",
                            },
                        },
                        PartyName = new List<PartyNameType>
                        {
                            new PartyNameType
                            {
                                Name = "Brand Company"
                            }
                        },
                        PartyIdentification = new List<PartyIdentificationType>
                        {
                            new PartyIdentificationType
                            {
                                ID = "9923:12345678901 ::Al99:12345"
                            }
                        }
                    }
                },
                AccountingCustomerParty = new CustomerPartyType
                {

                }
            };
           
            //var dcm = new EInvoiceDocument
            //{
            //    //ID = "1",
            //    Note = "Invoice Note",
            //    InvoiceTypeCode = InvoiceTypeCode.CommercialInvoice,
            //    IssueDate = date,
            //    DocumentCurrencyCode = CurrencyCodeSType.EUR.ToString(),
            //    TaxCurrencyCode = CurrencyCodeSType.EUR.ToString(),
            //    TaxPointDate = date,
            //    InvoicePeriod = new PeriodType { DescriptionCode = new List<CodeType> { InvoicePeriodCode.InvoiceIssueDate } },
            //    DueDate = date,
            //    BuyerReference = "buyer-0001",
            //    ProjectReference = new ProjectReferenceType { ID = "Project-0001" },
            //    //ContractDocumentReference = new ContractReference { ID = "contract-0001" },
            //    OrderFormReference = new OrderFormReference { ID = "Order-0001" },
            //    SaleOrderReference = new SaleOrderReference { SalesOrderID = "sales-order-0001" },
            //    ReceiptDocumentReference = new ReceiptDocumentReference { ID = "receipt-0001" },
            //    DespatchDocumentReference = new DespatchDocumentReference { ID = "delivery-0001" },
                
            //};
            var xml = invoiceDoc.ToXDocument();
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
