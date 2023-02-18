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
    /// Interaction logic for Sales.xaml
    /// </summary>
    public partial class Sales : UserControl
    {
        Context context=new Context();
        public Sales()
        {
            InitializeComponent();
           combstor.ItemsSource = context.Stors.ToList();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(comcat.SelectedItem != null)
            {
                //comcat.SelectedItem = context.Categorys.FirstOrDefault(d=>d.Id==1);
                var categor = (Categorys)comcat.SelectedItem;
                var proudects = context.proudcts.Where(p => p.category.Id == categor.Id);
                combproduct.ItemsSource = proudects.ToList();

            }
           
           


        }

        private void combstor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var store = (Stor)combstor.SelectedItem;
            comcat.ItemsSource=context.Categorys.Where(e=>e.objstor.Id==store.Id).ToList();

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
