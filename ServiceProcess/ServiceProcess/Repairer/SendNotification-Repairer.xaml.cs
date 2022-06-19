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
    /// Interaction logic for SendNotification_Repairer.xaml
    /// </summary>
    public partial class SendNotification_Repairer : Window
    {
        public readonly Request _request;
        public SendNotification_Repairer(Request request)
        {
            InitializeComponent();
            _request = request;
            tb_to.Text = CurrentRepairerInfo.SuperiorsEmailAddress;
            cb_choose_bill.ItemsSource = BillCRUD.LoadBillNames();
        }

        private void Button_GoBack(object sender, RoutedEventArgs e)
        {
            Homepage_Repairer homepage = new Homepage_Repairer();
            homepage.Show();
            this.Hide();
        }

        private void Button_Send(object sender, RoutedEventArgs e)
        {
            var bills = BillCRUD.LoadBills();
            Bill choosen_one_bill = new Bill();
            foreach (var bill in bills)
            {
                if(bill.Name == cb_choose_bill.Text)
                {
                    choosen_one_bill = bill;
                    break;
                }
            }

            int result = NotificationCRUD.CreateNotification(choosen_one_bill.ClientsEmailAddress,
                                                        tb_subject.Text,
                                                        tb_message.Text,
                                                        choosen_one_bill.Id,
                                                        CurrentRepairerInfo.Id);
            if (result == 1)
            {
                MessageBox.Show("Notification is sent to the Main repairer!");

                var notifications = NotificationCRUD.LoadNotifications();
                Notification vanted_not = new Notification();
                foreach (var notification in notifications)
                {
                    if(notification.Title.Equals(tb_subject.Text) & notification.Text.Equals(tb_message.Text))
                    {
                        vanted_not = notification;
                    }
                }

                NotificationCRUD.UpdateRequestNotificationId(_request.Id, vanted_not.Id);

                Homepage_Repairer homepage = new Homepage_Repairer();
                homepage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error occured while sending a notification!");
            }

        }
    }
}
