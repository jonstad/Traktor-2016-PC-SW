using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;
using LBSoft.IndustrialCtrls.Base;
using LBSoft.IndustrialCtrls.Meters;
//using LBSoft.IndustrialCtrls.Base.LBIndustrialCtrlBase;
//using LBSoft.IndustrialCtrls.Base.LBRendererBase;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Stream stm;
        public TcpClient tcpclnt;
        public bool connectedToNetwork = false;


        double[] wheelarray = new double[20];
        double[] pumparray = new double[20];
        double[] temparrayoil = new double[20];
        int wheelcounter = 0;
        int pumpcounter = 0;
        int tempcounter = 0;
        private Stopwatch sw;
       
        private History CurrentHistory;
        
        int buffersize = 30;
        private byte[] bb = new byte[30];

        private Settings.ColorTemplate colortemplate = new Settings.ColorTemplate();

        public Form1()
        {
            InitializeComponent();
            traktorG1.drawTraktor();


            myButton1.Update(0);
            defaultView();
            CurrentHistory = new History();
            CurrentHistory.InitHistory(1024, 0);
            pictureBox1 = CurrentHistory.SetUpHistoryBox(pictureBox1, Color.Black);
            pictureBox2 = CurrentHistory.SetUpHistoryBox(pictureBox2, Color.Black);
            // IP må enten settes fast eller så må man bruke Lantronix deviceInstaller for å finne den.
            textBox3.Text = "192.168.0.199";
            //textBox3.Text = "192.168.0.130";
            try
            {
                colortemplate = FileUtils.readColorsTemplate("FOO.txt");       
            }
            catch (Exception)
            {
                MessageBox.Show("klarte ikke finne template");
            }
            
            changeColors(colortemplate.buttonOffBack);
            trackBar1.Maximum = colortemplate.MaxOutValue;

            // Set treshold for Pump
           
            float step = colortemplate.yellowValuePump / 10;
            float step2 = (colortemplate.redValuePump - colortemplate.yellowValuePump) / 10;
            for (int i = 0; i <= step; i++)
            {
                float newcol = 255f / step * i;
                SetThresholds((int)(step * i), (int)(step * (i + 2)), Color.FromArgb(255, (int)newcol, 255 , 0), 0);
                int foo = 0;
            }

            for (int i = 0; i < step2; i++)
            {
                float newgreen = 255 - (255 / step2* i) ;
                SetThresholds(colortemplate.yellowValuePump + (int)(step2 * i), colortemplate.yellowValuePump + (int)(step2 * (i + 1)), Color.FromArgb(255, 255 , (int)newgreen, 0), 0);
            }
            //for (int i = 0; i < 10; i++)
            //{
            //    SetThresholds(colortemplate.redValuePump, (int)lbAnalogMeter1.MaxValue, Color.Red, 0);
            //}
           // SetThresholds(0, colortemplate.yellowValuePump, Color.Green, 0);
            //SetThresholds(colortemplate.yellowValuePump, colortemplate.redValuePump, Color.Yellow,0);
            //SetThresholds(colortemplate.redValuePump, (int)lbAnalogMeter1.MaxValue, Color.Red,0);

            // Set treshold for Wheel
            SetThresholds(0, colortemplate.yellowValueWheel, Color.Green,1);
            SetThresholds(colortemplate.yellowValueWheel, colortemplate.redValueWheel, Color.Yellow, 1);
            SetThresholds(colortemplate.redValueWheel, (int)lbAnalogMeter2.MaxValue, Color.Red, 1);
       
           
            //Initialise StopWatch
            sw = new Stopwatch();
        }

        public void SetThresholds(int start,int stop, Color col, int nr)
        {
            if (nr==0)
            {
                LBSoft.IndustrialCtrls.Meters.LBMeterThreshold threshold = new LBSoft.IndustrialCtrls.Meters.LBMeterThreshold();
                threshold.Color = col;
                threshold.StartValue = start;
                threshold.EndValue = stop;
                this.lbAnalogMeter1.Thresholds.Add(threshold);    
            }
            if (nr == 1)
            {
                LBSoft.IndustrialCtrls.Meters.LBMeterThreshold threshold = new LBSoft.IndustrialCtrls.Meters.LBMeterThreshold();
                threshold.Color = col;
                threshold.StartValue = start;
                threshold.EndValue = stop;
                this.lbAnalogMeter2.Thresholds.Add(threshold);
            }
        }
        private void changeColors(Color bcolor)
        {
           Image img = imageList1.Images[2];
            //this.BackgroundImage = img;
            /* Searches trough the control but only to layers need to iterate??? 
             Bytter farge på alle knapper, dette bytter også på knappene for å ta inn og ut hjul!
             */
            foreach (Control ctrl in this.Controls)
            {
              //  RetCtrls.Add(ctrl);
                if (ctrl.GetType() == typeof(Button))
                {
                    ctrl.BackColor = bcolor;
                }
                else if (ctrl.GetType() == typeof(GroupBox))
                {
                    foreach (Control ctrl_sub in ctrl.Controls)
                    {
                   //     SubRetCtrls.Add(ctrl_sub);
                        if (ctrl_sub.GetType() == typeof(Button))
                        {
                            ctrl_sub.BackColor = bcolor;
                        }
                        else if (ctrl_sub.GetType() == typeof(GroupBox))
                        {
                          
                        }
                    }
                }
            }
        }
        private void sendMessage(string msg)
        {
            if (connectedToNetwork)
            {
                timer1.Enabled = false;
                ASCIIEncoding asen = new ASCIIEncoding();
                String str = msg;
                byte[] ba = asen.GetBytes(str);
                stm.Write(ba, 0, ba.Length);
                timer1.Enabled = true;
            }
        }

        private void CheckAutorelease()
        {
            if (checkBox1.Checked)
            {
                checkBox1.BackColor = Color.Red;
                checkBox1.Text = "Activated";
            }
            else
            {
                checkBox1.BackColor = Color.Green;
                checkBox1.Text = "Disabled";
            }
            if (checkBox1.Checked == true &&lbAnalogMeter1.Value > (double)numericUpDown1.Value )
            {
                    sendMessage("I");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
 
            CheckAutorelease();
            ASCIIEncoding asen = new ASCIIEncoding();
            String CommandMsg = GetTractorStatusExtended;
            tcpclnt = new TcpClient();
            tcpclnt.ReceiveTimeout=100;
            if (connectToolStripMenuItem.Checked)
            {
                //Time since last package
                textBox2.Text = "Last coms: " + sw.ElapsedMilliseconds.ToString();
                try
                {
                    //if not connected
                    if (connectedToNetwork == false)
                    {
                        connectedToNetwork = true;
                        //tcpclnt = new TcpClient();
                        string IP = textBox3.Text;
                        int port = Convert.ToInt16(textBox4.Text);
                        tcpclnt.Connect(IP, port); // use the ipaddress as in the server program
                        // Stream stm = tcpclnt.GetStream();      
                        stm = tcpclnt.GetStream();
                    }
                    else
                    {
                        stm.Flush();
                        byte[] ba = asen.GetBytes(CommandMsg);
                        stm.Write(ba, 0, ba.Length);
                        //int buffersize = 30;
                        //byte[] bb = new byte[buffersize];
                        Array.Clear(bb, 0, bb.Length);

                        //  Reduser denne for å se om det hjelper, kanksje jeg leser for mange     
                        int k = stm.Read(bb, 0, buffersize);
                        if (CommandMsg == GetTractorStatusExtended)
                        {
                            ReturnExtended(bb);
                        }
                        
                    }
                }
                catch (Exception)
                {
                    tcpclnt.Close();
                    stm.Dispose();
                    connectedToNetwork = false;
                    connectToolStripMenuItem.Checked = false;
                   MessageBox.Show("Cant connect to ethernet module. Please try again");

                }
            } 
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (connectedToNetwork==true)
            {
                ASCIIEncoding asen = new ASCIIEncoding();
                String str = "c";
                byte[] ba = asen.GetBytes(str);
                stm.Write(ba, 0, ba.Length);
                byte[] bb = new byte[500];
                int k = stm.Read(bb, 0, 500);
                textBox1.Clear();
                for (int i = 0; i < k; i++)
                    textBox1.AppendText(Convert.ToChar(bb[i]).ToString());
                // tcpclnt.Close(); 
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (connectedToNetwork==true)
            {
                //TcpClient tcpclnt = new TcpClient();
                //string IP = textBox3.Text;
                //int port = Convert.ToInt16(textBox4.Text);
                //tcpclnt.Connect(IP, port); // use the ipaddress as in the server program
                //Stream stm = tcpclnt.GetStream();

                ASCIIEncoding asen = new ASCIIEncoding();
                String str = "v";
                byte[] ba = asen.GetBytes(str);
                stm.Write(ba, 0, ba.Length);
                byte[] bb = new byte[500];
                int k = stm.Read(bb, 0, 500);
                textBox1.Clear();
                for (int i = 0; i < k; i++)
                    textBox1.AppendText(Convert.ToChar(bb[i]).ToString());
                // tcpclnt.Close(); 
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
        //    traktorG1.SetDirection("FWD");
            sendMessage("k");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            sendMessage("u");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            sendMessage("t");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
         //   traktorG1.SetDirection("RWD");
            sendMessage("j");
        }
        
    
        private void button2_Click(object sender, EventArgs e){ 
            sendMessage("i");     /*    Toggle high/low speed    */
        }
   
        private void checkBox2_Click(object sender, EventArgs e)
        {
            sendMessage("w"); //Anti Spin
        }
        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create reader & open file
            try
            {
            StreamReader tr = new StreamReader("Changelog.txt");

            // read a line of text
            string msg = tr.ReadToEnd();

            // close the stream
            tr.Close();
            MessageBox.Show(msg);
            }
            catch (Exception)
            {
                ; ;
            }

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //If enter key pressed
            if (e.KeyChar== (char)13)
            {
                //Control analog output from AVR
                string numString = textBox5.Text; ; //"1287543.0" will return false for a long 
                long number1 = 0;
                bool canConvert = long.TryParse(numString, out number1);
                if (canConvert == true) //is it only numbers?
                {
                    if (number1<=trackBar1.Maximum)//valid number?
                    {
                        Int32 frombox = Convert.ToInt32(textBox5.Text);
                        if (frombox >= trackBar1.Minimum & frombox <= trackBar1.Maximum)
                        {
                            string msg = frombox.ToString("000");
                            sendMessage("a" + msg);
                            trackBar1.Value = frombox;
                        }
                    }
                }
                else
                {
                    int foo = 0;
                }
            }
        }
        private void textBox5_Enter(object sender, EventArgs e)
        {


        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ColorForm cf = new ColorForm();
           cf.ShowDialog(); // Show the form Modal so it has to be completed before moving forward
           // cf.Show();
           colortemplate = FileUtils.readColorsTemplate("FOO.txt");
           changeColors(colortemplate.buttonOffBack);

           try
           {
               colortemplate = FileUtils.readColorsTemplate("FOO.txt");
           }
           catch (Exception)
           {
               MessageBox.Show("klarte ikke finne template");
           }

           changeColors(colortemplate.buttonOffBack);
           trackBar1.Maximum = colortemplate.MaxOutValue;

           // Set treshold for Pump
           SetThresholds(0, colortemplate.yellowValuePump, Color.Green, 0);
           SetThresholds(colortemplate.yellowValuePump, colortemplate.redValuePump, Color.Yellow, 0);
           SetThresholds(colortemplate.redValuePump, 255, Color.Red, 0);

           // Set treshold for Wheel
           SetThresholds(0, colortemplate.yellowValueWheel, Color.Green, 1);
           SetThresholds(colortemplate.yellowValueWheel, colortemplate.redValueWheel, Color.Yellow, 1);
           SetThresholds(colortemplate.redValueWheel, 255, Color.Red, 1);




        }



        private void buttonsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Reverse
            if (e.Control && e.KeyCode == Keys.R)
            {
                button3_Click( sender,  e);
            }
            //Forward
            if (e.Control && e.KeyCode == Keys.F)
            {
                button6_Click(sender, e);
            }
            //High/low speed
            if (e.Control && e.KeyCode == Keys.H)
            {
                button2_Click(sender, e);
            }
            //Collapse front
            if (e.Control && e.KeyCode == Keys.Q)
            {
                button7_Click(sender, e);
            }
            //Collapse rear
            if (e.Control && e.KeyCode == Keys.A)
            {
                button8_Click(sender, e);
            }
        }
        private void defaultView()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            this.Size = new Size(760, 700);
        }

        private void historyView()
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            this.Size = new Size(1300, 700);
        }
        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defaultView();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            historyView();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //Control analog output from AVR
            string msg = trackBar1.Value.ToString("000");
            sendMessage("a" + msg);
            textBox5.Text = msg.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < trackBar1.Maximum - 1)
            {
                //Control analog output from AVR
                trackBar1.Value = trackBar1.Value + 1;
                string msg = trackBar1.Value.ToString("000");
                sendMessage("a" + msg);
                textBox5.Text = msg.ToString();
            }
            else
            {
                //Control analog output from AVR
                trackBar1.Value = trackBar1.Maximum;
                string msg = trackBar1.Value.ToString("000");
                sendMessage("a" + msg);
                textBox5.Text = msg.ToString();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (trackBar1.Value < trackBar1.Maximum - 5)
            {
                //Control analog output from AVR
                trackBar1.Value = trackBar1.Value + 5;
                string msg = trackBar1.Value.ToString("000");
                sendMessage("a" + msg);
                textBox5.Text = msg.ToString();
            }
            else
            {
                //Control analog output from AVR
                trackBar1.Value = trackBar1.Maximum;
                string msg = trackBar1.Value.ToString("000");
                sendMessage("a" + msg);
                textBox5.Text = msg.ToString();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (trackBar1.Value<trackBar1.Maximum-10)
            {
                //Control analog output from AVR
                trackBar1.Value = trackBar1.Value + 10;
                string msg = trackBar1.Value.ToString("000");
                sendMessage("a" + msg);
                textBox5.Text = msg.ToString();
            }
            else
            {
                //Control analog output from AVR
                trackBar1.Value = trackBar1.Maximum;
                string msg = trackBar1.Value.ToString("000");
                sendMessage("a" + msg);
                textBox5.Text = msg.ToString();
            }

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (trackBar1.Value > 0)
            {
                //Control analog output from AVR
                trackBar1.Value = trackBar1.Value - 1;
                string msg = trackBar1.Value.ToString("000");
                sendMessage("a" + msg);
                textBox5.Text = msg.ToString();
            }

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (trackBar1.Value > 5)
            {
                //Control analog output from AVR
                trackBar1.Value = trackBar1.Value - 5;
                string msg = trackBar1.Value.ToString("000");
                sendMessage("a" + msg);
                textBox5.Text = msg.ToString();
            }
            else
            {
                //Control analog output from AVR
                trackBar1.Value = 0;
                string msg = trackBar1.Value.ToString("000");
                sendMessage("a" + msg);
                textBox5.Text = msg.ToString();
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (trackBar1.Value > 10)
            {
                //Control analog output from AVR
                trackBar1.Value = trackBar1.Value - 10;
                string msg = trackBar1.Value.ToString("000");
                sendMessage("a" + msg);
                textBox5.Text = msg.ToString();
            }
            else
            {
                //Control analog output from AVR
                trackBar1.Value = 0;
                string msg = trackBar1.Value.ToString("000");
                sendMessage("a" + msg);
                textBox5.Text = msg.ToString();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            /*
                "A1:" + lbAnalogMeter1.Value.ToString("0.0") + ";" +
                "A2:" + lbAnalogMeter2.Value.ToString("0.0") + ";" +
                "D1:" + lbDigitalMeter1.Value.ToString("0.0") + ";" +
                "D2:" + lbDigitalMeter2.Value.ToString("0.0") + ";" +
                "H/L Speed:" + bb[StatusPort0].ToString() + ";" +
                "Reverse:" + bb[StatusPort1].ToString() + ";" +
                "Forward:" + bb[StatusPort2].ToString() + ";" +
                "Front i/o:" + bb[StatusPort3].ToString() + ";" +
                "Rear i/o:" + bb[StatusPortRear].ToString() + ";" +
                "AntiSpin:" + bb[StatusPortAntiSpin].ToString() + ";" +
             */
            try
            {
                string line =
                            lbAnalogMeter1.Value.ToString("0.0") + ";" +
                            lbAnalogMeter2.Value.ToString("0.0") + ";" +
                            lbDigitalMeter1.Value.ToString("0.0") + ";" +
                            lbDigitalMeter2.Value.ToString("0.0") + ";" +
                            bb[StatusPort0].ToString() + ";" +
                            bb[StatusPort1].ToString() + ";" +
                            bb[StatusPort2].ToString() + ";" +
                            bb[StatusPort3].ToString() + ";" +
                            bb[StatusPortRear].ToString() + ";" +
                            bb[StatusPortAntiSpin].ToString() + ";" +                                       
                            DateTime.Now.ToString() +
                            Environment.NewLine;
                string filename = "LogFile" + DateTime.Now.ToShortDateString()+".txt";
                System.IO.File.AppendAllText(filename, line);
            }
            catch (Exception)
            {
                ; ;
            }
        }

        private void myButton1_Load(object sender, EventArgs e)
        {
        }

        private void myButton1_MouseClick(object sender, MouseEventArgs e)
        {
            Point LocalMousePosition = myButton1.PointToClient(Cursor.Position);
            int val = LocalMousePosition.Y;
           
            UpdateTrackbar( myButton1.GetButtonValue(val));
        }
        private void UpdateTrackbar(int val)
        {
          if(val<0){
              if (trackBar1.Value + val <= trackBar1.Minimum)
              {
                  trackBar1.Value = 0;
              }
              else
              {
                  trackBar1.Value = trackBar1.Value + val;
              }
          }
          if(val>0){
              if (trackBar1.Value + val > trackBar1.Maximum)
              {
                  trackBar1.Value = trackBar1.Maximum;
              }
              else
              {
                  trackBar1.Value = trackBar1.Value + val;
              }
          }
            textBox5.Text = trackBar1.Value.ToString("000");

            //Control analog output from AVR
            string msg = trackBar1.Value.ToString("000");
            sendMessage("a" + msg);
            textBox5.Text = msg.ToString();
        }

        private void traktorG1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
