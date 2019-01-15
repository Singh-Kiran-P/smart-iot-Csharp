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

namespace Smartiot.Process.Iot
{
    class Led_process
    {

        public static void led_on()
        {
            try
            {
                var request = new Request();

                login_response oLogin;
                oLogin = (login_response)Login_process.user_info[0];  
                var led_model = new led_request
                {
                    userId = oLogin.id,
                    led = 1
                };

                var response = (led_response)request.Execute(Rest_API.serverurl + "/api/iot/led",led_model,"POST");


            }
            catch (Exception)
            {

                throw;
            }

        }

        public static void led_off()
        {
            try
            {
                string server_url = Server.Rest_API.serverurl;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(server_url + "api/users/iot/led");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"led\":\"0\"}";


                    streamWriter.Write(json);
                    streamWriter.Flush();

                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    Console.WriteLine(responseText);

                    //Now you have your response.
                    //or false depending on information in the response     
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
