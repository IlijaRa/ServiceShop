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
    /// Interaction logic for Homepage_MainRepairer.xaml
    /// </summary>
    public partial class Homepage_MainRepairer : Window
    {
        public Homepage_MainRepairer()
        {
            InitializeComponent();
            tb_name.Text = CurrentRepairerInfo.Name;
            tb_surname.Text = CurrentRepairerInfo.Surname;
            tb_email.Text = CurrentRepairerInfo.EmailAddress;
            tb_longevity.Text = CurrentRepairerInfo.Longevity.ToString();
            tb_birthday.Text = CurrentRepairerInfo.Birthday.ToString("MM/dd/yyyy");
            tb_role.Text = "Main repairer";
            dg_history.ItemsSource = HistoryCRUD.LoadHistoryJobs();
        }

        private void Button_ClientRequests(object sender, RoutedEventArgs e)
        {
            ClientRequests_MainRepairer requests = new ClientRequests_MainRepairer();
            requests.Show();
            this.Hide();
        }

        private void Button_RequestsInProgress(object sender, RoutedEventArgs e)
        {
            RequestsInProgress requests = new RequestsInProgress();
            requests.Show();
            this.Hide();
        }

        private void Button_FinishedRequests(object sender, RoutedEventArgs e)
        {
            FinishedRequests_MainRepairer requests = new FinishedRequests_MainRepairer();
            requests.Show();
            this.Hide();
        }

        private void Button_Profile(object sender, RoutedEventArgs e)
        {
            Homepage_MainRepairer homepage = new Homepage_MainRepairer();
            homepage.Show();
            this.Hide();
        }

        private void Button_GenerateReport(object sender, RoutedEventArgs e)
        {
            ServiceProcessReport.Report report = new ServiceProcessReport.Report();
            report.Show();
            this.Hide();
        }
    }
}
