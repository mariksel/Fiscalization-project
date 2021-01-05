using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.Models.UBL
{
    public class Contact
    {
        /// <summary>
        /// A contact point for a legal person or a natural person.
        /// Such as the person's name, contact identification, department or office identification.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Buyer/Seller Contact Phone Number
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        /// Buyer/Seller's Contact E-mail Address
        /// </summary>
        public string ElectronicMail { get; set; }
    }
}
