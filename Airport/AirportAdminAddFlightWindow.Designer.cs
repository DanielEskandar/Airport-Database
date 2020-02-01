namespace Airport
{
    partial class AirportAdminAddFlightWindow
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
            this.components = new System.ComponentModel.Container();
            this.FlightNumberTextBox = new System.Windows.Forms.TextBox();
            this.ArrDepCombo = new System.Windows.Forms.ComboBox();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.RunwayComboBox = new System.Windows.Forms.ComboBox();
            this.AirlineComboBox = new System.Windows.Forms.ComboBox();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TerminalComboBox = new System.Windows.Forms.ComboBox();
            this.PlaneModelComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.airportDBDataSet = new Airport.AirportDBDataSet();
            this.airportDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportDBDataSet1 = new Airport.AirportDBDataSet1();
            this.aIRLINEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aIRLINETableAdapter = new Airport.AirportDBDataSet1TableAdapters.AIRLINETableAdapter();
            this.airportDBDataSet2 = new Airport.AirportDBDataSet2();
            this.cITYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cITYTableAdapter = new Airport.AirportDBDataSet2TableAdapters.CITYTableAdapter();
            this.airportDBDataSet3 = new Airport.AirportDBDataSet3();
            this.pLANETYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLANETYPETableAdapter = new Airport.AirportDBDataSet3TableAdapters.PLANETYPETableAdapter();
            this.airportDBDataSet4 = new Airport.AirportDBDataSet4();
            this.tERMINALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tERMINALTableAdapter = new Airport.AirportDBDataSet4TableAdapters.TERMINALTableAdapter();
            this.airportDBDataSet5 = new Airport.AirportDBDataSet5();
            this.rUNWAYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rUNWAYTableAdapter = new Airport.AirportDBDataSet5TableAdapters.RUNWAYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.airportDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRLINEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANETYPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tERMINALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUNWAYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FlightNumberTextBox
            // 
            this.FlightNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightNumberTextBox.Location = new System.Drawing.Point(59, 291);
            this.FlightNumberTextBox.Name = "FlightNumberTextBox";
            this.FlightNumberTextBox.Size = new System.Drawing.Size(272, 44);
            this.FlightNumberTextBox.TabIndex = 0;
            // 
            // ArrDepCombo
            // 
            this.ArrDepCombo.FormattingEnabled = true;
            this.ArrDepCombo.Items.AddRange(new object[] {
            "Arrival",
            "Departure"});
            this.ArrDepCombo.Location = new System.Drawing.Point(59, 403);
            this.ArrDepCombo.Name = "ArrDepCombo";
            this.ArrDepCombo.Size = new System.Drawing.Size(272, 28);
            this.ArrDepCombo.TabIndex = 1;
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTextBox.Location = new System.Drawing.Point(503, 343);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(198, 53);
            this.TimeTextBox.TabIndex = 3;
            // 
            // RunwayComboBox
            // 
            this.RunwayComboBox.DataSource = this.rUNWAYBindingSource;
            this.RunwayComboBox.DisplayMember = "RunwayCode";
            this.RunwayComboBox.FormattingEnabled = true;
            this.RunwayComboBox.Location = new System.Drawing.Point(517, 508);
            this.RunwayComboBox.Name = "RunwayComboBox";
            this.RunwayComboBox.Size = new System.Drawing.Size(97, 28);
            this.RunwayComboBox.TabIndex = 4;
            this.RunwayComboBox.ValueMember = "RunwayCode";
            // 
            // AirlineComboBox
            // 
            this.AirlineComboBox.DataSource = this.aIRLINEBindingSource;
            this.AirlineComboBox.DisplayMember = "Name";
            this.AirlineComboBox.FormattingEnabled = true;
            this.AirlineComboBox.Location = new System.Drawing.Point(392, 292);
            this.AirlineComboBox.Name = "AirlineComboBox";
            this.AirlineComboBox.Size = new System.Drawing.Size(309, 28);
            this.AirlineComboBox.TabIndex = 5;
            this.AirlineComboBox.ValueMember = "Name";
            this.AirlineComboBox.SelectedIndexChanged += new System.EventHandler(this.AirlineComboBox_SelectedIndexChanged);
            // 
            // CityComboBox
            // 
            this.CityComboBox.DataSource = this.cITYBindingSource;
            this.CityComboBox.DisplayMember = "Name";
            this.CityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(59, 506);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(272, 40);
            this.CityComboBox.TabIndex = 6;
            this.CityComboBox.ValueMember = "Name";
            this.CityComboBox.SelectedIndexChanged += new System.EventHandler(this.CityComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "Flight Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Arrival or Departure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gotham Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(386, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gotham Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gotham Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(385, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = "Airline";
            // 
            // TerminalComboBox
            // 
            this.TerminalComboBox.DataSource = this.tERMINALBindingSource;
            this.TerminalComboBox.DisplayMember = "TerminalCode";
            this.TerminalComboBox.FormattingEnabled = true;
            this.TerminalComboBox.Location = new System.Drawing.Point(517, 463);
            this.TerminalComboBox.Name = "TerminalComboBox";
            this.TerminalComboBox.Size = new System.Drawing.Size(97, 28);
            this.TerminalComboBox.TabIndex = 12;
            this.TerminalComboBox.ValueMember = "TerminalCode";
            // 
            // PlaneModelComboBox
            // 
            this.PlaneModelComboBox.DataSource = this.pLANETYPEBindingSource;
            this.PlaneModelComboBox.DisplayMember = "Name";
            this.PlaneModelComboBox.FormattingEnabled = true;
            this.PlaneModelComboBox.Location = new System.Drawing.Point(568, 416);
            this.PlaneModelComboBox.Name = "PlaneModelComboBox";
            this.PlaneModelComboBox.Size = new System.Drawing.Size(133, 28);
            this.PlaneModelComboBox.TabIndex = 13;
            this.PlaneModelComboBox.ValueMember = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gotham Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(387, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Plane Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gotham Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(387, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Terminal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gotham Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(387, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Runway";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Tomato;
            this.AddButton.Font = new System.Drawing.Font("Gotham Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddButton.Location = new System.Drawing.Point(653, 481);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(145, 64);
            this.AddButton.TabIndex = 17;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // airportDBDataSet
            // 
            this.airportDBDataSet.DataSetName = "AirportDBDataSet";
            this.airportDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airportDBDataSetBindingSource
            // 
            this.airportDBDataSetBindingSource.DataSource = this.airportDBDataSet;
            this.airportDBDataSetBindingSource.Position = 0;
            // 
            // airportDBDataSet1
            // 
            this.airportDBDataSet1.DataSetName = "AirportDBDataSet1";
            this.airportDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aIRLINEBindingSource
            // 
            this.aIRLINEBindingSource.DataMember = "AIRLINE";
            this.aIRLINEBindingSource.DataSource = this.airportDBDataSet1;
            // 
            // aIRLINETableAdapter
            // 
            this.aIRLINETableAdapter.ClearBeforeFill = true;
            // 
            // airportDBDataSet2
            // 
            this.airportDBDataSet2.DataSetName = "AirportDBDataSet2";
            this.airportDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cITYBindingSource
            // 
            this.cITYBindingSource.DataMember = "CITY";
            this.cITYBindingSource.DataSource = this.airportDBDataSet2;
            // 
            // cITYTableAdapter
            // 
            this.cITYTableAdapter.ClearBeforeFill = true;
            // 
            // airportDBDataSet3
            // 
            this.airportDBDataSet3.DataSetName = "AirportDBDataSet3";
            this.airportDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pLANETYPEBindingSource
            // 
            this.pLANETYPEBindingSource.DataMember = "PLANETYPE";
            this.pLANETYPEBindingSource.DataSource = this.airportDBDataSet3;
            // 
            // pLANETYPETableAdapter
            // 
            this.pLANETYPETableAdapter.ClearBeforeFill = true;
            // 
            // airportDBDataSet4
            // 
            this.airportDBDataSet4.DataSetName = "AirportDBDataSet4";
            this.airportDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tERMINALBindingSource
            // 
            this.tERMINALBindingSource.DataMember = "TERMINAL";
            this.tERMINALBindingSource.DataSource = this.airportDBDataSet4;
            // 
            // tERMINALTableAdapter
            // 
            this.tERMINALTableAdapter.ClearBeforeFill = true;
            // 
            // airportDBDataSet5
            // 
            this.airportDBDataSet5.DataSetName = "AirportDBDataSet5";
            this.airportDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rUNWAYBindingSource
            // 
            this.rUNWAYBindingSource.DataMember = "RUNWAY";
            this.rUNWAYBindingSource.DataSource = this.airportDBDataSet5;
            // 
            // rUNWAYTableAdapter
            // 
            this.rUNWAYTableAdapter.ClearBeforeFill = true;
            // 
            // AirportAdminAddFlightWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Airport.Properties.Resources.AirportAdminAddFlightWindow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(824, 612);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PlaneModelComboBox);
            this.Controls.Add(this.TerminalComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CityComboBox);
            this.Controls.Add(this.AirlineComboBox);
            this.Controls.Add(this.RunwayComboBox);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.ArrDepCombo);
            this.Controls.Add(this.FlightNumberTextBox);
            this.DoubleBuffered = true;
            this.Name = "AirportAdminAddFlightWindow";
            this.Text = "AirportAdminAddFlightWindow";
            this.Load += new System.EventHandler(this.AirportAdminAddFlightWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airportDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRLINEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cITYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANETYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tERMINALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUNWAYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FlightNumberTextBox;
        private System.Windows.Forms.ComboBox ArrDepCombo;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.ComboBox RunwayComboBox;
        private System.Windows.Forms.ComboBox AirlineComboBox;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TerminalComboBox;
        private System.Windows.Forms.ComboBox PlaneModelComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddButton;
        private AirportDBDataSet airportDBDataSet;
        private System.Windows.Forms.BindingSource airportDBDataSetBindingSource;
        private AirportDBDataSet1 airportDBDataSet1;
        private System.Windows.Forms.BindingSource aIRLINEBindingSource;
        private AirportDBDataSet1TableAdapters.AIRLINETableAdapter aIRLINETableAdapter;
        private AirportDBDataSet2 airportDBDataSet2;
        private System.Windows.Forms.BindingSource cITYBindingSource;
        private AirportDBDataSet2TableAdapters.CITYTableAdapter cITYTableAdapter;
        private AirportDBDataSet3 airportDBDataSet3;
        private System.Windows.Forms.BindingSource pLANETYPEBindingSource;
        private AirportDBDataSet3TableAdapters.PLANETYPETableAdapter pLANETYPETableAdapter;
        private AirportDBDataSet4 airportDBDataSet4;
        private System.Windows.Forms.BindingSource tERMINALBindingSource;
        private AirportDBDataSet4TableAdapters.TERMINALTableAdapter tERMINALTableAdapter;
        private AirportDBDataSet5 airportDBDataSet5;
        private System.Windows.Forms.BindingSource rUNWAYBindingSource;
        private AirportDBDataSet5TableAdapters.RUNWAYTableAdapter rUNWAYTableAdapter;
    }
}