using FiscalizationService.SOAP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Fiscalization.Models
{
    public class Seller : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }



        private IDTypeSType iDTypeField;

        private string iDNumField;

        private string nameField;

        private string addressField;

        private string townField;

        private CountryCodeSType countryField;

        private bool countryFieldSpecified;



        public IDTypeSType IDType
        {
            get => iDTypeField;
            set
            {
                this.iDTypeField = value;
                RaisePropertyChanged(nameof(IDType));
            }
        }

        /// <summary>
        /// Numri identifikues i shitësit.
        /// Gjatësia: 20 karaktere.
        /// Shembull: Për NUIS/NIPT: K72001008V, Për numrin social: 123-45-6789.
        /// </summary>
        public string IDNum
        {
            get => iDNumField;
            set
            {
                this.iDNumField = value;
                RaisePropertyChanged(nameof(IDNum));
            }
        }

        /// <summary>
        /// Emri i shitësit.
        /// Gjatësia: 100 karaktere.
        /// Shembull: Emri Mbiemri.
        /// </summary>
        public string Name
        {
            get => nameField;
            set
            {
                this.nameField = value;
                RaisePropertyChanged(nameof(Name));
            }
        }


        public string Address
        {
            get => addressField;
            set
            {
                this.addressField = value;
                RaisePropertyChanged(nameof(Address));
            }
        }


        public string Town
        {
            get => townField;
            set
            {
                this.townField = value;
                RaisePropertyChanged(nameof(Town));
            }
        }


        public CountryCodeSType Country
        {
            get => countryField;
            set
            {
                this.countryField = value;
                RaisePropertyChanged(nameof(Country));
            }
        }

 
        public bool CountrySpecified
        {
            get => countryFieldSpecified;
            set
            {
                this.countryFieldSpecified = value;
                RaisePropertyChanged(nameof(CountrySpecified));
            }
        }

        public SellerType ToSellerType()
        {
            return new SellerType
            {
                Address = Address,
                Country = Country,
                CountrySpecified = CountrySpecified,
                IDNum = IDNum,
                IDType = IDType,
                Name = Name,
                Town = Town
            };
        }
    }
}
