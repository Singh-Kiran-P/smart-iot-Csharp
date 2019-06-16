using BespokeFusion;
using JsonRequest;
using Smartiot.Models.Users.Feedback;
using Smartiot.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartiot.Process.User
{
    class SendFeedback_process
    {

        public SendFeedback_process(string userId1, string feedback)
        {
            try
            {
                var request = new Request();
                var sendModel = new sendFeedback_request
                {
                    userId = userId1,
                    feedback = feedback,
                    platform = "C#-WPF"


                };

                //var response = request.Execute("http://192.168.0.198:8080/register", register_Model, "POST");

                sendFeedback_response response = (sendFeedback_response)request.Execute<sendFeedback_response>(Rest_API.serverurl + "/api/users/data/sendFeedback", sendModel, "POST");

                if (response.status == 200)
                {
                    MaterialMessageBox.Show(response.message);      



                }
                if (response.status == 901)
                {
                    MaterialMessageBox.Show(response.message);


                }
                if (response.status == 902)
                {
                    MaterialMessageBox.Show(response.message);
                    //register_form register_Form = new register_form();

                    //register_Form.Show();
                }
                return;

            }
            catch (Exception)
            {

            }
        }
    }

}
