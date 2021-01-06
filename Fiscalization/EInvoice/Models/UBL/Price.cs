using Fiscalization.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class Price
    {
        public Price(decimal quantity, decimal grossPrice, UnitCode unitCode, CurrencyCode currencyCode)
        {
            BaseQuantity = new Quantity
            {
                unitCode = unitCode,
                Value = quantity,
            };

            PriceAmount = new Amount
            {
                currencyID = currencyCode,
                Value = grossPrice
            };

        }
        public Amount PriceAmount { get; set; }
        public AllowanceCharge AllowanceCharge { get; set; }
        public Quantity BaseQuantity { get; set; }

        public PriceType ToPriceType()
        {
            return new PriceType
            {
                PriceAmount = PriceAmount.ToAmountType(),
                AllowanceCharge = new List<AllowanceChargeType> { AllowanceCharge?.ToAllowanceChargeType() },
                BaseQuantity = BaseQuantity.ToQuantityType()
            };
        }
    }
}
