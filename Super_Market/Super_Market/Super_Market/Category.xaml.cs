using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Super_Market
{
    /// <summary>
    /// Interaction logic for Category.xaml
    /// </summary>
    public partial class Category : UserControl
    {
        public Category()
        {
            InitializeComponent();
            Fill_Combox_WithStore();
            Fill_dataGrid_WithCategories();
        }

        private void Fill_Combox_WithStore()
        {
            store_combo.ItemsSource= SampleData.st;
         
        }
        private void Fill_dataGrid_WithCategories()
        {
            foreach(var item in SampleData.Allcategorys)
            {
                datagrid.Items.Add(item);
            }
          
             
        }

        private void store_combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Stor stores = store_combo.SelectedItem as Stor;

            //foreach (var item in stores.Categories)
            //{
            //    datagrid.Items.Add(item);
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            // Stor stores = store_combo.SelectedItem as Stor;
            // stores.Categories.Add(new Categorys { Name=category.Text});

            SampleData.Allcategorys.Add(new Categorys { Name = category.Text });
            datagrid.Items.Clear();
            Fill_dataGrid_WithCategories();
            store_combo.Text = "";
            category.Text = "";
        }
    }
}
