using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezerwacjaSal
{
    public class Reservation
    {
        public Reservation(string reservation_id, string room_number, string date_from, string date_to, string doctor_id, string sick_id)
        {
            this.reservation_id = reservation_id;
            this.room_number = room_number;
            this.date_from = date_from;
            this.date_to = date_to;
            this.doctor_id = doctor_id;
            this.sick_id = sick_id;
        }

        public string reservation_id { get; private set; }
        public string room_number { get; private set; }
        public string date_from { get; private set; }
        public string date_to { get; private set; }
        public string doctor_id { get; private set; }
        public string sick_id { get; private set; }


    }
}
