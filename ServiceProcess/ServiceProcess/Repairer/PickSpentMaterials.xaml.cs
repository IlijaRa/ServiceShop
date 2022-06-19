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
    /// Interaction logic for PickSpentMaterials.xaml
    /// </summary>
    public partial class PickSpentMaterials : Window
    {
        public BillGenerator_Repairer _bill;
        public PickSpentMaterials(BillGenerator_Repairer bill)
        {
            InitializeComponent();
            _bill = bill;
            dg_materials.ItemsSource = MaterialCRUD.LoadMaterials();
            tb_price.Text = "0";
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

        private void Button_SearchMaterials(object sender, RoutedEventArgs e)
        {
            List<Material> search_result_materials = new List<Material>();
            if (cb_criteria.Text.Equals("Name"))
            {
                search_result_materials = SearchMaterials(Enums.SearchCriteria.name, tb_for_search.Text, dg_materials);
                dg_materials.ItemsSource = search_result_materials;
            }
        }

        private List<Material> SearchMaterials(Enums.SearchCriteria criteria, string text, DataGrid datagrid)
        {
            var materials = MaterialCRUD.LoadMaterials();
            List<Material> searched_materials = new List<Material>();
            if (text.Length > 1 & criteria == Enums.SearchCriteria.name)
            {
                datagrid.ItemsSource = null;

                foreach (var material in materials)
                {
                    if (material.Name.ToLower().Contains(text.ToLower()))
                    {
                        searched_materials.Add(material);
                    }
                }
            }

            return searched_materials;
        }

        private void ButtonPick(object sender, RoutedEventArgs e)
        {
            if(dg_materials.SelectedItem != null)
            {
                var selected_material = (Material)dg_materials.SelectedItem;
                lb_picked_materials.Items.Add(selected_material.Name);
                double current_price = Convert.ToDouble(tb_price.Text);
                current_price += (selected_material.Price + (selected_material.Price * (selected_material.EarningPercentage / 100)));
                tb_price.Text = Convert.ToString(current_price);
            }
            else
            {
                MessageBox.Show("Select a material!");
            }
        }

        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            tb_price.Text = "0";
            lb_picked_materials.Items.Clear();
        }

        private void Button_Done(object sender, RoutedEventArgs e)
        {
            _bill.tb_price.Text = tb_price.Text;
            _bill.lb_spent_materials.ItemsSource = lb_picked_materials.Items;
            this.Hide();
        }
    }
}
