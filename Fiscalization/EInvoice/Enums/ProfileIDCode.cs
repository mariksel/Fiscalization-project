using System;
using System.Collections.Generic;
using System.Text;

namespace EInvoice.Enums
{
    /// <summary>
    /// Supported business process requirements
    /// </summary>
    public enum ProfileIDCode
    {
        /// <summary> Invoicing the supply of goods and services ordered on a contract basis </summary>
        P1,
        /// <summary> Periodic invoicing of contract-based delivery</summary>
        P2,
        /// <summary> Invoicing delivery over unforeseen orders</summary>
        P3,
        /// <summary> Advance Payment</summary>
        P4,
        /// <summary> Spot payment</summary>
        P5,
        /// <summary> Payment before delivery on the based on a purchase order</summary>
        P6,
        /// <summary> Invoices with reference to a dispatch note</summary>
        P7,
        /// <summary> Invoices with reference to dispatch and receipt</summary>
        P8,
        /// <summary> Approval or Negative Invoicing</summary>
        P9,
        /// <summary> Corrective Invoicing</summary>
        P10,
        /// <summary> Partial and final invoicing</summary>
        P11,
        /// <summary> Self-invoicing</summary>
        P12,
    }
}
