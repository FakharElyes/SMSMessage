using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SendSMSMessages.Models
{
    public class Message
    {
        public string To { get; set; }
        public string ContentMsg { get; set; }
    }
}
