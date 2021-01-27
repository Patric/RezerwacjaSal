﻿using MySql.Data.MySqlClient;
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

                string query = "Select * FROM reservations WHERE doctor_id = '" + Authenticator.currentUser.external_id.ToString() + "';";
   
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
                        dr["date_from"].ToString(),
                        dr["date_to"].ToString(), 
                        dr["doctor_id"].ToString(), 
                        dr["sick_id"].ToString()));
                }

                    return reservations;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message, "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return null;

        }

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
                        dr["equipment"].ToString()));
                }

                return patientRooms;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message, "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return null;

        }















    }














}
