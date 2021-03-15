using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezerwacjaSal
{
    public class Reservation : FormattableString
    {
        public Reservation(string reservation_id, string room_number, string department, string building, string sick_id, string name, string surname, string illness, string date_from, string date_to)
        {
            this.reservation_id = reservation_id;
            this.room_number = room_number;
            this.department = department;
            this.building = building;
            this.sick_id = sick_id;
            this.name = name;
            this.surname = surname;
            this.illness = illness;
            this.date_from = date_from;
            this.date_to = date_to;
        }

        public string reservation_id { get; private set; }

        public string room_number { get; private set; }

        public string department { get; private set; }

        public string building { get; private set; }

        public string sick_id { get; private set; }

        public string name { get; private set; }

        public string surname { get; private set; }

        public string illness { get; private set; }

        public string date_from { get; private set; }

        public string date_to { get; private set; }

        public override string Format => throw new NotImplementedException();

        public override int ArgumentCount => throw new NotImplementedException();

        public override object GetArgument(int index)
        {
            throw new NotImplementedException();
        }

        public override object[] GetArguments()
        {
            throw new NotImplementedException();
        }

        public override string ToString(IFormatProvider formatProvider)
        {
            string[] reservation =
            {
            "Numer rezerwacji: " + this.reservation_id + "\n" +
            "Numer sali: " + this.room_number + "\n" +
            "Oddział: " + this.department + "\n" +
            "Budynek " + this.building + "\n" +
            "Numer pacjenta" + this.sick_id + "\n" +
            "Imię pacjenta: " + this.name + "\n" +
            "Nazwisko pacjenta: " +this.surname + "\n" +
            "Choroba pacjenta: " + this.illness + "\n" +
            "Data wpisu: " + this.date_from + "\n" +
            "Przewidywana data wypisu: " + this.date_to + "\n"
        };

            return string.Concat(reservation);
            

         
        }
    }
}
