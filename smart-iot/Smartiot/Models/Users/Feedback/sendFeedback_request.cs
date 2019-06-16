using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartiot.Models.Users.Feedback
{
    class sendFeedback_request
    {
        public string userId { get; set; }
        public string feedback { get; set; }
        public string platform { get; set; }
    }
}
