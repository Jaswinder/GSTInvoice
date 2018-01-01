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
    public class CityDetail : INotifyPropertyChanged
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
        public CityDetail()
        {

        }
        private string countryCode = string.Empty;
        public string CountryCode
        {
            get
            {
                return countryCode;
            }
            set
            {
                countryCode = value;
                NotifyPropertyChanged();
            }
        }
        
        private string postalCode = string.Empty;
        public string PostalCode
        {
            get
            {
                return postalCode;
            }
            set
            {
                postalCode = value;
                NotifyPropertyChanged();
            }
        }

        private string village = string.Empty;
        public string Village
        {
            get
            {
                return village;
            }
            set
            {
                village = value;
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
        private string stateid = string.Empty;
        public string StateID
        {
            get
            {
                return stateid;
            }
            set
            {
                stateid = value;
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
        private string column6 = string.Empty;
        public string Column6
        {
            get
            {
                return column6;
            }
            set
            {
                column6 = value;
                NotifyPropertyChanged();
            }
        }
        private string town = string.Empty;
        public string Town
        {
            get
            {
                return town;
            }
            set
            {
                town = value;
                NotifyPropertyChanged();
            }
        }
        private string column8 = string.Empty;
        public string Column8
        {
            get
            {
                return column8;
            }
            set
            {
                column8 = value;
                NotifyPropertyChanged();
            }
        }
        private string cord1 = string.Empty;
        public string Cord1
        {
            get
            {
                return cord1;
            }
            set
            {
                cord1 = value;
                NotifyPropertyChanged();
            }
        }
        private string cord2 = string.Empty;
        public string Cord2
        {
            get
            {
                return cord2;
            }
            set
            {
                cord2 = value;
                NotifyPropertyChanged();
            }
        }
        private string column11 = string.Empty;
        public string Column11
        {
            get
            {
                return column11;
            }
            set
            {
                column11 = value;
                NotifyPropertyChanged();
            }
        }

    }
}
