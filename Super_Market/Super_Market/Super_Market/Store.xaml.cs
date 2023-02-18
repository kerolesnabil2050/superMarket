using System;
using System.Collections.Generic;
using System.Data;
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

namespace Super_Market
{
    /// <summary>
    /// Interaction logic for Store.xaml
    /// </summary>
    public partial class Store : UserControl
    {
        Context context=new Context();
        public Store()
        {
            InitializeComponent();
            Fillgrid();
            // 
        }

        private void Fillgrid()
        {
            datagrid.ItemsSource = context.Stors.ToList();       
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void comstore_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            context.Stors.Add(new Stor { Name = txtstor.Text, Location = txtloc.Text });
            context.SaveChanges();
            datagrid.ItemsSource = "";
            Fillgrid();
            txtloc.Text = "";
            txtstor.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var selectedItem = datagrid.SelectedItem;
            var properties = selectedItem.GetType().GetProperties();
            int id = Convert.ToInt32(properties[0].GetValue(selectedItem));
            var stor = context.Stors.Where(s => s.Id == id).FirstOrDefault();
            stor.Name = txtstor.Text;
            stor.Location=txtloc.Text;
            context.SaveChanges();
            datagrid.ItemsSource = "";
            Fillgrid();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var stor = context.Stors.Where(s => s.Name == txtstor.Text).FirstOrDefault();
            
                context.Stors.Remove(stor);
            
            context.SaveChanges();
            datagrid.ItemsSource = "";
            Fillgrid();

        }

        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }
    }
}
