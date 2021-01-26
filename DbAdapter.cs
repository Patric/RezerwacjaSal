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


        public static List<Reservation> getReservations()
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

                List<Reservation> reservationList = new List<Reservation>();

                //foreach(DataRow dr in )
                // return 1;
                //return new User(loginData.Rows[0]["id"].ToString(),
                //   loginData.Rows[0]["username"].ToString(),
                //   loginData.Rows[0]["external_id"].ToString(),
                //   loginData.Rows[0]["role"].ToString(),
                //   loginData.Rows[0]["name"].ToString(),
                //   loginData.Rows[0]["surname"].ToString());
                return reservationList;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message, "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return null;

        }


    }







}
