using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class CommodityClassification
    {
        public Code ItemClassificationCode { get; set; }

        public CommodityClassificationType ToCommodityClassificationType()
        {
            return new CommodityClassificationType
            {
                ItemClassificationCode = ItemClassificationCode.ToCodeType()
            };
        }
    }
}
