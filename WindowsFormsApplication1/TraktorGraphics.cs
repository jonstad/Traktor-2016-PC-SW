using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TraktorGraphics
    {
        public Image GetWheelOutImage(Button button )
        {
            Size imgsize = button.Size;
            Bitmap flag = new Bitmap(imgsize.Width, imgsize.Height);
            Pen myPen = new Pen(Color.Black, imgsize.Height/10); 
            using (Graphics g = Graphics.FromImage((Image)flag))
            {
                g.DrawImage(flag, 0, 0, flag.Width, flag.Height);

                g.DrawLine(myPen, new Point(imgsize.Width / 10, imgsize.Height / 10), new Point(imgsize.Width - imgsize.Width / 10, imgsize.Height / 10));
                g.DrawLine(myPen, new Point(imgsize.Width / 10, imgsize.Height - imgsize.Height / 10), new Point(imgsize.Width - imgsize.Width / 10, imgsize.Height - imgsize.Height / 10));

                g.DrawLine(myPen, new Point(imgsize.Width / 3, imgsize.Height  /10), new Point(imgsize.Width /3, imgsize.Height - imgsize.Height / 10));
                g.DrawLine(myPen, new Point(imgsize.Width - imgsize.Width / 3, imgsize.Height / 10), new Point(imgsize.Width - imgsize.Width / 3, imgsize.Height - imgsize.Height / 10));
            }
            return flag;
        }
        public Image GetWheelCollapsedImage(Button button)
        {
            Size imgsize = button.Size;
            Bitmap flag = new Bitmap(imgsize.Width, imgsize.Height);
            Pen myPen = new Pen(Color.Black, imgsize.Height / 10);
            using (Graphics g = Graphics.FromImage((Image)flag))
            {
                g.DrawImage(flag, 0, 0, flag.Width, flag.Height);

                g.DrawLine(myPen, new Point(imgsize.Width / 10, imgsize.Height / 2), new Point(imgsize.Width - imgsize.Width / 10, imgsize.Height / 2));
                g.DrawLine(myPen, new Point(imgsize.Width / 10, imgsize.Height - imgsize.Height / 10), new Point(imgsize.Width - imgsize.Width / 10, imgsize.Height - imgsize.Height / 10));

                g.DrawLine(myPen, new Point(imgsize.Width / 3, imgsize.Height / 2), new Point(imgsize.Width / 3, imgsize.Height - imgsize.Height / 10));
                g.DrawLine(myPen, new Point(imgsize.Width - imgsize.Width / 3, imgsize.Height / 2), new Point(imgsize.Width - imgsize.Width / 3, imgsize.Height - imgsize.Height / 10));
            }
            return flag;
        }

    }
}
