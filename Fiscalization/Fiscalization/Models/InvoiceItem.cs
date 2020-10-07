using FiscalizationService.SOAP;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiscalization.Models
{
    public class InvoiceItem
    {
        public VouchersSoldType VS { get; set; }
        /// <summary>
        /// Emri i artikullit.
        /// Gjatësia: maksimale 50 karaktere.
        /// Shembull: Verë 1.5L.
        /// </summary>
        public string N { get; set; }
        public string C { get; set; }
        /// <summary>
        /// Njësia matëse për artikullin e veçantë – copë, peshë, gjatësi, etj.
        /// Gjatësia maksimale: 50 karaktere.
        /// Shembull: Kg.
        /// </summary>
        public string U { get; set; }
        public double Q { get; set; }
        public decimal UPB { get; set; }
        public decimal UPA { get; set; }
        public decimal R { get; set; }
        public bool RSpecified { get; set; }
        public bool RR { get; set; }
        public bool RRSpecified { get; set; }
        public decimal PB { get; set; }
        public decimal VR { get; set; }
        public bool VRSpecified { get; set; }
        public decimal VA { get; set; }
        public bool VASpecified { get; set; }
        public bool IN { get; set; }
        public bool INSpecified { get; set; }
        public decimal PA { get; set; }
        public ExemptFromVATSType EX { get; set; }
        public bool EXSpecified { get; set; }

        public InvoiceItemType ToInvoiceItemType()
        {
            return new InvoiceItemType
            {
                VS = VS,
                N = N,
                C = C,
                U = U,
                Q = Q,
                UPB = UPB,
                UPA = UPA,
                R = R,
                RSpecified = RSpecified,
                RR = RR,
                RRSpecified = RRSpecified,
                PB = PB,
                VR = VR,
                VRSpecified = VRSpecified,
                VA = VA,
                VASpecified = VASpecified,
                IN = IN,
                INSpecified = INSpecified,
                PA = PA,
                EX = EX,
                EXSpecified = EXSpecified,
            };
        }
    }
}
