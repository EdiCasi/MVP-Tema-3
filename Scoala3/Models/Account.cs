using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala3.Models
{
    class Account
    {
        public string Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string acces { get; set; }

        public Account()
        {

        }
        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public Account(string username, string password, string acces)
        {
            this.username = username;
            this.password = password;
            this.acces = acces;
        }
        public Account(string Id, string username, string password, string acces)
        {
            this.Id = Id;
            this.username = username;
            this.password = password;
            this.acces = acces;
        }
    }
}
