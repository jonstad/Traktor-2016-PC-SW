using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class History
    {
        int[][] jaggedArray;
        private int CurrentPoint;

        public int getCurrentPoint()
        {
            return CurrentPoint;
        }
        public void setCurrentPoint(int p)
        {
            CurrentPoint = p;
        }
        public int getWaveLength(int element)
        {
            return jaggedArray[element].Length;
        }
        public void setWave(int index, int value, int element) //element type of data stored. i.e. to what array it should be stored
        {
            jaggedArray[element][index] = value;
        }
        public PictureBox SetUpHistoryBox(PictureBox picBox, Color backcolor)
        {
            picBox.BackColor = backcolor;
            picBox.BorderStyle = BorderStyle.Fixed3D;
            return picBox;
        }
        public void InitHistory(int length, short count)
        {
            jaggedArray = new int[length][];

            for (int i = 0; i < 4; i++)
            {
                jaggedArray[i] = new int[1000]; // create a jagged array with elements for temperature , current pressure etc.
            }
            CurrentPoint = count;
        }

        public void ShowHistory(History HS, PictureBox picBox, int penwidth, Color pencolor, int element, String label)
        {
            int screenWidth = picBox.Size.Width;
            int screenHeight = picBox.Size.Height;

            int[][] jaggedwave = HS.jaggedArray;

            System.Drawing.Bitmap flag = new System.Drawing.Bitmap(screenWidth, screenHeight);
            Bitmap result = new Bitmap(screenWidth, screenHeight);

            List<PointF> path = new List<PointF>();
            path.Clear();
            // xscaling = picBox.Height / 100;
            double yscaling = (double)picBox.Height / (double)255;
            double xscaling = (double)picBox.Width / (double)jaggedArray[element].Length;

            //Fill up array then make path from array
            int[] wave = new int[HS.jaggedArray[element].Length];
            for (int i = 0; i < HS.CurrentPoint; i++)
            {
                //wave[HS.HistoryWave.Length - HS.CurrentPoint + i] = HS.HistoryWave[i];
                wave[HS.jaggedArray[element].Length - HS.CurrentPoint + i] = HS.jaggedArray[element][i];
            }

            //for (int i = HS.CurrentPoint; i < HS.HistoryWave.Length; i++)
            for (int i = HS.CurrentPoint; i < HS.jaggedArray[element].Length; i++)
            {
                //wave[i-HS.CurrentPoint ] = HS.HistoryWave[i];
                wave[i - HS.CurrentPoint] = HS.jaggedArray[element][i];
            }
            //Draw path to scale
            for (int i = 0; i < wave.Length; i++)
            {
                path.Add(new Point((int)(xscaling * i), (int)(((double)wave[i]) * yscaling)));
            }
            Pen myPen = new Pen(pencolor, penwidth);
            using (Graphics g = Graphics.FromImage((Image)result))
            {
                g.DrawImage(flag, 0, 0, screenWidth, screenHeight);
                for (int i = 0; i < path.Count - 1; i++)
                {
                    g.DrawLine(myPen, path[i], path[i + 1]);
                    //    g.DrawLine(Pens.Green, path[path.Count - i-1], path[path.Count - i -2]);
                }
                result.SetResolution(1, 1);
                result.RotateFlip(RotateFlipType.RotateNoneFlipY);
                //result.RotateFlip(RotateFlipType.Rotate180FlipNone);

                // Create font and brush.
                Font drawFont = new Font("Arial", 16);
                SolidBrush drawBrush = new SolidBrush(pencolor);
                // Create point for upper-left corner of drawing.
                PointF drawPoint = new PointF(5, 5.0F);
                g.DrawString(label, drawFont, drawBrush, drawPoint);
                picBox.Image = result;
            }
        }
    }
}
