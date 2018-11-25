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
using System.Net.Http;
using Smartiot.Views.Auth.Login;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace Smartiot.Views.Auth.Register
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class register_form : Window
    {
        public register_form()
        {
            InitializeComponent();       
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("bye bye");           
            System.Environment.Exit(1);
        }

        private void btn_min_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

        }

        private void btn_register_Click(object sender, RoutedEventArgs e)
        {
            string name, username, email, password, password2;
            name = txt_name.Text;
            username = txt_username.Text;
            email = txt_email.Text;
            password = pwd1.Password;
            password2 = pwd2.Password;
            bool check_email = !Regex.IsMatch(email, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (password == password2 &&check_email != true )
            {                
               MessageBoxResult boxResult= MessageBox.Show("Successfully Registered");
                if (boxResult == MessageBoxResult.OK)
                {
                    Register_process register_Process = new Register_process(name, email, username, password, password2);
                    this.Close();

                }

            }
            else
            {
                if (check_email)
                {
                    MessageBox.Show("Invaild Email");
                    return;

                }
                if (password != password2)
                {
                    MessageBox.Show("Password does not match the confirm password.");
                    return;

                }
            }



        }


        private void btn_login_page_Click(object sender, RoutedEventArgs e)
        {

            var loginpage = new login_form();
            this.Close();
            loginpage.Show();
            
        }


    }
    }

