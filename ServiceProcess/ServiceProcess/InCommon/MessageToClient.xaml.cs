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
                FindClient_Repairer find = new FindClient_Repairer();
                find.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error while sending a message!");
            }
        }
    }
}
