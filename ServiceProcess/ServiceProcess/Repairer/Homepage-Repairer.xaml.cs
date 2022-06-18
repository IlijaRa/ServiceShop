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
    /// Interaction logic for Homepage_Repairer.xaml
    /// </summary>
    public partial class Homepage_Repairer : Window
    {
        public Homepage_Repairer()
        {
            InitializeComponent();
        }

        private void Button_FindClient(object sender, RoutedEventArgs e)
        {
            FindClient_Repairer find = new FindClient_Repairer();
            find.Show();
            this.Hide();
        }

        private void Button_WriteReport(object sender, RoutedEventArgs e)
        {
            WriteReport_Repairer report = new WriteReport_Repairer();
            report.Show();
            this.Hide();
        }
    }
}
