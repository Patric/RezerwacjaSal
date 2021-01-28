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
    public partial class PatientRoomReservations : Form
    {
        private DataTable reservationsTable;
        private DataTable reservationTableFiltered;

        Dictionary<String, Action> filters = new Dictionary<String, Action>();


        public PatientRoomReservations()

        {
            InitializeComponent();
            
        }

        private void dataGridViewAllPatientRoomReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewAllPatientRoomReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         


        }

        private void dataGridViewAllPatientRoomReservations_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            
          
        }

        private void dataGridViewAllPatientRoomReservations_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
        
        }

        private void dataGridViewAllPatientRoomReservations_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

 

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void populateReservations()
        {
            Stack<Reservation> reservations = DbAdapter.getReservations();
            this.reservationsTable = new DataTable();
            reservationsTable.Columns.Add(new DataColumn("Numer Rezerwacji"));
            reservationsTable.Columns.Add(new DataColumn("Numer sali"));
            reservationsTable.Columns.Add(new DataColumn("Oddział"));
            reservationsTable.Columns.Add(new DataColumn("Budynek"));
            reservationsTable.Columns.Add(new DataColumn("Id pacjenta"));
            reservationsTable.Columns.Add(new DataColumn("Imie pacjenta"));
            reservationsTable.Columns.Add(new DataColumn("Nazwisko pacjenta"));
            reservationsTable.Columns.Add(new DataColumn("Choroba"));
            reservationsTable.Columns.Add(new DataColumn("Data od"));
            reservationsTable.Columns.Add(new DataColumn("Data do"));

         

            foreach (var reservation in reservations)
            {
                reservationsTable.Rows.Add(
                    reservation.reservation_id,
                    reservation.room_number,
                    reservation.department,
                    reservation.building,
                    reservation.sick_id,
                    reservation.name,
                    reservation.surname,
                    reservation.illness,
                    reservation.date_from.Replace(" 00:00:00", ""),
                    reservation.date_to.Replace(" 00:00:00", "")
                    ); ;
            }

            dataGridViewAllPatientRoomReservations.DataSource = this.reservationsTable;
            dataGridViewAllPatientRoomReservations.ReadOnly = true;
            dataGridViewAllPatientRoomReservations.AutoGenerateColumns = true;
            dataGridViewAllPatientRoomReservations.AutoResizeColumns();
            dataGridViewAllPatientRoomReservations.Refresh();

           
        }


        private void PatientRoomReservations_Load(object sender, EventArgs e)
        {
            this.populateReservations();


        }

        private void buttonShowReservations_Click(object sender, EventArgs e)
        {
            this.populateReservations();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try { 
           var index =  dataGridViewAllPatientRoomReservations.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć zaznaczoną rezerwację?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DbAdapter.deleteReservation(index);
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
          catch(Exception eee)
            {
                Console.WriteLine(eee);
            }
          

           
            populateReservations();


        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // Navigator.navigateChild(new ReservePatientRoom(reservation), this);
        }

        private void buttonNewReservation_Click(object sender, EventArgs e)
        {
            Navigator.navigateToChild(new ReservePatientRoom(), this);
        }



        private void filterTable(String columnName, String value)
        {
            // add new filter
            if (columnName != null)
            {
                // If already contains filter for certain column delete it
                if (this.filters.ContainsKey(columnName))
                {
                    this.filters.Remove(columnName);
                }


                // get original table
                this.reservationTableFiltered = this.reservationsTable.Copy();


                // add new filter
                this.filters.Add(columnName, () =>
                {
                    for (int i = 0; i < this.reservationTableFiltered.Rows.Count; i++)
                    {
                        if (!this.reservationTableFiltered.Rows[i][columnName].ToString().StartsWith(value))
                        {

                            this.reservationTableFiltered.Rows[i].Delete();


                        }
                    }
                });
            }


       

            // For method in filterMethods
            // do filtermethod
            foreach(var item in this.filters)
            {
                item.Value.Invoke();
            }

            dataGridViewAllPatientRoomReservations.DataSource = this.reservationTableFiltered;
            dataGridViewAllPatientRoomReservations.ReadOnly = true;
            dataGridViewAllPatientRoomReservations.AutoGenerateColumns = true;
            dataGridViewAllPatientRoomReservations.AutoResizeColumns();
            dataGridViewAllPatientRoomReservations.Refresh();
        }


        private void textBoxReservationNumber_TextChanged(object sender, EventArgs e)
        {
            this.filterTable("Numer rezerwacji", this.textBoxReservationNumber.Text);
            
        }

        private void textBoxRoomNumber_TextChanged(object sender, EventArgs e)
        {
            this.filterTable("Numer sali", this.textBoxRoomNumber.Text);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Navigator.navigateBack(this);
        }
    }
}
