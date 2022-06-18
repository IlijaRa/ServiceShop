using ServiceProcessLibrary.BusinessLogic;
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
                    //TODO: make clients homepage
                }
            }
            foreach (var repairer in repairers)
            {
                if (repairer.EmailAddress.Equals(tb_email.Text) & repairer.Password.Equals(tb_password.Password.ToString()) & repairer.role == ServiceProcessLibrary.Model.Enums.RepairerRoles.MainRepairer)
                {
                    Homepage_MainRepairer homepage = new Homepage_MainRepairer();
                    homepage.Show();
                    this.Hide();
                    break;
                }
                else if (repairer.EmailAddress.Equals(tb_email.Text) & repairer.Password.Equals(tb_password.Password.ToString()) & repairer.role == ServiceProcessLibrary.Model.Enums.RepairerRoles.Repairer)
                {
                    Homepage_Repairer homepage = new Homepage_Repairer();
                    homepage.Show();
                    this.Hide();
                    break;
                }
            }
        }
    }
}
