using EInvoice.Models;
using EInvoice.SOAP;
using FiscalizationService.SOAP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UblSharp;
using UblSharp.CommonAggregateComponents;
using UblSharp.CommonExtensionComponents;
using UblSharp.UnqualifiedDataTypes;
using SignatureType = UblSharp.CommonAggregateComponents.SignatureType;

namespace EInvoice.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var service = new EInvoiceService(Path.Combine(Environment.CurrentDirectory, "eltonzhuleku.p12"));
            var date = EInvoiceService.GetDateTimeNow();


            //var xmlText = Case1(date);
            var xmlText = Case2(date);


            var invoice = new RegisterEinvoiceRequest{
                Header = new RegisterEinvoiceRequestHeaderType
                {
                    SendDateTime = date,
                    UUID = "a737f2f9-214d-4841-a3d9-331e7b2b3618"
                },
                EinvoiceEnvelope = new EinvoiceEnvelopeType {
                    ItemElementName = ItemChoiceType.UblInvoice,
                    Item = EInvoiceService.EncodeTo64(xmlText),
                    
                },
                

            };
            
            var response = await service.RegisterEinvoiceAsync(invoice);
            
        }

        public static string Case1(DateTime date)
        {

            var invoiceDoc = new UblSharp.InvoiceType
            {
                ID = "20-221-1",
                IssueDate = date,
                InvoiceTypeCode = InvoiceTypeCode.CommercialInvoice,
                DocumentCurrencyCode = CurrencyCodeSType.EUR.ToString(),
                TaxCurrencyCode = CurrencyCodeSType.EUR.ToString(),
                TaxPointDate = date,
                InvoicePeriod = new List<PeriodType> {
                    new PeriodType { DescriptionCode = new List<CodeType> { InvoicePeriodCode.InvoiceIssueDate } }
                },
                DueDate = date,
                BuyerReference = "buyer-0001",
                ProjectReference = new List<ProjectReferenceType> {
                    new ProjectReferenceType { ID = "Project-0001" }
                },
                ContractDocumentReference = new List<DocumentReferenceType> {
                    new DocumentReferenceType { ID = "contract-0001" }
                },
                OrderReference = new OrderReferenceType { ID = "contract-0001" },
                ReceiptDocumentReference = new List<DocumentReferenceType> {
                    new DocumentReferenceType { ID = "receipt-0001" }
                },
                DespatchDocumentReference = new List<DocumentReferenceType> {
                    new DocumentReferenceType { ID = "delivery-0001" }
                },
                OriginatorDocumentReference = new List<DocumentReferenceType> {
                    new DocumentReferenceType { ID = "bid-0001" }
                },
                AdditionalDocumentReference = new List<DocumentReferenceType> {
                    new DocumentReferenceType {
                        ID = new IdentifierType {
                            schemeID = "AGU",
                            Value = "bid-0001"
                        },
                        DocumentTypeCode = "130"
                    }
                },
                AccountingSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
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
                    Party = new PartyType
                    {
                        PartyLegalEntity = new List<PartyLegalEntityType>
                        {
                            new PartyLegalEntityType
                            {
                                RegistrationName = "Ministry of Finance",
                                CompanyID = "07654321"
                            },
                        },
                        PartyIdentification = new List<PartyIdentificationType> {
                            new PartyIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeID = "0088",
                                    Value = "5305123456789"
                                }
                            }
                        },
                        PartyName = new List<PartyNameType>
                        {
                            new PartyNameType
                            {
                                Name = "Customs Administration"
                            }
                        },
                        PartyTaxScheme = new List<PartyTaxSchemeType>
                        {
                            new PartyTaxSchemeType
                            {
                                CompanyID = "AL11111111119",
                                TaxScheme = new TaxSchemeType {
                                    ID = "VAT"
                                }
                            }
                        }
                    }
                },
                PayeeParty = new PartyType
                {
                    PartyIdentification = new List<PartyIdentificationType>
                    {
                        new PartyIdentificationType
                        {
                            ID = "9923:11111111119"
                        }
                    },
                    PartyName = new List<PartyNameType>
                    {
                        new PartyNameType
                        {
                            Name = "Payee Company Ltd."
                        }
                    },
                    PartyLegalEntity = new List<PartyLegalEntityType>
                    {
                        new PartyLegalEntityType
                        {
                            CompanyID = "07654321"
                        }
                    }
                },
                TaxRepresentativeParty = new PartyType
                {
                    PostalAddress = new AddressType
                    {
                        StreetName = "Street 127",
                        AdditionalStreetName = "Landing 4",
                        CityName = "Tirana",
                        PostalZone = "1000",
                        CountrySubentity = "Tirana",
                        AddressLine = new List<AddressLineType> {
                            new AddressLineType
                            {
                                Line = "Street 127, Subdirectory 4"
                            }
                        },
                        Country = new CountryType
                        {
                            IdentificationCode = "AL"
                        }
                    }
                },
                Delivery = new List<DeliveryType>
                {
                    new DeliveryType
                    {
                        ActualDeliveryDate = new DateTime(2020,12,1),
                        DeliveryLocation = new LocationType
                        {
                            ID = new IdentifierType
                            {
                                schemeID = "0088",
                                Value = "53099998888745"
                            }
                        },
                        DeliveryParty = new PartyType{
                            PartyName = new List<PartyNameType>
                            {
                                new PartyNameType
                                {
                                    Name = "Delivery Company"
                                }
                            }
                        }
                    }
                },
                PaymentMeans = new List<PaymentMeansType>
                {
                    new PaymentMeansType
                    {
                        PaymentMeansCode = PaymentMeansCode.CashTransfer,
                        InstructionNote = new List<TextType>{"Payment Note"},
                        PaymentID = new List<IdentifierType>{ "AL00 12345678901" },
                        PayeeFinancialAccount = new FinancialAccountType
                        {
                            ID = "AL47212110090000000235698741",
                            Name = "ALL Account",
                            FinancialInstitutionBranch = new BranchType
                            {
                                ID = "2360000"
                            }
                        }
                    },
                },
                AllowanceCharge = new List<AllowanceChargeType>
                {
                    new AllowanceChargeType
                    {
                        ChargeIndicator = true,
                        AllowanceChargeReasonCode = "32",
                        AllowanceChargeReason = new List<TextType>{ "Delivery Charge" },
                        MultiplierFactorNumeric = 2,
                        Amount = new AmountType
                        {
                            currencyID = "ALL",
                            Value = 2.00M
                        },
                        BaseAmount = new AmountType
                        {
                            currencyID = "ALL",
                            Value = 200.00M
                        },
                        TaxCategory = new List<TaxCategoryType>
                        {
                            new TaxCategoryType
                            {
                                ID = "",
                                Percent = 13,
                                TaxScheme = new TaxSchemeType
                                {
                                    ID = "VAT"
                                }
                            }
                        }
                    }
                },
                LegalMonetaryTotal = new MonetaryTotalType
                {
                    LineExtensionAmount = new AmountType
                    {
                        currencyID = "ALL",
                        Value = 250.00M
                    },
                    TaxExclusiveAmount = new AmountType
                    {
                        currencyID = "ALL",
                        Value = 210.00M
                    },
                    TaxInclusiveAmount = new AmountType
                    {
                        currencyID = "ALL",
                        Value = 262.00M
                    },
                    AllowanceTotalAmount = new AmountType
                    {
                        currencyID = "ALL",
                        Value = 70.00M
                    },
                    ChargeTotalAmount = new AmountType
                    {
                        currencyID = "ALL",
                        Value = 30.00M
                    },
                    PrepaidAmount = new AmountType
                    {
                        currencyID = "ALL",
                        Value = 50.00M
                    },
                    PayableRoundingAmount = new AmountType
                    {
                        currencyID = "ALL",
                        Value = 0.00M
                    },
                    PayableAmount = new AmountType
                    {
                        currencyID = "ALL",
                        Value = 212.50M
                    },
                },
                InvoiceLine = new List<InvoiceLineType>
                {
                    new InvoiceLineType
                    {
                        ID = "1",
                        Note = new List<TextType>{ "Please check the correctness of delivered goods" },
                        InvoicedQuantity = new QuantityType
                        {
                            unitCode = "H87",
                            Value = 10000
                        },
                        LineExtensionAmount = new AmountType
                        {
                            currencyID = "ALL",
                            Value = 900.00M
                        },
                        AccountingCost = ">CS-024",
                        OrderLineReference = new List<OrderLineReferenceType>
                        {
                            new OrderLineReferenceType
                            {
                                LineID = "st-nar-1",
                            }
                        },
                        DocumentReference = new List<DocumentReferenceType>
                        {
                            new DocumentReferenceType
                            {
                                ID = "measuring-place-0001",
                                DocumentTypeCode = "130"
                            }
                        },
                        InvoicePeriod = new List<PeriodType>
                        {
                            new PeriodType
                            {
                                StartDate = new DateTime(2020,10,1),
                                EndDate = new DateTime(2020,10,10)
                            }
                        },
                        AllowanceCharge = new List<AllowanceChargeType>
                        {
                            new AllowanceChargeType
                            {
                                ChargeIndicator = true,
                                AllowanceChargeReasonCode = "PMI",
                                AllowanceChargeReason = new List<TextType>{ "Delivery Charge" },
                                MultiplierFactorNumeric = 10000,
                                Amount = new AmountType
                                {
                                    currencyID = "ALL",
                                    Value = 100.00M
                                },
                                BaseAmount = new AmountType
                                {
                                    currencyID = "ALL",
                                    Value = 1000.00M
                                },
                            }
                        },
                        Price = new PriceType
                        {
                            PriceAmount = new AmountType
                            {
                                currencyID = "ALL",
                                Value = 250.00M
                            },
                            BaseQuantity = new QuantityType
                            {
                                unitCode = "H87",
                                Value = 1000
                            },
                            AllowanceCharge = new List<AllowanceChargeType>
                            {
                                new AllowanceChargeType
                                {
                                    ChargeIndicator = false,
                                    Amount = new AmountType
                                    {
                                        currencyID = "ALL",
                                        Value = 10.00M
                                    },
                                    BaseAmount = new AmountType
                                    {
                                        currencyID = "ALL",
                                        Value = 260.00M
                                    },
                                }
                            }
                        },
                        Item = new ItemType
                        {
                            ClassifiedTaxCategory = new List<TaxCategoryType>
                            {
                                new TaxCategoryType
                                {
                                    ID = "",
                                    Percent = 25,
                                    TaxScheme = new TaxSchemeType
                                    {
                                        ID = "VAT"
                                    }
                                }
                            },
                            Description = new List<TextType>{"Various commodities that can be described"},
                            Name = "Goods 1",
                            BuyersItemIdentification = new ItemIdentificationType
                            {
                                ID = "art-to-1000"
                            },
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "art-p-0001"
                            },
                            StandardItemIdentification = new ItemIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeID = "0160",
                                    Value = "04012345123456"
                                }
                            },
                            OriginCountry = new CountryType
                            {
                                IdentificationCode = "AL"
                            },
                            CommodityClassification = new List<CommodityClassificationType>
                            {
                                new CommodityClassificationType
                                {
                                    ItemClassificationCode = new CodeType
                                    {
                                        listID = "STI",
                                        Value = "03111200-4"
                                    }
                                }
                            },
                            AdditionalItemProperty = new List<ItemPropertyType>
                            {
                                new ItemPropertyType
                                {
                                    Name = "Color",
                                    Value = "Red"
                                }
                            }
                        }
                    }
                },
                Signature = new List<SignatureType>
                {
                    new SignatureType
                    {
                        ID = "urn:oasis:names:specification:ubl:signature:Invoice",
                        SignatureMethod = "urn:oasis:names:specification:ubl:dsig:enveloped",
                        ValidationDate = DateTime.Now,
                        ValidationTime = DateTime.Now,
                        ValidatorID = "Validation ID",
                        CanonicalizationMethod = "http://www.w3.org/2000/09/xmldsig#dsa-sha1",
                        SignatoryParty = new PartyType
                        {
                            PartyIdentification = new List<PartyIdentificationType>()
                            {
                                new PartyIdentificationType
                                {
                                    ID = "MyParty"
                                }
                            },
                            PartyName = new List<PartyNameType>
                            {
                                new PartyNameType
                                {
                                    Name = "Singatory Party Name"
                                }
                            }
                        },
                        DigitalSignatureAttachment = new AttachmentType
                        {
                            ExternalReference = new ExternalReferenceType
                            {
                                URI = "UBL-Invoice-2.0-Detached-Signature.xml"
                            }
                        },

                    }
                },
            };



            var xml = invoiceDoc.ToXDocument();
            var xmlText = xml.ToString();
            return xmlText;
        }

        public static string Case2(DateTime date)
        {

            var invoiceDoc = new UblSharp.InvoiceType
            {
                ID = "20-221-1",
                IssueDate = date,
                InvoiceTypeCode = InvoiceTypeCode.CommercialInvoice,
                DocumentCurrencyCode = CurrencyCodeSType.EUR.ToString(),
                TaxCurrencyCode = CurrencyCodeSType.EUR.ToString(),
                TaxPointDate = date,
                PricingCurrencyCode = new CodeType
                {
                    
                },
                PaymentCurrencyCode = new CodeType { },
                PaymentAlternativeCurrencyCode = new CodeType { },
                AccountingCostCode = new CodeType { },
                AccountingCost = new TextType { },
                LineCountNumeric = new NumericType { },
                BuyerReference = new TextType { },
                InvoicePeriod = new List<PeriodType> {
                    new PeriodType {
                        DescriptionCode = new List<CodeType> { InvoicePeriodCode.InvoiceIssueDate },
                        Description = new List<TextType>{ "desc" },
                        StartDate = date.AddDays(-2),
                        StartTime = date.AddDays(-2),
                        EndDate = date.AddDays(2),
                        EndTime = date.AddDays(2),
                        DurationMeasure = new MeasureType{ 
                            unitCode = "m",
                            Value = 1M
                        }
                    } 
                },
                OrderReference = new OrderReferenceType { 
                    ID = "id"
                },
                BillingReference = new List<BillingReferenceType>
                {
                    new BillingReferenceType{
                        InvoiceDocumentReference = new DocumentReferenceType
                        {
                            ID = "id",
                            IssueDate = date,
                            IssueTime = date,
                        }
                    }
                },
                DespatchDocumentReference = new List<DocumentReferenceType>
                {
                    new DocumentReferenceType
                    {
                        ID = "id"
                    }
                },
                ReceiptDocumentReference = new List<DocumentReferenceType>
                {
                    new DocumentReferenceType
                    {
                        ID = "id"
                    }
                },
                StatementDocumentReference = new List<DocumentReferenceType>
                {
                    new DocumentReferenceType
                    {
                        ID = "id"
                    }
                },
                AdditionalDocumentReference = new List<DocumentReferenceType>
                {
                    new DocumentReferenceType
                    {
                        ID = "id"
                    }
                },
                OriginatorDocumentReference = new List<DocumentReferenceType>
                {
                    new DocumentReferenceType
                    {
                        ID = "id"
                    }
                },
                ContractDocumentReference = new List<DocumentReferenceType>
                {
                    new DocumentReferenceType
                    {
                        ID = "id"
                    }
                },
                ProjectReference = new List<ProjectReferenceType>
                {
                    new ProjectReferenceType
                    {
                        ID = "id"
                    }
                },
                Signature = new List<SignatureType>
                {
                    new SignatureType
                    {
                        ID = "id"
                    }
                },
                AccountingSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = new IdentifierType
                        {
                            schemeID = "848",
                            Value = "value"
                        }
                    }
                },
                AccountingCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = new IdentifierType
                        {
                            schemeID = "848",
                            Value = "value"
                        }
                    }
                },
                PayeeParty = new PartyType { },
                BuyerCustomerParty = new CustomerPartyType
                {

                },
                SellerSupplierParty = new SupplierPartyType { },
                TaxRepresentativeParty = new PartyType { },
                Delivery = new List<DeliveryType> { new DeliveryType { } },
                DeliveryTerms = new DeliveryTermsType { },
                PaymentMeans = new List<PaymentMeansType> { 
                    new PaymentMeansType {
                        PaymentMeansCode = "30",
                        InstructionNote =new List<TextType>{ "Payment Text" },
                        PaymentID = new List<IdentifierType>{"id" }
                    }
                },
                PaymentTerms = new List<PaymentTermsType> { new PaymentTermsType { } },
                PrepaidPayment = new List<PaymentType> { new PaymentType { } },
                AllowanceCharge = new List<AllowanceChargeType> { 
                    new AllowanceChargeType { 
                        ChargeIndicator = false,
                        AllowanceChargeReasonCode = "71",
                        AllowanceChargeReason =new List<TextType>{ "Volume Discount" },
                        MultiplierFactorNumeric = 10,
                        Amount = new AmountType
                        {
                            currencyID = "ALL",
                            Value = 200
                        },
                        BaseAmount = new AmountType
                        {
                            currencyID = "ALL",
                            Value = 200
                        },
                        TaxCategory = new List<TaxCategoryType>
                        {
                            new TaxCategoryType
                            {
                                ID ="id",
                                Percent = 25,
                                TaxScheme = new TaxSchemeType
                                {
                                    ID = "VAT"
                                }
                            }
                        }
                    } 
                },
                TaxExchangeRate = new ExchangeRateType { 
                    SourceCurrencyCode = "ALL",
                    SourceCurrencyBaseRate = 1.2M,
                    TargetCurrencyCode = "EUR"
                },
                PricingExchangeRate = new ExchangeRateType
                {
                    SourceCurrencyCode = "ALL",
                    SourceCurrencyBaseRate = 1.2M,
                    TargetCurrencyCode = "EUR"
                },
                PaymentExchangeRate = new ExchangeRateType
                {
                    SourceCurrencyCode = "ALL",
                    SourceCurrencyBaseRate = 1.2M,
                    TargetCurrencyCode = "EUR"
                },
                PaymentAlternativeExchangeRate = new ExchangeRateType
                {
                    SourceCurrencyCode = "ALL",
                    SourceCurrencyBaseRate = 1.2M,
                    TargetCurrencyCode = "EUR"
                },
                TaxTotal = new List<TaxTotalType>
                {
                    new TaxTotalType{
                        TaxAmount = new AmountType
                        {
                            currencyID = "ALL",
                            Value = 10
                        }
                    }
                },
                WithholdingTaxTotal = new List<TaxTotalType>
                {
                    new TaxTotalType{
                        TaxAmount = new AmountType
                        {
                            currencyID = "ALL",
                            Value = 10
                        }
                    }
                },
                LegalMonetaryTotal = new MonetaryTotalType
                {
                    LineExtensionAmount = new AmountType {  currencyID = "ALL", Value = 10},
                    TaxExclusiveAmount = new AmountType {  currencyID = "ALL", Value = 10},
                    TaxInclusiveAmount = new AmountType {  currencyID = "ALL", Value = 10},
                    AllowanceTotalAmount = new AmountType {  currencyID = "ALL", Value = 10},
                    ChargeTotalAmount = new AmountType {  currencyID = "ALL", Value = 10},
                    PrepaidAmount = new AmountType {  currencyID = "ALL", Value = 10},
                    PayableRoundingAmount = new AmountType {  currencyID = "ALL", Value = 10},
                    PayableAlternativeAmount = new AmountType {  currencyID = "ALL", Value = 10},
                    PayableAmount = new AmountType {  currencyID = "ALL", Value = 10},
                },
                InvoiceLine = new List<InvoiceLineType>
                {
                    new InvoiceLineType
                    {
                        ID = "1",
                        Note = new List<TextType>{"Invoice Line Note" },
                        InvoicedQuantity = new QuantityType
                        {
                            unitCode = "H87", Value = 10000
                        },
                        LineExtensionAmount = new AmountType { currencyID = "ALL", Value = 1000},
                        OrderLineReference = new List<OrderLineReferenceType>{ new OrderLineReferenceType
                        {
                            LineID = "id"
                        } },
                        DocumentReference = new List<DocumentReferenceType>
                        {
                            new DocumentReferenceType
                            {
                                ID = "id",
                                DocumentTypeCode = "130"
                            }
                        },
                        PricingReference = new PricingReferenceType{},
                        OriginatorParty = new PartyType{ },
                        Delivery = new List<DeliveryType>{ new DeliveryType { } },
                        PaymentTerms = new List<PaymentTermsType>
                        {
                            new PaymentTermsType{}
                        },
                        AllowanceCharge = new List<AllowanceChargeType>
                        {
                            new AllowanceChargeType {
                                ChargeIndicator = false,
                                AllowanceChargeReasonCode = "71",
                                AllowanceChargeReason =new List<TextType>{ "Volume Discount" },
                                MultiplierFactorNumeric = 10,
                                Amount = new AmountType
                                {
                                    currencyID = "ALL",
                                    Value = 200
                                },
                                BaseAmount = new AmountType
                                {
                                    currencyID = "ALL",
                                    Value = 200
                                },
                                TaxCategory = new List<TaxCategoryType>
                                {
                                    new TaxCategoryType
                                    {
                                        ID ="id",
                                        Percent = 25,
                                        TaxScheme = new TaxSchemeType
                                        {
                                            ID = "VAT"
                                        }
                                    }
                                }
                            }
                        },
                        TaxTotal = new List<TaxTotalType>
                        {
                            new TaxTotalType{
                                TaxAmount = new AmountType
                                {
                                    currencyID = "ALL",
                                    Value = 10
                                }
                            }
                        },
                        WithholdingTaxTotal = new List<TaxTotalType>
                        {
                            new TaxTotalType{
                                TaxAmount = new AmountType
                                {
                                    currencyID = "ALL",
                                    Value = 10
                                }
                            }
                        },
                        Item = new ItemType{}
                    }
                },
                IssueTime = date,
                Note =new List<TextType> { "note" },
                DueDate = date.AddDays(10),
                UUID = Guid.NewGuid().ToString(),
                
            };


           
            var xml = invoiceDoc.ToXDocument();
            var xmlText = xml.ToString();
            return xmlText;
        }
    }
}
