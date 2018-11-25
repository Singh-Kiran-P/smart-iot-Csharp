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

using Smartiot.Controls.IOT.LED;
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
            txt_name.Text = Login_process.user_info[1];
            txt_id.Text = Login_process.user_info[0];
            txt_email.Text = Login_process.user_info[3];
            txt_role.Text = Login_process.user_info[4];

        }

        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            Login_process.user_info.Clear();
            var loginpage = new login_form();
            this.Close();
            MessageBox.Show("Logout successfully ");
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
            LED.led_on();

        }

        private void btn_Led_off_Click(object sender, RoutedEventArgs e)
        {
            LED.led_off();

        }
    }
}
