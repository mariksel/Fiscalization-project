using EInvoice.SOAP;
using Fiscalization;
using FiscalizationService.SOAP;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using UblSharp;
using UblSharp.CommonAggregateComponents;
using UblSharp.CommonExtensionComponents;
using UblSharp.UnqualifiedDataTypes;
using CountryCodeSType = FiscalizationService.SOAP.CountryCodeSType;
using InvoiceType = FiscalizationService.SOAP.InvoiceType;
using _con = Colorful.Console;

using SignatureType = UblSharp.CommonAggregateComponents.SignatureType;
using Newtonsoft.Json;
using System.Diagnostics;
using EInvoice.Models;
using EnumsNET;
using System.Drawing;
using EInvoice.Requests;

namespace EInvoice.Console
{
    public class Program
    {
        public static string CERT = "eltonzhuleku.p12";
        //public static string CERT = "cimi.p12";
        static EInvoiceServiceFactory _factory = new EInvoiceServiceFactory(Path.Combine(Environment.CurrentDirectory, CERT));

        public class MenuItem
        {
            public delegate void MenuItemCommand();
            public string Name { get; set; }
            public MenuItemCommand Command { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }


        static MenuItem[] MenuItems = new MenuItem[]
            {
                new MenuItem{ Name = "Get Tax Payers By Name", Command = GetTaxPayersByName },
                new MenuItem{ Name = "Get Tax Payer By Tin",  Command = GetTaxPayersByTin },
                new MenuItem{ Name = "Get EInvoice BY EIC", Command = GetEInvoiceByEIC },
                new MenuItem{ Name = "Get EInvoices", Command = GetEInvoices },
                new MenuItem{ Name = "EInvoice Change Status", Command = EInvocieChangeStatus },
                new MenuItem{ Name = "Create EInvoice", Command = CreateEInvoice },
                new MenuItem{ Name = "Clear Screen", Command = ClearScreen },
                new MenuItem{ Name = "Exit", Command = Exit },


            };
        static int position = MenuItems.Length;
        static async Task Main(string[] args)
        {
           
            _con.ForegroundColor = Color.White;
            _con.BackgroundColor = Color.Black;
            _con.Clear();

            ShowMenu();

            while (true)
            {
                var line = _con.ReadLine();
                if (line == "menu")
                {
                    ShowMenu();
                }
            }


            //await getTaxPayers();


            return;


            
            
        }

        public static void SelectMenuItem(bool isUp)
        {
            if (isUp)
            {
                if (position > 0)
                {
                    _con.SetCursorPosition(0, _con.CursorTop);
                    _con.Write(MenuItems[position]);
                    position--;
                    _con.SetCursorPosition(0, _con.CursorTop - 1);
                    _con.BackgroundColor = Color.DarkMagenta;
                    _con.ForegroundColor = Color.White;
                    _con.Write(MenuItems[position]);
                    _con.ResetColor();
                }
            }
            else
            {
                if (position < MenuItems.Length-1)
                {
                    _con.SetCursorPosition(0, _con.CursorTop);
                    _con.Write(MenuItems[position]);
                    position++;
                    _con.SetCursorPosition(0, _con.CursorTop + 1);
                    _con.BackgroundColor = Color.DarkMagenta;
                    _con.ForegroundColor = Color.White;
                    _con.Write(MenuItems[position]);
                    _con.ResetColor();
                }
            }
        }

        static bool inOnMenu = false;
        public static void ShowMenu()
        {
            inOnMenu = true;
            _con.ResetColor();
            foreach (var item in MenuItems)
            {
                _con.WriteLine(item);
            }
            _con.SetCursorPosition(0, _con.CursorTop - MenuItems.Length);
            _con.BackgroundColor = Color.DarkMagenta;
            _con.ForegroundColor = Color.White;
            _con.Write(MenuItems[0]);
            _con.ResetColor();
            position = 0;

            while (inOnMenu)
            {
                var key = _con.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    SelectMenuItem(true);
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    SelectMenuItem(false);
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    OnMenuItemSelect();
                }
            }
        }

        public static void OnMenuItemSelect()
        {
            var item = MenuItems[position];
            HideMenu();
            _con.WriteLine($"You selected: {item}");

            item.Command();

        }

        public static void HideMenu()
        {
            _con.SetCursorPosition(0, _con.CursorTop - position);
            foreach (var item in MenuItems)
            {
                _con.Write(new string(' ', _con.WindowWidth));

            }
            _con.SetCursorPosition(0, _con.CursorTop);
            _con.SetCursorPosition(0, _con.CursorTop - (MenuItems.Length -1));
            inOnMenu = false;
        }

        public static void GetTaxPayersByName()
        {
            _con.Write("Enter Name:");
            var name = _con.ReadLine();

            EInvoiceService service = _factory.GetEInvoiceService();

            var request = new Requests.GetTaxpayersByNameRequest(DateTime.Now, name);

            var res = service.GetTaxPayersAsync(request).Result;
            var json = JsonConvert.SerializeObject(res, Newtonsoft.Json.Formatting.Indented);
            _con.WriteLine(json);
        }

        public static void GetTaxPayersByTin()
        {
            _con.Write("Enter Tin:");
            var tin = _con.ReadLine();

            EInvoiceService service = _factory.GetEInvoiceService();

            var request = new Requests.GetTaxpayersByTinRequest(DateTime.Now, tin);

            var res = service.GetTaxPayersAsync(request).Result;
            var json = JsonConvert.SerializeObject(res, Newtonsoft.Json.Formatting.Indented);
            _con.WriteLine(json);
        }

        public static void GetEInvoiceByEIC()
        {
            DateTime date = EInvoiceService.GetDateTimeNow();
            _con.Write("Enter EIC:");
            var eic = _con.ReadLine();

            EInvoiceService service = _factory.GetEInvoiceService();

            var request = GetEInvoicesRequest.GetEInvoiceByEICRequest(eic, date);

            var res = service.GetEInvoicesAsync(request).Result;
            var json = JsonConvert.SerializeObject(res, Newtonsoft.Json.Formatting.Indented);
            _con.WriteLine(json);

            if (res.Success)
            {
                var pdf = res.Einvoices.First().Pdf.GetTempFile();
                Process.Start(new ProcessStartInfo("cmd", $"/c start {pdf}"));
            }

        }

