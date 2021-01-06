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
    public class Item
    {
        public Item(InvoiceItem item)
        {
            Name = item.N;
            Description = item.Description;
            SellersItemIdentification = item.BarCode;
            ClassifiedTaxCategory = new TaxCategory
            {
                Percent = (int)item.VR
            };

            switch (item.EX)
            {
                case ExemptFromVAT.TYPE_1:
                case ExemptFromVAT.TYPE_2:
                    ClassifiedTaxCategory.ID = Enums.VATCategoryCode.O;
                    break;
                case ExemptFromVAT.TAX_FREE:
                case ExemptFromVAT.MARGIN_SCHEME:
                    ClassifiedTaxCategory.ID = Enums.VATCategoryCode.Z;
                    break;
                case ExemptFromVAT.EXPORT_OF_GOODS:
                    ClassifiedTaxCategory.ID = Enums.VATCategoryCode.G;
                    break;
                default:
                    ClassifiedTaxCategory.ID = Enums.VATCategoryCode.S;
                    break;

            }
            if (!item.EXSpecified)
                ClassifiedTaxCategory.ID = Enums.VATCategoryCode.S;
            else
                ClassifiedTaxCategory.TaxExemptionReason = item.EX.AsString(EnumFormat.Description);

        }
        /// <summary>
        /// VAT INFORMATION FOR INVOICE ITEMS
        /// </summary>
        [Required]
        public TaxCategory ClassifiedTaxCategory { get; }
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

        public ItemType ToItemType()
        {
            return new ItemType
            {
                ClassifiedTaxCategory = new List<TaxCategoryType> { ClassifiedTaxCategory.ToTaxCategoryType() },
                Name = Name,
                Description = new List<UblSharp.UnqualifiedDataTypes.TextType> { Description },
                SellersItemIdentification = BuyersItemIdentification != null ? new ItemIdentificationType { ID = SellersItemIdentification?.ToIdentifierType() } : null,
                BuyersItemIdentification = BuyersItemIdentification != null ? new ItemIdentificationType { ID = BuyersItemIdentification?.ToIdentifierType() } : null,
                StandardItemIdentification = StandardItemIdentification != null ?  new ItemIdentificationType { ID = StandardItemIdentification?.ToIdentifierType() } : null,
                CommodityClassification = new List<CommodityClassificationType> { CommodityClassification?.ToCommodityClassificationType() },
                OriginCountry = OriginCountry?.ToCountryType(),
                AdditionalItemProperty = new List<ItemPropertyType> { AdditionalItemProperty?.ToItemPropertyType() }
            };
        }
    }
}
