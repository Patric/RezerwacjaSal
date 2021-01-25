using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezerwacjaSal
{
    public class User
    {
        public User(string id, string username, string external_id, string role, string name, string surname)
        {
            this.id = id;
            this.username = username;
            this.external_id = external_id;
            this.role = role;
            this.name = name;
            this.surname = surname;
        }

        public string id { get; private set; }
        public string username { get; private set; }
        public string external_id { get; private set; }
        public string role { get; private set; }
        public string name { get; private set; }
        public string surname { get; private set; }
    }
}
