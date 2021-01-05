using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class FinancialInstitutionBranch
    {
        /// <summary>
        /// Identifier for the payment service provider at which the invoice to be paid is located.
        /// For example, BIC or National Clearing Code (NCC) where necessary. 
        /// No identification scheme is used.
        /// </summary>
        public Identifier ID { get; set; }

        public BranchType ToBranchType()
        {
            return new BranchType
            {
                ID = ID.ToIdentifierType()
            };
        }
    }
}
