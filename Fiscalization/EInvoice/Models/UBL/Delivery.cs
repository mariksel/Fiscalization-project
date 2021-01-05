using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.Models.UBL
{
    /// <summary>
    /// BG-13 Delivery Information
    /// </summary>
    public class Delivery
    {
        /// <summary>
        /// Shipping on Behalf of a Party
        /// Used if delivery is to a customer different from the Buyer.v
        /// </summary>
        public DeliveryParty DeliveryParty { get; set; }
        public DeliveryLocation DeliveryLocation { get; set; }
        /// <summary>
        /// Date of execution or completion of delivery of goods or services.
        /// [yyyy-MM-dd]
        /// </summary>
        public DateTime ActualDeliveryDate { get; set; }
    }
}
