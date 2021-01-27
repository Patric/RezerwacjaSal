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
    public partial class ReservePatientRoom : Form
    {
        private DataTable roomsTable;
        private DataTable roomsTableFiltered;

        private DataTable patientsTable;
        private DataTable patientsTableFiltered;

        Dictionary<String, Action> filters = new Dictionary<String, Action>();
        Dictionary<String, Action> patientFilters = new Dictionary<String, Action>();

        public ReservePatientRoom()
        {
            InitializeComponent();

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Navigator.navigateTo(new RoomInformation());
        }

        private void groupBoxRequirements_Enter(object sender, EventArgs e)
        {

        }

        private void button_root_Click(object sender, EventArgs e)
        {
            Navigator.navigateRoot();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Navigator.navigateBack(this);
        }

        private void dataGridViewPatientRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void populatePatients()
        {
            Stack<Patient> patients = DbAdapter.getPatients();
            this.patientsTable = new DataTable();
            patientsTable.Columns.Add(new DataColumn("Id"));
            patientsTable.Columns.Add(new DataColumn("Imie"));
            patientsTable.Columns.Add(new DataColumn("Nazwisko"));
            patientsTable.Columns.Add(new DataColumn("Choroba"));
            patientsTable.Columns.Add(new DataColumn("Czy zakaźna?"));


            foreach (var patient in patients)
            {
                patientsTable.Rows.Add(
                   patient.id,
                   patient.name,
                   patient.surname,
                   patient.illness,
                   patient.infectious
                );
            }


            String[] idAutoComplete = patientsTable
                    .AsEnumerable()
                    .Select<System.Data.DataRow, String>(x => x.Field<String>("Id"))
                    .ToArray();

            String[] namesAutoComplete = patientsTable
                    .AsEnumerable()
                    .Select<System.Data.DataRow, String>(x => x.Field<String>("Imie"))
                    .ToArray();


            String[] surnamesAutoComplete = patientsTable
                  .AsEnumerable()
                  .Select<System.Data.DataRow, String>(x => x.Field<String>("Nazwisko"))
                  .ToArray();


            String[] sicknessesAutoComplete = patientsTable
                   .AsEnumerable()
                   .Select<System.Data.DataRow, String>(x => x.Field<String>("Choroba"))
                   .ToArray();


            var source = new AutoCompleteStringCollection();
            source.AddRange(namesAutoComplete);
            textBoxFirstName.AutoCompleteCustomSource = source;
            textBoxFirstName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxFirstName.AutoCompleteSource = AutoCompleteSource.CustomSource;


            source = new AutoCompleteStringCollection();
            source.AddRange(idAutoComplete);
            textBoxId.AutoCompleteCustomSource = source;
            textBoxId.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxId.AutoCompleteSource = AutoCompleteSource.CustomSource;

            source = new AutoCompleteStringCollection();
            source.AddRange(surnamesAutoComplete);
            textBoxSurname.AutoCompleteCustomSource = source;
            textBoxSurname.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxSurname.AutoCompleteSource = AutoCompleteSource.CustomSource;


            dataGridViewPatients.DataSource = this.patientsTable;
            dataGridViewPatients.ReadOnly = true;
            dataGridViewPatients.AutoGenerateColumns = true;
            dataGridViewPatients.AutoResizeColumns();
            dataGridViewPatients.Refresh();



        }
        private void populatePatientRooms()
        {
            Stack<PatientRoom> rooms = DbAdapter.getPatientRooms();
            this.roomsTable = new DataTable();
            roomsTable.Columns.Add(new DataColumn("Numer sali"));
            roomsTable.Columns.Add(new DataColumn("Oddział"));
            roomsTable.Columns.Add(new DataColumn("Budynek"));
            roomsTable.Columns.Add(new DataColumn("Zakaźna"));
            roomsTable.Columns.Add(new DataColumn("Sprzęt"));




            foreach (var room in rooms)
            {
                roomsTable.Rows.Add(
                    room.room_number,
                   room.department,
                   room.building,
                   room.type,
                   room.equipment
                );
            }

            dataGridViewPatientRooms.DataSource = this.roomsTable;
            dataGridViewPatientRooms.ReadOnly = true;
            dataGridViewPatientRooms.AutoGenerateColumns = true;
            dataGridViewPatientRooms.AutoResizeColumns();
            dataGridViewPatientRooms.Refresh();


        }

        private void filterPatientsTable(String columnName, String value)
        {
            // If already contains filter for certain column delete it
            if (this.patientFilters.ContainsKey(columnName))
            {
                this.patientFilters.Remove(columnName);
            }



            // add new filter
            this.patientFilters.Add(columnName, () => {


                for (int i = this.patientsTableFiltered.Rows.Count - 1; i >= 0; i--)
                {
                    if (!this.patientsTableFiltered.Rows[i][columnName].ToString().StartsWith(value))
                    {
                        this.patientsTableFiltered.Rows[i].Delete();
                    }
                }

            });

            // get original table
            this.patientsTableFiltered = this.patientsTable.Copy();


            // For method in filterMethods
            // do filtermethod
            foreach (var item in this.patientFilters)
            {
                item.Value.Invoke();
            }

            dataGridViewPatients.DataSource = this.patientsTableFiltered;
            dataGridViewPatients.ReadOnly = true;
            dataGridViewPatients.AutoGenerateColumns = true;
            dataGridViewPatients.AutoResizeColumns();
            dataGridViewPatients.Refresh();


        }


        private void filterRoomsTable(String columnName, String value)
        {
            // If already contains filter for certain column delete it
            if (this.filters.ContainsKey(columnName))
            {
                this.filters.Remove(columnName);
            }


       
            // add new filter
            this.filters.Add(columnName, () => {
            

                for (int i = this.roomsTableFiltered.Rows.Count - 1; i >= 0 ; i--)
                {      
                    if (!this.roomsTableFiltered.Rows[i][columnName].ToString().StartsWith(value))
                    {
                        this.roomsTableFiltered.Rows[i].Delete();
                    }
                }
            
            });

            // get original table
            this.roomsTableFiltered = this.roomsTable.Copy();


            // For method in filterMethods
            // do filtermethod
            foreach (var item in this.filters)
            {
                item.Value.Invoke();
            }

            dataGridViewPatientRooms.DataSource = this.roomsTableFiltered;
            dataGridViewPatientRooms.ReadOnly = true;
            dataGridViewPatientRooms.AutoGenerateColumns = true;
            dataGridViewPatientRooms.AutoResizeColumns();
            dataGridViewPatientRooms.Refresh();
        }



        private void ReservePatientRoom_Load(object sender, EventArgs e)
        {
            this.populatePatientRooms();
            this.populatePatients();
        }

        private void comboBoxBulding_SelectedIndexChanged(object sender, EventArgs e)
        {
            String value = (this.comboBoxBulding.Text == "Wszystkie") ? "" : this.comboBoxBulding.Text;
   
            this.filterRoomsTable("Budynek", value);
        }

      

        private void comboBoxInfectious_SelectedIndexChanged(object sender, EventArgs e)
        {
            String value = (this.comboBoxInfectious.Text == "Tak") ? "1" : "0";
            value = (this.comboBoxInfectious.Text == "Wszystkie") ? "" : value;

            this.filterRoomsTable("Zakaźna", value);
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            this.filterPatientsTable("Id", this.textBoxId.Text);
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            this.filterPatientsTable("Imie", this.textBoxFirstName.Text);
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            this.filterPatientsTable("Nazwisko", this.textBoxSurname.Text);

        }

       

        private void labelFilters_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIllness_TextChanged(object sender, EventArgs e)
        {
            this.filterPatientsTable("Choroba", this.textBoxIllness.Text);
        }

        private void textBoxRoomNr_TextChanged(object sender, EventArgs e)
        {
            this.filterRoomsTable("Numer sali", this.textBoxRoomNr.Text);
        }

        private void textBoxRoomNrRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxReservationNr_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewPatientRooms_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            Console.WriteLine("Rowenter");
           
           
            //Console.WriteLine(this.dataGridViewPatientRooms.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void dataGridViewPatientRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewPatientRooms.SelectedRows.Count > 0)
            {
                this.textBoxRoomNrRes.Text = this.dataGridViewPatientRooms.SelectedRows[0].Cells[0].Value.ToString();
            }
        }
    }

}
