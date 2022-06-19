using ServiceProcessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ServiceProcess
{
    /// <summary>
    /// Interaction logic for Homepage_Client.xaml
    /// </summary>
    public partial class Homepage_Client : Window
    {
        public Homepage_Client()
        {
            InitializeComponent();
            tb_name.Text = CurrentClientInfo.Name;
            tb_surname.Text = CurrentClientInfo.Surname;
            tb_email.Text = CurrentClientInfo.EmailAddress;
            tb_delivery_address.Text = CurrentClientInfo.DeliveryAddress;
            tb_delivery_city.Text = CurrentClientInfo.DeliveryCity;
            tb_postal_code.Text = CurrentClientInfo.PostalCode;
            tb_phone_number.Text = CurrentClientInfo.PhoneNumber;
        }

        private void Button_Profile(object sender, RoutedEventArgs e)
        {
            Homepage_Client homepage = new Homepage_Client();
            homepage.Show();
            this.Hide();
        }

        private void Button_MalfunctionReport(object sender, RoutedEventArgs e)
        {
            ReportMalfunction_Client report = new ReportMalfunction_Client();
            report.Show();
            this.Hide();
        }

    }
}
