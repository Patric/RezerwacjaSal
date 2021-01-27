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
    public partial class ReserveIsolationRoom : Form
    {
        public ReserveIsolationRoom()
        {
            InitializeComponent();
            var equipement = DbAdapter.getEquipement();
            foreach (var eq in equipement)
            {
                this.checkedListBox1.Items.Add(eq);
            }
            
        }

        private void labelReservePatientRoom_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewHasLinkTo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBoxRequirements_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Navigator.navigateBack(this);
        }
    }
}