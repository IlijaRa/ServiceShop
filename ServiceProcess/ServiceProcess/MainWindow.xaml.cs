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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ServiceProcess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonLogIn(object sender, RoutedEventArgs e)
        {
            var clients = ClientCRUD.LoadClients();
            var repairers = RepairerCRUD.LoadRepairers();

            foreach (var client in clients)
            {
                if(client.EmailAddress.Equals(tb_email.Text) & client.Password.Equals(tb_password.Password))
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

                    Homepage_Client homepage = new Homepage_Client();
                    homepage.Show();
                    this.Hide();
                    break;
                }
            }
            foreach (var repairer in repairers)
            {
                if (repairer.EmailAddress.Equals(tb_email.Text) & repairer.Password.Equals(tb_password.Password.ToString()) & repairer.role == ServiceProcessLibrary.Model.Enums.RepairerRoles.MainRepairer)
                {
                    CurrentRepairerInfo.Id = repairer.Id;
                    CurrentRepairerInfo.Name = repairer.Name;
                    CurrentRepairerInfo.Surname = repairer.Surname;
                    CurrentRepairerInfo.EmailAddress = repairer.EmailAddress;
                    CurrentRepairerInfo.Longevity = repairer.Longevity;
                    CurrentRepairerInfo.Birthday = repairer.Birthday;
                    CurrentRepairerInfo.role = repairer.role;
                    CurrentRepairerInfo.SuperiorsEmailAddress = repairer.SuperiorsEmailAddress;

                    Homepage_MainRepairer homepage = new Homepage_MainRepairer();
                    homepage.Show();
                    this.Hide();
                    break;
                }
                else if (repairer.EmailAddress.Equals(tb_email.Text) & repairer.Password.Equals(tb_password.Password.ToString()) & repairer.role == ServiceProcessLibrary.Model.Enums.RepairerRoles.Repairer)
                {
                    CurrentRepairerInfo.Id = repairer.Id;
                    CurrentRepairerInfo.Name = repairer.Name;
                    CurrentRepairerInfo.Surname = repairer.Surname;
                    CurrentRepairerInfo.EmailAddress = repairer.EmailAddress;
                    CurrentRepairerInfo.Longevity = repairer.Longevity;
                    CurrentRepairerInfo.Birthday = repairer.Birthday;
                    CurrentRepairerInfo.role = repairer.role;
                    CurrentRepairerInfo.SuperiorsEmailAddress = repairer.SuperiorsEmailAddress;

                    Homepage_Repairer homepage = new Homepage_Repairer();
                    homepage.Show();
                    this.Hide();
                    break;
                }
            }
        }
    }
}
