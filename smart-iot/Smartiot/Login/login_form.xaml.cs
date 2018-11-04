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
using Smartiot;



namespace Smartiot.Login
{
    /// <summary>
    /// Interaction logic for login_form.xaml
    /// </summary>
    public partial class login_form : Window
    {
        public string username="";
        public login_form()
        {
            InitializeComponent();
        }

        private void btn_min_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("bye bye");
            System.Environment.Exit(1);
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            username = txt_username.Text;
            string password = txt_password.Text;
            Login_process login_Process= new Login_process(username, password);
            if (login_Process.succes =="true")
            {
                this.Close();
            }
            if (login_Process.succes == "false")
            {
                MessageBox.Show("username or password invaild");
            }


        }

        private void btn_register_from_Click(object sender, RoutedEventArgs e)
        {
            var registerpage = new Register.register_form();
            this.Close();
            registerpage.Show();
        }
    }
}
