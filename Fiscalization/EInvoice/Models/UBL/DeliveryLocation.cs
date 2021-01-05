using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.Models.UBL
{
    public class DeliveryLocation
    {
        /// <summary>
        /// Delivery Location Identifier
        /// The place where the goods and services are delivered to.
        /// If no Scheme is specified, it must be known to the Buyer and Seller.
        /// </summary>
        public Identifier ID { get; set; }
        public PostalAddress Address { get; set; }
    }
}
