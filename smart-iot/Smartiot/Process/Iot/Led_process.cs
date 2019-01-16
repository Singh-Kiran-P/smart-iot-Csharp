using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using JsonRequest;
using Smartiot.Server;
using Smartiot.Models.Iot.Led;
using Smartiot.Process.Auth;
using Smartiot.Models.Auth.Login;
using System.Windows;
using Newtonsoft;
using System;
using System.Net.Http;
using System.Threading.Tasks;

using System.Net.Http;
using System.Web.Script.Serialization;
using System.Windows.Controls;
using Newtonsoft.Json;

namespace Smartiot.Process.Iot
{
    class Led_process
    {

        public static void led_on()
        {
            string result;
            try
            {
                

                login_response oLogin;
                oLogin = (login_response)Login_process.user_info[0];

                //config request
                string serverUrl = Rest_API.serverurl + "/api/iot/led";

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(serverUrl);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                led_request request_model = new led_request
                {
                    userId = oLogin.id,
                    led = "1"

                };

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    var json = new JavaScriptSerializer().Serialize(request_model);

                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                    
                }
                led_response led_Response = JsonConvert.DeserializeObject<led_response>(result);
                MessageBox.Show(led_Response.message);


            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }

        }

        public static void led_off()
        {
            string result;
            try
            {


                login_response oLogin;
                oLogin = (login_response)Login_process.user_info[0];

                //config request
                string serverUrl = Rest_API.serverurl + "/api/iot/led";

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(serverUrl);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                led_request request_model = new led_request
                {
                    userId = oLogin.id,
                    led = "0"

                };

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    var json = new JavaScriptSerializer().Serialize(request_model);

                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();

                }
                led_response led_Response = JsonConvert.DeserializeObject<led_response>(result);
                MessageBox.Show(led_Response.message);


            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
