using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Smartiot.Views.UI.Users.Admin;
using Smartiot.Views.UI.Users.NormalUsers;
using JsonRequest;
using Smartiot.Models.Auth.Login;
using Smartiot.Server;


namespace Smartiot.Views.Auth.Login
{

    class Login_process
    {
        public string id = "";
        public string username = "";
        public string name = "";
        public string email = "";
        public string role = "";
        public string succes = "";
        public static string error = "";
        public static List<string> user_info = new List<string>();


        public Login_process()
        {


        }



        public Login_process(string usernaam, string password)
        {
            try
            {
                var request = new Request();
                var loginModel = new login_request { username = usernaam, password = password };

                var response = (login_response)request.Execute<login_response>(Rest_API.serverurl+"/api/users/login", loginModel, "POST");


                if (succes == "true")
                    {
                        user_info.Add(id);
                        user_info.Add(name);
                        user_info.Add(username);
                        user_info.Add(email);
                        user_info.Add(role);

                        if (role == "admin")
                        {
                            Mainpageadmin UI_Mainpage_admin = new Mainpageadmin();
                            UI_Mainpage_admin.Show();

                        }
                        if (role == "normal")
                        {
                            Mainpage UI_mainpage = new Mainpage();
                            UI_mainpage.Show();
                        }

                    }
                    return;



                }
            
            catch (Exception ex)
            {
                error = ex.ToString();
                succes = "false";


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
