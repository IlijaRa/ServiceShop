using ServiceProcessLibrary.BusinessLogic;
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
    /// Interaction logic for ReportMalfunction_Client.xaml
    /// </summary>
    public partial class ReportMalfunction_Client : Window
    {
        public ReportMalfunction_Client()
        {
            InitializeComponent();
            tb_name.Text = CurrentClientInfo.Name;
            tb_surname.Text = CurrentClientInfo.Surname;
            tb_email.Text = CurrentClientInfo.EmailAddress;
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

        private void Button_GoBack(object sender, RoutedEventArgs e)
        {
            Homepage_Client homepage = new Homepage_Client();
            homepage.Show();
            this.Hide();
        }

        private void Button_Send(object sender, RoutedEventArgs e)
        {
            int result = NotificationCRUD.CreateMalfunctionRequest(CurrentClientInfo.Name, 
                                                 CurrentClientInfo.Surname, 
                                                 CurrentClientInfo.EmailAddress, 
                                                 "Equipment name :" + tb_equipment_name.Text + '\n' + tb_details.Text,
                                                 Enums.RequestType.repairment,
                                                 Enums.StateType.not_forwarded,
                                                 cb_payment.Text,
                                                 DateTime.Now);
            if (result == 1)
            {
                tb_name.Clear();
                tb_surname.Clear();
                tb_email.Clear();
                tb_equipment_name.Clear();
                tb_details.Clear();
                cb_payment.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Error while sending a report!");
            }
        }
    }
}
