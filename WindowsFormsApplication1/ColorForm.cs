using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ColorForm : Form
    {
        private  Settings.ColorSettings cs = new Settings.ColorSettings();
        private Settings.ColorTemplate ct = new Settings.ColorTemplate();
        public ColorForm()
        {
            InitializeComponent();
           
            cs.buttonColorActive = SystemColors.Control;
            cs.buttonColorNotActive = SystemColors.Control;
            //1: read file
            //2: Change colors
            //3: Get user input
            //4: Save file:
            


            /*  1: Read old file*/
            try
            {
                //ct = FileUtils.readColorsTemplate("FOO.txt");
                //button1.BackColor = ct.buttonOnBack;
                //button1.ForeColor = ct.buttonOnText;
                //button2.BackColor = ct.buttonOffBack ;
                //button2.ForeColor = ct.buttonOffText  ;
                //lbDigitalMeter1.BackColor = ct.digitalColorBack  ;
                //lbDigitalMeter1.ForeColor = ct.digitalColorText ;
                //lbDigitalMeter2.BackColor = ct.digitalColorAlarmBack  ;
                //lbDigitalMeter2.ForeColor = ct.digitalColorAlarmText  ;
                //Load color template
                ct = FileUtils.readColorsTemplate("FOO.txt");
                button1.BackColor = ct.buttonOnBack;
                button1.ForeColor = ct.buttonOnText;
                button2.BackColor = ct.buttonOffBack;
                button2.ForeColor = ct.buttonOffText;
                lbDigitalMeter1.BackColor = ct.digitalColorBack;
                lbDigitalMeter1.ForeColor = ct.digitalColorText;
                lbDigitalMeter2.BackColor = ct.digitalColorAlarmBack;
                lbDigitalMeter2.ForeColor = ct.digitalColorAlarmText;
                numericUpDown3.Value = ct.yellowValuePump;
                numericUpDown4.Value = ct.redValuePump;
                numericUpDown5.Value = ct.yellowValueWheel;
                numericUpDown6.Value = ct.redValueWheel;
                numericUpDown7.Value = ct.MaxOutValue;
            }
            catch (Exception)
            {
                
                MessageBox.Show("klarte ikke finne template");
            }
            //cs = FileUtils.readColors("FOO.txt");

            /* 2: Change colors*/

            /* 3: Get user input*/

            /* 4: Save file*/


        }
        

        private void bSaveTemplate_Click(object sender, EventArgs e)
        {
            // Save current color template
            Settings.ColorTemplate CT = new Settings.ColorTemplate();
            CT.buttonOnBack = button1.BackColor;
            CT.buttonOnText = button1.ForeColor;            
            CT.buttonOffBack = button2.BackColor;
            CT.buttonOffText = button2.ForeColor;

            CT.digitalColorBack = lbDigitalMeter1.BackColor;
            CT.digitalColorText = lbDigitalMeter1.ForeColor;
            CT.digitalColorAlarmBack = lbDigitalMeter2.BackColor;
            CT.digitalColorAlarmText = lbDigitalMeter2.ForeColor;
            CT.yellowValuePump =(int) numericUpDown3.Value;
            CT.redValuePump = (int)numericUpDown4.Value;
            CT.yellowValueWheel = (int)numericUpDown5.Value;
            CT.redValueWheel = (int)numericUpDown6.Value;
            CT.MaxOutValue =(int) numericUpDown7.Value;

//            Color[] myColorTemplate = { button1.BackColor, button1.ForeColor, button2.BackColor, button2.ForeColor };
            FileUtils.writeColorSetting("FOO.txt", CT);

        }

        private void bLoadTemplate_Click(object sender, EventArgs e)
        {
            //Load color template
            ct = FileUtils.readColorsTemplate("FOO.txt");
            button1.BackColor = ct.buttonOnBack;
            button1.ForeColor = ct.buttonOnText;
            button2.BackColor = ct.buttonOffBack ;
            button2.ForeColor = ct.buttonOffText  ;
            lbDigitalMeter1.BackColor = ct.digitalColorBack  ;
            lbDigitalMeter1.ForeColor = ct.digitalColorText ;
            lbDigitalMeter2.BackColor = ct.digitalColorAlarmBack  ;
            lbDigitalMeter2.ForeColor = ct.digitalColorAlarmText  ;
            numericUpDown3.Value=ct.yellowValuePump ;
            numericUpDown4.Value=ct.redValuePump ;
            numericUpDown5.Value=ct.yellowValueWheel ;
            numericUpDown6.Value=ct.redValueWheel ;

          numericUpDown7.Value = ct.MaxOutValue ;
        }

        private Color getColor()
        {
            ColorDialog MyDialog = new ColorDialog();
            // allow the user from selecting a custom color.
            MyDialog.AllowFullOpen = true;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            //MyDialog.Color = textBox1.ForeColor;
            Color myColor = SystemColors.Control;
            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                myColor = MyDialog.Color;
            return myColor;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            lbDigitalMeter1.BackColor = getColor();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lbDigitalMeter1.ForeColor = getColor();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            lbDigitalMeter2.ForeColor = getColor();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            lbDigitalMeter2.ForeColor = getColor();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            button1.BackColor = getColor();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            button1.ForeColor = getColor();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            button2.BackColor = getColor();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            button2.ForeColor = getColor();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            groupBox4.BackColor = getColor();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            lbAnalogMeter2.BackColor = getColor();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            lbAnalogMeter2.NeedleColor = getColor();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            lbAnalogMeter2.BodyColor = getColor();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lbAnalogMeter2.MaxValue =(double) numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            lbAnalogMeter2.MinValue = (double)numericUpDown2.Value;
        }


    }
}
