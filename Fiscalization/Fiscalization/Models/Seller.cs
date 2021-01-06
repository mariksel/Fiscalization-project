using EnumsNET;
using Fiscalization.Enums;
using System.ComponentModel.DataAnnotations;

namespace Fiscalization.Models
{
    public class Seller
    {
        public static Seller CreateSeller(string idNum, string name, string address, string town, CountryCode? country)
        {
            var seller = new Seller
            {
                IDType = IDType.NUIS,
                IDNum = idNum,
                Name = name,
                Address = address,
                Town = town,
                Country = country
            };
            return seller;
        }
        [Required]
        public IDType IDType { get; set; }

        /// <summary>
        /// Numri identifikues i shitësit.
        /// Gjatësia: 20 karaktere.
        /// Shembull: Për NUIS/NIPT: K72001008V, Për numrin social: 123-45-6789.
        /// </summary>
        [Required]
        public string IDNum { get; set; }

        /// <summary>
        /// Emri i shitësit.
        /// Gjatësia: 100 karaktere.
        /// Shembull: Emri Mbiemri.
        /// </summary>
        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        public string Town { get; set; }

        public bool CountrySpecified { get; private set; } = false;
        private CountryCode? _country;
        public CountryCode? Country { 
            get => _country;
            set
            {
                if (value.HasValue && value.Value.IsDefined())
                {
                    _country = value;
                    CountrySpecified = true;
                }
            } 
        }


    }
}
