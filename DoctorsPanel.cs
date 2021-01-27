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
    public partial class DoctorsPanel : Form
    {
        public DoctorsPanel()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Navigator.navigateToChild(new ReserveIsolationRoom(), this);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSickRoomOccupation_Click(object sender, EventArgs e)
        {
            Navigator.navigateTo(new RoomInformation());
        }

        private void buttonSickMyReservation_Click(object sender, EventArgs e)
        {
            Navigator.navigateToChild(new PatientRoomReservations(), this);
        }

        private void buttonSickAddReservation_Click(object sender, EventArgs e)
        {
            Navigator.navigateToChild(new ReservePatientRoom(), this);
        }

        private void buttonIsolationMyReservations_Click(object sender, EventArgs e)
        {
            Navigator.navigateToChild(new IsolationRooms(), this);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Authenticator.logout();
            Navigator.newLogin();
        }
    }
}