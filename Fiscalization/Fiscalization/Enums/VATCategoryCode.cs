using System;
using System.Collections.Generic;
using System.Text;

namespace Fiscalization.Enums
{
    public enum VATCategoryCode
    {
        /// <summary> Standard rate </summary>
        S,
        /// <summary> Zero rated goods </summary>
        Z,
        /// <summary>
        /// Exempt from tax
        /// Code specifying that taxes are not applicable.
        /// </summary>
        E,
        /// <summary>
        /// VAT Reverse Charge
        /// Code specifying that the standard VAT rate is levied from the invoicee.
        /// </summary>
        AE,
        /// <summary>
        /// VAT exempt for EEA intra-community supply of goods and services
        /// A tax category code indicating the item is VAT exempt due to an intra-community supply in the European Economic Area.
        /// </summary>
        K,
        /// <summary>
        /// Free export item, tax not charged
        /// Code specifying that the item is free export and taxes are not charged
        /// </summary>
        G,
        /// <summary>
        /// Services outside scope of tax
        /// Code specifying that taxes are not applicable to the services.
        /// </summary>
        O,     
              
              
              
    }
}
