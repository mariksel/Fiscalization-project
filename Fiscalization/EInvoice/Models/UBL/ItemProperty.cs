using System;
using System.Collections.Generic;
using System.Text;
using UblSharp.CommonAggregateComponents;

namespace EInvoice.Models.UBL
{
    public class ItemProperty
    {
        /// <summary>
        /// Name of an attribute or property of an item.
        /// Such as "Color."
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Value of attributes or properties of an article.
        /// Such as "Red".
        /// </summary>
        public string Value { get; set; }

        public ItemPropertyType ToItemPropertyType()
        {
            return new ItemPropertyType
            {
                Name = Name,
                Value = Value
            };
        }
    }
}
