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

namespace Super_Market
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

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

            stores.Content = new Store();
        }

        private void list_2_Selected(object sender, RoutedEventArgs e)
        {
            stores.Content = new Category();
        }

        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            stores.Content = new Product();
        }

        private void ListViewItem_Selected_2(object sender, RoutedEventArgs e)
        {
            stores.Content = new Sales();
        }

        private void ListViewItem_Selected_3(object sender, RoutedEventArgs e)
        {
            stores.Content = new Purchase();
        }

        private void ListViewItem_Selected_4(object sender, RoutedEventArgs e)
        {
            stores.Content = new Report();
        }

        private void ListViewItem_Selected_5(object sender, RoutedEventArgs e)
        {
            stores.Content = new Home();
        }

        private void ListViewItem_Selected_6(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
