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
    /// Interaction logic for WriteReport_Repairer.xaml
    /// </summary>
    public partial class WriteReport_Repairer : Window
    {
        public WriteReport_Repairer()
        {
            InitializeComponent();
            tb_to.Text = CurrentRepairerInfo.SuperiorsEmailAddress;
            cb_involved_client.ItemsSource = null;
            cb_involved_client.ItemsSource = ClientCRUD.LoadClientsEmails();
        }

        private void Button_SendReport(object sender, RoutedEventArgs e)
        {
            int result = NotificationCRUD.CreateReport(cb_involved_client.Text,
                                                       tb_subject.Text,
                                                       tb_details.Text,
                                                       Convert.ToInt32(cb_mark.Text),
                                                       CurrentRepairerInfo.Id
                                                       );
            if(result == 1)
            {
                Homepage_Repairer homepage = new Homepage_Repairer();
                homepage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error occured while sending your report");
            }
        }
    }
}
