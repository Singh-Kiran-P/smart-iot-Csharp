using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartiot.Models.Iot.Led
{
    class led_request
    {
        public int userId { get; set; }
        public string action { get; set; }
        public string firebase_token { get; set; }
        public string endPoint { get; set; }
    }
}
