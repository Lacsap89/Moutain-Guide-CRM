using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moutain_Guide_CRM.Models
{
    class Client
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Comment { get; set; }

        public Client() { }

        public Client(string firstname, string lastname, string comment)
        {
            Firstname = firstname;
            Lastname = lastname;
            Comment = comment;
        }

        override public string ToString()
        {
            return Firstname + " " + Lastname;
        }
    }
}
