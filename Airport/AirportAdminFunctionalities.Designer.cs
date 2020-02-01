namespace Airport
{
    partial class AirportAdminFunctionalities
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
            this.FlightsButton = new System.Windows.Forms.Button();
            this.PassengersButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FlightsButton
            // 
            this.FlightsButton.BackgroundImage = global::Airport.Properties.Resources.AirpEmpFLightButton;
            this.FlightsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FlightsButton.Location = new System.Drawing.Point(8, 131);
            this.FlightsButton.Margin = new System.Windows.Forms.Padding(2);
            this.FlightsButton.Name = "FlightsButton";
            this.FlightsButton.Size = new System.Drawing.Size(101, 101);
            this.FlightsButton.TabIndex = 2;
            this.FlightsButton.UseVisualStyleBackColor = true;
            this.FlightsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PassengersButton
            // 
            this.PassengersButton.BackgroundImage = global::Airport.Properties.Resources.AirpEmpPassengerButton;
            this.PassengersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PassengersButton.Location = new System.Drawing.Point(117, 131);
            this.PassengersButton.Margin = new System.Windows.Forms.Padding(2);
            this.PassengersButton.Name = "PassengersButton";
            this.PassengersButton.Size = new System.Drawing.Size(101, 101);
            this.PassengersButton.TabIndex = 3;
            this.PassengersButton.UseVisualStyleBackColor = true;
            
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Airport.Properties.Resources.AirpEmpEmpButton;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(229, 131);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 101);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Airport.Properties.Resources.AirpEmpBillButton;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(337, 131);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 101);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(297, 88);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 27);
            this.button5.TabIndex = 6;
            this.button5.Text = "My Account";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameLabel.Location = new System.Drawing.Point(111, 88);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(57, 22);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Manage Flights";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Passenger Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Employee Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Manage Fares";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 27);
            this.button1.TabIndex = 14;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AirportAdminFunctionalities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Airport.Properties.Resources.AirportAdminMainWindow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(448, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PassengersButton);
            this.Controls.Add(this.FlightsButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AirportAdminFunctionalities";
            this.Text = "AirportAdminFunctionalities";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AirportAdminFunctionalities_FormClosed);
            this.Load += new System.EventHandler(this.AirportAdminFunctionalities_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FlightsButton;
        private System.Windows.Forms.Button PassengersButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}