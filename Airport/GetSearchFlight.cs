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
    public partial class GetSearchFlight : Form
    {
        Controller controllerObj;
        PassengerFunctionalities passengerFunc;
        public GetSearchFlight(PassengerFunctionalities PF)
        {
            InitializeComponent();
            controllerObj = new Controller();
            passengerFunc = PF;
            SearchButton.BackColor = Color.FromArgb(250, 54, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchFlightForm f = new SearchFlightForm(PNRtextbox.Text, SurnameTextBox.Text,this);
            f.Show();
            this.Hide();
        }

        private void GetSearchFlight_FormClosed(object sender, FormClosedEventArgs e)
        {
            passengerFunc.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            passengerFunc.Show();
            this.Hide();
        }

        private void PNRtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void SurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
