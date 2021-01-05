using Fiscalization.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EInvoice.Models.UBL
{
    public class Item
    {
        public Item(InvoiceItem item)
        {
            Name = item.N;
            Description = item.Description;
            SellersItemIdentification = item.Id;
            ClassifiedTaxCategory = new TaxCategory
            {
                ID = Enums.VATCategoryCode.S,
                Percent
            };
        }
        /// <summary>
        /// VAT INFORMATION FOR INVOICE ITEMS
        /// </summary>
        [Required]
        public TaxCategory ClassifiedTaxCategory { get; set; }
        /// <summary>
        /// Product Name
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// The item description provides a more detailed description of the item and its features than the name of the item.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The identifier assigned to the item by the Seller.
        /// </summary>
        public Identifier SellersItemIdentification { get; set; }
        /// <summary>
        /// The identifier assigned to the item by the Buyer.
        /// </summary>
        public Identifier BuyersItemIdentification { get; set; }
        /// <summary>
        /// An item identifier based on a registered scheme.
        /// </summary>
        public Identifier StandardItemIdentification { get; set; }
        public CommodityClassification CommodityClassification { get; set; }
        public Country OriginCountry { get; set; }
        public ItemProperty AdditionalItemProperty { get; set; }
    }
}
