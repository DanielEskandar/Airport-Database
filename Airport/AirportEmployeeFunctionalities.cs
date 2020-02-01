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
    public partial class AirportEmployeeFunctionalities : Form
    {
        int ID;
        DataRow EmpData;
        Controller ControllerObj;
        AirportEmployeeLogin portEmpLogin;
        public AirportEmployeeFunctionalities(int IDin, AirportEmployeeLogin AEL)
        {
            InitializeComponent();
            ID = IDin;
            portEmpLogin = AEL;
            ControllerObj = new Controller();
        }

        private void AirportEmployeeFunctionalities_Load(object sender, EventArgs e)
        {
            DataTable dt = ControllerObj.AirportEmpbyID(ID);
            EmpData = dt.Rows[0];
            Name.Text = EmpData["Fname"].ToString() + " " + EmpData["Lname"].ToString() + ",";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchFlightWindow f = new SearchFlightWindow();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        

        private void AirportEmployeeFunctionalities_FormClosed(object sender, FormClosedEventArgs e)
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
