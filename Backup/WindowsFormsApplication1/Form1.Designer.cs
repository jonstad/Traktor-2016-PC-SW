namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.speedButton = new System.Windows.Forms.Button();
            this.reverseButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardButton = new System.Windows.Forms.Button();
            this.cRearButton = new System.Windows.Forms.Button();
            this.cFrontButton = new System.Windows.Forms.Button();
            this.lbDigitalMeter1 = new LBSoft.IndustrialCtrls.Meters.LBDigitalMeter();
            this.lbAnalogMeter1 = new LBSoft.IndustrialCtrls.Meters.LBAnalogMeter();
            this.lbAnalogMeter2 = new LBSoft.IndustrialCtrls.Meters.LBAnalogMeter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDigitalMeter2 = new LBSoft.IndustrialCtrls.Meters.LBDigitalMeter();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.traktorG1 = new WindowsFormsApplication1.TraktorG();
            this.myButton1 = new WindowsFormsApplication1.MyButton();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(989, 355);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 95);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.WordWrap = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // speedButton
            // 
            this.speedButton.Location = new System.Drawing.Point(16, 50);
            this.speedButton.Name = "speedButton";
            this.speedButton.Size = new System.Drawing.Size(109, 42);
            this.speedButton.TabIndex = 3;
            this.speedButton.TabStop = false;
            this.speedButton.Text = "&High/Low";
            this.speedButton.UseVisualStyleBackColor = true;
            this.speedButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // reverseButton
            // 
            this.reverseButton.Location = new System.Drawing.Point(148, 50);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(109, 42);
            this.reverseButton.TabIndex = 4;
            this.reverseButton.TabStop = false;
            this.reverseButton.Text = "Reverse";
            this.reverseButton.UseVisualStyleBackColor = true;
            this.reverseButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(649, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(93, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "192.168.0.130";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(649, 77);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(93, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "10001";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.networkToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1260, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.networkToolStripMenuItem.Text = "Network";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.CheckOnClick = true;
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.versionToolStripMenuItem.Text = "Changelog";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonsToolStripMenuItem,
            this.groupBoxesToolStripMenuItem,
            this.formToolStripMenuItem,
            this.digitalToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // buttonsToolStripMenuItem
            // 
            this.buttonsToolStripMenuItem.Name = "buttonsToolStripMenuItem";
            this.buttonsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.buttonsToolStripMenuItem.Text = "Buttons";
            this.buttonsToolStripMenuItem.Click += new System.EventHandler(this.buttonsToolStripMenuItem_Click);
            // 
            // groupBoxesToolStripMenuItem
            // 
            this.groupBoxesToolStripMenuItem.Name = "groupBoxesToolStripMenuItem";
            this.groupBoxesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.groupBoxesToolStripMenuItem.Text = "Group boxes";
            this.groupBoxesToolStripMenuItem.Click += new System.EventHandler(this.groupBoxesToolStripMenuItem_Click);
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.formToolStripMenuItem.Text = "Form";
            // 
            // digitalToolStripMenuItem
            // 
            this.digitalToolStripMenuItem.Name = "digitalToolStripMenuItem";
            this.digitalToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.digitalToolStripMenuItem.Text = "Digital";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(273, 50);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(109, 42);
            this.forwardButton.TabIndex = 11;
            this.forwardButton.TabStop = false;
            this.forwardButton.Text = "Forward";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // cRearButton
            // 
            this.cRearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cRearButton.Location = new System.Drawing.Point(6, 48);
            this.cRearButton.Name = "cRearButton";
            this.cRearButton.Size = new System.Drawing.Size(96, 44);
            this.cRearButton.TabIndex = 10;
            this.cRearButton.TabStop = false;
            this.cRearButton.Text = "Rear Wheel";
            this.cRearButton.UseVisualStyleBackColor = true;
            this.cRearButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // cFrontButton
            // 
            this.cFrontButton.Location = new System.Drawing.Point(117, 48);
            this.cFrontButton.Name = "cFrontButton";
            this.cFrontButton.Size = new System.Drawing.Size(109, 44);
            this.cFrontButton.TabIndex = 12;
            this.cFrontButton.TabStop = false;
            this.cFrontButton.Text = "Front Wheel";
            this.cFrontButton.UseVisualStyleBackColor = true;
            this.cFrontButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // lbDigitalMeter1
            // 
            this.lbDigitalMeter1.BackColor = System.Drawing.Color.Black;
            this.lbDigitalMeter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDigitalMeter1.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbDigitalMeter1.Format = "000";
            this.lbDigitalMeter1.Location = new System.Drawing.Point(6, 48);
            this.lbDigitalMeter1.Name = "lbDigitalMeter1";
            this.lbDigitalMeter1.Renderer = null;
            this.lbDigitalMeter1.Signed = false;
            this.lbDigitalMeter1.Size = new System.Drawing.Size(139, 47);
            this.lbDigitalMeter1.TabIndex = 13;
            this.lbDigitalMeter1.TabStop = false;
            this.lbDigitalMeter1.Value = 0;
            // 
            // lbAnalogMeter1
            // 
            this.lbAnalogMeter1.BackColor = System.Drawing.Color.Transparent;
            this.lbAnalogMeter1.BodyColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbAnalogMeter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnalogMeter1.Location = new System.Drawing.Point(50, 19);
            this.lbAnalogMeter1.MaxValue = 200;
            this.lbAnalogMeter1.MeterStyle = LBSoft.IndustrialCtrls.Meters.LBAnalogMeter.AnalogMeterStyle.Circular;
            this.lbAnalogMeter1.MinValue = 0;
            this.lbAnalogMeter1.Name = "lbAnalogMeter1";
            this.lbAnalogMeter1.NeedleColor = System.Drawing.Color.Lime;
            this.lbAnalogMeter1.Renderer = null;
            this.lbAnalogMeter1.ScaleColor = System.Drawing.Color.White;
            this.lbAnalogMeter1.ScaleDivisions = 11;
            this.lbAnalogMeter1.ScaleSubDivisions = 3;
            this.lbAnalogMeter1.Size = new System.Drawing.Size(246, 237);
            this.lbAnalogMeter1.TabIndex = 14;
            this.lbAnalogMeter1.TabStop = false;
            this.lbAnalogMeter1.Value = 0;
            this.lbAnalogMeter1.ViewGlass = true;
            // 
            // lbAnalogMeter2
            // 
            this.lbAnalogMeter2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lbAnalogMeter2.BackColor = System.Drawing.Color.Transparent;
            this.lbAnalogMeter2.BodyColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAnalogMeter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnalogMeter2.Location = new System.Drawing.Point(6, 27);
            this.lbAnalogMeter2.MaxValue = 250;
            this.lbAnalogMeter2.MeterStyle = LBSoft.IndustrialCtrls.Meters.LBAnalogMeter.AnalogMeterStyle.Circular;
            this.lbAnalogMeter2.MinValue = 0;
            this.lbAnalogMeter2.Name = "lbAnalogMeter2";
            this.lbAnalogMeter2.NeedleColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbAnalogMeter2.Renderer = null;
            this.lbAnalogMeter2.ScaleColor = System.Drawing.Color.White;
            this.lbAnalogMeter2.ScaleDivisions = 11;
            this.lbAnalogMeter2.ScaleSubDivisions = 4;
            this.lbAnalogMeter2.Size = new System.Drawing.Size(205, 229);
            this.lbAnalogMeter2.TabIndex = 15;
            this.lbAnalogMeter2.TabStop = false;
            this.lbAnalogMeter2.Value = 0;
            this.lbAnalogMeter2.ViewGlass = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pump ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Wheel";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Speed mode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Reverse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(272, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Forward";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cRearButton);
            this.groupBox1.Controls.Add(this.cFrontButton);
            this.groupBox1.Location = new System.Drawing.Point(400, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 115);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Collapse Wheels";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(153, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Front";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Rear";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbDigitalMeter2);
            this.groupBox2.Controls.Add(this.lbDigitalMeter1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 450);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 95);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temperature";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(196, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Temperature Hydraulic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Temperature on PCB";
            // 
            // lbDigitalMeter2
            // 
            this.lbDigitalMeter2.BackColor = System.Drawing.Color.Transparent;
            this.lbDigitalMeter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDigitalMeter2.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbDigitalMeter2.Format = "000";
            this.lbDigitalMeter2.Location = new System.Drawing.Point(200, 48);
            this.lbDigitalMeter2.Name = "lbDigitalMeter2";
            this.lbDigitalMeter2.Renderer = null;
            this.lbDigitalMeter2.Signed = false;
            this.lbDigitalMeter2.Size = new System.Drawing.Size(137, 47);
            this.lbDigitalMeter2.TabIndex = 14;
            this.lbDigitalMeter2.TabStop = false;
            this.lbDigitalMeter2.Value = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(215, 19);
            this.trackBar1.Maximum = 35;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(42, 231);
            this.trackBar1.TabIndex = 26;
            this.trackBar1.TickFrequency = 25;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.speedButton);
            this.groupBox3.Controls.Add(this.reverseButton);
            this.groupBox3.Controls.Add(this.forwardButton);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(6, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 115);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Drive";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(18, 98);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 17);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.Text = "Anti Spin";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.myButton1);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.trackBar1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lbAnalogMeter2);
            this.groupBox4.Location = new System.Drawing.Point(6, 148);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(377, 296);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wheel pressure control";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(251, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Will automatically cut at 100 bar if Anti-Spin enabled";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(263, 253);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(74, 32);
            this.textBox5.TabIndex = 27;
            this.textBox5.TabStop = false;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            this.textBox5.Enter += new System.EventHandler(this.textBox5_Enter);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 613);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 25);
            this.button4.TabIndex = 34;
            this.button4.Text = "-10";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 582);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 25);
            this.button5.TabIndex = 33;
            this.button5.Text = "-5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 551);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 25);
            this.button6.TabIndex = 32;
            this.button6.Text = "-1";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(75, 551);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 25);
            this.button3.TabIndex = 31;
            this.button3.Text = "+10";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(75, 582);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 25);
            this.button2.TabIndex = 30;
            this.button2.Text = "+5";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 25);
            this.button1.TabIndex = 29;
            this.button1.Text = "+1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Controls.Add(this.numericUpDown1);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.lbAnalogMeter1);
            this.groupBox5.Location = new System.Drawing.Point(389, 148);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(353, 296);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pump Pressure";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(67, 259);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 23);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "Auto release";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(168, 262);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.TabStop = false;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "white-snow-background.jpg");
            this.imageList1.Images.SetKeyName(1, "Copy of white-snow-background.jpg");
            this.imageList1.Images.SetKeyName(2, "1234-snow-flake-msn-background.jpg");
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(649, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 20);
            this.textBox2.TabIndex = 33;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Siste pakke";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(748, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 151);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(748, 185);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 164);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // traktorG1
            // 
            this.traktorG1.BackColor = System.Drawing.SystemColors.Control;
            this.traktorG1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("traktorG1.BackgroundImage")));
            this.traktorG1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.traktorG1.Location = new System.Drawing.Point(389, 450);
            this.traktorG1.Name = "traktorG1";
            this.traktorG1.Size = new System.Drawing.Size(353, 197);
            this.traktorG1.TabIndex = 36;
            this.traktorG1.Load += new System.EventHandler(this.traktorG1_Load);
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.SystemColors.Control;
            this.myButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myButton1.BackgroundImage")));
            this.myButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myButton1.Location = new System.Drawing.Point(263, 27);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(74, 215);
            this.myButton1.TabIndex = 25;
            this.myButton1.Load += new System.EventHandler(this.myButton1_Load);
            this.myButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myButton1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1260, 739);
            this.Controls.Add(this.traktorG1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Traktor 2012 debug 0.10";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button speedButton;
        private System.Windows.Forms.Button reverseButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button cRearButton;
        private System.Windows.Forms.Button cFrontButton;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private LBSoft.IndustrialCtrls.Meters.LBDigitalMeter lbDigitalMeter1;
        private LBSoft.IndustrialCtrls.Meters.LBAnalogMeter lbAnalogMeter1;
        private LBSoft.IndustrialCtrls.Meters.LBAnalogMeter lbAnalogMeter2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private LBSoft.IndustrialCtrls.Meters.LBDigitalMeter lbDigitalMeter2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem buttonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupBoxesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private MyButton myButton1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private TraktorG traktorG1;
    }
}

