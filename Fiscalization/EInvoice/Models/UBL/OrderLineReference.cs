using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class OrderLineReference
    {
        public Identifier LineID { get; set; }
        public Identifier SalesOrderLineID { get; set; }
        public Identifier UUID { get; set; }
        //public CodeType LineStatusCode { get; set; }
        //public OrderReferenceType OrderReference { get; set; }

        public OrderLineReferenceType ToOrderLineReferenceType()
        {
            return new OrderLineReferenceType
            {
                LineID = LineID.ToIdentifierType(),
                SalesOrderLineID = SalesOrderLineID.ToIdentifierType(),
                UUID = UUID.ToIdentifierType(),
            };
        }
    }
}
