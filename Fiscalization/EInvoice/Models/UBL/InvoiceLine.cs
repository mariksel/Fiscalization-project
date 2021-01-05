using Fiscalization.Models;
using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    /// <summary>
    /// BG-25 Invoice item
    /// </summary>
    public class InvoiceLine
    {
        public InvoiceLine(InvoiceItem item)
        {
            ID = item.Id;
            Item = new Item(item);
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
        /// </summary>
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
        /// </summary>
        public Price Price { get; set; }
        public Item Item { get; set; }

        public InvoiceLineType ToInvoiceLineType()
        {
            return new InvoiceLineType
            {

            };
        }
    }
}
