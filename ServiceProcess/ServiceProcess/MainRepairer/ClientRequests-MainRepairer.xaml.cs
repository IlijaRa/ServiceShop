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
    /// Interaction logic for ClientRequests_MainRepairer.xaml
    /// </summary>
    public partial class ClientRequests_MainRepairer : Window
    {
        public ClientRequests_MainRepairer()
        {
            InitializeComponent();
            var requests = NotificationCRUD.LoadRequests();
            List<Request> not_forwarded_requests = new List<Request>();
            foreach (var request in requests)
            {
                if(request.StateType == Enums.StateType.not_forwarded)
                {
                    not_forwarded_requests.Add(request);
                }
            }
            dg_requests.ItemsSource = not_forwarded_requests;
        }

        private void Button_Profile(object sender, RoutedEventArgs e)
        {
            Homepage_MainRepairer homepage = new Homepage_MainRepairer();
            homepage.Show();
            this.Hide();
        }

        private void Button_SearchRequests(object sender, RoutedEventArgs e)
        {
            List<Request> search_result_requests = new List<Request>();
            if (cb_criteria.Text.Equals("Clients name"))
            {
                search_result_requests = SearchClient(Enums.SearchCriteria.name, tb_for_search.Text, dg_requests);
                dg_requests.ItemsSource = search_result_requests;
            }
            else if (cb_criteria.Text.Equals("Clients surname"))
            {
                search_result_requests = SearchClient(Enums.SearchCriteria.surname, tb_for_search.Text, dg_requests);
                dg_requests.ItemsSource = search_result_requests;
            }
            else if (cb_criteria.Text.Equals("Clients email"))
            {
                search_result_requests = SearchClient(Enums.SearchCriteria.email, tb_for_search.Text, dg_requests);
                dg_requests.ItemsSource = search_result_requests;
            }
            else if (cb_criteria.Text.Equals("Payment type"))
            {
                search_result_requests = SearchClient(Enums.SearchCriteria.payment_type, tb_for_search.Text, dg_requests);
                dg_requests.ItemsSource = search_result_requests;
            }
        }

        private List<Request> SearchClient(Enums.SearchCriteria criteria, string text, DataGrid datagrid)
        {
            var requests = NotificationCRUD.LoadRequests();
            List<Request> searched_requests = new List<Request>();
            if (text.Length > 1 & criteria == Enums.SearchCriteria.name)
            {
                datagrid.ItemsSource = null;

                foreach (var request in requests)
                {
                    if (request.ClientsName.ToLower().Contains(text.ToLower()))
                    {
                        searched_requests.Add(request);
                    }
                }
            }
            else if (text.Length > 1 & criteria == Enums.SearchCriteria.surname)
            {
                datagrid.ItemsSource = null;

                foreach (var request in requests)
                {
                    if (request.ClientsSurname.ToLower().Contains(text.ToLower()))
                    {
                        searched_requests.Add(request);
                    }
                }
            }
            else if (text.Length > 1 & criteria == Enums.SearchCriteria.email)
            {
                datagrid.ItemsSource = null;

                foreach (var request in requests)
                {
                    if (request.ClientsEmailAddress.ToLower().Contains(text.ToLower()))
                    {
                        searched_requests.Add(request);
                    }
                }
            }
            else if (text.Length > 1 & criteria == Enums.SearchCriteria.payment_type)
            {
                datagrid.ItemsSource = null;

                foreach (var request in requests)
                {
                    if (request.PaymentType.ToLower().Contains(text.ToLower()))
                    {
                        searched_requests.Add(request);
                    }
                }
            }

            return searched_requests;
        }

        private void Button_DeletionExplanation(object sender, RoutedEventArgs e)
        {
            if(dg_requests.SelectedItem != null)
            {
                var selected_request = (Request)dg_requests.SelectedItem;
                CurrentClientInfo.EmailAddress = selected_request.ClientsEmailAddress;
                DeletionExplanation deletion = new DeletionExplanation(selected_request);
                deletion.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select a request!");
            }
        }

        private void Button_SeeAcount(object sender, RoutedEventArgs e)
        {
            var selected_request = (Request)dg_requests.SelectedItem;
            var clients = ClientCRUD.LoadClients();

            foreach (var client in clients)
            {
                if (client.EmailAddress.Equals(selected_request.ClientsEmailAddress))
                {
                    CurrentClientInfo.Id = client.Id;
                    CurrentClientInfo.Name = client.Name;
                    CurrentClientInfo.Surname = client.Surname;
                    CurrentClientInfo.EmailAddress = client.EmailAddress;
                    CurrentClientInfo.DeliveryAddress = client.DeliveryAddress;
                    CurrentClientInfo.DeliveryCity = client.DeliveryCity;
                    CurrentClientInfo.PostalCode = client.PostalCode;
                    CurrentClientInfo.Birthday = client.Birthday;
                    CurrentClientInfo.PhoneNumber = client.PhoneNumber;

                    break;
                }
            }

            HomepageForMainRepairer_Client homepage = new HomepageForMainRepairer_Client();
            homepage.Show();
            this.Hide();
        }
    }
}
