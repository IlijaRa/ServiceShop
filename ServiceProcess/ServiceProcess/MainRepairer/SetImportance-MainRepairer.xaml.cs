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
using System.Windows.Shapes;
using ServiceProcessLibrary.Model;
namespace ServiceProcess.MainRepairer
{
    /// <summary>
    /// Interaction logic for SetImportance_MainRepairer.xaml
    /// </summary>
    public partial class SetImportance_MainRepairer : Window
    {
        private readonly ClientRequests_MainRepairer _client_request_page;
        public SetImportance_MainRepairer(ClientRequests_MainRepairer client_request_page)
        {
            InitializeComponent();
            _client_request_page = client_request_page;
        }

        private void Button_Confirm(object sender, RoutedEventArgs e)
        {
            if (rb_low_importance.IsChecked == true)
            {
                RequestCRUD.UpdateImportance(_client_request_page._selected_request.Id, "0");
            }
            else if (rb_mid_importance.IsChecked == true)
            {
                RequestCRUD.UpdateImportance(_client_request_page._selected_request.Id, "1");
            }
            else if (rb_high_importance.IsChecked == true)
            {
                RequestCRUD.UpdateImportance(_client_request_page._selected_request.Id, "2");
            }
            else if (rb_extreme_importance.IsChecked == true)
            {
                RequestCRUD.UpdateImportance(_client_request_page._selected_request.Id, "3");
            }
            MessageBox.Show("Importance is updated!");
            this.Hide();
        }
    }
}
