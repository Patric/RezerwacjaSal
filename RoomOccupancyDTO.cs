using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezerwacjaSal
{
    public class RoomOccupancyDTO
    {
        public RoomOccupancyDTO(string room_number, string department, string building, DateTime date_from, DateTime date_to)
        {
            this.room_number = room_number;
            this.department = department;
            this.building = building;
            this.date_from = date_from;
            this.date_to = date_to;
        }

        public string room_number { get; set; }
        public string department { get; set; }
        public string building { get; set; }
        public DateTime date_from { get; set; }
        public DateTime date_to { get; set; }
    }
}
