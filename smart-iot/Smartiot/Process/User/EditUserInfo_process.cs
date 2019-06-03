using BespokeFusion;
using JsonRequest;
using Smartiot.Models.Users.EditUser;
using Smartiot.Server;
using Smartiot.Views.UI.Users.NormalUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartiot.Process.User
{
    class EditUserInfo_process
    {
        public EditUserInfo_process(string userId, string name1, string email1, string password1)
        {
            try
            {
                var request = new Request();
                var edit_Model = new editUser_request
                {
                    userId = userId,
                    name = name1,
                    email = email1,
                    password = password1

                };

                //var response = request.Execute("http://192.168.0.198:8080/register", register_Model, "POST");

                editUser_response response = (editUser_response)request.Execute<editUser_response>(Rest_API.serverurl + "/api/users/data/changeUserData", edit_Model, "PUT");

                if (response.status == 200)
                {
                    MaterialMessageBox.Show(response.message);
                    var data = Process.Auth.Login_process.user_info;
                    data[0].name = name1;
                    data[0].email = email1;



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
            catch (Exception ex)
            {
                
            }
        }
    }
}
