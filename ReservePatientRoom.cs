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

        Dictionary<String, Action> filters = new Dictionary<String, Action>();



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

        private void filterTable(String columnName, String value)
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
        }

        private void comboBoxBulding_SelectedIndexChanged(object sender, EventArgs e)
        {
            String value = (this.comboBoxBulding.Text == "Wszystkie") ? "" : this.comboBoxBulding.Text;
   
            this.filterTable("Budynek", value);
        }

      

        private void comboBoxInfectious_SelectedIndexChanged(object sender, EventArgs e)
        {
            String value = (this.comboBoxInfectious.Text == "Tak") ? "1" : "0";
            value = (this.comboBoxInfectious.Text == "Wszystkie") ? "" : value;

            this.filterTable("Zakaźna", value);
        }
    }

}
