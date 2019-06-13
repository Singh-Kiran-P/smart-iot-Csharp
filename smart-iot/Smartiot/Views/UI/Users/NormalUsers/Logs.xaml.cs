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
using Smartiot.Models.Users.ShowLogs;
using Smartiot.Process.User;

namespace Smartiot.Views.UI.Users.NormalUsers
{
    /// <summary>
    /// Interaction logic for Logs.xaml
    /// </summary>
    public partial class Logs : Page
    {
        public Logs()
        {
            InitializeComponent();
            var data = Process.Auth.Login_process.user_info;
            var userId = data[0].id;
            lbl_userId.Content = userId;
            lbl_userName.Content = data[0].name;
            ShowLogs_process showLogs_Process = new ShowLogs_process(userId);


            List<showLogs_response> logsLijst = ShowLogs_process.logsLijst;

            logsLijst.ForEach(item => list_logs.Items.Add(item));

        }
    }
}
