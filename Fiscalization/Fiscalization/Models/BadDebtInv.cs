using System;
using System.ComponentModel.DataAnnotations;

namespace Fiscalization.Models
{
    public class BadDebtInv
    {
        [Required]
        public string IICRef { get; set; }
        [Required]
        public DateTime IssueDateTime { get; set; }
    }
}
