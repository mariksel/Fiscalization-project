using Fiscalization.Enums;
using FiscalizationService.SOAP;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fiscalization.Models
{
    public class InvoiceItem
    {
        public string BarCode { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public UnitCode UnitCode { get; set; }
        public VouchersSold VS { get; set; }
        /// <summary>
        /// (Name)
        /// Emri i artikullit (mall ose shërbim).
        /// Gjatësia: maksimale 50 karaktere.
        /// Shembull: Verë 1.5L.
        /// </summary>
        [Required]
        public string N { get; set; }
        /// <summary>
        /// (Code)
        /// Kodi i artikullit nga barcode ose kode të ngjashme
        /// </summary>
        public string C { get; set; }
        /// <summary>
        /// (Unit of measure)
        /// Njësia matëse për artikullin e veçantë – copë, peshë, gjatësi, etj.
        /// Gjatësia maksimale: 50 karaktere.
        /// Shembull: Kg.
        /// </summary>
        [Required]
        public string U { get; set; }
        /// <summary>
        /// (Quantity)
        /// Shuma ose numri (sasia) e artikujve. Vlerat negative lejohen kur ekzistojnë “CorrectiveInv” ose “BadDebtInv”.
        /// </summary>
        [Required]
        public double Q { get; set; }

        private decimal _UPB;
        /// <summary>
        /// (Cmimi i njësisë pa TVSH)
        /// Çmimi për njësi përpara aplikimit të tatimit mbi vlerën e shtuar.
        /// </summary>
        [Required]
        public decimal UPB {
            get => _UPB + 0.00M;
            set => _UPB = value; 
        }
        /// <summary>
        /// (Cmimi i njësisë me TVSH)
        /// Çmimi i një artikulli pas aplikimit të tatimit mbi vlerën e shtuar (çmimi njësi me TVSH). 
        /// Llogaritet si PA/Q.
        /// Vlerat negative lejohen kur ekzistojnë “CorrectiveInv” ose “BadDebtInv”.
        /// </summary>
        [Required]
        public decimal UPA => decimal.Round(UPB * (1 + VR / 100), 2);

        public bool RSpecified { get; private set; } = false;
        private decimal _R;
        /// <summary>
        /// (Rebate)
        /// Përqindja e zbritjes
        /// </summary>
        public decimal R { get => _R;
            set
            {
                _R = value;
                RSpecified = true;
            }
        }

        public bool RRSpecified { get; private set; } = false;
        private bool _RR;
        /// <summary>
        /// (Rebate Reducing base price)
        /// A e ul zbritja shumën e bazës tatimore?
        /// </summary>
        public bool RR { get => _RR;
            set
            {
                _RR = value;
                RRSpecified = true;
            }
        }
        /// <summary>
        /// PB (Price Before VAT)
        /// Çmimi para TVSH-së për artikujt në këtë grup artikujsh. 
        /// Ky nuk është çmimi për njësi i artikullit.
        /// Është çmimi për njësi i shumëzuar me sasinë e artikujve (UPB*Q).
        /// Vlerat negative lejohen kur ekzistojnë “CorrectiveInv” ose “BadDebtInv”.
        /// </summary>
        public decimal PB => UPB * (decimal)Q;

        public bool VRSpecified { get; private set; } = false;
        private decimal _VR = 0;
        /// <summary>
        /// VR (VAT Rate)
        /// Norma e tatimit mbi vlerën e shtuar si përqindje. 
        /// Të lejuara aktualisht janë 0%, 6%, 10% dhe 20%.
        /// Nuk duhet të ekzistojë nëse “IsIssuerInVAT” është e vërtetë dhe nuk është auto-ngarkesë ose vetë-faturim. 
        /// E detyrueshme nëse “IsReverseCharge” është e vërtetë.
        /// </summary>
        public decimal VR { 
            get => decimal.Round(_VR + 0.00M, 2) ;
            set
            {
                _VR = value;
                VRSpecified = true;
            }
        }

        /// <summary>
        /// (VAT Amount)
        /// Shuma e tatimit mbi vlerën e shtuar për të gjithë sasinë e të njëjtit artikull. 
        /// E llogaritur si PB*VR
        /// Nuk duhet të ekzistojë nëse “IsIssuerInVAT” është e vërtetë dhe nuk është auto-ngarkesë ose vetë-faturim. 
        /// E detyrueshme nëse “IsReverseCharge” është e vërtetë. 
        /// Vlerat negative lejohen kur ekzistojnë “CorrectiveInv” ose “BadDebtInv”.
        /// </summary>
        public decimal VA => decimal.Round(PB * (VR/100.0M), 2) ;
        public bool VASpecified => VRSpecified;

        public bool INSpecified { get; private set; } = false;
        private bool _IN;
        /// <summary>
        /// (Is Investment)
        /// Nëse është e vërtetë “true”, artikulli është investim për blerësin. 
        /// E detyrueshme vetëm për importin e mallrave.
        /// </summary>
        public bool IN { get => _IN;
            set
            {
                _IN = value;
                INSpecified = true;
            }
        }

        /// <summary>
        /// (Price After applying VAT)
        /// Çmimi total i mallrave pas tatimit dhe aplikimit të zbritjeve. 
        /// Çmimi përfshirë TVSH-në për të gjithë sasinë e të njëjtit artikull. 
        /// E llogaritur si PB+VA
        /// Vlerat negative lejohen kur ekzistojnë “CorrectiveInv” ose “BadDebtInv”.
        /// </summary>
        public decimal PA => decimal.Round(PB + VA + 0.00M, 2);

        public bool EXSpecified { get; private set; } = false;
        private ExemptFromVAT _EX;
        /// <summary>
        /// (EXempt from VAT)
        /// Përjashtimi nga TVSH.
        /// </summary>
        public ExemptFromVAT EX { get => _EX;
            set
            {
                _EX = value;
                EXSpecified = true;
            } 
        }

    }
}
