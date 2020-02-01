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
    public partial class AirportAdminAddFlightWindow : Form
    {
        FlightsAdminAirportWindow Parent;
        Controller controllerObj;

        public AirportAdminAddFlightWindow(FlightsAdminAirportWindow Fadmin)
        {
            InitializeComponent();
            controllerObj = new Controller();
            Parent = Fadmin;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            bool arrdepstate = true;
            if (ArrDepCombo.Text == "Arrival")
            {
                arrdepstate = true;
            }
            else
            {
                arrdepstate = false;
            }

            int c = controllerObj.AddFlightAirport(FlightNumberTextBox.Text, arrdepstate, TimeTextBox.Text, CityComboBox.Text, AirlineComboBox.Text, TerminalComboBox.Text, RunwayComboBox.Text, PlaneModelComboBox.Text);
        }

        private void AirportAdminAddFlightWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDBDataSet5.RUNWAY' table. You can move, or remove it, as needed.
            this.rUNWAYTableAdapter.Fill(this.airportDBDataSet5.RUNWAY);
            // TODO: This line of code loads data into the 'airportDBDataSet4.TERMINAL' table. You can move, or remove it, as needed.
            this.tERMINALTableAdapter.Fill(this.airportDBDataSet4.TERMINAL);
            // TODO: This line of code loads data into the 'airportDBDataSet3.PLANETYPE' table. You can move, or remove it, as needed.
            this.pLANETYPETableAdapter.Fill(this.airportDBDataSet3.PLANETYPE);
            // TODO: This line of code loads data into the 'airportDBDataSet2.CITY' table. You can move, or remove it, as needed.
            this.cITYTableAdapter.Fill(this.airportDBDataSet2.CITY);
            // TODO: This line of code loads data into the 'airportDBDataSet1.AIRLINE' table. You can move, or remove it, as needed.
            this.aIRLINETableAdapter.Fill(this.airportDBDataSet1.AIRLINE);

        }

        private void AirlineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CityComboBox.Text = controllerObj.GetCityForAirline(AirlineComboBox.Text);
        }

        private void CityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AirlineComboBox.Text = controllerObj.GetAirlineForCity(CityComboBox.Text);
        }
    }
}
