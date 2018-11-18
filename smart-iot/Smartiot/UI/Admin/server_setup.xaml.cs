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
namespace Smartiot.UI.Admin
{
    /// <summary>
    /// Interaction logic for server_setup.xaml
    /// </summary>
    public partial class server_setup : Window
    {
        public server_setup()
        {
            InitializeComponent();
        }
        public static string serverurl = "http://192.168.0.198/";
        private void btn_change_Click(object sender, RoutedEventArgs e)
        {
            serverurl = "http://" + txt_url.Text+"/";
            MessageBox.Show(serverurl);
            login_form login_Form = new login_form();
            this.Close();
            login_Form.Show();

        }

        private void btn_return_Click(object sender, RoutedEventArgs e)
        {
            login_form login_Form = new login_form();
            this.Close();
            login_Form.Show();

        }
    }
}
