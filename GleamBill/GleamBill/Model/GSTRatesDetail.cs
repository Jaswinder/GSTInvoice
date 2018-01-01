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
    public class GSTRatesDetail : INotifyPropertyChanged
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
        public GSTRatesDetail()
        {

        }
        private string hsn = string.Empty;
        public string HSN
        {
            get
            {
                return hsn;
            }
            set
            {
                hsn = value;
                NotifyPropertyChanged();
            }
        }
        private string descriptionOfGoods = string.Empty;
        public string DescriptionOfGoods
        {
            get
            {
                return descriptionOfGoods;
            }
            set
            {
                descriptionOfGoods = value;
                NotifyPropertyChanged();
            }
        }
        private decimal cgstRatePercentage = 0;
        public decimal CGSTRatePercentage
        {
            get
            {
                return cgstRatePercentage;
            }
            set
            {
                cgstRatePercentage = value;
                NotifyPropertyChanged();
            }
        }
        private decimal sgstRatePercentage = 0;
        public decimal SGSTRatePercentage
        {
            get
            {
                return sgstRatePercentage;
            }
            set
            {
                sgstRatePercentage = value;
                NotifyPropertyChanged();
            }
        }
        private decimal igstRatePercentage = 0;
        public decimal IGSTRatePercentage
        {
            get
            {
                return igstRatePercentage;
            }
            set
            {
                igstRatePercentage = value;
                NotifyPropertyChanged();
            }
        }
        private string condition = string.Empty;
        public string Condition
        {
            get
            {
                return condition;
            }
            set
            {
                condition = value;
                NotifyPropertyChanged();
            }
        }
        private decimal cessDefault = 0;
        public decimal CessDefault
        {
            get
            {
                return cessDefault;
            }
            set
            {
                cessDefault = value;
                NotifyPropertyChanged();
            }
        }
        private decimal cessPercent = 0;
        public decimal CessPercent
        {
            get
            {
                return cessPercent;
            }
            set
            {
                cessPercent = value;
                NotifyPropertyChanged();
            }
        }

    }
}
