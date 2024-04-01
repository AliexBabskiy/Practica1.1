using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        private BdPracticaEntities context = new BdPracticaEntities();
        public Page2()
        {
            InitializeComponent();
            tablic.ItemsSource = context.Client.ToList();
        }

        private void BtDob_Cl(object sender, RoutedEventArgs e)
        {
            Client o = new Client();
            o.ID_Client = Convert.ToInt32(text1.Text);
            o.ClientName = Convert.ToString(text2.Text);

            context.Client.Add(o);
            context.SaveChanges();
            tablic.ItemsSource = context.Client.ToList();
        }

        private void BtIzm_Cl(object sender, RoutedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as Client;

                selected.ID_Client = Convert.ToInt32(text1.Text);
                selected.ClientName = Convert.ToString(text2.Text);

                context.SaveChanges();
                tablic.ItemsSource = context.Client.ToList();
            }
        }

        private void BtDel_Cl(object sender, RoutedEventArgs e)
        {
            var selectedOrders = tablic.SelectedItem as Client;
            if (selectedOrders != null)
            {
                context.Client.Remove(selectedOrders);
                context.SaveChanges();
                tablic.ItemsSource = context.Client.ToList();
            }
        }

        private void tablic_Dob(object sender, SelectionChangedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as Client;

                text1.Text = selected.ID_Client.ToString();
                text2.Text = selected.ClientName.ToString();

                context.SaveChanges();
                tablic.ItemsSource = context.Client.ToList();
            }
        }
    }
}
