using Fiscalization.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fiscalization.Models
{
    public class CorrectiveInvoice
    {
        [Required]
        public string IICRef { get; set; }
        [Required]
        public DateTime IssueDateTime { get; set; }
        [Required]
        public CorrectiveInvoiceType Type { get; set; }
    }
}
