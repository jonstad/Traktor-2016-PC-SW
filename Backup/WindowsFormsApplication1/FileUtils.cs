using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication1
{
    class FileUtils
    {
        public static bool writeColorSetting(string filename, Color buttonColor, Color groupboxColor)
        {
            StreamWriter file = new StreamWriter(filename );
            file.Write("Active Button Color" + ";" + "Not Active Button Color" + ";" + "\r\n");
            //foreach (ListViewItem item in lv2.Items)
            //{
                file.Write(buttonColor.ToArgb()+ ";"+groupboxColor.ToArgb()+ "\r\n");
            //}
            file.Close();
            return true;
        }
        public static bool writeColorSetting(string filename, Color buttonOnBack, Color buttonOnText, Color buttonOffBack, Color buttonOffText)
        {
            StreamWriter file = new StreamWriter(filename );
            file.Write("Active Button Color" + ";" + "Not Active Button Color" + ";" + "\r\n");
            //foreach (ListViewItem item in lv2.Items)
            //{
            file.Write(buttonOnBack.ToArgb() + ";" + buttonOnText.ToArgb() + ";" + buttonOffBack.ToArgb() + ";" + buttonOffText.ToArgb() + "\r\n");
            //}
            file.Close();
            return true;
        }
        public static bool writeColorSetting(string filename, Settings.ColorTemplate ct)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, ct);

            fs.Close();
            return true;
        }
        public static Settings.ColorTemplate readColorsTemplate(string filename)
        {
            Settings.ColorTemplate clr = new Settings.ColorTemplate();
    
                FileStream fs = new FileStream(filename, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                clr =(Settings.ColorTemplate) formatter.Deserialize(fs);

                fs.Close();
                return clr;
        }

        public static Settings.ColorSettings readColors(string filename)
        {
            Settings.ColorSettings clr = new Settings.ColorSettings();
            try
            {

                StreamReader file = new StreamReader(filename);
                string version = file.ReadLine();
                string colo = file.ReadLine();
                string[] colorlist = colo.Split(';');
                clr.buttonColorActive = Color.FromArgb(Convert.ToInt32(colorlist[0]));
                clr.buttonColorNotActive = Color.FromArgb(Convert.ToInt32(colorlist[1])); 

                file.Close();
                return clr;
            }
            catch (Exception)
            {

                return clr;
            }

        }

    }
}
