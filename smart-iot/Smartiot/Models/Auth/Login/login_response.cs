using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartiot.Models.Auth.Login
{
    class login_response
    {
        public string id { get; set; }
        public string naam { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string role { get; set; }
        public string message { get; set; }
        public int status { get; set; }

    }
}
