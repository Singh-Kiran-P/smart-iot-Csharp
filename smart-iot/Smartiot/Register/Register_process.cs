using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Smartiot.UI;



namespace Smartiot.Register
{
    class Register_process
    {
        public Register_process(string name, string email, string username, string password, string password2)
        {
            try
            {


                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost/users/register");
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

                //var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                //{
                //    var result = streamReader.ReadToEnd();
                //    var jss = new JavaScriptSerializer();

                //    Dictionary<string, string> sData = jss.Deserialize<Dictionary<string, string>>(result);
                //    strid = sData["id"].ToString();
                //    username = sData["username"].ToString();
                //    email = sData["email"].ToString();
                //    succes = sData["succes"].ToString();

                //    if (succes == "true")
                //    {
                //        Mainpage UI_mainpage = new Mainpage();
                //        UI_mainpage.Show();
                //    }
                //    return;



                //}
            }
            catch (Exception ex)
            {
                //succes = "false";


            }
        }
    }
} 
