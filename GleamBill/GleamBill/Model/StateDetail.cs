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
    public class StateDetail : INotifyPropertyChanged
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
        public StateDetail()
        {

        }
        private string name = "GST5";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                NotifyPropertyChanged();
            }
        }
        
        private string code = string.Empty;
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
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
        
    }
}
