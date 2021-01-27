using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezerwacjaSal
{
    public class Patient
    {
        public Patient(string id, string name, string surname, string illness, string infectious)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.illness = illness;
            this.infectious = infectious;
        }

        public string id { get; private set; }
        public string name { get; private set; }
        public string surname { get; private set; }
        public string illness { get; private set; }
        public string infectious { get; private set; }





    }
}
