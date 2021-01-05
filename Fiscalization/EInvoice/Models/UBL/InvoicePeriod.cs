using EInvoice.Enums;
using EnumsNET;
using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;
using UblSharp.UnqualifiedDataTypes;

namespace EInvoice.Models.UBL
{
    public class InvoicePeriod
    {
        /// <summary>
        /// Code for VAT Effective Date.
        /// The code for the date when VAT becomes effective for the Seller and Buyer.
        /// The code should distinguish the following entries from UNTDID 2005 [6]:
        /// 3- Date of invoice
        /// 35- Delivery date, actual
        /// 432 Payment Date
        /// The date code on which the VAT comes into effect is used 
        /// if the date on which the VAT becomes effective is not known when issuing the invoice.
        /// The use of BT-8 and BT-7 is mutually exclusive.
        /// </summary>
        public InvoicePeriodCode DescriptionCode { get; set; }
        /// <summary>
        /// Initial delivery date of goods or services
        /// [yyyy-MM-dd]
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Date of delivery of goods or execution of services.
        /// [yyyy-MM-dd]
        /// </summary>
        public DateTime EndDate { get; set; }

        public PeriodType ToPeriodType()
        {
            var model = new PeriodType
            {
                DescriptionCode = new List<CodeType> {
                    DescriptionCode.AsString(EnumFormat.Description)
                },
                StartDate = StartDate.ToString("yyyy-MM-dd"),
                EndDate = EndDate.ToString("yyyy-MM-dd"),
            };
            return model;
        }
    }
}
