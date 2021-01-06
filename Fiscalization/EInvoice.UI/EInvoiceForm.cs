using EInvoice.SOAP;
using Fiscalization;
using FiscalizationService.SOAP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using UblSharp;
using UblSharp.CommonAggregateComponents;
using UblSharp.CommonExtensionComponents;
using UblSharp.UnqualifiedDataTypes;
using CountryCodeSType = FiscalizationService.SOAP.CountryCodeSType;
using Fiscalization.Requests;
using RegisterInvoiceRequest = Fiscalization.Requests.RegisterInvoiceRequest;
using Fiscalization.Enums;
using Fiscalization.Models;
using EInvoice.Requests;
using EInvoice.Models.UBL;

namespace EInvoice.UI
{
    public partial class EInvoiceForm : Form
    {
        public static string CERT = "eltonzhuleku.p12";
        //public static string CERT = "cimi.p12";
        EInvoiceServiceFactory _factory = new EInvoiceServiceFactory(Path.Combine(Environment.CurrentDirectory, CERT));
        FiscalizationFactory _fisFactory = new FiscalizationFactory(Path.Combine(Environment.CurrentDirectory, CERT));
        public EInvoiceForm()
        {
            InitializeComponent();

            CreateEInvoice.Click += CreateEInvoice_Click;
        }

        void CreateEInvoice_Click(object? sender, EventArgs e)
        {
            CreateEInvoice1();
        }



        public async void CreateEInvoice1()
        {
            //EInvoiceService service = _factory.GetEInvoiceService(); //new EInvoiceService(Path.Combine(Environment.CurrentDirectory, "eltonzhuleku.p12"),null) ;
            var date = EInvoiceService.GetDateTimeNow();



            //var xmlText = Case1(date);
            var xmlText = await Case2(date);
            //var xmlText = await Case3(date);



            var invoice = new RegisterEinvoiceRequest
            {
                Header = new RegisterEinvoiceRequestHeaderType
                {
                    SendDateTime = date,
                    UUID = Guid.NewGuid().ToString()
                },
                EinvoiceEnvelope = new EinvoiceEnvelopeType
                {
                    ItemElementName = ItemChoiceType.UblInvoice,
                    Item = EInvoiceService.EncodeTo64(xmlText),

                },


            };

            //var response = await service.RegisterEinvoiceAsync(invoice);
            //var json = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
            //WriteLine(json);
        }

        void WriteLine(string line)
        {
            Output.AppendText(line);
        }


        public async Task<string> Case2(DateTime date)
        {
            //var fic = "6da777be-ae85-45c1-afe7-14e13223f1eb";
            //var invoice = new InvoiceType
            //{
            //   IssueDateTime = date,
            //   IIC = "E51B0C0BDA3E8193B3A0130760E822A6",
            //   IICSignature = FiscalizationSigner.SignIICSignature("E51B0C0BDA3E8193B3A0130760E822A6"),
            //   InvNum = "1/2020/cc123cc123",
            //   SoftCode = "zz463gy579",
            //   BusinUnitCode = "bb123bb123",
            //   OperatorCode = "au254tb295"

            //};

            var client = new FiscalizationServicePortTypeClient();
            var endpointBh = new XMLSignerEndpointBehavior();
            client.Endpoint.EndpointBehaviors.Add(endpointBh);

            var now = DateTime.Now;
            date = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second, DateTimeKind.Local);


            var selleNUIS = "L41316032F";
            var buyerNUIS = "L82118024B";
            //var selleNUIS = "L82118024B";
            //var buyerNUIS = "L41316032F";
            //var rInvoice = new RegisterInvoiceRequest
            //{
            //    //Id = "id10",
            //    //Version = 1,

            //    Header = new RegisterInvoiceRequestHeaderType
            //    {
            //        UUID = Guid.NewGuid().ToString(),
            //        SendDateTime = date,
            //        SubseqDelivType = SubseqDelivTypeSType.SERVICE,
            //        SubseqDelivTypeSpecified = false,

