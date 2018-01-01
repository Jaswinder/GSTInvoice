using GleamBill.Model;
using GleamBill.ModelView;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace GleamBill.View
{
    /// <summary>
    /// Interaction logic for AddClient.xaml
    /// </summary>

    public partial class AddClient : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName]String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private ClientDetail clientDetail;
        public ClientDetail BaseObject
        {
            get
            {
                return clientDetail;
            }

            set
            {
                clientDetail = value;
            }
        }


        //private CompanyDetail companyDetail;
        //public CompanyDetail BaseObject
        //{
        //    get
        //    {
        //        return companyDetail;
        //    }

        //    set
        //    {
        //        companyDetail = value;
        //    }
        //}
        public AddClient()
        {
            InitializeComponent();
            clientDetail = new ClientDetail();
            //companyDetail.AllCurrency = new ObservableCollection<string>(CompanyDetailsSQL.GetAllCurrencies());
           // companyDetail.AllCountries = new ObservableCollection<GenericListBinder>(CompanyDetailsSQL.GetAllCountries());
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var genericButton = sender as Button;
            if (genericButton.Name == SaveButton.Name)
            {
                if (string.IsNullOrEmpty(clientDetail.ClientName))
                {
                    MessageBox.Show("Please enter company name");
                }
                else
                {
                    CompanyDetailsSQL.InsertUpdateClientDetail(clientDetail);
                }
            }
            //var genericButton = sender as Button;
            //if (genericButton.Name == SaveButton.Name)
            //{
            //    if (string.IsNullOrEmpty(companyDetail.CompanyName))
            //    {
            //        MessageBox.Show("Please enter company name");
            //    }
            //}
        }



        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var genericCombo = sender as ComboBox;
            //if (e.AddedItems.Count > 0)
            //{
            //    if (genericCombo.Name == CountryCombo.Name)
            //    {
            //       // companyDetail.AllStates = new ObservableCollection<string>();
            //        companyDetail.AllCities.Clear();
            //    }
            //    else if (genericCombo.Name == StateCombo.Name)
            //    {
            //        companyDetail.AllCities = new ObservableCollection<GenericListBinder>(CompanyDetailsSQL.GetCitiesByStateID(0));
            //    }
            //}

            var genericCombo = sender as ComboBox;
            if (e.AddedItems.Count > 0)
            {
                if (genericCombo.Name == CountryCombo.Name)
                {
                    //companyDetail.AllStates = new ObservableCollection<GenericListBinder>(CompanyDetailsSQL.GetStatesInCountry(companyDetail.CountryID));
                    //companyDetail.AllCities.Clear();
                }
                else if (genericCombo.Name == StateCombo.Name)
                {
                    //companyDetail.AllCities = new ObservableCollection<GenericListBinder>(CompanyDetailsSQL.GetCitiesByStateID(companyDetail.StateID));
                }
                //else if (genericCombo.Name == cmboCurrency.Name)
                //{
                //    companyDetail.AllCities = new ObservableCollection<string>(CompanyDetailsSQL.GetAllCitiesInState(companyDetail.Currency));
                //}
            }
        }
    }
}
