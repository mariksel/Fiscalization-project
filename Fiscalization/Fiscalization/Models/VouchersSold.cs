using System;
using System.Collections.Generic;
using System.Text;

namespace Fiscalization.Models
{
    public class VouchersSold
    {
        public VoucherSoldData VD { get; set; }
        public Voucher[] VN { get; set; }
    }
}