            //    },
            //    Invoice = new InvoiceType
            //    {

            //        IsIssuerInVAT = true,
            //        //IIC = FiscalizationSigner.GenerateIIC("I12345678I"),
            //        //IICSignature = FiscalizationSigner.SignIICSignature("I12345678I"),
            //        PayMethods = new PayMethodType[]
            //        {
            //            new PayMethodType
            //            {
            //                Amt = 20.00M,
            //                Type = PaymentMethodTypeSType.TRANSFER
            //            }
            //        },


            //        TypeOfInv = InvoiceSType.NONCASH,
            //        BusinUnitCode = "wo765uk675",
            //        Currency = new CurrencyType
            //        {
            //            Code = CurrencyCodeSType.EUR,
            //            ExRate = 1.0,
            //            IsBuying = true
            //        },
            //        InvNum = $"111/{date.Year}",
            //        InvOrdNum = 111,
            //        IssueDateTime = date,
            //        Items = new InvoiceItemType[]{
            //            new InvoiceItemType
            //            {
            //               C = "501234567890",
            //               PA = 20.00M,
            //               PB = 20.00M,
            //               Q = 1.0,
            //               R = 0,
            //               RR = true,
            //               UPB = 20.00M,
            //               UPA = 20.00M,
            //               VA = 4.00M,
            //               VR = 25.00M,
            //               EXSpecified = false,
            //               INSpecified = false,
            //               N = "Item name",
            //               U = "pieces",
            //               EX = ExemptFromVATSType.TAX_FREE
            //            }
            //        },
            //        OperatorCode = "au254tb295",
            //        PayDeadlineSpecified = false,
            //        Seller = new SellerType
            //        {
            //            Address = "seller address",
            //            Country = CountryCodeSType.ALB,
            //            CountrySpecified = true,
            //            IDNum = selleNUIS,
            //            IDType = IDTypeSType.NUIS,
            //            Name = "Seller name",
            //            Town = "seller town",


            //        },
            //        SoftCode = "eq535yw328",
            //        TCRCode = "dt947iw604",
            //        TotPrice = 20.00M,
            //        //TotVATAmtSpecified = false,
            //        //TotPriceWoVAT = 16.00M,
            //        //TotVATAmt = 4,

            //    },
            //};
            //string iicInput = CreateIICInput(rInvoice.Invoice);

            //rInvoice.Invoice.IIC = FiscalizationSigner.GenerateIIC(iicInput);
            //rInvoice.Invoice.IICSignature = FiscalizationSigner.SignIICSignature(iicInput);


            //var response =  (await client.registerInvoiceAsync(rInvoice)).RegisterInvoiceResponse;

            //var verifyUrl = GenerateVerifyURL(rInvoice);

            //rInvoice.Invoice.IIC = "FFDE6E2A81E2274402E6F9D85B45A188";
            //response.FIC = "57b95dab-fdc9-407d-821b-5a64839f4cd9";




            XmlSerializer xsSubmit = new XmlSerializer(typeof(ExtensionContent));

            var contentExt = new ExtensionContent
            {
                UBLDocumentSignatures = new UBLDocumentSignatures
                {
                    SignatureInformation = new SignatureInformation
                    {

                    }
                }
            };
            XmlDocument xmlDocExt = new XmlDocument();
            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, contentExt);

                    var xmlExt = sww.ToString();

