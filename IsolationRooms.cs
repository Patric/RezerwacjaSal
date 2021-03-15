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
    public partial class IsolationRooms : Form
    {
        public IsolationRooms()
        {
            InitializeComponent();
        }

        private void labelLoggedAs_Click(object sender, EventArgs e)
        {

        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            Navigator.navigateBack(this);
        }
    }
}
