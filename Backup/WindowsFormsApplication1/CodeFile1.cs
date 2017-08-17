using System;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public const string GetTractorStatus = "c";
        public const string GetTractorStatusExtended = "C";
        public int zero = 48;
        public int one = 49;


        /*Original return */
        public const int StatusPort0 = 2;
        public const int StatusPort1 = 5;
        public const int StatusPort2 = 8;
        public const int StatusPort3 = 11;
        public const int StatusPort4 = 14;
       
        /*extended return  */
        public const int StatusPortE0 = 1;
        public const int StatusPortE1 = 2;
        public const int StatusPortE2 = 3;
        public const int StatusPortE3 = 4;      //Collapse front
        public const int StatusPortRear = 5; //Collapse rear
        public const int StatusPortAntiSpin = 6;  //Anti-Spin


        public string wheelCollapsedASCII = 
                                    "           " + Environment.NewLine +
                                    "           " + Environment.NewLine +
                                    "           " + Environment.NewLine +
                                    "############" + Environment.NewLine +
                                    "     ##   " + Environment.NewLine +
                                    "     ##   " + Environment.NewLine +
                                    "###########" + Environment.NewLine;

        public string wheelOutASCII = 
                                    "############" + Environment.NewLine +
                                    "     ##   " + Environment.NewLine +
                                    "     ##   " + Environment.NewLine +
                                    "     ##   " + Environment.NewLine +
                                    "     ##   " + Environment.NewLine +
                                    "     ##   " + Environment.NewLine +
                                    "###########" + Environment.NewLine;

        public const string ActivLowSpeed = "00";
    }
}