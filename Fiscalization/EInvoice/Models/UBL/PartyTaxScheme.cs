using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class PartyTaxScheme
    {
        /// <summary>
        /// Seller VAT Identifier
        /// VAT number with country code prefix. 
        /// A supplier registered as a taxpayer must include his VAT number, unless he or she uses a tax representative.
        /// With cac:Taxscheme/cbc:ID="VAT"
        /// </summary>
        public string CompanyID { get; set; }
        public string ID = "VAT";

        public PartyTaxSchemeType ToPartyTaxSchemeType()
        {
            return new PartyTaxSchemeType
            {
                CompanyID = CompanyID,
                TaxScheme = new TaxSchemeType
                {
                    ID = ID
                }
            };
        }
    }
}
