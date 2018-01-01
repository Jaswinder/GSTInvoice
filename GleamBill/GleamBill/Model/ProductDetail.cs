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
    public class ProductDetail : INotifyPropertyChanged
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
        public ProductDetail()
        {

        }
        private string productName = "Jaswinder";
        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
                NotifyPropertyChanged();
            }
        }
        private string hsnCode = string.Empty;
        public string HSNCode
        {
            get
            {
                return hsnCode;
            }
            set
            {
                hsnCode = value;
                NotifyPropertyChanged();
            }
        }
        private string uom = string.Empty;
        public string UoM
        {
            get
            {
                return uom;
            }
            set
            {
                uom = value;
                NotifyPropertyChanged();
            }
        }
        private decimal unitPrice=0;
        public decimal UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                unitPrice = value;
                NotifyPropertyChanged();
            }
        }
        private bool isTaxIncluded = false;
        public bool IsTaxIncluded
        {
            get
            {
                return isTaxIncluded;
            }
            set
            {
                isTaxIncluded = value;
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
        private string type = string.Empty;
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                NotifyPropertyChanged();
            }
        }

        private string sac = string.Empty;
        public string SAC
        {
            get
            {
                return sac;
            }
            set
            {
                sac = value;
                NotifyPropertyChanged();
            }
        }
        private decimal purchaseRate = 0;
        public decimal PurchaseRate
        {
            get
            {
                return purchaseRate;
            }
            set
            {
                purchaseRate = value;
                NotifyPropertyChanged();
            }
        }
        private string sku = string.Empty;
        public string SKU
        {
            get
            {
                return sku;
            }
            set
            {
                sku = value;
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
        private ObservableCollection<string> allTaxesgst= new ObservableCollection<string>();
        public ObservableCollection<string> AllTaxesGST
        {
            get
            {
                return allTaxesgst;
            }
            set
            {
                allTaxesgst = value;
                NotifyPropertyChanged();
            }
        }
       
        
    }
}
