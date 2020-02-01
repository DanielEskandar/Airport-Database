namespace Airport
{
    partial class AirportEmployeeFunctionalities
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
            this.Name = new System.Windows.Forms.Label();
            this.SearchFlightButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewPassengerButton = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(135, 104);
            this.Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(71, 26);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            // 
            // SearchFlightButton
            // 
            this.SearchFlightButton.BackgroundImage = global::Airport.Properties.Resources.AirportEmpFlightButton;
            this.SearchFlightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchFlightButton.Location = new System.Drawing.Point(67, 140);
            this.SearchFlightButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchFlightButton.Name = "SearchFlightButton";
            this.SearchFlightButton.Size = new System.Drawing.Size(185, 143);
            this.SearchFlightButton.TabIndex = 2;
            this.SearchFlightButton.UseVisualStyleBackColor = true;
            this.SearchFlightButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Airport.Properties.Resources.AirportEmpPassButton;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(269, 140);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 143);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
           
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(448, 104);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "My Info";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 291);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search Flights";
            // 
            // ViewPassengerButton
            // 
            this.ViewPassengerButton.AutoSize = true;
            this.ViewPassengerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPassengerButton.Location = new System.Drawing.Point(270, 291);
            this.ViewPassengerButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ViewPassengerButton.Name = "ViewPassengerButton";
            this.ViewPassengerButton.Size = new System.Drawing.Size(181, 26);
            this.ViewPassengerButton.TabIndex = 6;
            this.ViewPassengerButton.Text = "View Passengers";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AirportEmployeeFunctionalities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Airport.Properties.Resources.AirportEmpMainWindow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(525, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewPassengerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SearchFlightButton);
            this.Controls.Add(this.Name);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            //this.Name = "AirportEmployeeFunctionalities";
            this.Text = "AirportEmployeeFunctionalites";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AirportEmployeeFunctionalities_FormClosed);
            this.Load += new System.EventHandler(this.AirportEmployeeFunctionalities_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Button SearchFlightButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ViewPassengerButton;
        private System.Windows.Forms.Button button1;
    }
}