namespace Airport
{
    partial class GetSearchFlight
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
            this.PNRtextbox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PNRtextbox
            // 
            this.PNRtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNRtextbox.Location = new System.Drawing.Point(231, 150);
            this.PNRtextbox.Margin = new System.Windows.Forms.Padding(1);
            this.PNRtextbox.MaxLength = 6;
            this.PNRtextbox.Name = "PNRtextbox";
            this.PNRtextbox.Size = new System.Drawing.Size(167, 30);
            this.PNRtextbox.TabIndex = 0;
            this.PNRtextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PNRtextbox_KeyPress);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameTextBox.Location = new System.Drawing.Point(231, 193);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(241, 30);
            this.SurnameTextBox.TabIndex = 1;
            this.SurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameTextBox_KeyPress);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.OrangeRed;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(127, 253);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(1);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(109, 36);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(288, 253);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GetSearchFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Airport.Properties.Resources.CheckMyBookingMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(574, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.PNRtextbox);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "GetSearchFlight";
            this.Text = "GetSearchFlight";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GetSearchFlight_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PNRtextbox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button button1;
    }
}