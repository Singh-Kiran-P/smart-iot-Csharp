using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Smartiot.UI;
using Smartiot.Login;



namespace Smartiot.Register
{
    class Register_process
    {

        public string username = "";
        public string succes = "";

        public Register_process(string name, string email, string username, string password, string password2)
        {
            try
            {


                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost/api/users/register");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"name\":\"" + name + "\"," +
                                  "\"email\":\"" + email + "\"," +
                                  "\"username\":\"" + username + "\"," +
                                  "\"password\":\"" + password + "\"," +
                                  "\"password2\":\"" + password2 + "\"}";

                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    var jss = new JavaScriptSerializer();

                    Dictionary<string, string> sData = jss.Deserialize<Dictionary<string, string>>(result);

                    username = sData["username"].ToString();
                    succes = sData["succes"].ToString();

                    if (succes == "true")
                    {
                        login_form login_Form = new login_form();
                        register_form register_Form =new register_form();
                        register_Form.Close();
                        login_Form.Show();
                    }
                    return;



                }
            }
            catch (Exception ex)
            {
                succes = "false";
                Console.WriteLine(ex);
            }
        }



    }
}
