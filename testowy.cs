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
    public partial class testowy : Form
    {
        public testowy()
        {
            InitializeComponent();
            Form findPatient = new FindPatient();
            findPatient.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
