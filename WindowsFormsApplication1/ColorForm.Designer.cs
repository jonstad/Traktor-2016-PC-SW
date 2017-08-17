namespace WindowsFormsApplication1
{
    partial class ColorForm
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
            this.lbDigitalMeter1 = new LBSoft.IndustrialCtrls.Meters.LBDigitalMeter();
            this.lbDigitalMeter2 = new LBSoft.IndustrialCtrls.Meters.LBDigitalMeter();
            this.button1 = new System.Windows.Forms.Button();
            this.bSaveTemplate = new System.Windows.Forms.Button();
            this.bLoadTemplate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Digital = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.lbAnalogMeter2 = new LBSoft.IndustrialCtrls.Meters.LBAnalogMeter();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.lbAnalogMeter1 = new LBSoft.IndustrialCtrls.Meters.LBAnalogMeter();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.Digital.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDigitalMeter1
            // 
            this.lbDigitalMeter1.BackColor = System.Drawing.Color.Black;
            this.lbDigitalMeter1.ForeColor = System.Drawing.Color.Red;
            this.lbDigitalMeter1.Format = "000";
            this.lbDigitalMeter1.Location = new System.Drawing.Point(6, 28);
            this.lbDigitalMeter1.Name = "lbDigitalMeter1";
            this.lbDigitalMeter1.Renderer = null;
            this.lbDigitalMeter1.Signed = false;
            this.lbDigitalMeter1.Size = new System.Drawing.Size(140, 44);
            this.lbDigitalMeter1.TabIndex = 0;
            this.lbDigitalMeter1.Value = 100;
            // 
            // lbDigitalMeter2
            // 
            this.lbDigitalMeter2.BackColor = System.Drawing.Color.Black;
            this.lbDigitalMeter2.Format = "000";
            this.lbDigitalMeter2.Location = new System.Drawing.Point(160, 28);
            this.lbDigitalMeter2.Name = "lbDigitalMeter2";
            this.lbDigitalMeter2.Renderer = null;
            this.lbDigitalMeter2.Signed = false;
            this.lbDigitalMeter2.Size = new System.Drawing.Size(140, 44);
            this.lbDigitalMeter2.TabIndex = 1;
            this.lbDigitalMeter2.Value = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "ON";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bSaveTemplate
            // 
            this.bSaveTemplate.Location = new System.Drawing.Point(545, 632);
            this.bSaveTemplate.Name = "bSaveTemplate";
            this.bSaveTemplate.Size = new System.Drawing.Size(164, 48);
            this.bSaveTemplate.TabIndex = 4;
            this.bSaveTemplate.Text = "Save and apply";
            this.bSaveTemplate.UseVisualStyleBackColor = true;
            this.bSaveTemplate.Click += new System.EventHandler(this.bSaveTemplate_Click);
            // 
            // bLoadTemplate
            // 
            this.bLoadTemplate.Location = new System.Drawing.Point(735, 632);
            this.bLoadTemplate.Name = "bLoadTemplate";
            this.bLoadTemplate.Size = new System.Drawing.Size(114, 48);
            this.bLoadTemplate.TabIndex = 5;
            this.bLoadTemplate.Text = "Load";
            this.bLoadTemplate.UseVisualStyleBackColor = true;
            this.bLoadTemplate.Click += new System.EventHandler(this.bLoadTemplate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Back color";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Text color";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Digital
            // 
            this.Digital.Controls.Add(this.label3);
            this.Digital.Controls.Add(this.label4);
            this.Digital.Controls.Add(this.lbDigitalMeter1);
            this.Digital.Controls.Add(this.label2);
            this.Digital.Controls.Add(this.label1);
            this.Digital.Controls.Add(this.lbDigitalMeter2);
            this.Digital.Location = new System.Drawing.Point(592, 38);
            this.Digital.Name = "Digital";
            this.Digital.Size = new System.Drawing.Size(362, 136);
            this.Digital.TabIndex = 8;
            this.Digital.TabStop = false;
            this.Digital.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Text color";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Back color";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "OFF";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Text color";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Back color";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(127, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Text color";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(127, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Back color";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 136);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buttons";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.numericUpDown5);
            this.groupBox4.Controls.Add(this.numericUpDown6);
            this.groupBox4.Controls.Add(this.numericUpDown2);
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.trackBar1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.lbAnalogMeter2);
            this.groupBox4.Location = new System.Drawing.Point(18, 180);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(500, 332);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wheel pressure control";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(367, 255);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 13);
            this.label20.TabIndex = 41;
            this.label20.Text = "Red";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(370, 210);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 40;
            this.label21.Text = "Yellow";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(370, 226);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown5.TabIndex = 39;
            this.numericUpDown5.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(370, 271);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown6.TabIndex = 38;
            this.numericUpDown6.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(364, 173);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown2.TabIndex = 37;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(364, 145);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown1.TabIndex = 36;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(302, 178);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Min Value";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(302, 152);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Max value";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(297, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Text color";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(297, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Body Color";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(297, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Needle color";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(297, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Gauge Color";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(297, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Box Back ground";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 283);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(324, 42);
            this.trackBar1.TabIndex = 26;
            this.trackBar1.TickFrequency = 25;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(101, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Wheel pressure";
            // 
            // lbAnalogMeter2
            // 
            this.lbAnalogMeter2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lbAnalogMeter2.BackColor = System.Drawing.Color.Transparent;
            this.lbAnalogMeter2.BodyColor = System.Drawing.Color.Aquamarine;
            this.lbAnalogMeter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnalogMeter2.Location = new System.Drawing.Point(16, 23);
            this.lbAnalogMeter2.MaxValue = 255;
            this.lbAnalogMeter2.MeterStyle = LBSoft.IndustrialCtrls.Meters.LBAnalogMeter.AnalogMeterStyle.Circular;
            this.lbAnalogMeter2.MinValue = 0;
            this.lbAnalogMeter2.Name = "lbAnalogMeter2";
            this.lbAnalogMeter2.NeedleColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAnalogMeter2.Renderer = null;
            this.lbAnalogMeter2.ScaleColor = System.Drawing.Color.White;
            this.lbAnalogMeter2.ScaleDivisions = 10;
            this.lbAnalogMeter2.ScaleSubDivisions = 5;
            this.lbAnalogMeter2.Size = new System.Drawing.Size(275, 254);
            this.lbAnalogMeter2.TabIndex = 15;
            this.lbAnalogMeter2.Value = 0;
            this.lbAnalogMeter2.ViewGlass = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.numericUpDown4);
            this.groupBox5.Controls.Add(this.numericUpDown3);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.lbAnalogMeter1);
            this.groupBox5.Location = new System.Drawing.Point(586, 180);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(368, 332);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pump Pressure";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(284, 110);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 36;
            this.label19.Text = "Red";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(287, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Yellow";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(287, 123);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown4.TabIndex = 18;
            this.numericUpDown4.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(287, 81);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown3.TabIndex = 17;
            this.numericUpDown3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Pump pressure";
            // 
            // lbAnalogMeter1
            // 
            this.lbAnalogMeter1.BackColor = System.Drawing.Color.Transparent;
            this.lbAnalogMeter1.BodyColor = System.Drawing.Color.DeepSkyBlue;
            this.lbAnalogMeter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnalogMeter1.Location = new System.Drawing.Point(6, 23);
            this.lbAnalogMeter1.MaxValue = 255;
            this.lbAnalogMeter1.MeterStyle = LBSoft.IndustrialCtrls.Meters.LBAnalogMeter.AnalogMeterStyle.Circular;
            this.lbAnalogMeter1.MinValue = 0;
            this.lbAnalogMeter1.Name = "lbAnalogMeter1";
            this.lbAnalogMeter1.NeedleColor = System.Drawing.Color.Lime;
            this.lbAnalogMeter1.Renderer = null;
            this.lbAnalogMeter1.ScaleColor = System.Drawing.Color.White;
            this.lbAnalogMeter1.ScaleDivisions = 10;
            this.lbAnalogMeter1.ScaleSubDivisions = 5;
            this.lbAnalogMeter1.Size = new System.Drawing.Size(275, 254);
            this.lbAnalogMeter1.TabIndex = 14;
            this.lbAnalogMeter1.Value = 0;
            this.lbAnalogMeter1.ViewGlass = true;
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(129, 538);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown7.TabIndex = 40;
            this.numericUpDown7.Value = new decimal(new int[] {
            36,
            0,
            0,
            0});
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 538);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 13);
            this.label22.TabIndex = 42;
            this.label22.Text = "Max output";
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 692);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.numericUpDown7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Digital);
            this.Controls.Add(this.bLoadTemplate);
            this.Controls.Add(this.bSaveTemplate);
            this.Name = "ColorForm";
            this.Text = "ColorForm";
            this.Digital.ResumeLayout(false);
            this.Digital.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LBSoft.IndustrialCtrls.Meters.LBDigitalMeter lbDigitalMeter1;
        private LBSoft.IndustrialCtrls.Meters.LBDigitalMeter lbDigitalMeter2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bSaveTemplate;
        private System.Windows.Forms.Button bLoadTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Digital;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label9;
        private LBSoft.IndustrialCtrls.Meters.LBAnalogMeter lbAnalogMeter2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private LBSoft.IndustrialCtrls.Meters.LBAnalogMeter lbAnalogMeter1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.Label label22;
    }
}