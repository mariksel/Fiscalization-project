using EnumsNET;
using Fiscalization.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class Country
    {
        /// <summary>
        /// Buyer/Seller’s Country Code
        /// If no tax representative is specified, this is the country where VAT is required. 
        /// Lists of valid states are registered with the ISO 3166-1 maintenance agency, 
        /// "Country Name and Subdivision Codes".
        /// </summary>
        public CountryCode IdentificationCode { get; set; }

        public CountryType ToCountryType()
        {
            return new CountryType
            {
                IdentificationCode = IdentificationCode.AsString(EnumFormat.EnumMemberValue)
            };
        }
    }
}
