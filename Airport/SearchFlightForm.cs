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
    public partial class SearchFlightForm : Form
    {
        public static string PNRin;
        public static string Surnamein;
        Controller controllerObj;
        GetSearchFlight getSearchFlight;
        public SearchFlightForm(string PNR, string Surname,GetSearchFlight GSF)
        {
            InitializeComponent();
            controllerObj = new Controller();
            PNRin = PNR;
            Surnamein = Surname;
            getSearchFlight = GSF;
            PNRdisp.BackColor = Color.FromArgb(0,30,59);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void SearchFlightForm_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetFlightDetailsPNR(PNRin, Surnamein);
            if (dt != null)
            {
                DataRow row = dt.Rows[0];
                string PNRs = "";
                PNRs = row["BOOKINGPNR"].ToString();

                string Fnames = "";
                Fnames = row["Fname"].ToString();

                string Lnames = "";
                Lnames = row["Lname"].ToString();

                string Passnums = "";
                Passnums = row["PassportNo"].ToString();

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

                string Dates = "";
                Dates = row["Date"].ToString();

                string PlanManus = "";
                PlanManus = row["Manufacturer"].ToString();

                PNRdisp.Text = PNRs;
                Fname.Text = Fnames + " " + Lnames;
                PassportNo.Text = Passnums;
                Airline.Text = Airlines;
                FlightNo.Text = Flightnos;
                Date.Text = Dates;
                Time.Text = Times;
                string PlaneTypeComplete = PlanManus + " " + Planetypes;
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
            else
            {
                MessageBox.Show("Booking not found! Try Again");
                this.Hide();
                getSearchFlight.Show();
            }
        }

        private void SearchFlightForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            getSearchFlight.Close();
        }

        private void PNRdisp_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getSearchFlight.Show();
            this.Hide();
        }
    }
}
