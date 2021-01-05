using EnumsNET;
using Fiscalization.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fiscalization.Models
{
    public class Buyer
    {
        [Required]
        public IDType IDType { get; set; }
        public bool IDTypeSpecified { get; set; } = true;
        [Required]
        public string IDNum { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Town { get; set; }
        public bool CountrySpecified { get; } = false;
        [Required]
        public CountryCode Country { get; set; }
    }
}
