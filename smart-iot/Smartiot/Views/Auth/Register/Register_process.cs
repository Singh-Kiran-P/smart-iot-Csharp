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

        public Register_process(string name, string firstname, string email, string username, string password)
        {
            try
            {
                var request = new Request();
                var register_Model = new register_request
                {
                    name = name + " " + firstname,
                    email = email,
                    username = username,
                    password = password

                };

                //var response = request.Execute("http://192.168.0.198:8080/register", register_Model, "POST");

                register_response response = (register_response)request.Execute<register_response>(Rest_API.serverurl + "/api/users/register", register_Model, "POST");

                if (response.status == "200")
                {
                    MessageBox.Show("Successfully Registered");
                    login_form login_Form = new login_form();

                    login_Form.Show();
                }
                else
                {
                    MessageBox.Show("Register failed. Contact the adminstrator");
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
