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
    public partial class AirportEmployeeLogin : Form
    {
        Controller controllerObj;
        Welcome welcomeForm;
        public AirportEmployeeLogin(Welcome wForm)
        {
            InitializeComponent();
            controllerObj = new Controller();
            welcomeForm = wForm;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.AirportLoginVerfication(userntextbox.Text, passtextbox.Text);
            if (dt != null)
            {
                DataRow row = dt.Rows[0];
                int LevelAccess = (int)row["LevelAccess"];
                int ID = (int)row["ID"];
                if (LevelAccess > 2)
                {
                    AirportAdminFunctionalities f = new AirportAdminFunctionalities(ID, this);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    AirportEmployeeFunctionalities f = new AirportEmployeeFunctionalities(ID, this);
                    f.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Wrong Username or password!");
            }
        }

        private void AirportEmployeeLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            welcomeForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomeForm.Show();
        }

        private void userntextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
