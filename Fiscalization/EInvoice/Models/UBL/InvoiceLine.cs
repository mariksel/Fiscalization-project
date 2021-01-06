using EnumsNET;
using Fiscalization.Enums;
using Fiscalization.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using UblSharp.CommonAggregateComponents;
using UblSharp.UnqualifiedDataTypes;

namespace EInvoice.Models.UBL
{
    /// <summary>
    /// BG-25 Invoice item
    /// </summary>
    public class InvoiceLine
    {
        public InvoiceLine(InvoiceItem item, CurrencyCode currencyCode)
        {
            ID = new Identifier{
                schemeID = "0160",
                Value = item.BarCode
            };
            Item = new Item(item);
            Note = item.Note;
            InvoicedQuantity = new Quantity{
                unitCode = item.UnitCode,
                Value = (decimal)item.Q
            };
            LineExtensionAmount = new Amount {
                currencyID = currencyCode,
                Value = item.PB
            };
            Price = new Price((decimal)item.Q, item.PA, item.UnitCode, currencyCode);
        }
        /// <summary>
        /// A unique identifier for a single invoice item.
        /// </summary>
        public Identifier ID { get; set; }
        /// <summary>
        /// A text note that gives unstructured information relevant to an invoice item.
        /// </summary>
        public string Note { get; set; }
        /// <summary>
        /// With cbc:DocumentTypeCode="130"
        /// </summary>
        public DocumentReference DocumentReference { get; set; }
        /// <summary>
        /// The quantity of items (goods or services) that are charged as invoice items.
        /// Cardinality 1..1
        /// </summary>
        [Required]
        public Quantity InvoicedQuantity { get; set; }
        /// <summary>
        /// The total amounts for invoice items
        /// The amount is "net" without VAT, Including item-level discounts and Charges, as well as other relevant taxes.
        /// </summary>
        public Amount LineExtensionAmount { get; set; }
        public OrderLineReference OrderLineReference { get; set; }
        /// <summary>
        /// Buyer Accounting Reference on Item(Cost Center)
        /// The textual value that determines where the relevant data will be posted to a Buyer's financial accounts.
        /// If necessary, the Buyer will provide this Reference to the Seller before the invoice is issued.
        /// </summary>
        public string AccountingCharge { get; set; }
        public InvoicePeriod InvoicePeriod { get; set; }
        public AllowanceCharge AllowanceCharge { get; set; }
        /// <summary>
        /// PRICE DETAILS
        /// Cardinality 1..1
        /// </summary>
        [Required]
        public Price Price { get; set; }
        public Item Item { get; set; }

        public InvoiceLineType ToInvoiceLineType()
        {
            return new InvoiceLineType
            {
                ID = ID.ToIdentifierType(),
                Note = new List<TextType> { Note },
                DocumentReference = new List<DocumentReferenceType> { DocumentReference?.ToDocumentReferenceType() },
                InvoicedQuantity = InvoicedQuantity.ToQuantityType(),
                LineExtensionAmount = LineExtensionAmount.ToAmountType(),
                OrderLineReference = new List<OrderLineReferenceType> { OrderLineReference?.ToOrderLineReferenceType() },
                AccountingCost = AccountingCharge,
                InvoicePeriod = new List<PeriodType> { InvoicePeriod?.ToPeriodType() },
                AllowanceCharge = new List<AllowanceChargeType> { AllowanceCharge?.ToAllowanceChargeType()},
                Price = Price.ToPriceType(),
                Item = Item.ToItemType(),
            };
        }
    }
}
