﻿using ServiceProcessLibrary.BusinessLogic;
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

        private void Button_SearchRequests(object sender, RoutedEventArgs e)
        {
            List<Request> search_result_requests = new List<Request>();
            if (cb_criteria.Text.Equals("Clients name"))
            {
                search_result_requests = SearchRequests(Enums.SearchCriteria.name, tb_for_search.Text, dg_requests);
                dg_requests.ItemsSource = search_result_requests;
            }
            if (cb_criteria.Text.Equals("Clients surname"))
            {
                search_result_requests = SearchRequests(Enums.SearchCriteria.surname, tb_for_search.Text, dg_requests);
                dg_requests.ItemsSource = search_result_requests;
            }
            if (cb_criteria.Text.Equals("Clients email"))
            {
                search_result_requests = SearchRequests(Enums.SearchCriteria.email, tb_for_search.Text, dg_requests);
                dg_requests.ItemsSource = search_result_requests;
            }
            if (cb_criteria.Text.Equals("Payment type"))
            {
                search_result_requests = SearchRequests(Enums.SearchCriteria.payment_type, tb_for_search.Text, dg_requests);
                dg_requests.ItemsSource = search_result_requests;
            }
        }
        private List<Request> SearchRequests(Enums.SearchCriteria criteria, string text, DataGrid datagrid)
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
    }
}
