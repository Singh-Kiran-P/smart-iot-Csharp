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
    /// Interaction logic for Feedback.xaml
    /// </summary>
    public partial class Feedback : Page
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void Btn_Send_Click(object sender, RoutedEventArgs e)
        {
            var data = Process.Auth.Login_process.user_info;
            string userId = data[0].id;
            new SendFeedback_process(userId, txt_feedback.Text);
        }
    }
}
