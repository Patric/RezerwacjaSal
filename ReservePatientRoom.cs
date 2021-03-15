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

        private DataTable roomsOccupancyTable;

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

        private void populateAutoComplete(DataTable dataTable, List<TextBox> textBoxes)
        {
            try
            {
                String[] autoComplete;
                for (int i = 0; i < textBoxes.Count - 1; i++)
                {
                    autoComplete = dataTable
                    .AsEnumerable()
                    .Select<System.Data.DataRow, String>(x => x.Field<String>(dataTable.Columns[i].ColumnName))
                    .ToArray();

                    var source = new AutoCompleteStringCollection();
                    source.AddRange(autoComplete);
                    textBoxes[i].AutoCompleteCustomSource = source;
                    textBoxes[i].AutoCompleteMode = AutoCompleteMode.Suggest;
                    textBoxes[i].AutoCompleteSource = AutoCompleteSource.CustomSource;


                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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

            dataGridViewPatients.DataSource = this.patientsTable;
            dataGridViewPatients.ReadOnly = true;
            dataGridViewPatients.AutoGenerateColumns = true;
            dataGridViewPatients.AutoResizeColumns();
            dataGridViewPatients.Refresh();



        }


        private void populatePatientRooms()
        {




            Stack<PatientRoom> rooms = DbAdapter.getPatientRooms();
            this.roomsTable= new DataTable();
            this.roomsTable.Columns.Add(new DataColumn("Numer sali"));
            this.roomsTable.Columns.Add(new DataColumn("Oddział"));
            this.roomsTable.Columns.Add(new DataColumn("Budynek"));
            this.roomsTable.Columns.Add(new DataColumn("Sprzęt"));


            foreach (var room in rooms)
            {
                roomsTable.Rows.Add(
                   room.room_number,
                   room.department,
                   room.building,
                   null
                );
            }

            // Filter table with data

          

            dataGridViewPatientRooms.DataSource = this.roomsTable;
            dataGridViewPatientRooms.ReadOnly = true;
            dataGridViewPatientRooms.AutoGenerateColumns = true;
            dataGridViewPatientRooms.AutoResizeColumns();
            dataGridViewPatientRooms.Refresh();

        }


        private void populateRoomsOccupancy()
        {
            Stack<RoomOccupancyDTO> roomsOccupancy = DbAdapter.getPatientRoomsOccupancy(
               this.dateTimePickerCheckInDate.Value,
               this.dateTimePickerCheckOutDate.Value);

            this.roomsOccupancyTable = new DataTable();
            this.roomsOccupancyTable.Columns.Add(new DataColumn("Numer sali"));
            this.roomsOccupancyTable.Columns.Add(new DataColumn("Oddział"));
            this.roomsOccupancyTable.Columns.Add(new DataColumn("Budynek"));
            this.roomsOccupancyTable.Columns.Add(new DataColumn("Rezerwacja od"));
            this.roomsOccupancyTable.Columns.Add(new DataColumn("Rezerwacja do"));

 
            foreach (var roomOccupancy in roomsOccupancy)
            {
                this.roomsOccupancyTable.Rows.Add(
                   roomOccupancy.room_number,
                   roomOccupancy.department,
                   roomOccupancy.building,
                   roomOccupancy.date_from,
                   roomOccupancy.date_to
                );
            }


        }

        private void filterRoomsOccupancy()
        {
            var occupied_room_nrs = this.roomsOccupancyTable.AsEnumerable().Where(x =>
            (DateTime.Parse(x["Rezerwacja do"].ToString()) <= this.dateTimePickerCheckOutDate.Value
            &&
            DateTime.Parse(x["Rezerwacja od"].ToString()) >= this.dateTimePickerCheckInDate.Value
            )
            ||
            (
            DateTime.Parse(x["Rezerwacja do"].ToString()) >= this.dateTimePickerCheckOutDate.Value 
            && 
            DateTime.Parse(x["Rezerwacja od"].ToString()) <= this.dateTimePickerCheckOutDate.Value 
            )
            ||
            (
            DateTime.Parse(x["Rezerwacja od"].ToString()) <= this.dateTimePickerCheckInDate.Value
            &&
            DateTime.Parse(x["Rezerwacja do"].ToString()) >= this.dateTimePickerCheckInDate.Value
            )
           );
           
           for (int i = this.roomsTableFiltered.Rows.Count - 1; i >= 0; i--)
            {
                foreach (var item in occupied_room_nrs)
                {
         
                        if (item[0].ToString() == this.roomsTableFiltered.Rows[i]["Numer sali"].ToString())
                        {
                        this.roomsTableFiltered.Rows[i].Delete();
                        break;
                        }

                }
            }

        }

        private void filterPatientsTable(String columnName, String value)
        {
            // add new filter
            if (columnName != null)
            {
                // If already contains filter for certain column delete it
                if (this.patientFilters.ContainsKey(columnName))
                {
                    this.patientFilters.Remove(columnName);
                }



                // add new filter
                this.patientFilters.Add(columnName, () =>
                {


                    for (int i = this.patientsTableFiltered.Rows.Count - 1; i >= 0; i--)
                    {
                        if (!this.patientsTableFiltered.Rows[i][columnName].ToString().StartsWith(value))
                        {
                            this.patientsTableFiltered.Rows[i].Delete();
                        }
                    }

                });
            }

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
            // add new filter
            if (columnName != null)
            {
                // If already contains filter for certain column delete it
                if (this.filters.ContainsKey(columnName))
            {
                this.filters.Remove(columnName);
            }

           
                this.filters.Add(columnName, () => {


                    for (int i = this.roomsTableFiltered.Rows.Count - 1; i >= 0; i--)
                    {
                        if (!this.roomsTableFiltered.Rows[i][columnName].ToString().StartsWith(value))
                        {
                            this.roomsTableFiltered.Rows[i].Delete();
                        }
                    }

                });
            }
           

            // get original table
            this.roomsTableFiltered = this.roomsTable.Copy();


            // For method in filterMethods
            // do filtermethod
            if(this.filters.Count > 0)
            {
                foreach (var item in this.filters)
                {
                    item.Value.Invoke();
                }
            }
           

            this.filterRoomsOccupancy();

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
            var equipement = DbAdapter.getEquipement();
            foreach (var eq in equipement)
            {
                this.checkedListBoxEquipment.Items.Add(eq);
            }
            this.populateAutoComplete(this.patientsTable, new List<TextBox>()
            {this.textBoxId , this.textBoxFirstName, this.textBoxSurname, this.textBoxIllness});
            this.populateAutoComplete(this.roomsTable, new List<TextBox>() 
            { this.textBoxRoomNr, this.textBoxDepartment });


            this.populateRoomsOccupancy();
            this.dateTimePickerCheckInDate.Value = System.DateTime.Now;
            this.dateTimePickerCheckOutDate.Value = DateTime.Now;

            this.dateTimePickerCheckInDate.MinDate = DateTime.Now;
            this.dateTimePickerCheckOutDate.MinDate = DateTime.Now;
            this.buttonSave.Enabled = false;
            this.Refresh();

        }

        private void comboBoxBulding_SelectedIndexChanged(object sender, EventArgs e)
        {
            String value = (this.comboBoxBulding.Text == "Wszystkie") ? "" : this.comboBoxBulding.Text;
   
            this.filterRoomsTable("Budynek", value);
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

        }

        private void dataGridViewPatientRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewPatientRooms.SelectedRows.Count > 0)
            {
                this.textBoxRoomNrRes.Text = this.dataGridViewPatientRooms.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var newReservation = new Reservation(
                    null,
                    this.dataGridViewPatientRooms.SelectedRows[0].Cells[0].Value.ToString(),
                    this.dataGridViewPatientRooms.SelectedRows[0].Cells[1].Value.ToString(),
                    this.dataGridViewPatientRooms.SelectedRows[0].Cells[2].Value.ToString(),
                    this.dataGridViewPatients.SelectedRows[0].Cells[0].Value.ToString(),
                    this.dataGridViewPatients.SelectedRows[0].Cells[1].Value.ToString(),
                    this.dataGridViewPatients.SelectedRows[0].Cells[2].Value.ToString(),
                    this.dataGridViewPatients.SelectedRows[0].Cells[3].Value.ToString(),
                    this.dateTimePickerCheckInDate.Value.ToString(),
                    this.dateTimePickerCheckOutDate.Value.ToString());


                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz dodać rezerwację z następującymi danymi? \n \n" + newReservation.ToString(), "Dodawanie rezerwacji", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DbAdapter.addReservation(newReservation);
                    Navigator.navigateToChild(new PatientRoomReservations(), this);
                }
                else if (dialogResult == DialogResult.No)
                {
                    // nothing
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Wystąpił błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

           
        }

        private void dateTimePickerCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Check in date changed");
            this.filterRoomsTable(null, null);
            this.dateTimePickerCheckOutDate.MinDate = this.dateTimePickerCheckInDate.Value;
        }

        private void dateTimePickerCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Check out date changed");
            this.filterRoomsTable(null, null);
          
          

        }

        private void textBoxDepartment_TextChanged(object sender, EventArgs e)
        {
            this.filterRoomsTable("Oddział", this.textBoxDepartment.Text);
        }

        private void dataGridViewPatientRooms_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewPatientRooms.SelectedRows.Count == 0 && this.dataGridViewPatients.SelectedRows.Count > 0 && this.textBoxRoomNrRes.Text.Length > 0)
            {
                this.buttonSave.Enabled = false;
            }
            else
            {
                this.buttonSave.Enabled = true;
            }
        }

        private void dataGridViewPatients_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewPatientRooms.SelectedRows.Count == 0 && this.dataGridViewPatients.SelectedRows.Count > 0 && this.textBoxRoomNrRes.Text.Length > 0)
            {
                this.buttonSave.Enabled = false;
            }
            else
            {
                this.buttonSave.Enabled = true;
            }
        }
    }

}
