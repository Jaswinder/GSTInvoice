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
    public class InvoiceDetail : INotifyPropertyChanged
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
        public InvoiceDetail()
        {

        }
        private string invoiceNumber = string.Empty;
        public string InvoiceNumber
        {
            get
            {
                return invoiceNumber;
            }
            set
            {
                invoiceNumber = value;
                NotifyPropertyChanged();
            }
        }
        
        private DateTime issueDate = DateTime.Now;
        public DateTime IssueDate
        {
            get
            {
                return issueDate;
            }
            set
            {
                issueDate = value;
                NotifyPropertyChanged();
            }
        }
        private DateTime dueDate = DateTime.Now;
        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }
            set
            {
                dueDate = value;
                NotifyPropertyChanged();
            }
        }
        private Int64 companyDetailsID = 0;
        public Int64 CompanyDetailsID
        {
            get
            {
                return companyDetailsID;
            }
            set
            {
                companyDetailsID = value;
                NotifyPropertyChanged();
            }
        }
        private Int64 clientID = 0;
        public Int64 ClientID
        {
            get
            {
                return clientID;
            }
            set
            {
                clientID = value;
                NotifyPropertyChanged();
            }
        }

        private string clientName = string.Empty;
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
        private string clientEmail = string.Empty;
        public string ClientEmail
        {
            get
            {
                return clientEmail;
            }
            set
            {
                clientEmail = value;
                NotifyPropertyChanged();
            }
        }
        private string clientTelephone = string.Empty;
        public string ClientTelephone
        {
            get
            {
                return clientTelephone;
            }
            set
            {
                clientTelephone = value;
                NotifyPropertyChanged();
            }
        }
        private string clientContact = string.Empty;
        public string ClientContact
        {
            get
            {
                return clientContact;
            }
            set
            {
                clientContact = value;
                NotifyPropertyChanged();
            }
        }
        private string clientBillingAddress = string.Empty;
        public string ClientBillingAddress
        {
            get
            {
                return clientBillingAddress;
            }
            set
            {
                clientBillingAddress = value;
                NotifyPropertyChanged();
            }
        }
        private string clientBillingZip = string.Empty;
        public string ClientBillingZip
        {
            get
            {
                return clientBillingZip;
            }
            set
            {
                clientBillingZip = value;
                NotifyPropertyChanged();
            }
        }
        private string clientBillingCity = string.Empty;
        public string ClientBillingCity
        {
            get
            {
                return clientBillingCity;
            }
            set
            {
                clientBillingCity = value;
                NotifyPropertyChanged();
            }
        }
        private string clientShippingAddress = string.Empty;
        public string ClientShippingAddress
        {
            get
            {
                return clientShippingAddress;
            }
            set
            {
                clientShippingAddress = value;
                NotifyPropertyChanged();
            }
        }
        private string clientShippingZip = string.Empty;
        public string ClientShippingZip
        {
            get
            {
                return clientShippingZip;
            }
            set
            {
                clientShippingZip = value;
                NotifyPropertyChanged();
            }
        }
        private string clientShippingCity = string.Empty;
        public string ClientShippingCity
        {
            get
            {
                return clientShippingCity;
            }
            set
            {
                clientShippingCity = value;
                NotifyPropertyChanged();
            }
        }
        private bool isPaid = false;
        public bool IsPaid
        {
            get
            {
                return isPaid;
            }
            set
            {
                isPaid = value;
                NotifyPropertyChanged();
            }
        }
        private bool isDraft = false;
        public bool IsDraft
        {
            get
            {
                return isDraft;
            }
            set
            {
                isDraft = value;
                NotifyPropertyChanged();
            }
        }
        private string totalNoTax = string.Empty;
        public string TotalNoTax
        {
            get
            {
                return totalNoTax;
            }
            set
            {
                totalNoTax = value;
                NotifyPropertyChanged();
            }
        }
        private string totalTax = string.Empty;
        public string TotalTax
        {
            get
            {
                return totalTax;
            }
            set
            {
                totalTax = value;
                NotifyPropertyChanged();
            }
        }
        private string totalAll = string.Empty;
        public string TotalAll
        {
            get
            {
                return totalAll;
            }
            set
            {
                totalAll = value;
                NotifyPropertyChanged();
            }
        }
        private string internalNote = string.Empty;
        public string InternalNote
        {
            get
            {
                return internalNote;
            }
            set
            {
                internalNote = value;
                NotifyPropertyChanged();
            }
        }
        private string invoiceNote = string.Empty;
        public string InvoiceNote
        {
            get
            {
                return invoiceNote;
            }
            set
            {
                invoiceNote = value;
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
        private string color = string.Empty;
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                NotifyPropertyChanged();
            }
        }
        private string poNumber = string.Empty;
        public string PONumber
        {
            get
            {
                return poNumber;
            }
            set
            {
                poNumber = value;
                NotifyPropertyChanged();
            }
        }
        private string logo = string.Empty;
        public string Logo
        {
            get
            {
                return logo;
            }
            set
            {
                logo = value;
                NotifyPropertyChanged();
            }
        }
        private int pageSizeID = 0;
        public int PageSizeID
        {
            get
            {
                return pageSizeID;
            }
            set
            {
                pageSizeID = value;
                NotifyPropertyChanged();
            }
        }
        private int clientBillingStateID = 0;
        public int ClientBillingStateID
        {
            get
            {
                return clientBillingStateID;
            }
            set
            {
                clientBillingStateID = value;
                NotifyPropertyChanged();
            }
        }
        private int clientShippingStateID = 0;
        public int ClientShippingStateID
        {
            get
            {
                return clientShippingStateID;
            }
            set
            {
                clientShippingStateID = value;
                NotifyPropertyChanged();
            }
        }
        private string payEmail = string.Empty;
        public string PayEmail
        {
            get
            {
                return payEmail;
            }
            set
            {
                payEmail = value;
                NotifyPropertyChanged();
            }
        }
        private bool payOnline = false;
        public bool PayOnline
        {
            get
            {
                return payOnline;
            }
            set
            {
                payOnline = value;
                NotifyPropertyChanged();
            }
        }
        private int flagID = 0;
        public int FlagID
        {
            get
            {
                return flagID;
            }
            set
            {
                flagID = value;
                NotifyPropertyChanged();
            }
        }
        private int layout = 0;
        public int Layout
        {
            get
            {
                return layout;
            }
            set
            {
                layout = value;
                NotifyPropertyChanged();
            }
        }
        private string discount = string.Empty;
        public string Discount
        {
            get
            {
                return discount;
            }
            set
            {
                discount = value;
                NotifyPropertyChanged();
            }
        }
        private bool sent = false;
        public bool Sent
        {
            get
            {
                return sent;
            }
            set
            {
                sent = value;
                NotifyPropertyChanged();
            }
        }
        private int printID = 0;
        public int PrintID
        {
            get
            {
                return printID;
            }
            set
            {
                printID = value;
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
        private string fiscalYear = string.Empty;
        public string FiscalYear
        {
            get
            {
                return fiscalYear;
            }
            set
            {
                fiscalYear = value;
                NotifyPropertyChanged();
            }
        }
        private string numberPrefix = string.Empty;
        public string NumberPrefix
        {
            get
            {
                return numberPrefix;
            }
            set
            {
                numberPrefix = value;
                NotifyPropertyChanged();
            }
        }
        private string secondNumber = string.Empty;
        public string SecondNumber
        {
            get
            {
                return secondNumber;
            }
            set
            {
                secondNumber = value;
                NotifyPropertyChanged();
            }
        }
        private string exciseDuty = string.Empty;
        public string ExciseDuty
        {
            get
            {
                return exciseDuty;
            }
            set
            {
                exciseDuty = value;
                NotifyPropertyChanged();
            }
        }
        private bool useTransport = false;
        public bool UseTransport
        {
            get
            {
                return useTransport;
            }
            set
            {
                useTransport = value;
                NotifyPropertyChanged();
            }
        }
        private string diliveryNote = string.Empty;
        public string DiliveryNote
        {
            get
            {
                return diliveryNote;
            }
            set
            {
                diliveryNote = value;
                NotifyPropertyChanged();
            }
        }
        private string vehicleNumber = string.Empty;
        public string VehicleNumber
        {
            get
            {
                return vehicleNumber;
            }
            set
            {
                vehicleNumber = value;
                NotifyPropertyChanged();
            }
        }
        private string esugam = string.Empty;
        public string Esugam
        {
            get
            {
                return esugam;
            }
            set
            {
                esugam = value;
                NotifyPropertyChanged();
            }
        }
        private string irNumber = string.Empty;
        public string IrNumber
        {
            get
            {
                return irNumber;
            }
            set
            {
                irNumber = value;
                NotifyPropertyChanged();
            }
        }
        private string shippingMethod = string.Empty;
        public string ShippingMethod
        {
            get
            {
                return shippingMethod;
            }
            set
            {
                shippingMethod = value;
                NotifyPropertyChanged();
            }
        }
        private string exciseCess = string.Empty;
        public string ExciseCess
        {
            get
            {
                return exciseCess;
            }
            set
            {
                exciseCess = value;
                NotifyPropertyChanged();
            }
        }
        private bool isCancelled = false;
        public bool IsCancelled
        {
            get
            {
                return isCancelled;
            }
            set
            {
                isCancelled = value;
                NotifyPropertyChanged();
            }
        }
        private bool quantityNumberDecimal = false;
        public bool QuantityNumberDecimal
        {
            get
            {
                return quantityNumberDecimal;
            }
            set
            {
                quantityNumberDecimal = value;
                NotifyPropertyChanged();
            }
        }
        private bool productInlineDiscount = false;
        public bool ProductInlineDiscount
        {
            get
            {
                return productInlineDiscount;
            }
            set
            {
                productInlineDiscount = value;
                NotifyPropertyChanged();
            }
        }
        private int esugamLabel = 0;
        public int EsugamLabel
        {
            get
            {
                return esugamLabel;
            }
            set
            {
                esugamLabel = value;
                NotifyPropertyChanged();
            }
        }
        private DateTime poDate = DateTime.Now;
        public DateTime PODate
        {
            get
            {
                return poDate;
            }
            set
            {
                poDate = value;
                NotifyPropertyChanged();
            }
        }
        private string gstType = string.Empty;
        public string GSTType
        {
            get
            {
                return gstType;
            }
            set
            {
                gstType = value;
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
    }
}
