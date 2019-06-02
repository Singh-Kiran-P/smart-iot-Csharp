using BespokeFusion;
using Smartiot.Views.Auth.Login;
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

namespace Smartiot.Views.UI.Users.NormalUsers
{
    /// <summary>
    /// Interaction logic for Mainpage_admin.xaml
    /// </summary>
    public partial class Mainpage_normaal : Window
    {
        public Mainpage_normaal()
        {
            InitializeComponent();
        }

        private void re(object sender, MouseButtonEventArgs e)
        {
            MaterialMessageBox.Show("hello");
        }

        private void ButtonCloseWindow_Click(object sender, RoutedEventArgs e)
        {
            
    
            MaterialMessageBox.Show("You are now logout");
            var loginpage = new login_form();
            loginpage.Show();
            this.Close();

        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {



        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListViewItem_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            MaterialMessageBox.Show("gedsg");
        }

        private void Profile_Selected(object sender, RoutedEventArgs e)
        {
            Main.Content = new Profile();

        }

        private void Lv_iot_Selected(object sender, RoutedEventArgs e)
        {
            Main.Content = new Iot();
        }


        private void Logs_Selected(object sender, RoutedEventArgs e)
        {
            Main.Content = new Logs();
        }



        private void Policy_Selected(object sender, RoutedEventArgs e)
        {
            Main.Content = new Privacy_Policy();

        }

        private void Feedback_Selected(object sender, RoutedEventArgs e)
        {
            Main.Content = new Feedback();

        }

        private void Settings_Selected(object sender, RoutedEventArgs e)
        {
            Main.Content = new Settings();

        }
    }
}
