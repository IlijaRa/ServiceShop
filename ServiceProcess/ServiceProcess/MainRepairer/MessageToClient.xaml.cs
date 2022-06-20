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
    /// Interaction logic for MessageToClient_MainRepairer.xaml
    /// </summary>
    public partial class MessageToClient_MainRepairer : Window
    {
        public MessageToClient_MainRepairer()
        {
            InitializeComponent();
            tb_to.Text = CurrentClientInfo.EmailAddress;
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
            int result = MessageCRUD.CreateMessage(tb_to.Text,
                                                   tb_subject.Text,
                                                   tb_message.Text,
                                                   CurrentRepairerInfo.EmailAddress,
                                                   DateTime.Now,
                                                   Enums.MessageStatus.unread);

            if(result == 1)
            {
                HomepageForMainRepairer_Client find = new HomepageForMainRepairer_Client();
                find.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error while sending a message!");
            }
        }

        private void Button_GoBack(object sender, RoutedEventArgs e)
        {
            Homepage_MainRepairer homepage = new Homepage_MainRepairer();
            homepage.Show();
            this.Hide();
        }
    }
}
