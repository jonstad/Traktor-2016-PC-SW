using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication1
{
    public partial class TraktorG : UserControl
    {
        private bool[] wheelstate = {false,false};
        private int mousehighlight = 0;
        private Bitmap bgimage;
        public void SetDirection(string str)
        {
            if (str == "FWD")
            {
                flashArrow1.TurnOn();
                flashArrow2.TurnOff();
            }
            else if (str == "RWD")
            {
                flashArrow1.TurnOff();
                flashArrow2.TurnOn();
            }
            else
            {
                flashArrow1.TurnOff();
                flashArrow2.TurnOff();
            }
        }

        /*Set wheel state, i.e. is the wheel extended or retracted*/
        public void SetWheelState(string pos, bool state) {
            if (pos == "Rear")
            {
                wheelstate[0] = state;
            }
            if (pos == "Front")
            {
                wheelstate[1] = state;
            }
        }
        public TraktorG()
        {
            InitializeComponent();
            flashArrow1.Size = new Size(flashArrow1.Size.Width,this.Size.Height/2);
            flashArrow2.Size = new Size(flashArrow2.Size.Width, this.Size.Height / 2);
            flashArrow1.Location = new Point((int)(this.Width - flashArrow1.Width / 2), this.Height / 2 - flashArrow1.Height / 2);
            flashArrow2.Location = new Point(0, this.Height / 2 - flashArrow2.Height / 2);
            
            flashArrow1.SetDirection("FWD");
            flashArrow2.SetDirection("RWD");
           // flashArrow1.Location = new Point((int)(this.Width-flashArrow1.Width/2), this.Height/8);
           // flashArrow2.Location = new Point((int)(this.Width * 0.05), this.Height / 8);
            bgimage = new Bitmap(this.Size.Width,this.Size.Height);
        }
        public void drawTraktor()
        {
            bool frontextended= wheelstate[0];

            bool rearextended=wheelstate[1];
            int mhighlight = mousehighlight;
            this.BackColor = SystemColors.Control;
            Size imgsize = this.Size;
            Bitmap flag = new Bitmap(imgsize.Width, imgsize.Height);
            Pen myPen = new Pen(Color.Gray, imgsize.Height / 10);

            // Create font and brush.
            Font drawFont = new Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);

            SolidBrush drawBrush = new SolidBrush(Color.Black);
            

            float wheelØ = imgsize.Height / 4;
            int collapsedYpos = imgsize.Height;
            int extendedYpos = (int)(imgsize.Height * 0.2);
            int bottomwheelYpos = (int)(imgsize.Height - wheelØ * 1.2);
            int xposfront =(int)( imgsize.Width * 0.4f);
            int xposrear = (int)(imgsize.Width * 0.7f);
            // Create all extended
            using (Graphics g = Graphics.FromImage((Image)flag))
            {
                addFancyBackground(g, SystemColors.Control, SystemColors.ControlDark, SystemColors.Control, imgsize);
                g.DrawString("REAR", drawFont, drawBrush, imgsize.Width * 0.1f, (int)(imgsize.Height * 0.01));
                g.DrawString("FRONT", drawFont, drawBrush, imgsize.Width * 0.75f, (int)(imgsize.Height * 0.01));
            }

            using (Graphics g = Graphics.FromImage((Image)flag))
            {
                int frontypos = 0;
                int rearypos = 0;
                if (frontextended == true)
                {
                    frontypos = extendedYpos+(int)wheelØ/2;
                }
                else
                {
                    frontypos = (int)(imgsize.Height - wheelØ*2) ;
                }
                if (rearextended == true)
                {
                    rearypos = extendedYpos + (int)wheelØ / 2;
                }
                else
                {
                    rearypos = (int)(imgsize.Height - wheelØ * 2);
                }
                SolidBrush localbrush = new SolidBrush(Color.Gray);
                GraphicsPath gp = new GraphicsPath();
                Point p1 = new Point(xposrear - (int)wheelØ / 2, rearypos);
                Point p2 = new Point(xposfront, frontypos);
                Point p3 = new Point(xposfront, (int)(imgsize.Height-wheelØ));
                Point p4 = new Point(xposrear - (int)wheelØ / 2, (int)(imgsize.Height-wheelØ));
                Point[] p = { p1, p2, p3, p4, p1 };
                gp.AddLine(p1, p2);
                gp.AddLine(p2, p3);
                gp.AddLine(p3, p4);
                gp.CloseFigure();
                g.FillPath(localbrush, gp);
                g.DrawPath(myPen, gp);
                if (frontextended == true)
                {
                    drawWheelSet(drawBrush, imgsize, g, true, true);
                }
                else
                {
                    drawWheelSet(drawBrush, imgsize, g, true, false);
                }
                if (rearextended == true)
                {
                    drawWheelSet(drawBrush, imgsize, g, false, true);
                }
                else
                {
                    drawWheelSet(drawBrush, imgsize, g, false, false);
                }
            }
            using (Graphics g = Graphics.FromImage((Image)flag))
            {
                SolidBrush highlightBrush = new SolidBrush(Color.FromArgb(128, 0, 128, 160));
                if (mhighlight == 0)
                {
                    //g.DrawRectangle(myPen, 0, 0, 0, 0);
                }
                if (mhighlight == 1)
                {
                    g.FillRectangle(highlightBrush, xposfront - (int)(wheelØ /2*1.2), 0, wheelØ, bottomwheelYpos); 
                }
                if (
                    mhighlight == 2) { g.FillRectangle(highlightBrush, xposrear - (int)(wheelØ / 2 * 1.2), 0, wheelØ, bottomwheelYpos);
                }
            }
            bgimage = flag;
            this.BackgroundImage = flag;
        }
        private Graphics addFancyBackground(Graphics g, Color c1, Color c2, Color c3, Size imgsize)
        {
            //Draw fancy background 
            GraphicsPath gp = new GraphicsPath();
            Rectangle tr = new Rectangle();
            tr.Width = imgsize.Width;
            tr.Height = imgsize.Height;
            tr.X = 0;
            tr.Y = 0;
            gp.AddRectangle(tr);
            PathGradientBrush pgb = new PathGradientBrush(gp);
            pgb.WrapMode = WrapMode.Clamp;

            pgb.CenterPoint = new PointF(imgsize.Width / 2, imgsize.Height / 4);
            pgb.CenterColor = c1;
            pgb.SurroundColors = new Color[] {c2, c3 };
            Blend bl = new Blend();
            bl.Factors = new float[] { 0, 0.25f, 0.48f, 0.75f, 1f };
            bl.Positions = new float[] { 0, 0.25f, 0.5f, 0.75f, 1f };
            pgb.Blend = bl;
            ////Draw main background
            g.FillRectangle(pgb, tr);
            return g;
        }
        private Graphics drawWheelSet(SolidBrush drawBrush,Size imgsize, Graphics g,bool front,bool collapsed)
        {
            float wheelØ = imgsize.Height / 4;
            int ypos = 0;
            int collapsedYpos = (int)(imgsize.Height * 0.4f);
            int extendedYpos =(int)( imgsize.Height*0.2);
            int bottomwheelYpos = (int)(imgsize.Height - wheelØ*1.2);
            float xpos = 0;
            if (front == true)
            {
                 xpos = imgsize.Width * 0.3f;
            }
            else {  xpos = imgsize.Width * 0.6f; }
            if (collapsed == true)
            {
                ypos = extendedYpos;
            }
            else
            {
                ypos = collapsedYpos;
            }
            g.FillEllipse(drawBrush, xpos, ypos, wheelØ, wheelØ);
            g.FillEllipse(drawBrush, xpos, bottomwheelYpos, wheelØ, wheelØ);
            return g;
        }
        private void TraktorG_Load(object sender, EventArgs e)
        { }

        private void TraktorG_MouseMove(object sender, MouseEventArgs e)
        {
            //Point LocalMousePosition = this.PointToClient(Cursor.Position);
            //int xpos = LocalMousePosition.X;
            //if (LocalMousePosition.X < this.Size.Width / 2 && LocalMousePosition.Y < this.Size.Height / 2)
            //{
            //    mousehighlight = 1;
            //}
            //if (LocalMousePosition.X > this.Size.Width / 2 && LocalMousePosition.Y < this.Size.Height / 2)
            //{
            //    mousehighlight = 2;
            //}
            //drawTraktor();
        }

        private void TraktorG_MouseClick(object sender, MouseEventArgs e)
        {
            //Point LocalMousePosition = this.PointToClient(Cursor.Position);
            //int xpos = LocalMousePosition.X;
            //if (LocalMousePosition.X < this.Size.Width / 2 )
            //{
            //    if (wheelstate[0]==true)
            //    {
            //        wheelstate[0] = false;  
            //    }
            //    else
            //    {
            //        wheelstate[0] = true; 
            //    }
              
            //}
            //if (LocalMousePosition.X > this.Size.Width / 2)
            //{
            //    if (wheelstate[1] == true)
            //    {
            //        wheelstate[1] = false;
            //    }
            //    else
            //    {
            //        wheelstate[1] = true;
            //    }
            //}
            
            
            ////if (LocalMousePosition.X < this.Size.Width / 2 && LocalMousePosition.Y<this.Size.Height/2)
            ////{
            ////    wheelstate[0] = true;
            ////}
            ////if (LocalMousePosition.X > this.Size.Width / 2 && LocalMousePosition.Y < this.Size.Height/2)
            ////{
            ////    wheelstate[1] = true;
            ////}
            ////if (LocalMousePosition.X > this.Size.Width / 2 && LocalMousePosition.Y > this.Size.Height/2)
            ////{
            ////    wheelstate[1] = false;
            ////}
            ////if (LocalMousePosition.X < this.Size.Width / 2 && LocalMousePosition.Y >this.Size.Height/2)
            ////{
            ////    wheelstate[0] = false;
            ////}
            //drawTraktor();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //SetDirection("FWD");
        }
      }
}

