using Fiscalization.Enums;
using System.ComponentModel.DataAnnotations;

namespace Fiscalization.Models
{
    public class Fee
    {
        [Required]
        public FeeType Type { get; set; }
        [Required]
        public decimal Amt { get; set; }
    }
}
