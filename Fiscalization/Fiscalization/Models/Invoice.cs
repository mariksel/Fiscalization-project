using EnumsNET;
using Fiscalization.Enums;
using FiscalizationService.SOAP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Fiscalization.Models
{
    public class Invoice
    {

        public static Invoice CreateInvoice(Seller seller, DateTime issueDateTime, Enums.InvoiceType typeOfInv,
            string businUnitCode, string tcrCode, string softCode, string operatorCode, int invOrdNum,
            InvoiceItem[] items, PayMethod[] paymethods, bool isIssuerInVAT)
        {
            var invoice = new Invoice
            {
                TypeOfInv = typeOfInv,
                Seller = seller,
                IssueDateTime = FiscalizationService.GetDateTime(issueDateTime),
                BusinUnitCode = businUnitCode,
                TCRCode = tcrCode,
                SoftCode = softCode,
                InvOrdNum = invOrdNum,
                OperatorCode = operatorCode,
                Items = items,
                PayMethods = paymethods,
                IsIssuerInVAT = isIssuerInVAT
            };

            GenerateIIC(invoice);
            invoice.VerifyUrl = GenerateVerifyURL(invoice);

            return invoice;
        }

        private Invoice() { }

        /// <summary>Lloji i faturës (me, pa para në dorë)</summary>
        [Required]
        public Enums.InvoiceType TypeOfInv { get; set; }

        public bool TypeOfSelfIssSpecified { get; private set; }
        private SelfIss _typeOfSelfIss;
        /// <summary>Vendosur vetëm nëse është një vetë-faturim</summary>
        public SelfIss TypeOfSelfIss
        {
            get => _typeOfSelfIss;
            set
            {
                if (value.IsDefined())
                {
                    _typeOfSelfIss = value;
                    TypeOfSelfIssSpecified = true;
                }
            }
        }

        /// <summary> Lloji i faturës përfaqëson faturat me para në dorë ose pa para në dorë. </summary>
        [Required]
        public bool IsSimplifiedInv { get; set; }
        [Required]
        public DateTime IssueDateTime { get; set; }

        /// <summary>
        /// Numri i faturës i përbërë nga numri rendor, viti i lëshimit të faturës dhe kodi i TCR-së që ka lëshuar faturën, nëse
        /// fatura nuk është e barabartë me “NONCASH”. Numri rendor i faturës është një sekuencë, që i caktohet çdo fature
        /// të re, kështu që faturat të mund të numërohen.Sekuenca rivendoset në fillim të çdo viti.
        /// [0-9][1-9]{0,14}\/[0-9]{4}(\/[a-z]{2}[0-9]{3}[a-z]{2}[0-9]{3})?
        /// TypeOfInv nuk është e barabartë me NONCASH: 9934/2019/ab123ab123
        /// TypeOfInv është e barabartë me NONCASH: 9934/2019
        /// </summary>
        [Required]
        public string InvNum
        {
            get
            {
                var year = IssueDateTime.Year;
                if (TypeOfInv == Enums.InvoiceType.NONCASH)
                    return $"{InvOrdNum}/{year}";
                else
                    return $"{InvOrdNum}/{year}/{TCRCode}";
            }
        }
        /// <summary>
        /// Numri rendor i faturës. Numri rendor i faturës është një sekuencë, që i caktohet çdo fature të re, kështu që faturat
        /// të mund të numërohen.Sekuenca rivendoset në fillim të çdo viti.
        /// </summary>
        [Required]
        public int InvOrdNum { get; set; }
        public bool IsIssuerInVAT { get; set; }
        public SupplyDateOrPeriod SupplyDateOrPeriod { get; set; }
        /// <summary>
        /// Referenca në NSLF (IIC) e faturës origjinale. 
        /// Vendoset vetëm nëse kjo është një faturë korrigjuese e faturës origjinale që duhet të ndryshohet.
        /// </summary>
        public CorrectiveInvoice CorrectiveInv { get; set; }
        [Required, MinLength(1), MaxLength(10)]
        public PayMethod[] PayMethods { get; set; }
        public Currency Currency { get; set; }
        [Required]
        public Seller Seller { get; set; }
        public Buyer Buyer { get; set; }
        /// <summary> Lista e artikujve. </summary>
        [Required, MinLength(1), MaxLength(1000)]
        public InvoiceItem[] Items { get; set; }
        /// <summary>
        /// Elementi XML që përfaqëson listën e artikujve të grumbulluar për të njëjtën normë TVSH-je ose përjashtim nga TVSH-ja
        /// </summary>
        public SameTax[] SameTaxes { get; set; }
        public ConsTax[] ConsTaxes { get; set; }
        [MaxLength(20)]
        public Fee[] Fees { get; set; }
        public SumInvIICRef[] SumInvIICRefs { get; set; }
        public BadDebtInv BadDebtInv { get; set; }
        
        /// <summary>
        /// Kodi i pajisjes që lëshon faturën.
        /// Modeli: [a-z]{2}[0-9]{3}[a-z]{2}[0-9]{3} .
        /// Shembull: ab123ab123 .
        /// </summary>
        public string TCRCode { get; set; }

        public bool TaxFreeAmtSpecified { get; private set; } = false;
        private decimal _taxFreeAmt;
        public decimal TaxFreeAmt { 
            get => _taxFreeAmt;
            set
            {
                _taxFreeAmt = value;
                TaxFreeAmtSpecified = true;
            }
        }

        public bool MarkUpAmtSpecified { get; private set; }
        private decimal _markUpAmt;
        /// <summary>
        /// Shuma totale që i përket procedurës së veçantë të skemës së marzhit në faturë si numër dhjetor (shuma e tatueshme). 
        /// Marzhi për mallrat e përdorura, veprat e artit, koleksionet ose antikuaret.
        /// </summary>
        public decimal MarkUpAmt { 
            get => _markUpAmt;
            set
            {
                _markUpAmt = value;
                MarkUpAmtSpecified = true;
            }
        }

        public bool GoodsExAmtSpecified { get; private set; } = false;
        private decimal _goodsExAmt;
        /// <summary>
        /// Çmimi total i furnizimit të mallrave të eksportuara. Nuk ka TVSH në faturë.
        /// </summary>
        public decimal GoodsExAmt { 
            get => _goodsExAmt;
            set
            {
                _goodsExAmt = value;
                GoodsExAmtSpecified = true;
            } 
        }

        /// <summary>Çmimi total i faturës pa TVSH</summary>
        [Required]
        public decimal TotPriceWoVAT { get; set; }

        public bool TotVATAmtSpecified { get; private set; } = false;
        private decimal _totVATAmt;
        /// <summary>Shuma totale e TVSH-së së faturës</summary>
        public decimal TotVATAmt { 
            get => _totVATAmt;
            set
            {
                _totVATAmt = value;
                TotVATAmtSpecified = true;
            }
        }

        /// <summary>Çmimi total i të gjithë artikujve përfshirë tatimet dhe zbritjet</summary>
        [Required]
        public decimal TotPrice => Items.Sum(item => item.PA);

        [Required]
        public string OperatorCode { get; set; }
        /// <summary>
        /// Kodi i vendit të ushtrimit të veprimtarisë së biznesit në të cilin është lëshuar fatura.
        /// Gjatësia 10 karaktere
        /// [a-z]{2}[0-9]{3}[a-z]{2}[0-9]{3}
        /// Shembull ab123ab123
        /// </summary>
        [Required]
        public string BusinUnitCode { get; set; }
        /// <summary>
        /// Kodi i softuerit të përdorur për lëshimin e faturës.
        /// [a-z]{2}[0-9]{3}[a-z]{2}[0-9]{3}
        /// Shembull ab123ab123
        /// </summary>
        public string SoftCode { get; set; }
        public string ImpCustDecNum { get; set; }
        [Required]
        public string IIC { get; set; }
        [Required]
        public string IICSignature { get; set; }
        /// <summary>
        /// Nëse është e vërtetë, blerësi është i detyruar të paguajë TVSH-në.
        /// </summary>
        public bool IsReverseCharge { get; set; }

        public bool PayDeadlineSpecified { get; private set; } = false;
        private DateTime _payDeadline;
        public DateTime PayDeadline { 
            get => _payDeadline;
            set
            {
                _payDeadline = value;
                PayDeadlineSpecified = true;
            } 
        }

        public string VerifyUrl { get; set; }

        private static void GenerateIIC(Invoice invoice)
        {
            var iicInput = CreateIICInput(invoice);
            if (iicInput == null)
                return;
            invoice.IIC = FiscalizationSigner.GenerateIIC(iicInput);
            invoice.IICSignature = FiscalizationSigner.SignIICSignature(iicInput);
        }


        public static string CreateIICInput(Invoice invoice)
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
            iicInput += "|" + FiscalizationService.GetDatetimeISO8601(invoice.IssueDateTime);

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

        public static string GenerateVerifyURL(Invoice invoice)
        {
            if (invoice.InvNum is null || invoice.Seller is null)
                return null;

            // This is QR Code
            string baseUrl = @"https://efiskalizimi-app-test.tatime.gov.al/invoice-check/#/verify?";

            baseUrl += "iic=" + invoice.IIC + "&";

            baseUrl += "tin=" + invoice.Seller.IDNum + "&";

            baseUrl += "crtd=" + FiscalizationService.GetDatetimeISO8601(invoice.IssueDateTime) + "&";

            baseUrl += "ord=" + Regex.Match(invoice.InvNum, @"\A([0-9]{0,10})", RegexOptions.Singleline).Value + "&";

            baseUrl += "bu=" + invoice.BusinUnitCode + "&";

            baseUrl += "cr=" + invoice.TCRCode + "&";

            baseUrl += "sw=" + invoice.SoftCode + "&";

            baseUrl += "prc=" + invoice.TotPrice.ToString("F", CultureInfo.InvariantCulture);

            return baseUrl;
        }


    }

}
