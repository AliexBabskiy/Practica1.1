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

namespace PrPract1._1
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        private BdPracticaEntities context = new BdPracticaEntities();
        public Page3()
        {
            InitializeComponent();
            tablic.ItemsSource = context.Coffee.ToList();
        }

        private void BtDob_Cl(object sender, RoutedEventArgs e)
        {
            Coffee o = new Coffee();
            o.Coffee_Name = Convert.ToString(text2.Text);
            o.Coffee_Price = Convert.ToInt32(text3.Text);

            context.Coffee.Add(o);
            context.SaveChanges();
            tablic.ItemsSource = context.Coffee.ToList();
        }

        private void BtIzm_Cl(object sender, RoutedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as Coffee;

                selected.Coffee_Name = Convert.ToString(text2.Text);
                selected.Coffee_Price = Convert.ToInt32(text3.Text);

                context.SaveChanges();
                tablic.ItemsSource = context.Coffee.ToList();
            }
        }

        private void BtDel_Cl(object sender, RoutedEventArgs e)
        {
            var selected = tablic.SelectedItem as Coffee;
            if (selected != null)
            {
                context.Coffee.Remove(selected);
                context.SaveChanges();
                tablic.ItemsSource = context.Coffee.ToList();
            }
        }

        private void tablic_Dob(object sender, SelectionChangedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as Coffee;

                text1.Text = selected.ID_Coffee.ToString();
                text2.Text = selected.Coffee_Name.ToString();
                text3.Text = selected.Coffee_Price.ToString();

                context.SaveChanges();
                tablic.ItemsSource = context.Coffee.ToList();
            }
        }
    }
}
