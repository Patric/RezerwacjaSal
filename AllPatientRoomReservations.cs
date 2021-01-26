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
    public partial class AllPatientRoomReservations : Form
    {
        public AllPatientRoomReservations()
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
         

            //if (dataGridViewAllPatientRoomReservations.CurrentCell.ColumnIndex == ColumnOptions.Index)
            //{
            //    var comboBox = e.Control as ComboBox;
                
            //    Console.WriteLine("Options clicked", comboBox.ValueMember);
            //    var dataGridView = sender as DataGridView;
            //    Console.WriteLine(dataGridViewAllPatientRoomReservations.CurrentCell.Value);
            //    ;
            //}
        }

        private void dataGridViewAllPatientRoomReservations_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

       

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
