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
    /// Interaction logic for Privacy_Policy.xaml
    /// </summary>
    public partial class Privacy_Policy : Page
    {
        public Privacy_Policy()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.MainBrowser.Navigate("https://sites.google.com/view/smartiot2456/nl");

        }
    }
}