                    xmlDocExt.LoadXml(xmlExt);
                }
            }

            var taxCategory = new List<TaxCategoryType>
                        {
                            new TaxCategoryType
                            {
                                ID = "E",
                                Percent = 0,
                                TaxScheme = new TaxSchemeType
                                {
                                    ID = "VAT"
                                },
                                TierRange = "",
                                TierRatePercent = 10,
                                TaxExemptionReason = new List<TextType> {"Tax Exemption Reason"}

                            }
                        };


            var invoiceDoc = new UblSharp.InvoiceType
            {
                CustomizationID = "urn:cen.eu:en16931:2017",
                ProfileID = "P1",
                //ID = rInvoice.Invoice.InvNum,
                IssueDate = date.ToString("yyyy-MM-dd"),
                DueDate = date.ToString("yyyy-MM-dd"),
                //InvoiceTypeCode = InvoiceTypeCode.CommercialInvoice,
                DocumentCurrencyCode = "ALL",
                TaxCurrencyCode = "ALL",
                TaxPointDate = date,
                InvoicePeriod = new List<PeriodType> {
                    new PeriodType
                    {
                       StartDate = date.ToString("yyyy-MM-dd")
                    }
                },
                InvoiceTypeCode = new CodeType
                {
                    //Value = Enums.InvoiceTypeCode.CommercialInvoice
                },
                //PricingCurrencyCode = new CodeType { },
                //PaymentCurrencyCode = new CodeType { },
                //PaymentAlternativeCurrencyCode = new CodeType { },
                //AccountingCostCode = new CodeType { },
                //AccountingCost = new TextType { },
                //LineCountNumeric = new NumericType { },
                //BuyerReference = new TextType { },
                //InvoicePeriod = new List<PeriodType> {
                //    new PeriodType {
                //        DescriptionCode = new List<CodeType> { InvoicePeriodCode.InvoiceIssueDate },
                //        Description = new List<TextType> { "desc" },
                //        StartDate = date.AddDays(-2),
                //        StartTime = date.AddDays(-2),
                //        EndDate = date.AddDays(2),
                //        EndTime = date.AddDays(2),
                //        DurationMeasure = new MeasureType {
                //            unitCode = "m",
                //            Value = 1M
                //        }
                //    }
                //},
                //OrderReference = new OrderReferenceType {ID = "id"},
                BillingReference = new List<BillingReferenceType>
                {
                    new BillingReferenceType {
                        InvoiceDocumentReference = new DocumentReferenceType
                        {
                            ID = "id",
                            IssueDate = date,
                            IssueTime = date,
                        }
                    }
                },
                //DespatchDocumentReference = new List<DocumentReferenceType>
                //{
                //    new DocumentReferenceType
                //    {
                //        ID = "id"
                //    }
                //},
                //ReceiptDocumentReference = new List<DocumentReferenceType>
                //{
                //    new DocumentReferenceType
                //    {
                //        ID = "id"
                //    }
                //},
                //StatementDocumentReference = new List<DocumentReferenceType>
                //{
                //    new DocumentReferenceType
                //    {
                //        ID = "id"
                //    }
                //},
                AdditionalDocumentReference = new List<DocumentReferenceType>
                {
                    new DocumentReferenceType
                    {
                        ID = "id"
                    }
                },
                //OriginatorDocumentReference = new List<DocumentReferenceType>
                //{
                //    new DocumentReferenceType
                //    {
                //        ID = "id"
                //    }
                //},
                //ContractDocumentReference = new List<DocumentReferenceType>
                //{
                //    new DocumentReferenceType
                //    {
                //        ID = "id"
                //    }
                //},
                //ProjectReference = new List<ProjectReferenceType>
                //{
                //    new ProjectReferenceType
                //    {
                //        ID = "id"
                //    }
                //},
                AccountingSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        PartyName = new List<PartyNameType>
                        {
                            //new PartyNameType { Name = rInvoice.Invoice.Seller.Name}
                        },
                        PartyIdentification = new List<PartyIdentificationType>
                        {
                            new PartyIdentificationType
                            {
                                ID = "9923:" + selleNUIS,

                            }
                        },
                        EndpointID = new IdentifierType
                        {
                            schemeID = "9923",
                            Value = selleNUIS
                        },
                        PartyLegalEntity = new List<PartyLegalEntityType>
                        {
                            new PartyLegalEntityType
                            {
                               RegistrationName = "Company Ltd.",
                               CompanyID = "AL"+ selleNUIS,
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Street 127",
                            AdditionalStreetName = "Street name aditional",
                            CityName = "Tirana",
                            PostalZone = "10001",
                            CountrySubentity = "Tirana",
                            AddressLine = new List<AddressLineType> { new AddressLineType
                           {
                                Line = "Street 127, Tirana"
                           } },
                            Country = new CountryType
                            {
                                IdentificationCode = "AL"
                            }
                        },
                        PartyTaxScheme = new List<PartyTaxSchemeType>
                        {
                            new PartyTaxSchemeType
                            {
                                CompanyID = "AL"+ selleNUIS,
                                TaxScheme = new TaxSchemeType
                                {
                                    ID = "VAT"
                                },
                            }
                        },

                    }
                },
                AccountingCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        PartyName = new List<PartyNameType>
                        {
                            new PartyNameType { Name = "name"}
                        },
                        EndpointID = new IdentifierType
                        {
                            schemeID = "9923",
                            Value = buyerNUIS
                        },

                        PartyLegalEntity = new List<PartyLegalEntityType>
                        {
                            new PartyLegalEntityType
                            {
                               RegistrationName = "Buyer party name",
                               CompanyID = "AL"+ buyerNUIS,
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Street 127",
                            AdditionalStreetName = "Street name aditional",
                            CityName = "Tirana",
                            PostalZone = "10001",
                            CountrySubentity = "Tirana",
                            AddressLine = new List<AddressLineType> { new AddressLineType
                           {
                                Line = "Street 127, Tirana"
                           } },
                            Country = new CountryType
                            {
                                IdentificationCode = "AL"
                            }
                        },
                        PartyTaxScheme = new List<PartyTaxSchemeType>
                        {
                            new PartyTaxSchemeType
                            {
                                CompanyID = "AL"+ buyerNUIS,
                                TaxScheme = new TaxSchemeType
                                {
                                    ID = "VAT"
                                },
                            }
                        }
                    }
                },
                //PayeeParty = new PartyType
                //{
                //    PartyIdentification = new List<PartyIdentificationType>
                //    {
                //        new PartyIdentificationType
                //        {
                //            ID = "9923:11111111119"
                //        }
                //    },
                //    PartyName = new List<PartyNameType>
                //    {
                //        new PartyNameType
                //        {
                //            Name = "Payee Company Ltd."
                //        }
                //    },
                //    PartyLegalEntity = new List<PartyLegalEntityType>
                //    {
                //        new PartyLegalEntityType { CompanyID = "7654321"}
                //    }
                //},
                //BuyerCustomerParty = new CustomerPartyType{},
                //SellerSupplierParty = new SupplierPartyType {
                //    Party = new PartyType
                //    {

                //    }
                //},
                TaxRepresentativeParty = new PartyType
                {

                    PartyName = new List<PartyNameType>
                    {
                        new PartyNameType
                        {
                            Name = "Tax Representative Ltd."
                        }
                    },
                    PostalAddress = new AddressType
                    {
                        StreetName = "Street 127",
                        AdditionalStreetName = "Street name aditional",
                        CityName = "Tirana",
                        PostalZone = "10001",
                        CountrySubentity = "Tirana",
                        AddressLine = new List<AddressLineType> { new AddressLineType
                           {
                                Line = "Street 127, Tirana"
                           } },
                        Country = new CountryType
                        {
                            IdentificationCode = "AL"
                        }
                    },
                    PartyTaxScheme = new List<PartyTaxSchemeType>
                    {
                        new PartyTaxSchemeType
                        {
                            CompanyID = new IdentifierType{ Value = "AL11111111119" },
                            TaxScheme = new TaxSchemeType
                            {
                                ID = "VAT",
                            }
                        }
                    }
                },
                //Delivery = new List<DeliveryType> { new DeliveryType { } },
                //DeliveryTerms = new DeliveryTermsType { },
                PaymentMeans = new List<PaymentMeansType> {
                    new PaymentMeansType {
                        PaymentMeansCode = "30",
                        InstructionNote = new List<TextType> { "Payment Text" },
                        PaymentID = new List<IdentifierType> { "id" },
                        PayeeFinancialAccount = new FinancialAccountType
                        {
                            ID = "AL47212110090000000235698741",
                            Name = "ALL Acount",
                            FinancialInstitutionBranch = new BranchType
                            {
                                ID = "2360000"
                            }
                        }
                    }
                },
                //PaymentTerms = new List<PaymentTermsType> { new PaymentTermsType { } },
                //PrepaidPayment = new List<PaymentType> { new PaymentType { } },
                //AllowanceCharge = new List<AllowanceChargeType> {
                //    new AllowanceChargeType {
                //        ChargeIndicator = true,
                //        AllowanceChargeReasonCode = "TAC",
                //        AllowanceChargeReason = new List<TextType> { "Volume Discount" },
                //        MultiplierFactorNumeric = 1,
                //        Amount = new AmountType
                //        {
                //            currencyID = "ALL",
                //            Value = 0
                //        },
                //        BaseAmount = new AmountType
                //        {
                //            currencyID = "ALL",
                //            Value = 0
                //        },
                //        TaxCategory = taxCategory
                //    }
                //},
                //TaxExchangeRate = new ExchangeRateType {
                //    SourceCurrencyCode = "ALL",
                //    SourceCurrencyBaseRate = 1.2M,
                //    TargetCurrencyCode = "EUR"
                //},
                //PricingExchangeRate = new ExchangeRateType
                //{
                //    SourceCurrencyCode = "ALL",
                //    SourceCurrencyBaseRate = 1.2M,
                //    TargetCurrencyCode = "EUR"
                //},
                //PaymentExchangeRate = new ExchangeRateType
                //{
                //    SourceCurrencyCode = "ALL",
                //    SourceCurrencyBaseRate = 1.2M,
                //    TargetCurrencyCode = "EUR"
                //},
                //PaymentAlternativeExchangeRate = new ExchangeRateType
                //{
                //    SourceCurrencyCode = "ALL",
                //    SourceCurrencyBaseRate = 1.2M,
                //    TargetCurrencyCode = "EUR"
                //},
                TaxTotal = new List<TaxTotalType>
                {
                    new TaxTotalType {
                        TaxAmount = new AmountType
                        {
                            currencyID = "ALL",
                            Value = 0
                        },
                        TaxSubtotal = new List<TaxSubtotalType>
                        {
                            new TaxSubtotalType
                            {
                                TaxableAmount = new AmountType{
                                    currencyID = "ALL",
                                    Value = 10
                                },
                                TaxAmount = new AmountType{
                                    currencyID = "ALL",
                                    Value = 0
                                },
                                TaxCategory = taxCategory.First()

                            }
                        }
                    },
                    new TaxTotalType {
                        TaxAmount = new AmountType
                        {
                            currencyID = "EUR",
                            Value = 10
                        }
                    }
                },
                LegalMonetaryTotal = new MonetaryTotalType
                {
                    LineExtensionAmount = new AmountType { currencyID = "ALL", Value = 10 },
                    TaxExclusiveAmount = new AmountType { currencyID = "ALL", Value = 10 },
                    TaxInclusiveAmount = new AmountType { currencyID = "ALL", Value = 10 },
                    PayableAmount = new AmountType { currencyID = "ALL", Value = 10 },
                },
                InvoiceLine = new List<InvoiceLineType>
                {
                    new InvoiceLineType
                    {
                        ID = "1",
                        Note = new List<TextType> { "Invoice Line Note" },
                        InvoicedQuantity = new QuantityType
                        {
                            unitCode = "H87", Value = 10000
                        },
                        LineExtensionAmount = new AmountType { currencyID = "ALL", Value = 10 },
                        OrderLineReference = new List<OrderLineReferenceType> { new OrderLineReferenceType
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
                        PricingReference = new PricingReferenceType { },
                        OriginatorParty = new PartyType { },
                        Delivery = new List<DeliveryType> { new DeliveryType { } },
                        PaymentTerms = new List<PaymentTermsType>
                        {
                            new PaymentTermsType { }
                        },
                        AllowanceCharge = new List<AllowanceChargeType>
                        {
                            new AllowanceChargeType {
                                ChargeIndicator = true,
                                AllowanceChargeReasonCode = "TAC",
                                AllowanceChargeReason = new List<TextType> { "Volume Discount" },
                                MultiplierFactorNumeric = 10,
                                Amount = new AmountType
                                {
                                    currencyID = "ALL",
                                    Value = 0
                                },
                                BaseAmount = new AmountType
                                {
                                    currencyID = "ALL",
                                    Value = 0
                                },
                                TaxCategory = taxCategory
                            }
                        },
                        TaxTotal = new List<TaxTotalType>
                        {
                            new TaxTotalType {
                                TaxAmount = new AmountType
                                {
                                    currencyID = "ALL",
                                    Value = 0
                                }
                            }
                        },
                        WithholdingTaxTotal = new List<TaxTotalType>
                        {
                            new TaxTotalType {
                                TaxAmount = new AmountType
                                {
                                    currencyID = "ALL",
                                    Value = 0
                                }
                            }
                        },
                        Item = new ItemType {
                            Name = "Goods 1",
                            ClassifiedTaxCategory = new List<TaxCategoryType>
                            {
                                new TaxCategoryType
                                {
                                    ID = "E",
                                    Percent = 0,
                                    TaxScheme = new TaxSchemeType
                                    {
                                        ID = "VAT",

                                    },
                                    TaxExemptionReason = new List<TextType> {"Tax Exemption Reason"}
                                }
                            }
                        },
                        Price = new PriceType
                        {
                            PriceAmount = new AmountType
                                {
                                    currencyID = "ALL",
                                    Value = 10
                                }
                        }
                    }
                },
                //IssueTime = date,
                //Note = createNoteTypes(date, rInvoice.Invoice, response.FIC),

                //UUID = Guid.NewGuid().ToString(),
                UBLExtensions = new List<UBLExtensionType>
                {
                    new UBLExtensionType
                    {
                        ExtensionContent = (XmlElement)xmlDocExt.GetElementsByTagName("SignatureInformation").Item(0)
                    }
                },
 

            };





            var xml = invoiceDoc.ToXDocument();
            var xmlText = xml.ToString();
            //xmlText = File.ReadAllText("C:/Repo/FiscalizationProject/Fiscalization/EInvoice.Console/bin/Debug/netcoreapp3.1/ubl.xml");
            var signedxml = createSignature(xmlText);
            return signedxml;
        }


        static private string createSignature(string xmlEInvoice)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlEInvoice);

            string myfile = "cert";
            string certPass = "123456";//db.Certificate.Select(c => c.certPass).FirstOrDefault().ToString();
            string certPath = Path.Combine(Environment.CurrentDirectory, CERT); //Path.Combine(System.Web.HttpContext.Current.Server.MapPath("/Certificate/"), myfile);

            X509Certificate2Collection collection = new X509Certificate2Collection();
            collection.Import(certPath, certPass, X509KeyStorageFlags.PersistKeySet);

            XmlElement xmlDocChild = (XmlElement)xmlDoc.GetElementsByTagName("SignatureInformation")[0];


            RSA privateKey = collection[0].GetRSAPrivateKey();

            Reference reference = new Reference();
            XmlDsigExcC14NTransform innerTransform = new XmlDsigExcC14NTransform(false);
            reference.AddTransform(new XmlDsigEnvelopedSignatureTransform(false));
            reference.AddTransform(innerTransform);
            reference.Uri = "";
            reference.DigestMethod = "http://www.w3.org/2000/09/xmldsig#sha1";

            // create key info element
            KeyInfo keyInfo = new KeyInfo();
            keyInfo.AddClause(new KeyInfoX509Data(collection[0]));

            // Create a SignedXml object.
            SignedXml signedXml = new SignedXml(xmlDoc);
            signedXml.SigningKey = privateKey;
            signedXml.SignedInfo.CanonicalizationMethod = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
            signedXml.SignedInfo.SignatureMethod = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
            signedXml.SignedInfo.AddReference(reference);
            signedXml.KeyInfo = keyInfo;
            signedXml.ComputeSignature();

            // Get the XML representation of the signature and save
            // it to an XmlElement object.
            XmlElement xmlDigitalSignature = signedXml.GetXml();

            xmlDocChild.AppendChild(xmlDoc.ImportNode(xmlDigitalSignature, true));

            using (var stringWriter = new StringWriter())
            using (var xmlTextWriter = XmlWriter.Create(stringWriter))
            {
                xmlDoc.WriteTo(xmlTextWriter);
                xmlTextWriter.Flush();
                return stringWriter.GetStringBuilder().ToString();
            }

        }

        //private static List<TextType> createNoteTypes(DateTime date, InvoiceType invoice, string fic)
        //{

        //    List<TextType> noteTypes = new List<TextType>
        //    {
        //        new TextType
        //        {
        //            Value = "IssueDateTime=" + date.ToString("yyyy-MM-ddTHH:mm:ssK", CultureInfo.InvariantCulture) + "#AAI#"
        //        },
        //        new TextType
        //        {
        //            Value = "OperatorCode=" + invoice.OperatorCode + "#AAI#"
        //        },
        //        new TextType
        //        {
        //            Value = "BusinessUnitCode=" + invoice.BusinUnitCode + "#AAI#"
        //        },
        //        new TextType
        //        {
        //            Value = "SoftwareCode=" + invoice.SoftCode + "#AAI#"
        //        },
        //        new TextType
        //        {
        //            Value = "IsBadDebtInv=false#AAI#"
        //        },
        //        new TextType
        //        {
        //            Value = "IIC=" + invoice.IIC + "#AAI#"
        //        },
        //        new TextType
        //        {
        //            Value = "FIC=" + fic + "#AAI#"
        //        },
        //        new TextType
        //        {
        //            Value = "IICSignature=" + invoice.IICSignature + "#AAI#"
        //        },
        //    };

        //    return noteTypes;
        //}

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

        [XmlRoot(ElementName = "ExtensionContent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        [Serializable()]
        public class ExtensionContent
        {
            [XmlElement(ElementName = "UBLDocumentSignatures", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonSignatureComponents-2")]
            public UBLDocumentSignatures UBLDocumentSignatures { get; set; }

            [XmlElement(ElementName = "any_element", Namespace = "otherNS")]
            public Any_element Any_element { get; set; }
        }

        [XmlRoot(ElementName = "UBLDocumentSignatures", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonSignatureComponents-2")]
        [Serializable()]
        public class UBLDocumentSignatures
        {
            [XmlElement(ElementName = "SignatureInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2")]
            public SignatureInformation SignatureInformation { get; set; }
        }

        [XmlRoot(ElementName = "SignatureInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2")]
        [Serializable()]
        public class SignatureInformation
        {
            [XmlElement(ElementName = "any_element", Namespace = "otherNS")]
            public Any_element Any_element { get; set; }

            [XmlText]
            public string Text { get; set; }

            [XmlAttribute(AttributeName = "xmlns")]
            public string Xmlns { get; set; }

        }

        [XmlRoot(ElementName = "any_element", Namespace = "otherNS")]
        [Serializable()]
        public class Any_element
        {
            [XmlAttribute(AttributeName = "xmlns")]
            public string Xmlns { get; set; }
            [XmlText]
            public string Text { get; set; }
        }


        public static string GetDatetimeISO8601(DateTime date)
        {
            return date.ToString("yyyy-MM-ddTHH:mm:ssK", CultureInfo.InvariantCulture);
            //2019-01-24T22:00:58+01:00
            //2019-01-24T22:00:58-01:00
            //2020-04-24T23:15:51+02:00
        }

        //public static string CreateIICInput(InvoiceType invoice)
        //{
        //    // Issuer NUIS(Chapter 3.7.1.51)
        //    // Date and time created(Chapter 3.7.1.8)
        //    // Invoice number(Chapter 3.7.1.10)
        //    // Business unit code(Chapter 3.7.1.21)
        //    // TCR code(Chapter 3.7.1.12)
        //    // Software code(Chapter 3.7.1.22)86 | 118
        //    // Total price(Chapter 3.7.1.19)

        //    if (invoice.InvNum is null || invoice.Seller is null)
        //        return null;

        //    // Issuer NUIS
        //    string iicInput = invoice.Seller.IDNum;

        //    // dateTimeCreated
        //    iicInput += "|" + GetDatetimeISO8601(invoice.IssueDateTime);

        //    // invoiceNumber
        //    iicInput += "|" + Regex.Match(invoice.InvNum, @"\A([0-9]{0,10})", RegexOptions.Singleline).Value;

        //    // busiUnitCode
        //    iicInput += "|" + invoice.BusinUnitCode;

        //    // tcrCode
        //    iicInput += "|" + invoice.TCRCode;

        //    // softCode
        //    iicInput += "|" + invoice.SoftCode;

        //    // totalPrice
        //    iicInput += "|" + invoice.TotPrice;

        //    return iicInput;
        //}

        private void SelectCertificateButton_Click(object sender, EventArgs e)
        {

            var result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                var path = openFileDialog1.FileName;
                using var cert = new X509Certificate2(path, "123456");
                SellerNameValue.Text = cert.SubjectName.Name;
                var subject = ParseSuject(cert);
                SellerNameValue.Text = subject.Name;
                SellerNuisValue.Text = subject.NUIS;
                //CountryCodeBox.Text = subject.Country;
                SellerTownValue.Text = subject.Town;
            }
            
        }

        private static CertSubject ParseSuject(X509Certificate2 cert)
        {
            var dict = cert.SubjectName.Name.Split(',')
                .ToDictionary(kv => kv.Split('=')[0].Trim(),
                kv => kv.Split('=')[1],
                StringComparer.InvariantCultureIgnoreCase);


            var subject = new CertSubject
            {
                NUIS = dict["SN"],
                Name = dict["O"],
                Town = dict["L"],
                Country = dict["C"],
            };

            return subject;
        }

        public class CertSubject
        {
            public string NUIS { get; init; }
            public string Name { get; init; }
            public string Town { get; init; }
            public string Country { get; init; }
            public string Address { get; init; }

        }

        Invoice _invoice;
        private async void RegisterInvoiceButton_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now;
            var fisService=_fisFactory.GetFiscaliztionService();
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
                    Type = PaymentMethodType.TRANSFER,
                    Amt = items.Sum(i => i.PA)
                }
            };
            _invoice = Invoice.CreateInvoice(seller, date, Fiscalization.Enums.InvoiceType.NONCASH, "wo765uk675", "dt947iw604", "eq535yw328", "au254tb295",
                100, items, payMethods, true);
            _invoice.Buyer = new Buyer
            {
               IDNum = "L82118024B",
                Address = "Tiran Albania",
               IDType = IDType.NUIS,
               Name = "CIMI",
               Country = CountryCode.ALB
            };
            _invoice.Currency = new Currency { 
                Code = CurrencyCode.ALL,
                ExRate = 1
            };
            var req = RegisterInvoiceRequest.CreateRegisterInvoiceRequest(date, SubsequentDeliveryType.SERVICE, _invoice);
            var res = await fisService.RegisterInvoiceAsync(req);
            FIC = res.FIC;
        }
        string FIC;
        private async void RegisterEInvoiceBtn_Click(object sender, EventArgs e)
        {
            var service = _factory.EInvoiceService;
            var eInvoiceFac = _factory.EInvoiceFactory;



            var date = DateTime.Now;

            var req = eInvoiceFac.EInviceP1(_invoice, date, date, date, FIC);

            var res = await service.RegisterEinvoiceAsync(req);
            
        }
    }
}

