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
    /// Interaction logic for FindClient_Repairer.xaml
    /// </summary>
    public partial class FindClient_Repairer : Window
    {
        public FindClient_Repairer()
        {
            InitializeComponent();
            var clients = ClientCRUD.LoadClients();
            dg_clients.ItemsSource = clients;
        }

        private void Button_Search(object sender, RoutedEventArgs e)
        {
            List<Client> search_result_clients = new List<Client>();
            if (cb_criteria.Text.Equals("Clients name"))
            {
                search_result_clients = SearchClient(Enums.SearchCriteria.name, tb_for_search.Text, dg_clients);
                dg_clients.ItemsSource = search_result_clients;
            }
            else if (cb_criteria.Text.Equals("Clients surname"))
            {
                search_result_clients = SearchClient(Enums.SearchCriteria.surname, tb_for_search.Text, dg_clients);
                dg_clients.ItemsSource = search_result_clients;
            }
            else if (cb_criteria.Text.Equals("Clients email"))
            {
                search_result_clients = SearchClient(Enums.SearchCriteria.email, tb_for_search.Text, dg_clients);
                dg_clients.ItemsSource = search_result_clients;
            }
        }

        private List<Client> SearchClient(Enums.SearchCriteria criteria, string text, DataGrid datagrid)
        {
            var clients = ClientCRUD.LoadClients();
            List<Client> searched_clients = new List<Client>();
            if (text.Length > 1 & criteria == Enums.SearchCriteria.name)
            {
                datagrid.ItemsSource = null;

                foreach (var client in clients)
                {
                    if (client.Name.ToLower().Contains(text.ToLower()))
                    {
                        searched_clients.Add(client);
                    }
                }
            }
            else if (text.Length > 1 & criteria == Enums.SearchCriteria.surname)
            {
                datagrid.ItemsSource = null;

                foreach (var client in clients)
                {
                    if (client.Surname.ToLower().Contains(text.ToLower()))
                    {
                        searched_clients.Add(client);
                    }
                }
            }
            else if (text.Length > 1 & criteria == Enums.SearchCriteria.email)
            {
                datagrid.ItemsSource = null;

                foreach (var client in clients)
                {
                    if (client.EmailAddress.ToLower().Contains(text.ToLower()))
                    {
                        searched_clients.Add(client);
                    }
                }
            }
            return searched_clients;
        }

        private void Button_SendMessage(object sender, RoutedEventArgs e)
        {
            if(dg_clients.SelectedItem != null)
            {
                var selected_client = (Client)dg_clients.SelectedItem;
                CurrentClientInfo.EmailAddress = selected_client.EmailAddress;
                MessageToClient_MainRepairer message = new MessageToClient_MainRepairer();
                message.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select a client!");
            }
        }
    }
}