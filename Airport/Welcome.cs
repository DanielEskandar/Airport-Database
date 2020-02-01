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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent(); 
            label1.BackColor = Color.FromArgb(216, 235, 255);
            
            label3.BackColor = Color.FromArgb(216, 235, 255);
           
            label5.BackColor = Color.FromArgb(216, 235, 255);
            
            
            StatusLabel.BackColor = Color.FromArgb(137, 196, 255);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PassengerFunctionalities f = new PassengerFunctionalities(this);
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            StatusLabel.Text = "Check your Booking or Search for Flights";
            StatusLabel.Show();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            StatusLabel.Text = "Log-In for Government Employees";
            StatusLabel.Show();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            StatusLabel.Text = "Log-In for Airlines' Employees";
            StatusLabel.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            StatusLabel.Text = "Log-In for Airport's Employees";
            StatusLabel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AirportEmployeeLogin f = new AirportEmployeeLogin(this);
            f.Show();
            this.Hide();
        }

        
    }
}
