using EInvoice.Enums;
using EnumsNET;
using Fiscalization.Enums;
using Fiscalization.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class UBLInvoice
    {
        /// <summary>
        /// Invoice number
        /// The required number in Article 226, paragraph 2 Of Directive 2006/112/EC [2], 
        /// which uniquely identifies an Invoice in the commercial context, timing, 
        /// operating systems and records of the Seller. 
        /// It can be based on one or more series of numbers that may include alphanumeric characters. 
        /// No identification scheme should be used.
        /// </summary>
        [Required]
        public string ID { get; set; }
        /// <summary>
        /// Invoice Issue Date. 
        /// yyyy-MM-dd
        /// Date when invoice was issued.
        /// </summary>
        public DateTime Issued { get; set; }
        /// <summary>
        /// The code that determines the functional type of the invoice
        /// Business invoices and approvals are defined according to entries in the UNTDID 1001 codebook [6].
        /// If applicable, other UNTDID 1001 [6] entries may also be used for specific invoices or approvals.
        /// </summary>
        public InvoiceTypeCode InvoiceTypeCode { get; set; }
        /// <summary>
        /// Invoice Type Code
        /// The currency in which all the invoice amounts are listed except the total amount of VAT in the accounting currency.
        /// Only one currency will be used on an invoice, except for the total amount of VAT in the accounting currency (BT-111) 
        /// in accordance with Article 230 of Directive 2006/112/EC on VAT.
        /// Lists of valid currencies are registered with ISO 4217 Maintenance Agency "Codes for representing currencies and funds”.
        /// </summary>
        public CurrencyCode DocumentCurrencyCode { get; set; }
        /// <summary>
        /// Invoice Currency Code
        /// Currency used for VAT calculation and reporting purposes accepted or required in the Seller's country.
        /// It is used in combination with the total amount of VAT in the accounting currency (BT-111) 
        /// when the currency code for VAT calculation differs from the invoice currency.
        /// Lists of valid currencies are registered with ISO 4217 Maintenance Agency, 
        /// "Codes for representing currencies and funds”. For more information, see Article 230 of Council Directive 2006/112/EC [2].
        /// </summary>
        public CurrencyCode TaxCurrencyCode { get; set; }
        /// <summary>
        /// VAT Date Effective [yyy-MM-dd]
        /// Date when VAT becomes applicable to the Seller and Buyer, 
        /// to the extent that this date may be determined and different 
        /// from the date of issue of the invoice in accordance with the VAT Directive.
        /// The date on which a tax becomes effective is usually the date of delivery of goods or services ("basic tax point"). There are some variations.
        /// For more information, see Article 226 (7) of Council Directive 2006/112/EC[2].
        /// This element is required if the date on which the VAT becomes effective differs from the date of issue of the invoice.
        /// The Buyer and Seller should both use the same date as the one provided by the Seller.
        /// </summary>
        public DateTime TaxPointDate { get; set; }
        /// <summary>
        /// It is used to indicate the start and end of the period to which an invoice relates. It is also called the delivery period.
        /// </summary>
        public InvoicePeriod InvoicePeriod { get; set; }
        /// <summary>
        /// Payment Due Date
        /// The payment due date reflects the due date of the net payment. For partial (installment) payments, the first net payment due date is stated. 
        /// Applicable descriptions of the more complex payment terms can be found in BT-20.
        /// </summary>
        public DateTime Dued { get; set; }
        /// <summary>
        /// Identifier assigned by the Buyer for internal routing purposes.
        /// This Identifier defines the Buyer (e.g. Contact ID, department, office id, project code), but is provided by the Seller in the invoice
        /// </summary>
        public string BuyerReference { get; set; }
        public ProjectReference ProjectReference { get; set; }
        public ContractDocumentReference ContractDocumentReference { get; set; }
        public OrderReference OrderReference { get; set; }
        public ReceiptDocumentReference ReceiptDocumentReference { get; set; }
        public DespatchDocumentReference DespatchDocumentReference { get; set; }
        public OriginatorDocumentReference OriginatorDocumentReference { get; set; }
        public DocumentReference AdditionalDocumentReference { get; set; }
        public InvoiceLine[] InvoiceLine { get; }
        /// <summary>
        /// The textual value that determines where the relevant data will be entered in the Buyer's financial accounts.
        /// </summary>
        public string AccountingCharge { get; set; }
        public PaymentTerms PaymentTerms { get; set; }

        /// <summary>
        /// Business Process Type
        /// Identifies the context of the business process in which the transaction occurs, 
        /// in order to allow the Buyer to process an invoice appropriately.
        /// </summary>
        public ProfileIDCode ProfileID { get; set; }
        /// <summary>
        /// Identification of specifications that contain the total set of semantic content rules, 
        /// cardinalities and business rules with which the information contained in the document instance is consistent.
        /// This identifies conformity or compliance with this document. 
        /// In accordance with your invoices, please indicate:urn:cen.eu:en16931:2017. 
        /// Invoices conforming to user specifications can identify the user specifications here.
        /// No identification scheme should be used.
        /// urn:cen.eu:en16931:2017#compliant#urn:akshi.al:2019:1.0
        /// urn:cen.eu:en16931:2017
        /// </summary>
        public string CustomizationID { get; set; } = "urn:cen.eu:en16931:2017";
        /// <summary>
        /// Reference to a previous invoice
        /// </summary>
        public BillingReference BillingReference { get; set; }
        public AccountingSupplierParty AccountingSupplierParty { get; set; }
        public AccountingCustomerParty AccountingCustomerParty { get; set; }
        public PaymentMeans PaymentMeans { get; set; }
        /// <summary>
        /// A set of business terms that provide discount information that applies to your entire account.
        /// </summary>
        public AllowanceCharge AllowanceCharge { get; set; }
        /// <summary>
        /// TOTAL AMOUNTS
        /// A set of business terms that provide information on the total monetary amount of the invoice.
        /// </summary>
        public LegalMonetaryTotal LegalMonetaryTotal { get; set; }
        public TaxTotal[] TaxTotal { get; set; }

        public UBLInvoice(Invoice invoice)
        {

            InvoiceLine = invoice.Items.Select(m =>
            {
                return new InvoiceLine
                {
                    ID = m.Id,

                };
            }).ToArray();
            LegalMonetaryTotal = new LegalMonetaryTotal
            {

            };
        }

        public UblSharp.InvoiceType ToInvoiceType()
        {
            var ublInvoiceType = new UblSharp.InvoiceType
            {
                ID = ID,
                IssueDate = Issued.ToString("yyyy-MM-dd"),
                InvoiceTypeCode = InvoiceTypeCode.AsString(EnumFormat.Description),
                DocumentCurrencyCode = DocumentCurrencyCode.AsString(EnumFormat.Name),
                TaxPointDate = TaxPointDate.ToString("yyyy-MM-dd"),
                InvoicePeriod = new List<PeriodType>{ InvoicePeriod.ToPeriodType() },
                DueDate = Dued.ToString("yyyy-MM-dd"),
                BuyerReference = BuyerReference,
                ProjectReference = new List<ProjectReferenceType>{ ProjectReference.ToProjectReferenceType() },
                ContractDocumentReference = new List<DocumentReferenceType>{ ContractDocumentReference.ToDocumentReferenceType() },
                OrderReference = OrderReference.ToOrderReferenceType(),
                ReceiptDocumentReference = new List<DocumentReferenceType> { ReceiptDocumentReference.ToDocumentReferenceType() },
                DespatchDocumentReference = new List<DocumentReferenceType> { DespatchDocumentReference.ToDocumentReferenceType() },
                OriginatorDocumentReference = new List<DocumentReferenceType> { OriginatorDocumentReference.ToDocumentReferenceType() },
                AdditionalDocumentReference = new List<DocumentReferenceType> { AdditionalDocumentReference.ToDocumentReferenceType() },
                InvoiceLine = InvoiceLine.Select(m => m.ToInvoiceLineType()).ToList(),
                AccountingCost = AccountingCharge,
                PaymentTerms = new List<PaymentTermsType> { PaymentTerms.ToPaymentTermsType() },
                ProfileID = ProfileID.AsString(),
                CustomizationID = CustomizationID,
                BillingReference = new List<BillingReferenceType> { BillingReference.ToBillingReferenceType() },
                AccountingSupplierParty = AccountingSupplierParty.ToSupplierPartyType(),
                AccountingCustomerParty = AccountingCustomerParty.ToSupplierPartyType(),
                PaymentMeans = new List<PaymentMeansType> { PaymentMeans.ToPaymentMeansType() },
                AllowanceCharge = new List<AllowanceChargeType> { AllowanceCharge.ToAllowanceChargeType() },
                LegalMonetaryTotal = LegalMonetaryTotal.ToMonetaryTotalType(),
                TaxTotal = TaxTotal.Select(m => m.ToTaxTotalType()).ToList()
            };
            return ublInvoiceType;
        }
    }
}
