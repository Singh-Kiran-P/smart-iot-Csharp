using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartiot.Models.Users.ShowLogs
{
    class showLogs_response
    {
        public string Permission { get; set; }
        public string value { get; set; }
        public string name { get; set; }
        public string createdOn { get; set; }

        public override string ToString()
        {
            return "Permission:[ "+this.Permission + "] | Device:  [" + this.name + "] | Data: [" + createdOn+"]";
        }
    }
}
