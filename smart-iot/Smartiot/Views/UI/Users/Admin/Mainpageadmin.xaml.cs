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
using System.Windows.Shapes;

namespace Smartiot.Views.UI.Users.Admin
{
    /// <summary>
    /// Interaction logic for Mainpage_admin.xaml
    /// </summary>
    public partial class Mainpageadmin : Window
    {
        public Mainpageadmin()
        {
            InitializeComponent();
        }

        private void re(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void ButtonCloseWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            var profile = new Profile();
            Frame_profile.Navigate(profile);

        }
    }
}
