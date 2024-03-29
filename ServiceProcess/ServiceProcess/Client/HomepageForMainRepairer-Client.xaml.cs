﻿using ServiceProcessLibrary.Model;
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
    public partial class HomepageForMainRepairer_Client : Window
    {
        public HomepageForMainRepairer_Client()
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

        private void Button_SendMessage(object sender, RoutedEventArgs e)
        {
            MessageToClient_MainRepairer message = new MessageToClient_MainRepairer();
            message.Show();
            this.Hide();
        }
    }
}
