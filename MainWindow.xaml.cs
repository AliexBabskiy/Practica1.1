﻿using System;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Bt1_Cl(object sender, RoutedEventArgs e)
        {
            FrameP.Content = new Page1();
        }

        private void Bt2_Cl(object sender, RoutedEventArgs e)
        {
            FrameP.Content = new Page2();
        }

        private void Bt3_Cl(object sender, RoutedEventArgs e)
        {
            FrameP.Content = new Page3();
        }
    }
}
