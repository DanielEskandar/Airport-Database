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
    public partial class AirportAdminFunctionalities : Form
    {
        int ID;
        DataRow AdminData;
        Controller ControllerObj;
        AirportEmployeeLogin portEmpLogin;
        public AirportAdminFunctionalities(int IDin,AirportEmployeeLogin AEL)
        {
            InitializeComponent();
            ControllerObj = new Controller();
            ID = IDin;
            portEmpLogin = AEL;
            NameLabel.BackColor = Color.FromArgb(216,235,255);
            label1.BackColor = Color.FromArgb(216, 235, 255);
            label2.BackColor = Color.FromArgb(216, 235, 255);
            label3.BackColor = Color.FromArgb(216, 235, 255);
            label4.BackColor = Color.FromArgb(216, 235, 255);
        }

        private void AirportAdminFunctionalities_Load(object sender, EventArgs e)
        {
            DataTable dt = ControllerObj.AirportEmpbyID(ID);
            AdminData = dt.Rows[0];
            NameLabel.Text = AdminData["Fname"].ToString() + " " + AdminData["Lname"].ToString() + ",";
        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            FlightsAdminAirportWindow f = new FlightsAdminAirportWindow(this);
            f.Show();
            this.Hide();
        }

        

      

        private void AirportAdminFunctionalities_FormClosed(object sender, FormClosedEventArgs e)
        {
            portEmpLogin.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            portEmpLogin.Show();
            this.Hide();
        }
    }
}
