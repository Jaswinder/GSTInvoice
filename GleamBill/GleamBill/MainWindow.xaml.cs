using GleamBill.View;
using System.Windows;
using System.Windows.Controls;
using DBManager;
namespace GleamBill
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            bool IsConnectionSuccess = ConnectionModel.SetConnectionStrings();
            LoadView("Home");
            if (IsConnectionSuccess)
            {
                LoadView("Home");
            }
            else
            {
                MessageBox.Show("Not able to connnect to server...");
                Application.Current.Shutdown();
            }
        }

        private void HeaderItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem cb = sender as MenuItem;
            string Name = cb.Header as string;
            LoadView(Name);
        }
        HomeViewUC HomeViewUC = null;
        AddCompany AddCompany = null;
        AddClient AddClient = null;
        private void LoadView(string view_name)
        {

            switch (view_name)
            {
                case "Home":
                    if (HomeViewUC == null)
                    {
                        HomeViewUC = new HomeViewUC();
                    }
                    MainWindowContent.Content = HomeViewUC;
                    break;
                case "Add Company":
                    if (AddCompany == null)
                    {
                        AddCompany = new AddCompany();
                    }
                    MainWindowContent.Content = AddCompany;
                    break;
                case "Add Client":
                    if (AddClient == null)
                    {
                        AddClient = new AddClient();
                    }
                    MainWindowContent.Content = AddClient;
                    break;
            }

        }
    }
}
