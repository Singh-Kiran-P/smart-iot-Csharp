using Smartiot.Process.User;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Smartiot.Views.UI.Users.NormalUsers
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public Profile()
        {
            InitializeComponent();
            init1();
           
        }
        public TextBox text;

        public void init1()
        {
            
            var data = Process.Auth.Login_process.user_info;
            txt_email.Text = data[0].email;
            txt_role.Content = data[0].role;
            txt_userId.Content = data[0].id;
            txt_username.Content = data[0].username;
            txt_name.Text = data[0].name;

            if (data[0].FCM_token == null)
            {
                txt_FCM_token.Content = "None";
            }
            else
            {
                txt_FCM_token.Content = data[0].FCM_token;

            }
        }



        private void Btn_Save_Click(object sender, RoutedEventArgs e)
        {
            if(txt_password.Text == "")
            {
                MessageBox.Show("Please enter your old password or a new one");
                return;
            }
            else
            {
                EditUserInfo_process editUserInfo_Process = new EditUserInfo_process(txt_userId.Content.ToString(), txt_name.Text, txt_email.Text, txt_password.Text);

            }
        }
    }
}
