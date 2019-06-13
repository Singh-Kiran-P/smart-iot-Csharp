using JsonRequest;
using Newtonsoft.Json;
using Smartiot.Models.Users.ShowLogs;
using Smartiot.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartiot.Process.User
{
    class ShowLogs_process
    {
        public static List<showLogs_response> logsLijst;

        public  ShowLogs_process(string userId1)
        {
            try
            {
                var request = new Request();
                var showlogs_model = new showLogs_request
                {
                    userId = userId1,
                   

                };

                //var response = request.Execute("http://192.168.0.198:8080/register", register_Model, "POST");

                var response = request.Execute(Rest_API.serverurl + "/api/users/data/showLogs", showlogs_model, "POST");
                showLogs_response showLogs_;
                logsLijst = JsonConvert.DeserializeObject<List<showLogs_response>>(response.ToString());
                
            }
            catch (Exception ex)
            {
                

            }
        }
    }
}
