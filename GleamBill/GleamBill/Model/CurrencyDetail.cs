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
    public class CurrencyDetail : INotifyPropertyChanged
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
        public CurrencyDetail()
        {

        }
        private string currencySymbol = string.Empty;
        public string CurrencySymbol
        {
            get
            {
                return currencySymbol;
            }
            set
            {
                currencySymbol = value;
                NotifyPropertyChanged();
            }
        }
       
        private string currencyName = string.Empty;
        public string CurrencyName
        {
            get
            {
                return currencyName;
            }
            set
            {
                currencyName = value;
                NotifyPropertyChanged();
            }
        }
        
        private bool isUsed = false;
        public bool IsUsed
        {
            get
            {
                return isUsed;
            }
            set
            {
                isUsed = value;
                NotifyPropertyChanged();
            }
        }
        private string symbol = string.Empty;
        public string Symbol
        {
            get
            {
                return symbol;
            }
            set
            {
                symbol = value;
                NotifyPropertyChanged();
            }
        }

    }
}
