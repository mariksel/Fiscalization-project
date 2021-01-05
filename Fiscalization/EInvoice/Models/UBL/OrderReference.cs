using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class OrderReference
    {
        /// <summary>
        /// Purchase Order Reference
        /// Identifier of the specified Purchase Order, issued by the Buyer.
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Sales Order Reference
        /// The Sales Order Reference Identifier issued by the Seller.
        /// </summary>
        public string SalesOrderID { get; set; }

        public OrderReferenceType ToOrderReferenceType()
        {
            return new OrderReferenceType
            {
                ID = ID,
                SalesOrderID = SalesOrderID
            };
        }
    }
}
