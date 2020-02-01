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
    public partial class SelectedFlightWindow : Form
    {
        string FlightNo;
        Controller controllerObj;
        public SelectedFlightWindow(string numFlight)
        {
            InitializeComponent();
            FlightNo = numFlight;
            controllerObj = new Controller();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = controllerObj.DeleteFlightAirport(FlightNo);
            if (r == 0)
            {
                MessageBox.Show("Deletion Failed!");
            }
            else
            {
                MessageBox.Show("Deletion Successful!");
            }
            
            
        }

        private void SelectedFlightWindow_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SearchFlightbyNo(FlightNo);
            DataRow row = dt.Rows[0];

            string Airlines = "";
            Airlines = row["Airline"].ToString();

            string Flightnos = "";
            Flightnos = row["FlightNo"].ToString();

            string Times = "";
            Times = row["Time"].ToString();

            string Planetypes = "";
            Planetypes = row["PlaneType"].ToString();

            string Citys = "";
            Citys = row["City"].ToString();

            string Terminals = "";
            Terminals = row["Terminal"].ToString();

            bool ARRDEP;
            ARRDEP = (bool)row["ArrDep"];

            string Runways = "";
            Runways = row["Runway"].ToString();

            
            Airline.Text = Airlines;
            FlightNoLabel.Text = Flightnos;
            Runway.Text = Runways;
            Time.Text = Times;
            string PlaneTypeComplete = Planetypes;
            PlaneType.Text = PlaneTypeComplete;
            if (ARRDEP)
            {
                Origin.Text = "Cairo";
                Destination.Text = Citys;
            }
            else
            {
                Origin.Text = Citys;
                Destination.Text = "Cairo";
            }
            Terminal.Text = Terminals;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateFlightWindow f = new UpdateFlightWindow(FlightNo,this);
            f.Show();
            this.Hide();
        }

        private void SelectedFlightWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Runway_Click(object sender, EventArgs e)
        {

        }
    }
}
