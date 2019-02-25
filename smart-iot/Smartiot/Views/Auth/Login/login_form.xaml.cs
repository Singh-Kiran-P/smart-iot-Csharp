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
using Smartiot.Process.Auth;
using Smartiot.Views.UI.Users.Admin;



namespace Smartiot.Views.Auth.Login
{
    /// <summary>
    /// Interaction logic for login_form.xaml
    /// </summary>
    public partial class login_form : Window
    {
       
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
            string username = txt_username.Text;
            string password = pwdbox_password.Password;
            if (username =="sr"&& password == "sr") 
            {
                Views.Dialog.server_setup server_Setup = new Views.Dialog.server_setup();                
                this.Close();
                server_Setup.Show();
                return;
            }
            if (username == "" || password == "")
            {
                MessageBox.Show("Missing content");
                return;
            }
            Login_process login_Process= new Login_process(username, password);
            if ( Login_process.response.id != null)
            {
                this.Close();
            }



        }

        private void btn_register_from_Click(object sender, RoutedEventArgs e)
        {
            var registerpage = new Register.register_form();
            this.Close();
            registerpage.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Mainpageadmin mainpageadmin = new Mainpageadmin();
            mainpageadmin.Show();
        }
    }
}
