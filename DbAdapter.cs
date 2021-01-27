using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezerwacjaSal
{
    public static class DbAdapter
    {
        private static String connectionString = 
            RezerwacjaSal.Properties.Settings.Default._32466460_rezerwacja_salConnectionString;
            
        public static User getUser(String login, String pass)
        {
            try
            {

                string query = "Select * FROM users " +
                     " LEFT JOIN doctors on doctors.id = users.external_id WHERE username = '" 
                    + login
                    + "' AND password = '"
                    + pass + "'" 
                   + ";";

                Console.WriteLine(query);

                DataTable loginData = new DataTable();

         

                using (var connection = new MySqlConnection(connectionString))

                //using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.Fill(loginData);
                }

      
                return new User(loginData.Rows[0]["id"].ToString(),
                   loginData.Rows[0]["username"].ToString(),
                   loginData.Rows[0]["external_id"].ToString(),
                   loginData.Rows[0]["role"].ToString(),
                   loginData.Rows[0]["name"].ToString(),
                   loginData.Rows[0]["surname"].ToString());

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message, "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            return null;

        }


        public static Stack<Reservation> getReservations()
        {

            try
            {

                string query = "SELECT reservation_id, reservations.room_number, department, building, patients.id, patients.name, patients.surname, patients.illness, reservations.date_from, reservations.date_to " +
                                    "FROM reservations " +
                                    "LEFT JOIN rooms ON reservations.room_number = rooms.room_number " +
                                    "LEFT JOIN patients ON reservations.sick_id = patients.id " +
                                    "WHERE doctor_id = " + Authenticator.currentUser.external_id;
                  
   
                Console.WriteLine(query);
                DataTable queryData = new DataTable();
                using (var connection = new MySqlConnection(connectionString))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.Fill(queryData);
                }

                Stack<Reservation> reservations = new Stack<Reservation>();
                foreach (DataRow dr in queryData.Rows)
                {
                    reservations.Push(new Reservation(
                        dr["reservation_id"].ToString(), 
                        dr["room_number"].ToString(),
                        dr["department"].ToString(),
                        dr["building"].ToString(), 
                        dr["id"].ToString(), 
                        dr["name"].ToString(),
                        dr["surname"].ToString(),
                        dr["illness"].ToString(),
                        dr["date_from"].ToString(),
                        dr["date_to"].ToString()
                        ));
                }

                    return reservations;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message, "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return null;

        }

        // Łatwiejsze, ale nie uzywamy
        public static DataTable getReservationsTable()
        {

            try
            {

                string query = "Select * FROM reservations WHERE doctor_id = '" + Authenticator.currentUser.external_id.ToString() + "';";


                Console.WriteLine(query);



                DataTable queryData = new DataTable();



                using (var connection = new MySqlConnection(connectionString))

                //using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.Fill(queryData);
                }

                Console.WriteLine(queryData);

                return queryData;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message, "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return null;

        }


        public static Stack<PatientRoom> getPatientRooms()
        {

            try
            {

                string query = "Select * FROM rooms ;"; // WHERE " rooms.available = true ;"


                Console.WriteLine(query);



                DataTable queryData = new DataTable();



                using (var connection = new MySqlConnection(connectionString))

                //using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.Fill(queryData);
                }

                Console.WriteLine(queryData);

                Stack<PatientRoom> patientRooms = new Stack<PatientRoom>();

                foreach (DataRow dr in queryData.Rows)
                {

                    patientRooms.Push(new PatientRoom(
                        dr["room_number"].ToString(),
                        dr["department"].ToString(),
                        dr["building"].ToString(),
                        dr["type"].ToString(),
                        null));
                        //dr["equipment"].ToString()));
                }

                return patientRooms;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message, "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return null;

        }




        public static Stack<Patient> getPatients()
        {

            try
            {

                string query = "Select * FROM patients ;"; // WHERE " rooms.available = true ;"


                Console.WriteLine(query);



                DataTable queryData = new DataTable();



                using (var connection = new MySqlConnection(connectionString))

           
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.Fill(queryData);
                }

                Console.WriteLine(queryData);

                Stack<Patient> patients = new Stack<Patient>();

                foreach (DataRow dr in queryData.Rows)
                {

                    patients.Push(new Patient(
                        dr["id"].ToString(),
                        dr["name"].ToString(),
                        dr["surname"].ToString(),
                        dr["illness"].ToString(),
                        dr["infectious"].ToString()));
                }

                return patients;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message, "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return null;

        }
        public static Stack<string> getEquipement()
        {

            try
            {

                string query = "SELECT name FROM eq_dict;"; // WHERE " rooms.available = true ;"


                Console.WriteLine(query);



                DataTable queryData = new DataTable();



                using (var connection = new MySqlConnection(connectionString))


                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.Fill(queryData);
                }

                Console.WriteLine(queryData);

                Stack<string> eq = new Stack<string>();

                foreach (DataRow dr in queryData.Rows)
                {

                    eq.Push(
                        dr["name"].ToString());
                }

                return eq;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message, "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return null;

        }










    }














}
