using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moutain_Guide_CRM
{
    public class Client
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Comment { get; set; }

        public Client()
        {
            this.Firstname = " ";
            this.Lastname = "";
            this.Comment = "";
        }
    }
}
