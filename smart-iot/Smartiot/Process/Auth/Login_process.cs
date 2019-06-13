using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Smartiot.Views.UI.Users;
using JsonRequest;
using Smartiot.Models.Auth.Login;
using Smartiot.Server;
using Smartiot.Views.UI.Users.Admin;
using Smartiot.Views.UI.Users.NormalUsers;
using System.Windows;
using BespokeFusion;

namespace Smartiot.Process.Auth
{

    class Login_process
    {
        //public string id = "";
        //public string username = "";
        //public string name = "";
        //public string email = "";
        //public string role = "";
        //public string succes = "";
        //public static string error = "";
        public static List<login_response> user_info = new List<login_response>();
        public static login_response response;

        public Login_process()
        {


        }



        public Login_process(string usernaam, string password)
        {
            try
            {
                var request = new Request();
                var loginModel = new login_request { username = usernaam, password = password };

                response = (login_response)request.Execute<login_response>(Rest_API.serverurl + "/api/users/login", loginModel, "POST");

                if (response.status != 200)
                {
                    MaterialMessageBox.Show(response.message);
                }

                if (response.status == 200)
                {
                    login_response login_ = new login_response();
                    login_.id = response.id;
                    login_.name = response.name;
                    login_.email = response.email;
                    login_.username = response.username;
                    login_.role = response.role;
                    login_.status = response.status;
                    login_.message = response.message;
                    login_.FCM_token = response.FCM_token;
                    user_info.Add(login_);

                    if (response.role == "admin")
                    {
                        //Mainpageadmin UI_Mainpage_admin = new Mainpageadmin();
                        Mainpage_normaal UI_mainpage = new Mainpage_normaal();
                        UI_mainpage.Show();

                    }
                    if (response.role == "normal_user")
                    {
                        //Mainpage UI_mainpage = new Mainpage();
                        Mainpage_normaal UI_mainpage = new Mainpage_normaal();
                        UI_mainpage.Show();
                    }

                }
                return;





            }

            catch (Exception ex)
            {
                string error = ex.ToString();

                MaterialMessageBox.Show(error);

            }
        }

        //public override string ToString()
        //{
        //    if (succes == "false")
        //    {
        //        return "false";
        //    }
        //    if (succes == "true")
        //    {
        //        return "true";
        //    }
        //    return base.ToString();
        //}
    }
}
