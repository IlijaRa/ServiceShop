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
    /// Interaction logic for DeletionExplanation.xaml
    /// </summary>
    public partial class DeletionExplanation : Window
    {
        Request request = new Request();
        public DeletionExplanation(Request request_for_deletion)
        {
            InitializeComponent();
            tb_to.Text = CurrentClientInfo.EmailAddress;
            request = request_for_deletion;
        }

        private void Button_Send(object sender, RoutedEventArgs e)
        {
            int result = NotificationCRUD.DeleteRequest(request.Id);
            
            if(result == 1)
            {
                int message_result = MessageCRUD.CreateMessage(tb_to.Text,
                                          tb_subject.Text,
                                          tb_message.Text,
                                          CurrentRepairerInfo.EmailAddress,
                                          DateTime.Now,
                                          Enums.MessageStatus.unread);

                if(message_result == 1)
                {
                    ClientRequests_MainRepairer request = new ClientRequests_MainRepairer();
                    request.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error occured while sending a message!");
                }
            }
            else
            {
                MessageBox.Show("Error occured while deleting a request!");
            }
        }

        private void Button_GoBack(object sender, RoutedEventArgs e)
        {
            ClientRequests_MainRepairer requests = new ClientRequests_MainRepairer();
            requests.Show();
            this.Hide();
        }
    }
}
