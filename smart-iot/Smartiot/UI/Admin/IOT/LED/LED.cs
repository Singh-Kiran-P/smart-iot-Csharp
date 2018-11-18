using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Smartiot.UI.Admin.IOT
{
    class LED
    {

        public static void led_on()
        {
            try
            {


                string server_url = server_setup.serverurl;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(server_url + "api/users/iot/led");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"led\":\"1\"}";


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

        public static void led_off()
        {
            try
            {
                string server_url = server_setup.serverurl;
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
