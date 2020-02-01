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
    public partial class UpdateFlightWindow : Form
    {
        Controller controllerObj;
        string FlightNo;
        bool ArrDep;
        string time;
        string city;
        string airline;
        string terminal;
        string runway;
        string planeType;
        SelectedFlightWindow selectFlightWin;
        public UpdateFlightWindow(string numFlight,SelectedFlightWindow SFW)
        {
            InitializeComponent();
            controllerObj = new Controller();
            FlightNo = numFlight;
            selectFlightWin = SFW;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string timeIn = textBox1.Text == "" ? time : textBox1.Text;
            string terminalIn = textBox3.Text == "" ? terminal : textBox3.Text;
            string runwayIn = textBox2.Text == "" ? runway : textBox2.Text;
            string planeTypeIn = textBox4.Text == "" ? planeType : textBox4.Text;
            int r = controllerObj.UpdateFlight(FlightNo, ArrDep, timeIn, city, airline, terminalIn, runwayIn, planeTypeIn);
            if (r == 0)
            {
                MessageBox.Show("Update Failed!");
            }
            else
            {
                MessageBox.Show("Update Successful!");
                this.Hide();
                SelectedFlightWindow S = new SelectedFlightWindow(FlightNo);
                this.Hide();
                S.ShowDialog();
                this.Show();
            }
        }

        private void UpdateFlightWindow_Load(object sender, EventArgs e)
        {
            FlightLabel.Text = "Flight " + FlightNo;
            DataTable dt = controllerObj.SearchFlightbyNo(FlightNo);
            DataRow row = dt.Rows[0];
            ArrDep = Convert.ToBoolean(row["ArrDep"]);
            time = row["Time"].ToString();  //
            city = row["City"].ToString();
            airline = row["Airline"].ToString();
            terminal = row["Terminal"].ToString();  //
            runway = row["Runway"].ToString();  //
            planeType = row["PlaneType"].ToString();    //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectFlightWin.Show();
        }

        private void UpdateFlightWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            selectFlightWin.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsSymbol(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
