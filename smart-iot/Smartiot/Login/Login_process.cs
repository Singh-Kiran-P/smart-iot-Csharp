using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Smartiot.UI.Users;
using Smartiot.UI.Admin;
namespace Smartiot.Login
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

                string server_url = server_setup.serverurl;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(server_url + "api/users/login");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"username\":\"" + usernaam + "\"," +
                                  "\"password\":\"" + password + "\"}";

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
                    id = sData["id"].ToString();
                    name = sData["name"].ToString();
                    username = sData["username"].ToString();
                    email = sData["email"].ToString();
                    role = sData["role"].ToString().ToLower(); 
                    succes = sData["succes"].ToString();

                    if (succes == "true")
                    {
                        user_info.Add(id);
                        user_info.Add(name);
                        user_info.Add(username);
                        user_info.Add(email);
                        user_info.Add(role);

                        if (role == "admin")
                        {
                            Mainpage_admin UI_Mainpage_admin = new Mainpage_admin();
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