        public static void GetEInvoices()
        {
            DateTime date = EInvoiceService.GetDateTimeNow();
            var indent = "   ";
            _con.WriteLine("Filter flags:");
            _con.WriteLine($"{indent}Type: --type //PartyType [BUYER, SELLER]");
            _con.WriteLine($"{indent}From: --from //From Date [Format: {DateFormat}]");
            _con.WriteLine($"{indent}To: --to //To Date [Format: {DateFormat}]");
            _con.Write("Enter Filters:");
            var line = _con.ReadLine();
            Enums.PartyType? type = null;
            DateTime? from = null;
            DateTime? to = null;
            if (GetTypeFlag(line, out Enums.PartyType typeValue))
                type = typeValue;

            if (GetDateFlag("--from", line, out DateTime fromValue))
                from = fromValue;

            if (GetDateFlag("--to", line, out DateTime toValue))
                to = toValue;

            EInvoiceService service = _factory.GetEInvoiceService();

            var request = GetEInvoicesRequest.GetEInvoicesListRequest(type, from, to);

            

            var res = service.GetEInvoicesAsync(request).Result;
            

            if (res.Success)
            {
           
                _con.WriteLine($"EInvoices:");
                foreach (var invoice in res.Einvoices)
                {
                    ShowInvoice(invoice, indent);
                }
                //var pdf = res.Einvoices.First().Pdf.GetTempFile();
                //Process.Start(new ProcessStartInfo("cmd", $"/c start {pdf}"));
            } else
            {
                _con.WriteLineStyled(res.ErrorMessage, new Colorful.StyleSheet(Color.Red));
                var json = JsonConvert.SerializeObject(res, Newtonsoft.Json.Formatting.Indented);
                _con.WriteLine(json);
            }
            
        }

        public static void ShowInvoice(EInvoiceModel invoice, string parentIndent)
        {
            var indend = parentIndent+"|   ";
            _con.WriteLine($"{parentIndent}EInvoice:");
            _con.WriteLine($"{indend}{nameof(invoice.EIC)}: { invoice.EIC}");
            _con.WriteLine($"{indend}{nameof(invoice.DocNumber)}: { invoice.DocNumber}");
            _con.WriteLine($"{indend}{nameof(invoice.DocType)}: { invoice.DocType.AsString()}");
            _con.WriteLine($"{indend}{nameof(invoice.RecDateTime)}: { invoice.RecDateTime}");
            _con.WriteLine($"{indend}{nameof(invoice.DueDateTime)}: { invoice.DueDateTime}");
            _con.WriteLine($"{indend}{nameof(invoice.Status)}: { invoice.Status.AsString()}");
            _con.WriteLine($"{indend}{nameof(invoice.Amount)}: { invoice.Amount}");
            _con.WriteLine($"{indend}{nameof(invoice.PartyType)}: { invoice.PartyType.AsString()}");

        }

        public static void EInvocieChangeStatus()
        {
            EInvoiceService service = _factory.GetEInvoiceService(); 
            var date = EInvoiceService.GetDateTimeNow();

            var request = new EInvoiceChangeStatusRequest
            {
                Header = new EInvoiceChangeStatusRequestHeader
                {
                    SendDateTime = date,
                    UUID = Guid.NewGuid().ToString()
                },
                EInStatus = Enums.EInvoiceStatusChange.REFUSED,
                EICs = new string[]
                {
                    "a287ea21-40a7-446c-95f3-9ff9e04ff85d"
                }
            };

            var response = service.EInvoiceChangeStatusAsync(request).Result;
            var json = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
            _con.WriteLine(json);
        }

        public static void CreateEInvoice()
        {
            EInvoiceService service = _factory.GetEInvoiceService(); //new EInvoiceService(Path.Combine(Environment.CurrentDirectory, "eltonzhuleku.p12"),null) ;
            var date = EInvoiceService.GetDateTimeNow();



            //var xmlText = Case1(date);
            var xmlText = Case2(date).Result;
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

            var response = service.RegisterEinvoiceAsync(invoice).Result;
            var json = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
            _con.WriteLine(json);
        }


        public static void ClearScreen()
        {
            _con.Clear();
        }
        public static void Exit()
        {
            Environment.Exit(0);
        }


        public const string  DateFormat = "dd-MM-yyyy-HH:mm";
        public static bool GetDateFlag(string flag, string line, out DateTime date)
        {
            
            if (GetFlag(flag, line, out string value))
            {
                date = DateTime.ParseExact(value, DateFormat, null);
                date = EInvoiceService.GetDateTime(date);
                return true;
            }
            date = new DateTime();
            return false;
        }

        public static bool GetTypeFlag(string line, out Enums.PartyType type)
        {
            type = (Enums.PartyType)( -1);
            if(GetFlag("--type", line, out string value))
            {
                if (value.ToUpperInvariant() == Enums.PartyType.BUYER.AsString())
                    type = Enums.PartyType.BUYER;
                else if (value.ToUpperInvariant() == Enums.PartyType.SELLER.AsString())
                    type = Enums.PartyType.SELLER;
                else
                    throw new ArgumentException($"{value} is not a valid type");
                return true;
            }
            return false;
        }

        public static bool GetFlag(string flag, string line, out string argument)
        {
            argument = null;
            if (!line.Contains(flag))
                return false;
            var lineAfterFlag = line.Split(flag)[1].Trim();
            argument = lineAfterFlag.Split(' ')[0];
            return true;
        }





















        public static async Task getTaxPayers() 
        {
            EInvoiceService service = _factory.GetEInvoiceService();

            var request = new Requests.GetTaxpayersByNameRequest(DateTime.Now, "elton");
            //  request = new Requests.GetTaxpayersByTinRequest(date, "L41316032F")
 

            var res = await service.GetTaxPayersAsync(request);
            var json = JsonConvert.SerializeObject(res, Newtonsoft.Json.Formatting.Indented);
            _con.WriteLine(json);
        }
 

        public static async Task<string> Case2(DateTime date)
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


