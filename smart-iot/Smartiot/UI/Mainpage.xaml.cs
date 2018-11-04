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

namespace Smartiot.UI
{
    /// <summary>
    /// Interaction logic for Mainpage.xaml
    /// </summary>
    public partial class Mainpage : Window
    {
        public Mainpage()
        {
            InitializeComponent();
            //var loginform = new login_form();
            //txt_username.Text = loginform.username;

        }

        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            var loginpage = new login_form();
            this.Close();
            loginpage.Show();
        }
    }
}
