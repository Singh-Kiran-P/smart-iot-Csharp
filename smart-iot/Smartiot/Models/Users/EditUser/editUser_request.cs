using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartiot.Models.Users.EditUser
{
    class editUser_request
    {
        public String userId { get; set; }
        public String name { get; set; }
        public String email { get; set; }
        public String password { get; set; }
    }
}
