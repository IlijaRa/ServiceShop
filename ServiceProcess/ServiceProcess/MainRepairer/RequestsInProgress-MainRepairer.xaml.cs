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
    /// Interaction logic for RequestsInProgress.xaml
    /// </summary>
    public partial class RequestsInProgress : Window
    {
        public RequestsInProgress()
        {
            InitializeComponent();
            var requests = NotificationCRUD.LoadRequests();
            List<Request> in_progress_requests = new List<Request>();
            foreach (var request in requests)
            {
                if (request.StateType == Enums.StateType.in_progress)
                {
                    in_progress_requests.Add(request);
                }
            }
            dg_requests.ItemsSource = in_progress_requests;
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

    }
}
