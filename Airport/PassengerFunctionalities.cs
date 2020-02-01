using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport
{
    public partial class PassengerFunctionalities : Form
    {
        Welcome welcomeForm;
        public PassengerFunctionalities(Welcome wForm)
        {
            InitializeComponent();
            welcomeForm = wForm;
            label1.BackColor = Color.FromArgb(216, 235, 255);
            label2.BackColor = Color.FromArgb(216, 235, 255);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetSearchFlight f = new GetSearchFlight(this);
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchFlightWindow f = new SearchFlightWindow();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void PassengerFunctionalities_FormClosed(object sender, FormClosedEventArgs e)
        {
            welcomeForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            welcomeForm.Show();
            this.Hide();
        }
    }
}
