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

namespace Smartiot.Views.UI.Users.NormalUsers
{
    /// <summary>
    /// Interaction logic for Iot.xaml
    /// </summary>
    public partial class Iot : Page
    {
        public Iot()
        {
            InitializeComponent();
        }

        private void led01(object sender, DependencyPropertyChangedEventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void HandleChecked(object sender, RoutedEventArgs e)
        {
            Process.Iot.Led_process.led_on();

        }
        private void HandleUnChecked(object sender, RoutedEventArgs e)
        {
            Process.Iot.Led_process.led_off();


        }
    }
}
