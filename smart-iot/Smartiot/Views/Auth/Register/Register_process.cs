using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows;
using JsonRequest;
using Newtonsoft;
using Smartiot.Models.Auth.Register;
using Smartiot.Server;
using Smartiot.Views.Auth.Login;



namespace Smartiot.Views.Auth.Register
{
    class Register_process
    {

        public string username = "";
        public string succes = "";

        public Register_process(string name, string email, string username, string password, string password2)
        {
            try
            {
                var request = new Request();
                var register_Model = new Register_Obj
                {
                    
                };
                var response = (Register_Obj)request.Execute<Register_Obj>(Rest_API.serverurl +"/register", register_Model, "POST");

                if (succes == "true")
                {
                    login_form login_Form = new login_form();

                    login_Form.Show();
                }
                return;

            }
            catch (Exception ex)
            {
                succes = "false";
                Console.WriteLine(ex);
                return;
            }
        }



    }
}
