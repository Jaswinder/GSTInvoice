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
    public class TaxDetail : INotifyPropertyChanged
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
        public TaxDetail()
        {

        }
        private string taxName = "GST5";
        public string TaxName
        {
            get
            {
                return taxName;
            }
            set
            {
                taxName = value;
                NotifyPropertyChanged();
            }
        }
        private decimal taxPercentage = 0;
        public decimal TaxPercentage
        {
            get
            {
                return taxPercentage;
            }
            set
            {
                taxPercentage = value;
                NotifyPropertyChanged();
            }
        }
        private string taxType = string.Empty;
        public string TaxType
        {
            get
            {
                return taxType;
            }
            set
            {
                taxType = value;
                NotifyPropertyChanged();
            }
        }
        
        private bool isDeleted = false;
        public bool IsDeleted
        {
            get
            {
                return isDeleted;
            }
            set
            {
                isDeleted = value;
                NotifyPropertyChanged();
            }
        }
        
    }
}
