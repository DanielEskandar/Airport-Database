namespace Airport
{
    partial class SearchFlightForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Fname = new System.Windows.Forms.Label();
            this.PassportNo = new System.Windows.Forms.Label();
            this.PNRdisp = new System.Windows.Forms.Label();
            this.Airline = new System.Windows.Forms.Label();
            this.FlightNo = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.PlaneType = new System.Windows.Forms.Label();
            this.Origin = new System.Windows.Forms.Label();
            this.Destination = new System.Windows.Forms.Label();
            this.Terminal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.Location = new System.Drawing.Point(21, 279);
            this.Fname.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(179, 31);
            this.Fname.TabIndex = 12;
            this.Fname.Text = "FIRST NAME";
            // 
            // PassportNo
            // 
            this.PassportNo.AutoSize = true;
            this.PassportNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassportNo.Location = new System.Drawing.Point(285, 279);
            this.PassportNo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PassportNo.Name = "PassportNo";
            this.PassportNo.Size = new System.Drawing.Size(162, 31);
            this.PassportNo.TabIndex = 14;
            this.PassportNo.Text = "PASSPORT";
            this.PassportNo.Click += new System.EventHandler(this.label15_Click);
            // 
            // PNRdisp
            // 
            this.PNRdisp.AutoSize = true;
            this.PNRdisp.BackColor = System.Drawing.Color.MidnightBlue;
            this.PNRdisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNRdisp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PNRdisp.Location = new System.Drawing.Point(345, 153);
            this.PNRdisp.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PNRdisp.Name = "PNRdisp";
            this.PNRdisp.Size = new System.Drawing.Size(180, 44);
            this.PNRdisp.TabIndex = 15;
            this.PNRdisp.Text = "PNRXXX";
            this.PNRdisp.Click += new System.EventHandler(this.PNRdisp_Click);
            // 
            // Airline
            // 
            this.Airline.AutoSize = true;
            this.Airline.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Airline.Location = new System.Drawing.Point(214, 391);
            this.Airline.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Airline.Name = "Airline";
            this.Airline.Size = new System.Drawing.Size(104, 19);
            this.Airline.TabIndex = 16;
            this.Airline.Text = "AIRLINE NAME";
            // 
            // FlightNo
            // 
            this.FlightNo.AutoSize = true;
            this.FlightNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightNo.Location = new System.Drawing.Point(132, 382);
            this.FlightNo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.FlightNo.Name = "FlightNo";
            this.FlightNo.Size = new System.Drawing.Size(80, 19);
            this.FlightNo.TabIndex = 17;
            this.FlightNo.Text = "FLIGHT NO";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(23, 560);
            this.Date.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(99, 19);
            this.Date.TabIndex = 18;
            this.Date.Text = "DD/MM/YYYY";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(183, 560);
            this.Time.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(59, 19);
            this.Time.TabIndex = 19;
            this.Time.Text = "HH:MM";
            // 
            // PlaneType
            // 
            this.PlaneType.AutoSize = true;
            this.PlaneType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaneType.Location = new System.Drawing.Point(425, 399);
            this.PlaneType.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PlaneType.Name = "PlaneType";
            this.PlaneType.Size = new System.Drawing.Size(87, 19);
            this.PlaneType.TabIndex = 20;
            this.PlaneType.Text = "PLANE TYPE";
            // 
            // Origin
            // 
            this.Origin.AutoSize = true;
            this.Origin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Origin.Location = new System.Drawing.Point(66, 457);
            this.Origin.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Origin.Name = "Origin";
            this.Origin.Size = new System.Drawing.Size(90, 19);
            this.Origin.TabIndex = 21;
            this.Origin.Text = "ORIGIN CITY";
            // 
            // Destination
            // 
            this.Destination.AutoSize = true;
            this.Destination.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Destination.Location = new System.Drawing.Point(226, 457);
            this.Destination.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(130, 19);
            this.Destination.TabIndex = 22;
            this.Destination.Text = "DESTINATION CITY";
            // 
            // Terminal
            // 
            this.Terminal.AutoSize = true;
            this.Terminal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Terminal.Location = new System.Drawing.Point(425, 457);
            this.Terminal.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Terminal.Name = "Terminal";
            this.Terminal.Size = new System.Drawing.Size(77, 19);
            this.Terminal.TabIndex = 23;
            this.Terminal.Text = "TERMINAL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Airport.Properties.Resources.MyBookingMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(566, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Terminal);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.Origin);
            this.Controls.Add(this.PlaneType);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.FlightNo);
            this.Controls.Add(this.Airline);
            this.Controls.Add(this.PNRdisp);
            this.Controls.Add(this.PassportNo);
            this.Controls.Add(this.Fname);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "SearchFlightForm";
            this.Text = "SearchFlightForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchFlightForm_FormClosed);
            this.Load += new System.EventHandler(this.SearchFlightForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.Label PassportNo;
        private System.Windows.Forms.Label PNRdisp;
        private System.Windows.Forms.Label Airline;
        private System.Windows.Forms.Label FlightNo;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label PlaneType;
        private System.Windows.Forms.Label Origin;
        private System.Windows.Forms.Label Destination;
        private System.Windows.Forms.Label Terminal;
        private System.Windows.Forms.Button button1;
    }
}