            //var selleNUIS = rInvoice.Invoice.Seller.IDNum;
            //var buyerNUIS = "K81705022E";
            var selleNUIS = "L82118024B";
            var buyerNUIS = "L41316032F";
            var rInvoice = new RegisterInvoiceRequest
            {
                //Id = "id10",
                //Version = 1,
                
                Header = new RegisterInvoiceRequestHeaderType
                {
                    UUID = Guid.NewGuid().ToString(),
                    SendDateTime = date,
                    SubseqDelivType = SubseqDelivTypeSType.SERVICE,
                    SubseqDelivTypeSpecified = false,

                },
                Invoice = new InvoiceType
                {
                    
                    IsIssuerInVAT = true,
                    //IIC = FiscalizationSigner.GenerateIIC("I12345678I"),
                    //IICSignature = FiscalizationSigner.SignIICSignature("I12345678I"),
                    PayMethods = new PayMethodType[]
                    {
                        new PayMethodType
                        {
                            Amt = 20.00M,
                            Type = PaymentMethodTypeSType.TRANSFER
                        }
                    },


                    TypeOfInv = InvoiceSType.NONCASH,
                    BusinUnitCode = "wo765uk675",
                    Currency = new CurrencyType
                    {
                        Code = CurrencyCodeSType.EUR,
                        ExRate = 1.0,
                        IsBuying = true
                    },
                    InvNum = $"111/{date.Year}",
                    InvOrdNum = 111,
                    IssueDateTime = date,
                    Items = new InvoiceItemType[]{
                        new InvoiceItemType
                        {
                           C = "501234567890",
                           PA = 20.00M,
                           PB = 20.00M,
                           Q = 1.0,
                           R = 0,
                           RR = true,
                           UPB = 20.00M,
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
                    OperatorCode = "au254tb295",
                    PayDeadlineSpecified = false,
                    Seller = new SellerType
                    {
                        Address = "seller address",
                        Country = CountryCodeSType.ALB,
                        CountrySpecified = true,
                        IDNum = selleNUIS,
                        IDType = IDTypeSType.NUIS,
                        Name = "Seller name",
                        Town = "seller town",
                        

                    },
                    SoftCode = "eq535yw328",
                    TCRCode = "dt947iw604",
                    TotPrice = 20.00M,
                    //TotVATAmtSpecified = false,
                    //TotPriceWoVAT = 16.00M,
                    //TotVATAmt = 4,

                },
            };
            string iicInput = CreateIICInput(rInvoice.Invoice);

            rInvoice.Invoice.IIC = FiscalizationSigner.GenerateIIC(iicInput);
            rInvoice.Invoice.IICSignature = FiscalizationSigner.SignIICSignature(iicInput);


            var response = (await client.registerInvoiceAsync(rInvoice)).RegisterInvoiceResponse;

            var verifyUrl = GenerateVerifyURL(rInvoice);

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
                ID = rInvoice.Invoice.InvNum,
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
                InvoiceTypeCode = new CodeType { 
                    Value = Enums.InvoiceTypeCode.CommercialInvoice
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
                            new PartyNameType { Name = rInvoice.Invoice.Seller.Name}
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
                Note = createNoteTypes(date, rInvoice.Invoice, response.FIC),
                
                //UUID = Guid.NewGuid().ToString(),
                UBLExtensions = new List<UBLExtensionType>
                {
                    new UBLExtensionType
                    {
                        ExtensionContent = (XmlElement)xmlDocExt.GetElementsByTagName("SignatureInformation").Item(0)
                    }
                }
                
            };

            



            var xml = invoiceDoc.ToXDocument();
            var xmlText = xml.ToString();
            //xmlText = File.ReadAllText("C:/Repo/FiscalizationProject/Fiscalization/EInvoice.Console/bin/Debug/netcoreapp3.1/ubl.xml");
            var signedxml = createSignature(xmlText);
            return signedxml;
        }


        public static async Task<  string> Case3(DateTime date)
        {
            var client = new FiscalizationServicePortTypeClient();
            var endpointBh = new XMLSignerEndpointBehavior();
            client.Endpoint.EndpointBehaviors.Add(endpointBh);

            var now = DateTime.Now;
            date = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second, DateTimeKind.Local);





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
                    IIC = FiscalizationSigner.GenerateIIC("I12345678I"),
                    IICSignature = FiscalizationSigner.SignIICSignature("I12345678I"),
                    PayMethods = new PayMethodType[]
                    {
                        new PayMethodType
                        {
                            Amt = 20.00M,
                            Type = PaymentMethodTypeSType.BANKNOTE
                        }
                    },

                    TypeOfInv = InvoiceSType.CASH,
                    BusinUnitCode = "bb123bb123",
                    Currency = new CurrencyType
                    {
                        Code = CurrencyCodeSType.EUR,
                        ExRate = 1.24,
                        IsBuying = true
                    },
                    InvNum = "1/2020/cc123cc123",
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


            var response = (await client.registerInvoiceAsync(rInvoice)).RegisterInvoiceResponse;


            var doc = new UblSharp.InvoiceType
            {
                UBLVersionID = "2.1",
                ID = "TOSL108",
                CustomizationID = "urn:cen.eu:en16931:2017#compliant#urn:akshi.al:2019:1.0",
                IssueDate = "2009-12-15",
                InvoiceTypeCode = new CodeType
                {
                    listID = "UN/ECE 1001 Subset",
                    listAgencyID = "6",
                    Value = "380"
                },
                Note = createNoteTypes(date, rInvoice.Invoice, response.FIC),
                TaxPointDate = "2009-11-30",
                DocumentCurrencyCode = new CodeType
                {
                    listID = "ISO 4217 Alpha",
                    listAgencyID = "6",
                    Value = "EUR"
                },
                AccountingCost = "Project cost code 123",
                InvoicePeriod = new List<PeriodType>()
                {
                    new PeriodType
                    {
                        StartDate = "2009-11-01",
                        EndDate = "2009-11-30"
                    }
                },
                OrderReference = new OrderReferenceType
                {
                    ID = "123"
                },
                ContractDocumentReference = new List<DocumentReferenceType>()
                {
                    new DocumentReferenceType
                    {
                        ID = "Contract321",
                        DocumentType = "Framework agreement"
                    }
                },
                AdditionalDocumentReference = new List<DocumentReferenceType>()
                {
                    new DocumentReferenceType
                    {
                        ID = "Doc1",
                        DocumentType = "Timesheet",
                        Attachment = new AttachmentType
                        {
                            ExternalReference = new ExternalReferenceType
                            {
                                URI = "http://www.suppliersite.eu/sheet001.html"
                            }
                        }
                    },
                    new DocumentReferenceType
                    {
                        ID = "Doc2",
                        DocumentType = "Drawing",
                        Attachment = new AttachmentType
                        {
                            EmbeddedDocumentBinaryObject = new BinaryObjectType
                            {
                                mimeCode = "application/pdf",
                                Value = Convert.FromBase64String("UjBsR09EbGhjZ0dTQUxNQUFBUUNBRU1tQ1p0dU1GUXhEUzhi")
                            }
                        }
                    }
                },
                AccountingSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = new IdentifierType
                        {
                            schemeID = "GLN",
                            schemeAgencyID = "9",
                            Value = "1234567890123"
                        },
                        PartyIdentification = new List<PartyIdentificationType>()
                        {
                            new PartyIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeID = "ZZZ",
                                    Value = "Supp123"
                                }
                            }
                        },
                        PartyName = new List<PartyNameType>()
                        {
                            new PartyNameType
                            {
                                Name = "Salescompany ltd."
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            ID = new IdentifierType
                            {
                                schemeID = "GLN",
                                schemeAgencyID = "9",
                                Value = "1231412341324"
                            },
                            Postbox = "5467",
                            StreetName = "Main street",
                            AdditionalStreetName = "Suite 123",
                            BuildingNumber = "1",
                            Department = "Revenue department",
                            CityName = "Big city",
                            PostalZone = "54321",
                            CountrySubentityCode = "RegionA",
                            Country = new CountryType
                            {
                                IdentificationCode = new CodeType
                                {
                                    listID = "ISO3166-1",
                                    listAgencyID = "6",
                                    Value = "DK"
                                }
                            }
                        },
                        PartyTaxScheme = new List<PartyTaxSchemeType>()
                        {
                            new PartyTaxSchemeType
                            {
                                CompanyID = new IdentifierType
                                {
                                    schemeID = "DKVAT",
                                    schemeAgencyID = "ZZZ",
                                    Value = "DK12345"
                                },
                                TaxScheme = new TaxSchemeType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeID = "UN/ECE 5153",
                                        schemeAgencyID = "6",
                                        Value = "VAT"
                                    }
                                }
                            }
                        },
                        PartyLegalEntity = new List<PartyLegalEntityType>()
                        {
                            new PartyLegalEntityType
                            {
                                RegistrationName = "The Sellercompany Incorporated",
                                CompanyID = new IdentifierType
                                {
                                    schemeID = "CVR",
                                    schemeAgencyID = "ZZZ",
                                    Value = "5402697509"
                                },
                                RegistrationAddress = new AddressType
                                {
                                    CityName = "Big city",
                                    CountrySubentity = "RegionA",
                                    Country = new CountryType
                                    {
                                        IdentificationCode = "DK"
                                    }
                                }
                            }
                        },
                        Contact = new ContactType
                        {
                            Telephone = "4621230",
                            Telefax = "4621231",
                            ElectronicMail = "antonio@salescompany.dk"
                        },
                        Person = new List<PersonType>()
                        {
                            new PersonType
                            {
                                FirstName = "Antonio",
                                FamilyName = "M",
                                MiddleName = "Salemacher",
                                JobTitle = "Sales manager"
                            }
                        },
                    }
                },
                AccountingCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = new IdentifierType
                        {
                            schemeID = "GLN",
                            schemeAgencyID = "9",
                            Value = "1234567987654"
                        },
                        PartyIdentification = new List<PartyIdentificationType>()
                        {
                            new PartyIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeID = "ZZZ",
                                    Value = "345KS5324"
                                }
                            }
                        },
                        PartyName = new List<PartyNameType>()
                        {
                            new PartyNameType
                            {
                                Name = "Buyercompany ltd"
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            ID = new IdentifierType
                            {
                                schemeID = "GLN",
                                schemeAgencyID = "9",
                                Value = "1238764941386"
                            },
                            Postbox = "123",
                            StreetName = "Anystreet",
                            AdditionalStreetName = "Back door",
                            BuildingNumber = "8",
                            Department = "Accounting department",
                            CityName = "Anytown",
                            PostalZone = "101",
                            CountrySubentity = "RegionB",
                            Country = new CountryType
                            {
                                IdentificationCode = new CodeType
                                {
                                    listID = "ISO3166-1",
                                    listAgencyID = "6",
                                    Value = "BE"
                                }
                            }
                        },
                        PartyTaxScheme = new List<PartyTaxSchemeType>()
                        {
                            new PartyTaxSchemeType
                            {
                                CompanyID = new IdentifierType
                                {
                                    schemeID = "BEVAT",
                                    schemeAgencyID = "ZZZ",
                                    Value = "BE54321"
                                },
                                TaxScheme = new TaxSchemeType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeID = "UN/ECE 5153",
                                        schemeAgencyID = "6",
                                        Value = "VAT"
                                    }
                                }
                            }
                        },
                        PartyLegalEntity = new List<PartyLegalEntityType>()
                        {
                            new PartyLegalEntityType
                            {
                                RegistrationName = "The buyercompany inc.",
                                CompanyID = new IdentifierType
                                {
                                    schemeAgencyID = "ZZZ",
                                    schemeID = "ZZZ",
                                    Value = "5645342123"
                                },
                                RegistrationAddress = new AddressType
                                {
                                    CityName = "Mainplace",
                                    CountrySubentity = "RegionB",
                                    Country = new CountryType
                                    {
                                        IdentificationCode = "BE"
                                    }
                                }
                            }
                        },
                        Contact = new ContactType
                        {
                            Telephone = "5121230",
                            Telefax = "5121231",
                            ElectronicMail = "john@buyercompany.eu"
                        },
                        Person = new List<PersonType>()
                        {
                            new PersonType
                            {
                                FirstName = "John",
                                FamilyName = "X",
                                MiddleName = "Doe",
                                JobTitle = "Purchasing manager"
                            }
                        },
                    }
                },
                //PayeeParty = new PartyType
                //{
                //    PartyIdentification = new List<PartyIdentificationType>()
                //    {
                //        new PartyIdentificationType
                //        {
                //            ID = new IdentifierType
                //            {
                //                schemeID = "GLN",
                //                schemeAgencyID = "9",
                //                Value = "098740918237"
                //            }
                //        }
                //    },
                //    PartyName = new List<PartyNameType>()
                //    {
                //        new PartyNameType
                //        {
                //            Name = "Ebeneser Scrooge Inc."
                //        }
                //    },
                //    PartyLegalEntity = new List<PartyLegalEntityType>()
                //    {
                //        new PartyLegalEntityType
                //        {
                //            CompanyID = new IdentifierType
                //            {
                //                schemeID = "UK:CH",
                //                schemeAgencyID = "ZZZ",
                //                Value = "6411982340"
                //            }
                //        }
                //    },
                //},
                Delivery = new List<DeliveryType>()
                {
                    new DeliveryType
                    {
                        ActualDeliveryDate = "2009-12-15",
                        DeliveryLocation = new LocationType
                        {
                            ID = new IdentifierType
                            {
                                schemeID = "GLN",
                                schemeAgencyID = "9",
                                Value = "6754238987648"
                            },
                            Address = new AddressType
                            {
                                StreetName = "Deliverystreet",
                                AdditionalStreetName = "Side door",
                                BuildingNumber = "12",
                                CityName = "DeliveryCity",
                                PostalZone = "523427",
                                CountrySubentity = "RegionC",
                                Country = new CountryType
                                {
                                    IdentificationCode = "BE"
                                }
                            }
                        }
                    }
                },
                PaymentMeans = new List<PaymentMeansType>()
                {
                    new PaymentMeansType
                    {
                        PaymentMeansCode = new CodeType
                        {
                            listID = "UN/ECE 4461",
                            Value = "31"
                        },
                        PaymentDueDate = "2009-12-31",
                        PaymentChannelCode = "IBAN",
                        PaymentID = new List<IdentifierType>()
                        {
                            new IdentifierType
                            {
                                Value = "Payref1"
                            }
                        },
                        PayeeFinancialAccount = new FinancialAccountType
                        {
                            ID = "DK1212341234123412",
                            FinancialInstitutionBranch = new BranchType
                            {
                                FinancialInstitution = new FinancialInstitutionType
                                {
                                    ID = "DKDKABCD"
                                }
                            }
                        }
                    }
                },
                PaymentTerms = new List<PaymentTermsType>()
                {
                    new PaymentTermsType
                    {
                        Note = new List<TextType>()
                        {
                            new TextType
                            {
                                Value = "Penalty percentage 10% from due date"
                            }
                        },
                    }
                },
                AllowanceCharge = new List<AllowanceChargeType>()
                {
                    new AllowanceChargeType
                    {
                        ChargeIndicator = true,
                        AllowanceChargeReason = new List<TextType>()
                        {
                            new TextType
                            {
                                Value = "Packing cost"
                            }
                        },
                        Amount = new AmountType
                        {
                            currencyID = "EUR",
                            Value = 100M
                        }
                    },
                    new AllowanceChargeType
                    {
                        ChargeIndicator = false,
                        AllowanceChargeReason = new List<TextType>()
                        {
                            new TextType
                            {
                                Value = "Promotion discount"
                            }
                        },
                        Amount = new AmountType
                        {
                            currencyID = "EUR",
                            Value = 100M
                        }
                    }
                },
                TaxTotal = new List<TaxTotalType>()
                {
                    new TaxTotalType
                    {
                        TaxAmount = new AmountType
                        {
                            currencyID = "EUR",
                            Value = 292.20M
                        },
                        TaxSubtotal = new List<TaxSubtotalType>()
                        {
                            new TaxSubtotalType
                            {
                                TaxableAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = 1460.5M
                                },
                                TaxAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = 292.1M
                                },
                                TaxCategory = new TaxCategoryType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeID = "UN/ECE 5305",
                                        schemeAgencyID = "6",
                                        Value = "S"
                                    },
                                    Percent = 20M,
                                    TaxScheme = new TaxSchemeType
                                    {
                                        ID = new IdentifierType
                                        {
                                            schemeID = "UN/ECE 5153",
                                            schemeAgencyID = "6",
                                            Value = "VAT"
                                        }
                                    }
                                }
                            },
                            new TaxSubtotalType
                            {
                                TaxableAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = 1M
                                },
                                TaxAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = 0.1M
                                },
                                TaxCategory = new TaxCategoryType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeID = "UN/ECE 5305",
                                        schemeAgencyID = "6",
                                        Value = "AA"
                                    },
                                    Percent = 10M,
                                    TaxScheme = new TaxSchemeType
                                    {
                                        ID = new IdentifierType
                                        {
                                            schemeID = "UN/ECE 5153",
                                            schemeAgencyID = "6",
                                            Value = "VAT"
                                        }
                                    }
                                }
                            },
                            new TaxSubtotalType
                            {
                                TaxableAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = -25M
                                },
                                TaxAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = 0M
                                },
                                TaxCategory = new TaxCategoryType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeID = "UN/ECE 5305",
                                        schemeAgencyID = "6",
                                        Value = "E"
                                    },
                                    Percent = 0M,
                                    TaxExemptionReasonCode = new CodeType
                                    {
                                        listID = "CWA 15577",
                                        listAgencyID = "ZZZ",
                                        Value = "AAM"
                                    },
                                    TaxExemptionReason = new List<TextType>()
                                    {
                                        new TextType
                                        {
                                            Value = "Exempt New Means of Transport"
                                        }
                                    },
                                    TaxScheme = new TaxSchemeType
                                    {
                                        ID = new IdentifierType
                                        {
                                            schemeID = "UN/ECE 5153",
                                            schemeAgencyID = "6",
                                            Value = "VAT"
                                        }
                                    }
                                }
                            }
                        },
                    }
                },
                LegalMonetaryTotal = new MonetaryTotalType
                {
                    LineExtensionAmount = new AmountType
                    {
                        currencyID = "EUR",
                        Value = 1436.5M
                    },
                    TaxExclusiveAmount = new AmountType
                    {
                        currencyID = "EUR",
                        Value = 1436.5M
                    },
                    TaxInclusiveAmount = new AmountType
                    {
                        currencyID = "EUR",
                        Value = 1729M
                    },
                    AllowanceTotalAmount = new AmountType
                    {
                        currencyID = "EUR",
                        Value = 100M
                    },
                    ChargeTotalAmount = new AmountType
                    {
                        currencyID = "EUR",
                        Value = 100M
                    },
                    PrepaidAmount = new AmountType
                    {
                        currencyID = "EUR",
                        Value = 1000M
                    },
                    PayableRoundingAmount = new AmountType
                    {
                        currencyID = "EUR",
                        Value = 0.30M
                    },
                    PayableAmount = new AmountType
                    {
                        currencyID = "EUR",
                        Value = 729M
                    }
                },
                InvoiceLine = new List<InvoiceLineType>()
                {
                    new InvoiceLineType
                    {
                        ID = "1",
                        Note = new List<TextType>()
                        {
                            new TextType
                            {
                                Value = "Scratch on box"
                            }
                        },
                        InvoicedQuantity = new QuantityType
                        {
                            unitCode = "C62",
                            Value = 1M
                        },
                        LineExtensionAmount = new AmountType
                        {
                            currencyID = "EUR",
                            Value = 1273M
                        },
                        AccountingCost = "BookingCode001",
                        OrderLineReference = new List<OrderLineReferenceType>()
                        {
                            new OrderLineReferenceType
                            {
                                LineID = "1"
                            }
                        },
                        AllowanceCharge = new List<AllowanceChargeType>()
                        {
                            new AllowanceChargeType
                            {
                                ChargeIndicator = false,
                                AllowanceChargeReason = new List<TextType>()
                                {
                                    new TextType
                                    {
                                        Value = "Damage"
                                    }
                                },
                                Amount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = 12M
                                }
                            },
                            new AllowanceChargeType
                            {
                                ChargeIndicator = true,
                                AllowanceChargeReason = new List<TextType>()
                                {
                                    new TextType
                                    {
                                        Value = "Testing"
                                    }
                                },
                                Amount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = 10M
                                }
                            }
                        },
                        TaxTotal = new List<TaxTotalType>()
                        {
                            new TaxTotalType
                            {
                                TaxAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = 254.6M
                                }
                            }
                        },
                        Item = new ItemType
                        {
                            Description = new List<TextType>()
                            {
                                new TextType
                                {
                                    languageID = "EN",
                                    Value = @"Processor: Intel Core 2 Duo SU9400 LV (1.4GHz). RAM: 3MB. Screen 1440x900"
                                }
                            },
                            Name = "Labtop computer",
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "JB007"
                            },
                            StandardItemIdentification = new ItemIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeID = "GTIN",
                                    schemeAgencyID = "9",
                                    Value = "1234567890124"
                                }
                            },
                            CommodityClassification = new List<CommodityClassificationType>()
                            {
                                new CommodityClassificationType
                                {
                                    ItemClassificationCode = new CodeType
                                    {
                                        listAgencyID = "113",
                                        listID = "UNSPSC",
                                        Value = "12344321"
                                    }
                                },
                                new CommodityClassificationType
                                {
                                    ItemClassificationCode = new CodeType
                                    {
                                        listAgencyID = "2",
                                        listID = "CPV",
                                        Value = "65434568"
                                    }
                                }
                            },
                            ClassifiedTaxCategory = new List<TaxCategoryType>()
                            {
                                new TaxCategoryType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeID = "UN/ECE 5305",
                                        schemeAgencyID = "6",
                                        Value = "S"
                                    },
                                    Percent = 20M,
                                    TaxScheme = new TaxSchemeType
                                    {
                                        ID = new IdentifierType
                                        {
                                            schemeID = "UN/ECE 5153",
                                            schemeAgencyID = "6",
                                            Value = "VAT"
                                        }
                                    }
                                }
                            },
                            AdditionalItemProperty = new List<ItemPropertyType>()
                            {
                                new ItemPropertyType
                                {
                                    Name = "Color",
                                    Value = "black"
                                }
                            },
                        },
                        Price = new PriceType
                        {
                            PriceAmount = new AmountType
                            {
                                currencyID = "EUR",
                                Value = 1273M
                            },
                            BaseQuantity = new QuantityType
                            {
                                unitCode = "C62",
                                Value = 1M
                            },
                            AllowanceCharge = new List<AllowanceChargeType>()
                            {
                                new AllowanceChargeType
                                {
                                    ChargeIndicator = false,
                                    AllowanceChargeReason = new List<TextType>()
                                    {
                                        new TextType
                                        {
                                            Value = "Contract"
                                        }
                                    },
                                    MultiplierFactorNumeric = 0.15M,
                                    Amount = new AmountType
                                    {
                                        currencyID = "EUR",
                                        Value = 225M
                                    },
                                    BaseAmount = new AmountType
                                    {
                                        currencyID = "EUR",
                                        Value = 1500M
                                    }
                                }
                            },
                        }
                    },
                    new InvoiceLineType
                    {
                        ID = "2",
                        Note = new List<TextType>()
                        {
                            new TextType
                            {
                                Value = "Cover is slightly damaged."
                            }
                        },
                        InvoicedQuantity = new QuantityType
                        {
                            unitCode = "C62",
                            Value = -1M
                        },
                        LineExtensionAmount = new AmountType
                        {
                            currencyID = "EUR",
                            Value = -3.96M
                        },
                        OrderLineReference = new List<OrderLineReferenceType>()
                        {
                            new OrderLineReferenceType
                            {
                                LineID = "5"
                            }
                        },
                        TaxTotal = new List<TaxTotalType>()
                        {
                            new TaxTotalType
                            {
                                TaxAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = -0.396M
                                }
                            }
                        },
                        Item = new ItemType
                        {
                            Name = "Returned \"Advanced computing\" book",
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "JB008"
                            },
                            StandardItemIdentification = new ItemIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeID = "GTIN",
                                    schemeAgencyID = "9",
                                    Value = "1234567890125"
                                }
                            },
                            CommodityClassification = new List<CommodityClassificationType>()
                            {
                                new CommodityClassificationType
                                {
                                    ItemClassificationCode = new CodeType
                                    {
                                        listAgencyID = "113",
                                        listID = "UNSPSC",
                                        Value = "32344324"
                                    }
                                },
                                new CommodityClassificationType
                                {
                                    ItemClassificationCode = new CodeType
                                    {
                                        listAgencyID = "2",
                                        listID = "CPV",
                                        Value = "65434567"
                                    }
                                }
                            },
                            ClassifiedTaxCategory = new List<TaxCategoryType>()
                            {
                                new TaxCategoryType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeID = "UN/ECE 5305",
                                        schemeAgencyID = "6",
                                        Value = "AA"
                                    },
                                    Percent = 10M,
                                    TaxScheme = new TaxSchemeType
                                    {
                                        ID = new IdentifierType
                                        {
                                            schemeID = "UN/ECE 5153",
                                            schemeAgencyID = "6",
                                            Value = "VAT"
                                        }
                                    }
                                }
                            },
                        },
                        Price = new PriceType
                        {
                            PriceAmount = new AmountType
                            {
                                currencyID = "EUR",
                                Value = 3.96M
                            },
                            BaseQuantity = new QuantityType
                            {
                                unitCode = "C62",
                                Value = 1M
                            }
                        }
                    },
                    new InvoiceLineType
                    {
                        ID = "3",
                        InvoicedQuantity = new QuantityType
                        {
                            unitCode = "C62",
                            Value = 2M
                        },
                        LineExtensionAmount = new AmountType
                        {
                            currencyID = "EUR",
                            Value = 4.96M
                        },
                        OrderLineReference = new List<OrderLineReferenceType>()
                        {
                            new OrderLineReferenceType
                            {
                                LineID = "3"
                            }
                        },
                        TaxTotal = new List<TaxTotalType>()
                        {
                            new TaxTotalType
                            {
                                TaxAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = 0.496M
                                }
                            }
                        },
                        Item = new ItemType
                        {
                            Name = "\"Computing for dummies\" book",
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "JB009"
                            },
                            StandardItemIdentification = new ItemIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeID = "GTIN",
                                    schemeAgencyID = "9",
                                    Value = "1234567890126"
                                }
                            },
                            CommodityClassification = new List<CommodityClassificationType>()
                            {
                                new CommodityClassificationType
                                {
                                    ItemClassificationCode = new CodeType
                                    {
                                        listAgencyID = "113",
                                        listID = "UNSPSC",
                                        Value = "32344324"
                                    }
                                },
                                new CommodityClassificationType
                                {
                                    ItemClassificationCode = new CodeType
                                    {
                                        listAgencyID = "2",
                                        listID = "CPV",
                                        Value = "65434566"
                                    }
                                }
                            },
                            ClassifiedTaxCategory = new List<TaxCategoryType>()
                            {
                                new TaxCategoryType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeID = "UN/ECE 5305",
                                        schemeAgencyID = "6",
                                        Value = "AA"
                                    },
                                    Percent = 10M,
                                    TaxScheme = new TaxSchemeType
                                    {
                                        ID = new IdentifierType
                                        {
                                            schemeID = "UN/ECE 5153",
                                            schemeAgencyID = "6",
                                            Value = "VAT"
                                        }
                                    }
                                }
                            },
                        },
                        Price = new PriceType
                        {
                            PriceAmount = new AmountType
                            {
                                currencyID = "EUR",
                                Value = 2.48M
                            },
                            BaseQuantity = new QuantityType
                            {
                                unitCode = "C62",
                                Value = 1M
                            },
                            AllowanceCharge = new List<AllowanceChargeType>()
                            {
                                new AllowanceChargeType
                                {
                                    ChargeIndicator = false,
                                    AllowanceChargeReason = new List<TextType>()
                                    {
                                        new TextType
                                        {
                                            Value = "Contract"
                                        }
                                    },
                                    MultiplierFactorNumeric = 0.1M,
                                    Amount = new AmountType
                                    {
                                        currencyID = "EUR",
                                        Value = 0.275M
                                    },
                                    BaseAmount = new AmountType
                                    {
                                        currencyID = "EUR",
                                        Value = 2.75M
                                    }
                                }
                            },
                        }
                    },
                    new InvoiceLineType
                    {
                        ID = "4",
                        InvoicedQuantity = new QuantityType
                        {
                            unitCode = "C62",
                            Value = -1M
                        },
                        LineExtensionAmount = new AmountType
                        {
                            currencyID = "EUR",
                            Value = -25M
                        },
                        OrderLineReference = new List<OrderLineReferenceType>()
                        {
                            new OrderLineReferenceType
                            {
                                LineID = "2"
                            }
                        },
                        TaxTotal = new List<TaxTotalType>()
                        {
                            new TaxTotalType
                            {
                                TaxAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = 0M
                                }
                            }
                        },
                        Item = new ItemType
                        {
                            Name = "Returned IBM 5150 desktop",
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "JB010"
                            },
                            StandardItemIdentification = new ItemIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeID = "GTIN",
                                    schemeAgencyID = "9",
                                    Value = "1234567890127"
                                }
                            },
                            CommodityClassification = new List<CommodityClassificationType>()
                            {
                                new CommodityClassificationType
                                {
                                    ItemClassificationCode = new CodeType
                                    {
                                        listAgencyID = "113",
                                        listID = "UNSPSC",
                                        Value = "12344322"
                                    }
                                },
                                new CommodityClassificationType
                                {
                                    ItemClassificationCode = new CodeType
                                    {
                                        listAgencyID = "2",
                                        listID = "CPV",
                                        Value = "65434565"
                                    }
                                }
                            },
                            ClassifiedTaxCategory = new List<TaxCategoryType>()
                            {
                                new TaxCategoryType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeID = "UN/ECE 5305",
                                        schemeAgencyID = "6",
                                        Value = "E"
                                    },
                                    Percent = 0M,
                                    TaxScheme = new TaxSchemeType
                                    {
                                        ID = new IdentifierType
                                        {
                                            schemeID = "UN/ECE 5153",
                                            schemeAgencyID = "6",
                                            Value = "VAT"
                                        }
                                    }
                                }
                            },
                        },
                        Price = new PriceType
                        {
                            PriceAmount = new AmountType
                            {
                                currencyID = "EUR",
                                Value = 25M
                            },
                            BaseQuantity = new QuantityType
                            {
                                unitCode = "C62",
                                Value = 1M
                            }
                        }
                    },
                    new InvoiceLineType
                    {
                        ID = "5",
                        InvoicedQuantity = new QuantityType
                        {
                            unitCode = "C62",
                            Value = 250M
                        },
                        LineExtensionAmount = new AmountType
                        {
                            currencyID = "EUR",
                            Value = 187.5M
                        },
                        AccountingCost = "BookingCode002",
                        OrderLineReference = new List<OrderLineReferenceType>()
                        {
                            new OrderLineReferenceType
                            {
                                LineID = "4"
                            }
                        },
                        TaxTotal = new List<TaxTotalType>()
                        {
                            new TaxTotalType
                            {
                                TaxAmount = new AmountType
                                {
                                    currencyID = "EUR",
                                    Value = 37.5M
                                }
                            }
                        },
                        Item = new ItemType
                        {
                            Name = "Network cable",
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "JB011"
                            },
                            StandardItemIdentification = new ItemIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeID = "GTIN",
                                    schemeAgencyID = "9",
                                    Value = "1234567890128"
                                }
                            },
                            CommodityClassification = new List<CommodityClassificationType>()
                            {
                                new CommodityClassificationType
                                {
                                    ItemClassificationCode = new CodeType
                                    {
                                        listAgencyID = "113",
                                        listID = "UNSPSC",
                                        Value = "12344325"
                                    }
                                },
                                new CommodityClassificationType
                                {
                                    ItemClassificationCode = new CodeType
                                    {
                                        listAgencyID = "2",
                                        listID = "CPV",
                                        Value = "65434564"
                                    }
                                }
                            },
                            ClassifiedTaxCategory = new List<TaxCategoryType>()
                            {
                                new TaxCategoryType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeID = "UN/ECE 5305",
                                        schemeAgencyID = "6",
                                        Value = "S"
                                    },
                                    Percent = 20M,
                                    TaxScheme = new TaxSchemeType
                                    {
                                        ID = new IdentifierType
                                        {
                                            schemeID = "UN/ECE 5153",
                                            schemeAgencyID = "6",
                                            Value = "VAT"
                                        }
                                    }
                                }
                            },
                            AdditionalItemProperty = new List<ItemPropertyType>()
                            {
                                new ItemPropertyType
                                {
                                    Name = "Type",
                                    Value = "Cat5"
                                }
                            },
                        },
                        Price = new PriceType
                        {
                            PriceAmount = new AmountType
                            {
                                currencyID = "EUR",
                                Value = 0.75M
                            },
                            BaseQuantity = new QuantityType
                            {
                                unitCode = "C62",
                                Value = 1M
                            }
                        }
                    }
                },
                UBLExtensions = new List<UBLExtensionType>
                {
                    new UBLExtensionType
                    {
                        ExtensionContent = (XmlElement)xmlDocExt.GetElementsByTagName("SignatureInformation").Item(0)
                    }
                }
            };
            doc.Xmlns = new System.Xml.Serialization.XmlSerializerNamespaces(new[]
            {
                new XmlQualifiedName("cac","urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"),
                new XmlQualifiedName("cbc","urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"),
            });

            var xml = doc.ToXDocument();
            var xmlText = xml.ToString();
            var signedxml = createSignature(xmlText);
            return signedxml;
        }

        private static List<TextType> createNoteTypes(DateTime date, InvoiceType invoice, string fic)
        {

            List<TextType> noteTypes = new List<TextType>
            {
                new TextType
                {
                    Value = "IssueDateTime=" + date.ToString("yyyy-MM-ddTHH:mm:ssK", CultureInfo.InvariantCulture) + "#AAI#"
                },
                new TextType
                {
                    Value = "OperatorCode=" + invoice.OperatorCode + "#AAI#"
                },
                new TextType
                {
                    Value = "BusinessUnitCode=" + invoice.BusinUnitCode + "#AAI#"
                },
                new TextType
                {
                    Value = "SoftwareCode=" + invoice.SoftCode + "#AAI#"
                },
                new TextType
                {
                    Value = "IsBadDebtInv=false#AAI#"
                },
                new TextType
                {
                    Value = "IIC=" + invoice.IIC + "#AAI#"
                },
                new TextType
                {
                    Value = "FIC=" + fic + "#AAI#"
                },
                new TextType
                {
                    Value = "IICSignature=" + invoice.IICSignature + "#AAI#"
                },
            };

            return noteTypes;
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

        public static string CreateIICInput(InvoiceType invoice)
        {
            // Issuer NUIS(Chapter 3.7.1.51)
            // Date and time created(Chapter 3.7.1.8)
            // Invoice number(Chapter 3.7.1.10)
            // Business unit code(Chapter 3.7.1.21)
            // TCR code(Chapter 3.7.1.12)
            // Software code(Chapter 3.7.1.22)86 | 118
            // Total price(Chapter 3.7.1.19)

            if (invoice.InvNum is null || invoice.Seller is null)
                return null;

            // Issuer NUIS
            string iicInput = invoice.Seller.IDNum;

            // dateTimeCreated
            iicInput += "|" + GetDatetimeISO8601(invoice.IssueDateTime);

            // invoiceNumber
            iicInput += "|" + Regex.Match(invoice.InvNum, @"\A([0-9]{0,10})", RegexOptions.Singleline).Value;

            // busiUnitCode
            iicInput += "|" + invoice.BusinUnitCode;

            // tcrCode
            iicInput += "|" + invoice.TCRCode;

            // softCode
            iicInput += "|" + invoice.SoftCode;

            // totalPrice
            iicInput += "|" + invoice.TotPrice;

            return iicInput;
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
    }




 
}
