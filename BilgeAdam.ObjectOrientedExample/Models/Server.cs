using BilgeAdam.ObjectOrientedExample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.ObjectOrientedExample.Models
{
    public class Server
    {
        //sadece bu library içerisinde instance alınır
        internal Server()
        {

        }
        public string Name { get; set; }
        public string PublicIP { get; internal set; }
        public string PrivateIP { get; internal set; }
        public OS OperatingSystem { get; set; }
        public string Description { get; set; }
        public bool IsVirtual { get; set; }
    }
}
