using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GleamBill.Model
{
    public class CompanyDetail : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName]String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        //class constructor could be used later
        public CompanyDetail()
        {

        }
        private string companyName = "Company";
        public string CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                companyName = value;
                NotifyPropertyChanged();
            }
        }
        private int countryID = 0;
        public int CountryID
        {
            get
            {
                return countryID;
            }
            set
            {
                countryID = value;
                NotifyPropertyChanged();
            }
        }
        private Guid companyID = Guid.Empty;
        public Guid CompanyID
        {
            get
            {
                return companyID;
            }
            set
            {
                companyID = value;
                NotifyPropertyChanged();
            }
        }
        private string country = string.Empty;
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
                NotifyPropertyChanged();
            }
        }
        private string address = string.Empty;
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
                NotifyPropertyChanged();
            }
        }

        private int stateID;
        public int StateID
        {
            get
            {
                return stateID;
            }
            set
            {
                stateID = value;
                NotifyPropertyChanged();
            }
        }
        private string state = string.Empty;
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                NotifyPropertyChanged();
            }
        }

        private int cityID;
        public int CityID
        {
            get
            {
                return cityID;
            }
            set
            {
                cityID = value;
                NotifyPropertyChanged();
            }
        }
        private string city = string.Empty;
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
                NotifyPropertyChanged();
            }
        }
        private string pinCode = string.Empty;
        public string PINCode
        {
            get
            {
                return pinCode;
            }
            set
            {
                pinCode = value;
                NotifyPropertyChanged();
            }
        }
        private string websiteLogo = string.Empty;
        public string WebsiteLogo
        {
            get
            {
                return websiteLogo;
            }
            set
            {
                websiteLogo = value;
                NotifyPropertyChanged();
            }
        }
        private int companyPhone = 99999999;
        public int CompanyPhone
        {
            get
            {
                return companyPhone;
            }
            set
            {
                companyPhone = value;
                NotifyPropertyChanged();
            }
        }
        private string companyEmail = string.Empty;
        public string CompanyEmail
        {
            get
            {
                return companyEmail;
            }
            set
            {
                companyEmail = value;
                NotifyPropertyChanged();
            }
        }
        private string companyWebsite = string.Empty;
        public string CompanyWebsite
        {
            get
            {
                return companyWebsite;
            }
            set
            {
                companyWebsite = value;
                NotifyPropertyChanged();
            }
        }
        private string tinVAT = string.Empty;
        public string TINVAT
        {
            get
            {
                return tinVAT;
            }
            set
            {
                tinVAT = value;
                NotifyPropertyChanged();
            }
        }
        private string gstIN = string.Empty;
        public string GSTIN
        {
            get
            {
                return gstIN;
            }
            set
            {
                gstIN = value;
                NotifyPropertyChanged();
            }
        }
        private ObservableCollection<GenericListBinder> allCountries = new ObservableCollection<GenericListBinder>();
        public ObservableCollection<GenericListBinder> AllCountries
        {
            get
            {
                return allCountries;
            }
            set
            {
                allCountries = value;
                NotifyPropertyChanged();
            }
        }
        private ObservableCollection<GenericListBinder> allStates = new ObservableCollection<GenericListBinder>();
        public ObservableCollection<GenericListBinder> AllStates
        {
            get
            {
                return allStates;
            }
            set
            {
                allStates = value;
                NotifyPropertyChanged();
            }
        }
        private ObservableCollection<GenericListBinder> allcities = new ObservableCollection<GenericListBinder>();
        public ObservableCollection<GenericListBinder> AllCities
        {
            get
            {
                return allcities;
            }
            set
            {
                allcities = value;
                NotifyPropertyChanged();
            }
        }
        private ObservableCollection<string> allServiceCategories = new ObservableCollection<string>();
        public ObservableCollection<string> AllServiceCategories
        {
            get
            {
                return allServiceCategories;
            }
            set
            {
                allServiceCategories = value;
                NotifyPropertyChanged();
            }
        }
        private ObservableCollection<string> allCurrency = new ObservableCollection<string>();
        public ObservableCollection<string> AllCurrency
        {
            get
            {
                return allCurrency;
            }
            set
            {
                allCurrency = value;
                NotifyPropertyChanged();
            }
        }
        private string serviceTaxCSTTinNo = string.Empty;
        public string ServiceTaxCSTTinNo
        {
            get
            {
                return serviceTaxCSTTinNo;
            }
            set
            {
                serviceTaxCSTTinNo = value;
                NotifyPropertyChanged();
            }
        }
        private string serviceCategory = string.Empty;
        public string ServiceCategory
        {
            get
            {
                return serviceCategory;
            }
            set
            {
                serviceCategory = value;
                NotifyPropertyChanged();
            }
        }
        private int serviceCategoryID;
        public int ServiceCategoryID
        {
            get
            {
                return serviceCategoryID;
            }
            set
            {
                serviceCategoryID = value;
                NotifyPropertyChanged();
            }
        }
        private string pAN = string.Empty;
        public string PAN
        {
            get
            {
                return pAN;
            }
            set
            {
                pAN = value;
                NotifyPropertyChanged();
            }
        }
        private string additionalDetails = string.Empty;
        public string AdditionalDetails
        {
            get
            {
                return additionalDetails;
            }
            set
            {
                additionalDetails = value;
                NotifyPropertyChanged();
            }
        }
        private string currency = string.Empty;
        public string Currency
        {
            get
            {
                return currency;
            }
            set
            {
                currency = value;
                NotifyPropertyChanged();
            }
        }
        private int currencyID;
        public int CurrencyID
        {
            get
            {
                return currencyID;
            }
            set
            {
                currencyID = value;
                NotifyPropertyChanged();
            }

        }
    }
}
