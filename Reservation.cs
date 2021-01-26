using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezerwacjaSal
{
    public class Reservation
    {
        public string reservation_id { get; private set; }
        public string room_number { get; private set; }
        public string date_from { get; private set; }
        public string date_to { get; private set; }
        public string doctor_id { get; private set; }
        public string sick_id { get; private set; }


    }
}
