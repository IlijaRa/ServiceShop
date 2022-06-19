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
    /// Interaction logic for ChooseRepairer_MainRepairer.xaml
    /// </summary>
    public partial class ChooseRepairer_MainRepairer : Window
    {
        public readonly Request _request;
        public ChooseRepairer_MainRepairer(Request request)
        {
            InitializeComponent();
            _request = request;

            var repairers = RepairerCRUD.LoadRepairers();
            List<Repairer> list_repairers = new List<Repairer>();
            foreach (var repairer in repairers)
            {
                if(repairer.SuperiorsEmailAddress != null)
                {
                    list_repairers.Add(repairer);
                }
            }
            dg_repairers.ItemsSource = list_repairers;
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

        private void Button_SearchRequest(object sender, RoutedEventArgs e)
        {
            List<Repairer> search_result_repairers = new List<Repairer>();
            if (cb_criteria.Text.Equals("Name"))
            {
                search_result_repairers = SearchRepairer(Enums.SearchCriteria.name, tb_for_search.Text, dg_repairers);
                dg_repairers.ItemsSource = search_result_repairers;
            }
            if (cb_criteria.Text.Equals("Surname"))
            {
                search_result_repairers = SearchRepairer(Enums.SearchCriteria.surname, tb_for_search.Text, dg_repairers);
                dg_repairers.ItemsSource = search_result_repairers;
            }
            if (cb_criteria.Text.Equals("Email"))
            {
                search_result_repairers = SearchRepairer(Enums.SearchCriteria.email, tb_for_search.Text, dg_repairers);
                dg_repairers.ItemsSource = search_result_repairers;
            }
        }

        private List<Repairer> SearchRepairer(Enums.SearchCriteria criteria, string text, DataGrid datagrid)
        {
            var repairers = RepairerCRUD.LoadRepairers();
            List<Repairer> searched_repairers = new List<Repairer>();
            if (text.Length > 1 & criteria == Enums.SearchCriteria.name)
            {
                datagrid.ItemsSource = null;

                foreach (var repairer in repairers)
                {
                    if (repairer.Name.ToLower().Contains(text.ToLower()))
                    {
                        searched_repairers.Add(repairer);
                    }
                }
            }
            else if (text.Length > 1 & criteria == Enums.SearchCriteria.surname)
            {
                datagrid.ItemsSource = null;

                foreach (var repairer in repairers)
                {
                    if (repairer.Surname.ToLower().Contains(text.ToLower()))
                    {
                        searched_repairers.Add(repairer);
                    }
                }
            }
            else if (text.Length > 1 & criteria == Enums.SearchCriteria.email)
            {
                datagrid.ItemsSource = null;

                foreach (var repairer in repairers)
                {
                    if (repairer.EmailAddress.ToLower().Contains(text.ToLower()))
                    {
                        searched_repairers.Add(repairer);
                    }
                }
            }

            return searched_repairers;
        }

        private void Button_ForwardToRepairer(object sender, RoutedEventArgs e)
        {
            if(dg_repairers.SelectedItem != null)
            {
                var repairer = (Repairer)dg_repairers.SelectedItem;
                int result = NotificationCRUD.UpdateRequestInProgress(_request.Id, repairer.Id);

                if(result == 1)
                {
                    MessageBox.Show("Request is forwarded to a repairer");
                }
                else
                {
                    MessageBox.Show("Error occured while forwarding a request!");
                }
            }
            else
            {
                MessageBox.Show("Select a repairer!");
            }
        }
    }
}
