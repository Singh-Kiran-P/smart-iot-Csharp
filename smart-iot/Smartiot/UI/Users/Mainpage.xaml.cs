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
using Smartiot.Login;

namespace Smartiot.UI.Users
{
    /// <summary>
    /// Interaction logic for Mainpage.xaml
    /// </summary>
    public partial class Mainpage : Window
    {
        public Mainpage()
        {
            InitializeComponent();

            /*user_info[0] -->id
             *user_info[1] -->name
             *user_info[2] -->username
             *user_info[3] -->email
             */
            txt_username.Text = Login_process.user_info[1];

        }

        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            Login_process.user_info.Clear();
            var loginpage = new login_form();
            this.Close();
            MessageBox.Show("Logout successfully ");
            loginpage.Show();

        }

    }
}
