using Fiscalization.Enums;
using System.ComponentModel.DataAnnotations;

namespace Fiscalization.Models
{
    public class PayMethod
    {
        [MaxLength(20)]
        public Voucher[] Vouchers { get; set; }
        [Required]
        public PaymentMethodType Type { get; set; }
        [Required]
        public decimal Amt { get; set; }
        /// <summary>Numri i kartës së kompanisë nëse mënyra e pagesës është “company card (kartë e kompanisë)”.</summary>
        public string CompCard { get; set; }
    }
}
