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
    public partial class SearchFlightWindow : Form
    {
        Controller controllerObj;
        public SearchFlightWindow()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SelectSearchComboBox.Text == "Flight Number")
            {
                DataTable dt = controllerObj.SearchFlightbyNo(FlightnoTextBox.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else if (SelectSearchComboBox.Text == "Destination")
            {
                DataTable dt = controllerObj.SearchFlightByCity(DestinationTextBox.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else
            {
                DataTable dt = controllerObj.SearchFlightByCity(DateTextBox.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }

        private void SearchFlightWindow_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FlightnoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void DestinationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void DateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
        }
    }
}
