using EInvoice.Enums;
using EnumsNET;
using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;
using UblSharp.UnqualifiedDataTypes;

namespace EInvoice.Models.UBL
{
    public class TaxCategory
    {
        /// <summary>
        /// VAT Category Code of Document-level Discount
        /// The following entries are applied UNTDID 5305 [6]:
        /// - Standard rate
        /// - Zero rated goods
        /// - Exempt from VAT / IGIC / IPSI
        /// - VAT Reverse charge / IGIC / IPSI
        /// - VAT exempt for intra community supply of goods / IGIC / IPSI
        /// - Free export item, tax not charged VAT / IGIC / IPSI because of export outside the EU
        /// - Services outside scope of tax. (Non-taxable, Sales are not subject to VAT / IGIC / IPSI
        /// With cbc:ChargeIndicator="false"
        /// With cac:TaxScheme/cbc:ID="VAT"
        /// </summary>
        public VATCategoryCode ID { get; set; }
        /// <summary>
        /// VAT Rate of Document-level Discount
        /// The VAT rate is shown as the percentage which applies to a document-level discount.
        /// </summary>
        public int Percent { get; set; }
        
        /// <summary>
        /// A textual statement of reasons why the amount is exempt from VAT or why VAT has not been charged
        /// </summary>
        public string TaxExemptionReason { get; set; }
        /// <summary>
        /// Encoded statement of reasons why the amount is exempt from VAT.
        /// List of Codes issued and maintained by the Connecting Europe Facility (CEF)
        /// </summary>
        public string TaxExemptionReasonCode { get; set; }
        public TaxScheme TaxScheme = new TaxScheme
        {
            ID = new Identifier { Value = "VAT" }
        };

        public TaxCategoryType ToTaxCategoryType()
        {
            return new TaxCategoryType
            {
                ID = ID.AsString(),
                Percent = Percent,
                TaxExemptionReason = new List<TextType> { TaxExemptionReason },
                TaxExemptionReasonCode = TaxExemptionReasonCode,
                TaxScheme = TaxScheme.ToTaxSchemeType()
            };
        }
    }
}
