using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    /// <summary>
    /// BG-18 Payment card information
    /// </summary>
    public class CardAccount
    {
        /// <summary>
        /// The primary account number (PAN) used for payment.
        /// In accordance with card security payment standards, an invoice must never contain a full card number. 
        /// At present, the Security Standards Council of PCI has defined the following: 
        /// The first 6 digits and the last four digits represent the maximum number of digits to be displayed.
        /// XXXXXXXXXXXXX1234
        /// </summary>
        public string PrimaryAccountNumberID { get; set; }
        /// <summary>
        /// Card Holder's Name
        /// </summary>
        public string HolderName { get; set; }

        public CardAccountType ToCardAccountType()
        {
            return new CardAccountType
            {
                PrimaryAccountNumberID = PrimaryAccountNumberID,
                HolderName = HolderName
            };
        }
    }
}
