using Fiscalization.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fiscalization.Models
{
    public class Currency
    {
        [Required]
        public CurrencyCode Code { get; set; }
        public double ExRate { get; set; }
        public bool IsBuying { get; set; }
    }
}
