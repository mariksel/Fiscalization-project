using FiscalizationService.SOAP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Fiscalization.Models
{
    public class Invoice : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public Invoice()
        {
            PropertyChanged += (obj, args) =>
            {
                switch (args.PropertyName)
                {
                    case nameof(IssueDateTime):
                    case nameof(InvNum):
                    case nameof(BusinUnitCode):
                    case nameof(TCRCode):
                    case nameof(SoftCode):
                    case nameof(TotPrice):
                    case nameof(Seller):
                        GenerateIIC();
                        break;
                }

            };

            PropertyChanged += (obj, args) =>
            {
                switch (args.PropertyName)
                {
                    case nameof(Seller):
                        Seller.PropertyChanged += (obj2, args2) =>
                        {
                            switch (args2.PropertyName)
                            {
                                case nameof(Seller.IDNum):
                                    GenerateIIC();
                                    GenerateVerifyURL();
                                    break;
                            }

                        };
                        GenerateVerifyURL();
                        break;
                    case nameof(IIC):
                    case nameof(IssueDateTime):
                    case nameof(InvNum):
                    case nameof(BusinUnitCode):
                    case nameof(TCRCode):
                    case nameof(SoftCode):
                    case nameof(TotPrice):
                        GenerateVerifyURL();
                        break;
                }

            };
           

        }

        public string _UUID = Guid.NewGuid().ToString();
        public string UUID
        {
            get => _UUID;
            set
            {
                _UUID = value;
                RaisePropertyChanged(nameof(UUID));
            }
        }

        private SupplyDateOrPeriodType supplyDateOrPeriod;
        public SupplyDateOrPeriodType SupplyDateOrPeriod
        {
            get => supplyDateOrPeriod;
            set
            {
                supplyDateOrPeriod = value;
                RaisePropertyChanged(nameof(SupplyDateOrPeriod));
            }
        }
        private CorrectiveInvType correctiveInv;
        public CorrectiveInvType CorrectiveInv
        {
            get => correctiveInv;
            set
            {
                correctiveInv = value;
                RaisePropertyChanged(nameof(CorrectiveInv));
            }
        }
        private PayMethodType[] payMethods;
        public PayMethodType[] PayMethods
        {
            get => payMethods;
            set
            {
                payMethods = value;
                RaisePropertyChanged(nameof(PayMethods));
            }
        }
        private CurrencyType currency;
        public CurrencyType Currency
        {
            get => currency;
            set
            {
                currency = value;
                RaisePropertyChanged(nameof(Currency));
            }
        }

        private Seller seller;
        public Seller Seller {
            get => seller;
            set
            {
                seller = value;
                RaisePropertyChanged(nameof(Seller));
            }
        }
        private BuyerType buyer;
        public BuyerType Buyer
        {
            get => buyer;
            set
            {
                buyer = value;
                RaisePropertyChanged(nameof(Buyer));
            }
        }
        private InvoiceItem[] items;
        /// <summary>
        /// Lista e artikujve.
        /// </summary>
        public InvoiceItem[] Items
        {
            get => items;
            set
            {
                items = value;
                RaisePropertyChanged(nameof(Items));
            }
        }
        private SameTaxType[] sameTaxes;
        public SameTaxType[] SameTaxes
        {
            get => sameTaxes;
            set
            {
                sameTaxes = value;
                RaisePropertyChanged(nameof(SameTaxes));
            }
        }
        private ConsTaxType[] consTaxes;
        public ConsTaxType[] ConsTaxes
        {
            get => consTaxes;
            set
            {
                consTaxes = value;
                RaisePropertyChanged(nameof(ConsTaxes));
            }
        }
        private FeeType[] fees;
        public FeeType[] Fees
        {
            get => fees;
            set
            {
                fees = value;
                RaisePropertyChanged(nameof(Fees));
            }
        }
        private SumInvIICRefType[] sumInvIICRefs;
        public SumInvIICRefType[] SumInvIICRefs
        {
            get => sumInvIICRefs;
            set
            {
                sumInvIICRefs = value;
                RaisePropertyChanged(nameof(SumInvIICRefs));
            }
        }
        private BadDebtInvType badDebtInv;
        public BadDebtInvType BadDebtInv
        {
            get => badDebtInv;
            set
            {
                badDebtInv = value;
                RaisePropertyChanged(nameof(BadDebtInv));
            }
        }
        private InvoiceSType typeOfInv;
        /// <summary>
        /// Lloji i faturës përfaqëson faturat me para në dorë ose pa para në dorë.
        /// </summary>
        public InvoiceSType TypeOfInv
        {
            get => typeOfInv;
            set
            {
                typeOfInv = value;
                RaisePropertyChanged(nameof(TypeOfInv));
            }
        }
        private bool isSimplifiedInv;
        public bool IsSimplifiedInv
        {
            get => isSimplifiedInv;
            set
            {
                isSimplifiedInv = value;
                RaisePropertyChanged(nameof(IsSimplifiedInv));
            }
        }
        private SelfIssSType typeOfSelfIss;
        public SelfIssSType TypeOfSelfIss
        {
            get => typeOfSelfIss;
            set
            {
                typeOfSelfIss = value;
                RaisePropertyChanged(nameof(TypeOfSelfIss));
            }
        }
        private bool typeOfSelfIssSpecified;
        public bool TypeOfSelfIssSpecified
        {
            get => typeOfSelfIssSpecified;
            set
            {
                typeOfSelfIssSpecified = value;
                RaisePropertyChanged(nameof(TypeOfSelfIssSpecified));
            }
        }
        private DateTime issueDateTime = FiscalizationService.GetDateTimeNow();
        public DateTime IssueDateTime
        {
            get => issueDateTime;
            set
            {
                issueDateTime = value;
                RaisePropertyChanged(nameof(IssueDateTime));
            }
        }
        private string invNum;
        /// <summary>
        /// Numri i faturës i përbërë nga numri rendor, viti i lëshimit të faturës dhe kodi i TCR-së që ka lëshuar faturën, nëse
        /// fatura nuk është e barabartë me “NONCASH”. Numri rendor i faturës është një sekuencë, që i caktohet çdo fature
        /// të re, kështu që faturat të mund të numërohen.Sekuenca rivendoset në fillim të çdo viti.
        /// [0-9][1-9]{0,14}\/[0-9]{4}(\/[a-z]{2}[0-9]{3}[a-z]{2}[0-9]{3})?
        /// TypeOfInv nuk është e barabartë me NONCASH: 9934/2019/ab123ab123
        /// TypeOfInv është e barabartë me NONCASH: 9934/2019
        /// </summary>
        public string InvNum
        {
            get => invNum;
            set
            {
                invNum = value;
                RaisePropertyChanged(nameof(InvNum));
            }
        }
        private int invOrdNum;
        /// <summary>
        /// Numri rendor i faturës. Numri rendor i faturës është një sekuencë, që i caktohet çdo fature të re, kështu që faturat
        /// të mund të numërohen.Sekuenca rivendoset në fillim të çdo viti.
        /// </summary>
        public int InvOrdNum
        {
            get => invOrdNum;
            set
            {
                invOrdNum = value;
                RaisePropertyChanged(nameof(InvOrdNum));
            }
        }
        private string _TCRCode;
        /// <summary>
        /// Kodi i pajisjes që lëshon faturën.
        /// Modeli: [a-z]{2}[0-9]{3}[a-z]{2}[0-9]{3} .
        /// Shembull: ab123ab123 .
        /// </summary>
        public string TCRCode
        {
            get => _TCRCode;
            set
            {
                _TCRCode = value;
                RaisePropertyChanged(nameof(TCRCode));
            }
        }
        private bool isIssuerInVAT;
        public bool IsIssuerInVAT
        {
            get => isIssuerInVAT;
            set
            {
                isIssuerInVAT = value;
                RaisePropertyChanged(nameof(IsIssuerInVAT));
            }
        }
        private decimal taxFreeAmt;
        public decimal TaxFreeAmt
        {
            get => taxFreeAmt;
            set
            {
                taxFreeAmt = value;
                RaisePropertyChanged(nameof(TaxFreeAmt));
            }
        }
        private bool taxFreeAmtSpecified;
        public bool TaxFreeAmtSpecified
        {
            get => taxFreeAmtSpecified;
            set
            {
                taxFreeAmtSpecified = value;
                RaisePropertyChanged(nameof(TaxFreeAmtSpecified));
            }
        }
        private decimal markUpAmt;
        public decimal MarkUpAmt
        {
            get => markUpAmt;
            set
            {
                markUpAmt = value;
                RaisePropertyChanged(nameof(MarkUpAmt));
            }
        }
        private bool markUpAmtSpecified;
        public bool MarkUpAmtSpecified
        {
            get => markUpAmtSpecified;
            set
            {
                markUpAmtSpecified = value;
                RaisePropertyChanged(nameof(MarkUpAmtSpecified));
            }
        }
        private decimal goodsExAmt;
        public decimal GoodsExAmt
        {
            get => goodsExAmt;
            set
            {
                goodsExAmt = value;
                RaisePropertyChanged(nameof(GoodsExAmt));
            }
        }
        private bool goodsExAmtSpecified;
        public bool GoodsExAmtSpecified
        {
            get => goodsExAmtSpecified;
            set
            {
                goodsExAmtSpecified = value;
                RaisePropertyChanged(nameof(GoodsExAmtSpecified));
            }
        }
        private decimal totPriceWoVAT;
        public decimal TotPriceWoVAT
        {
            get => totPriceWoVAT;
            set
            {
                totPriceWoVAT = value;
                RaisePropertyChanged(nameof(TotPriceWoVAT));
            }
        }
        private decimal totVATAmt;
        public decimal TotVATAmt
        {
            get => totVATAmt;
            set
            {
                totVATAmt = value;
                RaisePropertyChanged(nameof(TotVATAmt));
            }
        }
        private bool totVATAmtSpecified;
        public bool TotVATAmtSpecified
        {
            get => totVATAmtSpecified;
            set
            {
                totVATAmtSpecified = value;
                RaisePropertyChanged(nameof(TotVATAmtSpecified));
            }
        }
        private decimal totPrice;
        public decimal TotPrice
        {
            get => totPrice;
            set
            {
                totPrice = value;
                RaisePropertyChanged(nameof(TotPrice));
            }
        }
        private string operatorCode;
        public string OperatorCode
        {
            get => operatorCode;
            set
            {
                operatorCode = value;
                RaisePropertyChanged(nameof(OperatorCode));
            }
        }
        private string businUnitCode;
        /// <summary>
        /// Kodi i vendit të ushtrimit të veprimtarisë së biznesit në të cilin është lëshuar fatura.
        /// Gjatësia 10 karaktere
        /// [a-z]{2}[0-9]{3}[a-z]{2}[0-9]{3}
        /// Shembull ab123ab123
        /// </summary>
        public string BusinUnitCode
        {
            get => businUnitCode;
            set
            {
                businUnitCode = value;
                RaisePropertyChanged(nameof(BusinUnitCode));
            }
        }
        private string softCode;
        /// <summary>
        /// Kodi i softuerit të përdorur për lëshimin e faturës.
        /// [a-z]{2}[0-9]{3}[a-z]{2}[0-9]{3}
        /// Shembull ab123ab123
        /// </summary>
        public string SoftCode
        {
            get => softCode;
            set
            {
                softCode = value;
                RaisePropertyChanged(nameof(SoftCode));
            }
        }
        private string impCustDecNum;
        public string ImpCustDecNum
        {
            get => impCustDecNum;
            set
            {
                impCustDecNum = value;
                RaisePropertyChanged(nameof(ImpCustDecNum));
            }
        }
        private string _IIC;
        public string IIC
        {
            get => _IIC;
            private set
            {
                _IIC = value;
                RaisePropertyChanged(nameof(IIC));
            }
        }
        private string _IICSignature;
        public string IICSignature
        {
            get => _IICSignature;
            private set
            {
                _IICSignature = value;
                RaisePropertyChanged(nameof(IICSignature));
            }
        }
        private bool isReverseCharge;
        public bool IsReverseCharge
        {
            get => isReverseCharge;
            set
            {
                isReverseCharge = value;
                RaisePropertyChanged(nameof(IsReverseCharge));
            }
        }
        private DateTime payDeadline;
        public DateTime PayDeadline
        {
            get => payDeadline;
            set
            {
                payDeadline = value;
                RaisePropertyChanged(nameof(PayDeadline));
            }
        }
        private bool payDeadlineSpecified;
        public bool PayDeadlineSpecified
        {
            get => payDeadlineSpecified;
            set
            {
                payDeadlineSpecified = value;
                RaisePropertyChanged(nameof(PayDeadlineSpecified));
            }
        }

        private string verifyUrl;
        public string VerifyUrl
        {
            get => verifyUrl;
            private set
            {
                verifyUrl = value;
                RaisePropertyChanged(nameof(VerifyUrl));
            }
        }

        private void GenerateIIC()
        {
            var iicInput = CreateIICInput();
            if (iicInput == null)
                return;
            IIC = FiscalizationSigner.GenerateIIC(iicInput);
            IICSignature = FiscalizationSigner.SignIICSignature(iicInput);
        }
        public string CreateIICInput()
        {
            // Issuer NUIS(Chapter 3.7.1.51)
            // Date and time created(Chapter 3.7.1.8)
            // Invoice number(Chapter 3.7.1.10)
            // Business unit code(Chapter 3.7.1.21)
            // TCR code(Chapter 3.7.1.12)
            // Software code(Chapter 3.7.1.22)86 | 118
            // Total price(Chapter 3.7.1.19)

            if (InvNum is null || Seller is null)
                return null;

            // Issuer NUIS
            string iicInput = Seller.IDNum;

            // dateTimeCreated
            iicInput += "|" + FiscalizationService.GetDatetimeISO8601(IssueDateTime);

            // invoiceNumber
            iicInput += "|" + Regex.Match(InvNum, @"\A([0-9]{0,10})", RegexOptions.Singleline).Value;

            // busiUnitCode
            iicInput += "|" + BusinUnitCode;

            // tcrCode
            iicInput += "|" + TCRCode;

            // softCode
            iicInput += "|" + SoftCode;

            // totalPrice
            iicInput += "|" + TotPrice;

            return iicInput;
        }

        public string GenerateVerifyURL()
        {
            if (InvNum is null || Seller is null)
                return null;

            // This is QR Code
            string baseUrl = @"https://efiskalizimi-app-test.tatime.gov.al/invoice-check/#/verify?";

            baseUrl += "iic=" + IIC + "&";

            baseUrl += "tin=" + Seller.IDNum + "&";

            baseUrl += "crtd=" + FiscalizationService.GetDatetimeISO8601(IssueDateTime) + "&";

            baseUrl += "ord=" + Regex.Match(InvNum, @"\A([0-9]{0,10})", RegexOptions.Singleline).Value + "&";

            baseUrl += "bu=" + BusinUnitCode + "&";

            baseUrl += "cr=" + TCRCode + "&";

            baseUrl += "sw=" + SoftCode + "&";

            baseUrl += "prc=" + TotPrice.ToString("F", CultureInfo.InvariantCulture);

            return baseUrl;
        }


    }

}
