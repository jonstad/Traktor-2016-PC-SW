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
    public partial class FlashArrow : UserControl
    {
        private string direction = "NA";
        private bool active = false;
        private int counter = 2;
        public Color color1 { get; set; }
        public Color color2 { get; set; }
        public Point mpos { get; set; }
        public bool mactive=false;
        public FlashArrow()
        {
            InitializeComponent();
            color1 = Color.Gray;
            color2 = Color.Blue;
        }
        public void SetDirection(string dir)
        {
            direction = dir;
           DrawArrow(); //Draw it the first time
        }
        public void TurnOn()
        {
            active = true;
        }
        public void TurnOff()
        {
            active = false;
            DrawArrow(); //remove colors?
        }
        private void DrawArrow()
        {
            Bitmap flag = new Bitmap(this.Width,this.Height);
            pictureBox1.Size = flag.Size;
            pictureBox1.Location = new Point(0, 0);
            Pen myPen = new Pen(Color.Gray, 5);
            using (Graphics g = Graphics.FromImage((Image)flag))
            {
                g.Clear(Color.Transparent);
                GraphicsPath gp = new GraphicsPath();
                Point p1;
                Point p2;
                Point p3;
                int nrarraows = 4;
                counter = (counter + 1) % nrarraows;
                for (int i = 0; i < nrarraows; i++)
                {
                    myPen = new Pen(color1, this.Width / 12);
                    gp.Reset();
                    p1 = new Point((int)(this.Width  - i * this.Width / (nrarraows-0)), (int)(this.Height * 0.1));
                    p2 = new Point((int)(this.Width - i * this.Width / (nrarraows-0) - this.Width / 4), (int)(this.Height * 0.5));
                    p3 = new Point((int)(this.Width - i * this.Width / (nrarraows-0)), (int)(this.Height * 0.9));
                    gp.AddLine(p1, p2);
                    gp.AddLine(p2, p3);
                    g.DrawPath(myPen, gp);
                }
                if (active)
                {
                    myPen = new Pen(color2, this.Width / 10);
                    gp.Reset();
                    p1 = new Point((int)(this.Width - counter * this.Width / nrarraows), (int)(this.Height * 0.1));
                    p2 = new Point((int)(this.Width - counter * this.Width / nrarraows - this.Width / 4), (int)(this.Height * 0.5));
                    p3 = new Point((int)(this.Width - counter * this.Width / nrarraows), (int)(this.Height * 0.9));
                    gp.AddLine(p1, p2);
                    gp.AddLine(p2, p3);
                    g.DrawPath(myPen, gp); 
                }
            }
            if (direction == "FWD")
            {
                flag.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
            else if (direction == "RWD")
            {
                flag.RotateFlip(RotateFlipType.Rotate180FlipX);
            }
            pictureBox1.Image = flag;
            //this.BackgroundImage = flag;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (active == true)
            {
                DrawArrow();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //if (active == true)
            //{
            //    TurnOff();
            //}
            //else
            //{
            //    TurnOn();
            //}
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            mpos = this.PointToClient(Cursor.Position);
            mactive=true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            mactive = false;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            mactive = true;
        }
    }
}
