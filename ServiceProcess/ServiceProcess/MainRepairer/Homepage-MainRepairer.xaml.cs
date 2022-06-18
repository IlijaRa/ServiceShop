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
    /// Interaction logic for Homepage_MainRepairer.xaml
    /// </summary>
    public partial class Homepage_MainRepairer : Window
    {
        public Homepage_MainRepairer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(CurrentRepairerInfo.Name);
        }
    }
}
