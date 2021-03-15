using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezerwacjaSal
{
    public class PatientRoom
    {
        public PatientRoom(string room_number, string department, string building, string type, string equipment)
        {
            this.room_number = room_number;
            this.department = department;
            this.building = building;
            this.type = type;
            this.equipment = equipment;
        }

        public string room_number { get; private set; }
        public string department { get; private set; }
        public string building { get; private set; }
        public string type { get; private set; }
        public string equipment { get; private set; }
    }
}
