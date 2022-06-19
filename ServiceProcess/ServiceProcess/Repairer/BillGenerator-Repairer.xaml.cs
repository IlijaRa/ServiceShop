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
    /// Interaction logic for BillGenerator_Repairer.xaml
    /// </summary>
    public partial class BillGenerator_Repairer : Window
    {
        public readonly Request _request;
        public BillGenerator_Repairer(Request request)
        {
            InitializeComponent();
            _request = request;

            tb_enterprise_name.Text = "Service and purchasement";
            tb_enterprise_address.Text = "Cara Lazara 15, Kraljevo";
            tb_clients_name.Text = _request.ClientsName;
            tb_clients_surname.Text = _request.ClientsSurname;
            tb_clients_address.Text = _request.ClientsEmailAddress;
            tb_terms_conditions.Text = @"a warranty and returns policy – to handle returns in terms of the CPA;
a security policy – if you are taking credit card payments yourself or through a payment gateway;
an acceptable use policy – if users have the potential to abuse your website;
comprehensive terms of use, terms of sale, or a privacy policy – if you need more thorough protection; or
attending our workshop ‘Legal Boot Camp for your Online Business’ – if you want to get an overview of the law that applies to your online business.";
        }

        private void Button_Profile(object sender, RoutedEventArgs e)
        {
            Homepage_Repairer homepage = new Homepage_Repairer();
            homepage.Show();
            this.Hide();
        }

        private void Button_FindClient(object sender, RoutedEventArgs e)
        {
            FindClient_Repairer find = new FindClient_Repairer();
            find.Show();
            this.Hide();
        }

        private void Button_Calculate(object sender, RoutedEventArgs e)
        {
            PickSpentMaterials materials = new PickSpentMaterials(this);
            materials.ShowDialog();
        }

        private void Button_GoBack(object sender, RoutedEventArgs e)
        {
            Homepage_Repairer homepage = new Homepage_Repairer();
            homepage.Show();
            this.Hide();
        }

        private void Button_Generate(object sender, RoutedEventArgs e)
        {
            string spent_materials = "";

            for (int i = 0; i < lb_spent_materials.Items.Count; i++)
            {
                spent_materials = spent_materials  + lb_spent_materials.Items[i].ToString() + ",";
            }
            int resuilt = BillCRUD.CreateBill(tb_bill_name.Text,
                                tb_enterprise_name.Text, 
                                tb_enterprise_address.Text, 
                                tb_clients_name.Text, 
                                tb_clients_surname.Text, 
                                tb_clients_address.Text, 
                                Convert.ToDouble(tb_price.Text), 
                                spent_materials,
                                tb_terms_conditions.Text);
            if(resuilt == 1)
            {
                MessageBox.Show("The bill is generated");

                NotificationCRUD.UpdateRequestBillName(_request.Id, tb_bill_name.Text);

                Homepage_Repairer homepage = new Homepage_Repairer();
                homepage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error occured while generating the bill!");
            }
        }
    }
}
