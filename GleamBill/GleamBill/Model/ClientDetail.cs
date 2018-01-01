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
    public class ClientDetail : INotifyPropertyChanged
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
        public ClientDetail()
        {

        }
        private string clientName = "Client1";
        public string ClientName
        {
            get
            {
                return clientName;
            }
            set
            {
                clientName = value;
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

        private string clientCode = string.Empty;
        public string ClientCode
        {
            get
            {
                return clientCode;
            }
            set
            {
                clientCode = value;
                NotifyPropertyChanged();
            }
        }
        private string email = string.Empty;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                NotifyPropertyChanged();
            }
        }
        private string telephone = string.Empty;
        public string Telephone
        {
            get
            {
                return telephone;
            }
            set
            {
                telephone = value;
                NotifyPropertyChanged();
            }
        }
        private string contact = string.Empty;
        public string Contact
        {
            get
            {
                return contact;
            }
            set
            {
                contact = value;
                NotifyPropertyChanged();
            }
        }
        private string billingAddress = string.Empty;
        public string BillingAddress
        {
            get
            {
                return billingAddress;
            }
            set
            {
                billingAddress = value;
                NotifyPropertyChanged();
            }
        }

        private string billingZip = string.Empty;
        public string BillingZip
        {
            get
            {
                return billingZip;
            }
            set
            {
                billingZip = value;
                NotifyPropertyChanged();
            }
        }
        private string billingCity = string.Empty;
        public string BillingCity
        {
            get
            {
                return billingCity;
            }
            set
            {
                billingCity = value;
                NotifyPropertyChanged();
            }
        }
        private string shippingAddress = string.Empty;
        public string ShippingAddress
        {
            get
            {
                return shippingAddress;
            }
            set
            {
                shippingAddress = value;
                NotifyPropertyChanged();
            }
        }
        private string shippingZip = string.Empty;
        public string ShippingZip
        {
            get
            {
                return shippingZip;
            }
            set
            {
                shippingZip = value;
                NotifyPropertyChanged();
            }
        }
        private Int32 billingStateID;
        public Int32 BillingStateID
        {
            get
            {
                return billingStateID;
            }
            set
            {
                billingStateID = value;
                NotifyPropertyChanged();
            }
        }
        private Int32 shippingStateID;
        public Int32 ShippingStateID
        {
            get
            {
                return shippingStateID;
            }
            set
            {
                shippingStateID = value;
                NotifyPropertyChanged();
            }
        }

        private string shippingCity = string.Empty;
        public string ShippingCity
        {
            get
            {
                return shippingCity;
            }
            set
            {
                shippingCity = value;
                NotifyPropertyChanged();
            }
        }
        private string details = string.Empty;
        public string Details
        {
            get
            {
                return details;
            }
            set
            {
                details = value;
                NotifyPropertyChanged();
            }
        }
        private string publicDetails = string.Empty;
        public string PublicDetails
        {
            get
            {
                return publicDetails;
            }
            set
            {
                publicDetails = value;
                NotifyPropertyChanged();
            }
        }
        private bool idDeleted = false;
        public bool IsDeleted
        {
            get
            {
                return idDeleted;
            }
            set
            {
                idDeleted = value;
                NotifyPropertyChanged();
            }
        }
        private string tin = string.Empty;
        public string TIN
        {
            get
            {
                return tin;
            }
            set
            {
                tin = value;
                NotifyPropertyChanged();
            }
        }
        private string pan = string.Empty;
        public string PAN
        {
            get
            {
                return pan;
            }
            set
            {
                pan = value;
                NotifyPropertyChanged();
            }
        }
        private string vatNumber = string.Empty;
        public string VATNumber
        {
            get
            {
                return vatNumber;
            }
            set
            {
                vatNumber = value;
                NotifyPropertyChanged();
            }
        }
        private string gstin = string.Empty;
        public string GSTIN
        {
            get
            {
                return gstin;
            }
            set
            {
                gstin = value;
                NotifyPropertyChanged();
            }
        }
        private Int64 companyID = 0;
        public Int64 CompanyID
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
        private ObservableCollection<string> allCountries = new ObservableCollection<string>();
        public ObservableCollection<string> AllCountries
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
        private ObservableCollection<string> allStates = new ObservableCollection<string>();
        public ObservableCollection<string> AllStates
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
        private ObservableCollection<string> allcities = new ObservableCollection<string>();
        public ObservableCollection<string> AllCities
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
        
    }
}
