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
using BespokeFusion;
using Smartiot.Models.Auth.Login;
using Smartiot.Process.Auth;
using Smartiot.Process.Iot;
using Smartiot.Views.Auth.Login;

namespace Smartiot.Views.UI.Users.NormalUsers
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
             *user_info[4] -->role
             */
            login_response oLogin;
            oLogin = (login_response)Login_process.user_info[0];

            txt_name.Text = oLogin.name;
            txt_id.Text = oLogin.id.ToString();
            txt_email.Text = oLogin.email;
            txt_role.Text = oLogin.role;

        }

        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            Login_process.user_info.Clear();
            var loginpage = new login_form();
            this.Close();
            MaterialMessageBox.Show("Logout successfully ");
            loginpage.Show();

        }

        private void Img_Loaded(object sender, RoutedEventArgs e)
        {/*
            // ... Create a new BitmapImage.
            BitmapImage b = new BitmapImage();
            b.BeginInit();
            b.UriSource = new Uri("/el.jpg");
            b.EndInit();

            // ... Get Image reference from sender.
            var image = sender as Image;
            // ... Assign Source.
            image.Source = b;
            */
        }

        private void btn_Led_on_Click(object sender, RoutedEventArgs e)
        {
            Led_process.led_on();

        }

        private void btn_Led_off_Click(object sender, RoutedEventArgs e)
        {
            Led_process.led_off();

        }
    }
}
