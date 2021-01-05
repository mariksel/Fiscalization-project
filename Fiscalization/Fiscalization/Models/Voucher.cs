using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fiscalization.Models
{
    public class Voucher
    {
        [Required]
        public string Num { get; set; }
    }
}
