using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezerwacjaSal
{
  
    public partial class Login : Form
    {
        public static string role;
        String connectionString;
        MySqlConnection connection;

        public Login()
        {   
            InitializeComponent();
            connectionString = RezerwacjaSal.Properties.Settings.Default._32466460_rezerwacja_salConnectionString;
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            try { 
             string username = textBoxLogin.Text;
                string userPassword = textBoxPass.Text;
                DataTable loginData = new DataTable();


                string query = "Select * from users";


                using (connection = new MySqlConnection(connectionString))
                //using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.Fill(loginData);

                }

               

                foreach (DataRow dr in loginData.Rows)
                {
                    Console.WriteLine("Login data: " + dr["role"]);
                    if (dr["username"].ToString() == username && dr["password"].ToString() == userPassword)
                    {
                     


                        role = dr["role"].ToString();

                        if (role == "0")
                        {
                            AllPatientRoomReservations allPatientRoomReservations = new AllPatientRoomReservations();
                           // this.Close();
                            allPatientRoomReservations.Show();
                        }


                    }


                }
        }
            catch (Exception)
            {

                MessageBox.Show("Wystąpił błąd", "Nieobsłużony wyjątek", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


}
    }
}
