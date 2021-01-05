using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.Models.UBL
{
    public class PostalAddress
    {
        /// <summary>
        /// Main address field.
        /// Usually street name and number or post office.
        /// </summary>
        public string StreetName { get; set; }
        /// <summary>
        /// An additional address field that can be used to provide further details that complement the main address field.
        /// </summary>
        public string AdditionalStreetName { get; set; }
        public AddressLine AddressLine { get; set; }
        /// <summary>
        /// Buyer/Seller's Postal Code
        /// </summary>
        public string PostalZone { get; set; }
        /// <summary>
        /// City of Buyer/Seller
        /// </summary>
        public string CityName { get; set; }
        /// <summary>
        /// Buyer/Seller’s County
        /// Such as regions, counties, states, provinces, etc.
        /// </summary>
        public string CountrySubentity { get; set; }
        public Country Country { get; set; }
    }
}
