using System;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MyButton : UserControl
    {
        private int GetButton(int mpos)
        {
            Size imgsize = this.Size;
            int highlight = 0;
            if (mpos > 0 && mpos <= imgsize.Height * 0.125f) { highlight = 0; }
            else if (mpos > imgsize.Height * 0.125 && mpos <= imgsize.Height * 0.250) { highlight = (int)(imgsize.Height * 0.125f); }
            else if (mpos > imgsize.Height * 0.250 && mpos <= imgsize.Height * 0.375) { highlight = (int)(imgsize.Height * 0.250f); }

            else if (mpos > imgsize.Height * 0.6250 && mpos <= imgsize.Height * 0.75) { highlight = (int)(imgsize.Height * 0.625f); }
            else if (mpos > imgsize.Height * 0.75f && mpos <= imgsize.Height * 0.875) { highlight = (int)(imgsize.Height * 0.75f); }
            else if (mpos > imgsize.Height * 0.875 && mpos <= imgsize.Height * 1) { highlight = (int)(imgsize.Height * 0.875f); }

            else
            {
                highlight = (int)(imgsize.Height * 0.435f);
            }
            return highlight;

        }
        public int GetButtonValue(int mpos)
        {
            Size imgsize = this.Size;
            int buttonvalue = 0;
            if (mpos > 0 && mpos <= imgsize.Height * 0.125f) { buttonvalue = 10; }
            else if (mpos > imgsize.Height * 0.125 && mpos <= imgsize.Height * 0.250) { buttonvalue = 5; }
            else if (mpos > imgsize.Height * 0.250 && mpos <= imgsize.Height * 0.375) { buttonvalue = 1; }

            else if (mpos > imgsize.Height * 0.6250 && mpos <= imgsize.Height * 0.75) { buttonvalue = -1; }
            else if (mpos > imgsize.Height * 0.75f && mpos <= imgsize.Height * 0.875) { buttonvalue = -5; }
            else if (mpos > imgsize.Height * 0.875 && mpos <= imgsize.Height * 1) { buttonvalue = -10; }

            else
            {
                buttonvalue = 0;
            }
            return buttonvalue;

        }
        public void Update(int mpos)
        {
            this.BackColor = SystemColors.Control;
            Size imgsize = this.Size;
            Bitmap flag = new Bitmap(imgsize.Width, imgsize.Height);
            Pen myPen = new Pen(Color.Black, imgsize.Height / 100);

            // Create font and brush.
            float fontsize = imgsize.Width/5;//9;
            Font drawFont = new Font("Microsoft Sans Serif", fontsize, System.Drawing.FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            
            // Create point for upper-left corner of drawing.

            using (Graphics g = Graphics.FromImage((Image)flag))
            {
                //Draw fancy background 
                GraphicsPath gp = new GraphicsPath();
                Rectangle tr = new Rectangle();
                tr.Width = imgsize.Width;
                tr.Height = imgsize.Height;
                tr.X =0;
                tr.Y = 0;
                gp.AddRectangle(tr);
                PathGradientBrush pgb = new PathGradientBrush(gp);
                pgb.WrapMode = WrapMode.Tile;

                pgb.CenterPoint = new PointF(imgsize.Width/2, imgsize.Height/4);
                pgb.CenterColor = SystemColors.Control;
                pgb.SurroundColors = new Color[] { SystemColors.ControlDark, SystemColors.Control};
                Blend bl = new Blend();
                bl.Factors = new float[] { 0, 0.65f, 0.48f, 0.75f, 1f };
                bl.Positions = new float[] { 0, 0.75f, 0.5f, 0.75f, 1f };
                pgb.Blend = bl;
                ////Draw main background
                Brush b = new SolidBrush(Color.Black);
                g.FillRectangle(pgb, tr);





                int highlight = 0;
                highlight = GetButton(mpos);
                g.FillRectangle(new SolidBrush(SystemColors.AppWorkspace), new Rectangle(new Point(0,highlight), new Size(imgsize.Width, imgsize.Height / 8)));
                
                //g.FillRectangle(new SolidBrush(Color.Yellow), new Rectangle(new Point(0, imgsize.Height / 8), new Size(imgsize.Width, imgsize.Height / 8)));
            
                //g.DrawLine(myPen, new Point(imgsize.Width, (int)(imgsize.Height * 0.125f)), new Point(0, (int)(imgsize.Height * 0.125f)));
                //g.DrawLine(myPen, new Point(imgsize.Width, (int)(imgsize.Height * 0.25f)), new Point(0, (int)(imgsize.Height * 0.25f)));
                //g.DrawLine(myPen, new Point(imgsize.Width, (int)(imgsize.Height * 0.375f)), new Point(0, (int)(imgsize.Height * 0.375f)));

                //g.DrawLine(myPen, new Point(imgsize.Width, (int)(imgsize.Height * 0.625f)), new Point(0, (int)(imgsize.Height * 0.625f)));
                //g.DrawLine(myPen, new Point(imgsize.Width, (int)(imgsize.Height * 0.75f)), new Point(0, (int)(imgsize.Height * 0.75f)));
                //g.DrawLine(myPen, new Point(imgsize.Width, (int)(imgsize.Height * 0.875f)), new Point(0, (int)(imgsize.Height * 0.875f)));

                g.DrawString("+10", drawFont, drawBrush, 5, (int)(imgsize.Height * 0.025));
                g.DrawString("+5 ", drawFont, drawBrush, 5, (int)(imgsize.Height * 0.15));
                g.DrawString("+1 ", drawFont, drawBrush, 5, (int)(imgsize.Height * 0.275));

                g.DrawString("-1 ", drawFont, drawBrush, 5, (int)(imgsize.Height * 0.625));
                g.DrawString("-5 ", drawFont, drawBrush, 5, (int)(imgsize.Height * 0.75));
                g.DrawString("-10", drawFont, drawBrush, 5, (int)(imgsize.Height * 0.875));

            }
            this.BackgroundImage = flag;
        }


        public MyButton()
        {
            InitializeComponent();
        }

        private void MyButton_Load(object sender, EventArgs e)
        {
            
        }

        private void MyButton_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void MyButton_MouseMove(object sender, MouseEventArgs e)
        {
            Point LocalMousePosition = this.PointToClient(Cursor.Position);
            Update(LocalMousePosition.Y); 
        }

        private void MyButton_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
