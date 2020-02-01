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
    public partial class FlightsAdminAirportWindow : Form
    {
        Controller ControllerObj;
        public AirportAdminFunctionalities portAdminFunc;
        public FlightsAdminAirportWindow(AirportAdminFunctionalities AAF)
        {
            InitializeComponent();
            ControllerObj = new Controller();
            portAdminFunc = AAF;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string FlightNo;
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                FlightNo = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                SelectedFlightWindow f = new SelectedFlightWindow(FlightNo);
                this.Hide();
                f.ShowDialog();
                this.Show();
            } 

        }

        private void FlightsAdminAirportWindow_Load(object sender, EventArgs e)
        {
            DataTable dt = ControllerObj.GetAllFlightData();
            DataTable arrdt = dt.Clone();
            DataTable depdt = dt.Clone(); 
            foreach (DataRow row in dt.Rows)
            {
                bool checkarrdep = (bool)row["ArrDep"];
                if (checkarrdep)
                {
                    DataRow R = row;
                    depdt.ImportRow(row);
                }
                else
                {
                    DataRow R = row;
                    arrdt.ImportRow(row);
                }
            }
            dataGridView1.DataSource = arrdt;
            dataGridView2.DataSource = depdt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string FlightNo;
            if (dataGridView2.Rows[e.RowIndex].Cells[0].Value != null)
            {
                FlightNo = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                SelectedFlightWindow f = new SelectedFlightWindow(FlightNo);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchFlightWindow f = new SearchFlightWindow();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void FlightsAdminAirportWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            portAdminFunc.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AirportAdminAddFlightWindow f = new AirportAdminAddFlightWindow(this);
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            portAdminFunc.Show();
            this.Hide();
        }
    }
}
