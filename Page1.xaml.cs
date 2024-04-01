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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private BdPracticaEntities context = new BdPracticaEntities();
        public Page1()
        {
            InitializeComponent();
            tablic.ItemsSource = context.EMP.ToList();
        }

        private void BtDob_Cl(object sender, RoutedEventArgs e)
        {
            EMP o = new EMP();
            o.ID_EMP = Convert.ToInt32(text1.Text);
            o.SURNAME = Convert.ToString(text2.Text);
            o.FIRST_NAME = Convert.ToString(text3.Text);
            o.MIDDLENAME = Convert.ToString(text4.Text);

            context.EMP.Add(o);
            context.SaveChanges();
            tablic.ItemsSource = context.EMP.ToList();
        }

        private void BtIzm_Cl(object sender, RoutedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as EMP;

                selected.ID_EMP = Convert.ToInt32(text1.Text);
                selected.SURNAME = Convert.ToString(text2.Text);
                selected.FIRST_NAME = Convert.ToString(text3.Text);
                selected.MIDDLENAME = Convert.ToString(text4.Text);

                context.SaveChanges();
                tablic.ItemsSource = context.EMP.ToList();
            }
        }

        private void BtDel_Cl(object sender, RoutedEventArgs e)
        {
            var selectedOrders = tablic.SelectedItem as EMP;
            if (selectedOrders != null)
            {
                context.EMP.Remove(selectedOrders);
                context.SaveChanges();
                tablic.ItemsSource = context.EMP.ToList();
            }
        }

        private void tablic_Dob(object sender, SelectionChangedEventArgs e)
        {
            if (tablic.SelectedItem != null)
            {
                var selected = tablic.SelectedItem as EMP;

                text1.Text = selected.ID_EMP.ToString();
                text2.Text = selected.SURNAME.ToString();
                text3.Text = selected.FIRST_NAME.ToString();
                text4.Text = selected.MIDDLENAME.ToString();

                context.SaveChanges();
                tablic.ItemsSource = context.EMP.ToList();
            }
        }
    }
}
