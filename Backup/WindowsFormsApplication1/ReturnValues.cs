using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public void ReturnExtended(byte[] bb)
        {
            textBox1.Clear();
            //reset stopwatch when receiving package
            sw.Reset();
            sw.Start();
            //textBox1.Text = System.Text.Encoding.UTF8.GetString(bb);
           // textBox1.AppendText(System.Text.Encoding.UTF8.GetString(bb) + "\r\n");
            textBox1.AppendText(
                (bb[12]-48).ToString()  + " " +
                (bb[13]-48).ToString()  + " " +
                (bb[14]-48).ToString()  + " " +
                "\r\n");
           
            //High speed or Low speed
            if (bb[StatusPortE0] == '1'-'0')
            {
                speedButton.BackColor = colortemplate.buttonOnBack;
                speedButton.Text = "High";
              //  button1.Visible = false;    //anti spin bare synling ved low speed
                checkBox2.Enabled = false;
            }
            else
            {
                speedButton.BackColor = colortemplate.buttonOffBack;
                speedButton.Text = "Low";
                //button1.Visible = true; //anti spin bare synling ved low speed
                checkBox2.Enabled = true;
            }

            if (bb[StatusPortE1] == '1' - '0')
            {
                reverseButton.BackColor = colortemplate.buttonOnBack;
                reverseButton.Text = "Reverse";
                traktorG1.SetDirection("RWD");
            }
            else
            {
                reverseButton.BackColor = colortemplate.buttonOffBack;
                reverseButton.Text = "Stopped";
                
            }
            if (bb[StatusPortE2] == '1' - '0')
            {
                forwardButton.BackColor = colortemplate.buttonOnBack;
                forwardButton.Text = "Forward";
               traktorG1.SetDirection("FWD");
            }
            else
            {
                forwardButton.BackColor = colortemplate.buttonOffBack;
                forwardButton.Text = "Stopped";
            }
            if (bb[StatusPortE1] == 0 & bb[StatusPortE2] == 0)
            {
                traktorG1.SetDirection("STOPPED");
            }
            TraktorGraphics tg = new TraktorGraphics();

            //Check if front is collapsed
            if (bb[StatusPortE3] == '0' - '0')
            {
                traktorG1.SetWheelState("Front", false);
                traktorG1.drawTraktor();
                cFrontButton.BackColor = Color.Red;
           //     cFrontButton.BackgroundImage = tg.GetWheelCollapsedImage(cFrontButton);
            }
            else
            {
                traktorG1.SetWheelState("Front", true);
                traktorG1.drawTraktor();
                cFrontButton.BackColor = Color.Green;
              //  cFrontButton.BackgroundImage = tg.GetWheelOutImage(cFrontButton);

            }
            //check if rear is collapsed
            if (bb[StatusPortRear] == '0' - '0')
            {
                traktorG1.SetWheelState("Rear", false);
                traktorG1.drawTraktor();
                cRearButton.BackColor = Color.Red;
                //cRearButton.Text = "Rear Collapsed";
                //cRearButton.Text = wheelCollapsedASCII;
           //     cRearButton.BackgroundImage = tg.GetWheelCollapsedImage(cRearButton);
            }
            else
            {
                traktorG1.SetWheelState("Rear", true);
                traktorG1.drawTraktor();
                cRearButton.BackColor = Color.Green;
           //     cRearButton.Text = "Rear Out";
            //    cRearButton.BackgroundImage = tg.GetWheelOutImage(cRearButton);
               // cRearButton.Text = wheelOutASCII;
            }
            if (bb[StatusPortE3] ==1 && bb[StatusPortRear]==1) //if both collapsed
            {
                int foo = 0;
            }
            if (bb[StatusPortAntiSpin] == '1' - '0')
            {
                checkBox2.Checked = true;
                //button1.BackColor = Color.Red;
            }
            else
            {
                checkBox2.Checked = false;
               // button1.BackColor = Color.Green;
            }

            /*lbAnalogMeter1 */
            int t1 = Convert.ToInt16(bb[18]) - '0';
            int t2 = Convert.ToInt16(bb[19]) - '0';
            int t3 = Convert.ToInt16(bb[20]) - '0';
            double voltage = t1 * 100 + t2 * 10 + t3;

            //voltage = voltage * (double)5.072 / (double)255;// Har måling i volt
            //voltage = voltage - (double)0.875; //Fjerner offsett    
            ////  lbAnalogMeter1.Value = t1 * 100 + t2 * 10 + t3;
            //double pressure = voltage * (double)70.4;
            double pressure = (voltage - 55) * 1.2;


            pumparray[pumpcounter % pumparray.Length] = pressure;
            // double pressure = voltage;
            double sum = 0;
            for (int i = 0; i < pumparray.Length; i++)
            {
                sum = sum + pumparray[i];
            }
            sum = sum / pumparray.Length;
            lbAnalogMeter1.Value = sum-5;// trekker fra 5 etter ønske fra Jon-Martin
            label1.Text = pressure.ToString("0.00");
            pumpcounter++;
            int HistorySum = (int)sum;  //value to save with history 
            
         
            /*lbAnalogMeter2 */
            t1 = Convert.ToInt16(bb[21]) - '0';
            t2 = Convert.ToInt16(bb[22]) - '0';
            t3 = Convert.ToInt16(bb[23]) - '0';
            voltage = t1 * 100 + t2 * 10 + t3;
            textBox1.AppendText("P= "+voltage.ToString() + "\r\n");
            //voltage = voltage * (double)5.072 / (double)255;// Har måling i volt
            //voltage = voltage - (double)0.875; //Fjerner offsett

            //pressure = voltage * (double)70.4;
            pressure = (voltage-50)*1.2;

            wheelarray[wheelcounter % wheelarray.Length] = pressure;
            // double pressure = voltage;
            sum = 0;
            for (int i = 0; i < wheelarray.Length; i++)
            {
                sum = sum + wheelarray[i];
            }
            sum = sum / wheelarray.Length;



            /*Update current history*/
            int cp = CurrentHistory.getCurrentPoint();
            if (cp < CurrentHistory.getWaveLength(0))
            {
                CurrentHistory.setWave(CurrentHistory.getCurrentPoint(), (int)sum+5, 0);   //Put ADC value into memory
                CurrentHistory.setWave(CurrentHistory.getCurrentPoint(), (int)HistorySum + 5, 1);   //Put ADC value into memory
                cp = cp + 1;
                CurrentHistory.setCurrentPoint(cp);
            }
            else
            {
                CurrentHistory.setCurrentPoint(0);
                CurrentHistory.setWave(CurrentHistory.getCurrentPoint(), (int)sum+5, 0);
                CurrentHistory.setWave(CurrentHistory.getCurrentPoint(), (int)HistorySum + 5, 1);
            }
            CurrentHistory.ShowHistory(CurrentHistory, pictureBox1, 3, Color.Red, 0, "Wheel");
            CurrentHistory.ShowHistory(CurrentHistory, pictureBox2, 3, Color.Blue, 1, "Pump");
            /* END Update current history*/



            wheelcounter++; 
            textBox1.AppendText("P= " + sum.ToString() + "\r\n");
            lbAnalogMeter2.Value = sum;
          
            //Drop pressure if it gets to hight
            if (sum > 110 && checkBox2.Checked==true)
            {
                int val = 0;
                string msg = val.ToString("000");
                sendMessage("a" + msg);
                //   int perentage = (100*trackBar1.Value / trackBar1.Maximum);
                textBox5.Text = msg.ToString();
                trackBar1.Value = 0;
            }
            if (sum > 100 && checkBox2.Checked == false)
            {
                checkBox2.Visible = false;
            }
            if (sum <= 100 && checkBox2.Checked == false)
            {
                checkBox2.Visible = true;
            }

            label2.Text = pressure.ToString("0.00");
            //lbAnalogMeter2.Value = t1 * 100 + t2 * 10 + t3;


            t1 = Convert.ToInt16(bb[24]) - '0';
            t2 = Convert.ToInt16(bb[25]) - '0';
            t3 = Convert.ToInt16(bb[26]) - '0';
            double var = t1 * 100 + t2 * 10 + t3;

            // Y = mx+b = 
            var = var * 5.072 / 255 * 27.98 - 22; //18.2459;
            //double voltage = var / (double)255 * (double)5;
            //double temp = (voltage - 0.5) / 0.01;
            // var = (int)temp;
            if (var > 60)
            {
                lbDigitalMeter2.ForeColor = colortemplate.digitalColorAlarmText;
                lbDigitalMeter2.BackColor = colortemplate.digitalColorAlarmBack;
            }
            else
            {
                lbDigitalMeter2.ForeColor = colortemplate.digitalColorText;
                lbDigitalMeter2.BackColor = colortemplate.digitalColorBack;
            }
            temparrayoil[tempcounter % temparrayoil.Length] = var;
            // double pressure = voltage;
             sum = 0;
             for (int i = 0; i < temparrayoil.Length; i++)
            {
                sum = sum + temparrayoil[i];
            }
            lbDigitalMeter2.Value = sum-15;


            /*Temperature on PCB*/
            t1 = Convert.ToInt16(bb[28]) - '0';
            t2 = Convert.ToInt16(bb[29]) - '0';
            var = t1 * 10 + t2;


            //voltage = (var * (double)5.072) / (double)255;
            voltage = (var * (double)5.075) / (double)255;
            double temp = (voltage - 0.5) / 0.01;
            var = (int)temp ;
            if (var > 60)
            {
                lbDigitalMeter1.ForeColor = colortemplate.digitalColorAlarmText;
                lbDigitalMeter1.BackColor = colortemplate.digitalColorAlarmBack;
            }
            else
            {
                lbDigitalMeter1.ForeColor = colortemplate.digitalColorText;
                lbDigitalMeter1.BackColor = colortemplate.digitalColorBack;

            }
            lbDigitalMeter1.Value = var;
        }


    }
}
