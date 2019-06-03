using Smartiot.Models.Auth.Login;
using Smartiot.Process.Auth;
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

namespace Smartiot.Views.UI.Users.Admin
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public Profile()
        {
            InitializeComponent();
            login_response oLogin;
            oLogin = Login_process.user_info[0];

            txt_id.Text = oLogin.id;
            txt_email.Text = oLogin.email;
            txt_FCM_token.Text = oLogin.FCM_token;
            txt_message.Text = oLogin.message;
            txt_name.Text = oLogin.name;
            txt_role.Text = oLogin.role;
            txt_username.Text = oLogin.username;
        }
    }
}
