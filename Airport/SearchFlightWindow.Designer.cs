namespace Airport
{
    partial class SearchFlightWindow
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
            this.FlightnoTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.SelectSearchComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FlightnoTextBox
            // 
            this.FlightnoTextBox.Location = new System.Drawing.Point(21, 158);
            this.FlightnoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FlightnoTextBox.MaxLength = 5;
            this.FlightnoTextBox.Name = "FlightnoTextBox";
            this.FlightnoTextBox.Size = new System.Drawing.Size(115, 20);
            this.FlightnoTextBox.TabIndex = 0;
            this.FlightnoTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.FlightnoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FlightnoTextBox_KeyPress);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(452, 110);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(79, 28);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 189);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(519, 190);
            this.dataGridView1.TabIndex = 3;
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Location = new System.Drawing.Point(159, 157);
            this.DestinationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(138, 20);
            this.DestinationTextBox.TabIndex = 4;
            this.DestinationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DestinationTextBox_KeyPress);
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(321, 157);
            this.DateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(123, 20);
            this.DateTextBox.TabIndex = 5;
            this.DateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DateTextBox_KeyPress);
            // 
            // SelectSearchComboBox
            // 
            this.SelectSearchComboBox.FormattingEnabled = true;
            this.SelectSearchComboBox.Items.AddRange(new object[] {
            "Flight Number",
            "Destination",
            "Date"});
            this.SelectSearchComboBox.Location = new System.Drawing.Point(143, 98);
            this.SelectSearchComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SelectSearchComboBox.Name = "SelectSearchComboBox";
            this.SelectSearchComboBox.Size = new System.Drawing.Size(98, 21);
            this.SelectSearchComboBox.TabIndex = 6;
            // 
            // SearchFlightWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Airport.Properties.Resources.FlightSearchWindow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(561, 409);
            this.Controls.Add(this.SelectSearchComboBox);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.DestinationTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.FlightnoTextBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchFlightWindow";
            this.Text = "SearchFlightWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchFlightWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FlightnoTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.ComboBox SelectSearchComboBox;
    }
}