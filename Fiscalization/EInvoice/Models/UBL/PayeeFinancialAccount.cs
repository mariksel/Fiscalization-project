using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class PayeeFinancialAccount
    {
        /// <summary>
        /// A unique billing account identifier, at payment service providers, to which payments must be executed.
        /// Like IBAN (in case of SEPA payment) or national account number.
        /// </summary>
        public Identifier ID { get; set; }
        /// <summary>
        /// The payment account name, at payment service providers, to which payments must be executed.
        /// </summary>
        public string Name { get; set; }
        public FinancialInstitutionBranch FinancialInstitutionBranch { get; set; }

        public FinancialAccountType ToFinancialAccountType()
        {
            return new FinancialAccountType
            {
                ID = ID.ToIdentifierType(),
                Name = Name,
                FinancialInstitutionBranch = FinancialInstitutionBranch.ToBranchType()
            };
        }
    }
}
