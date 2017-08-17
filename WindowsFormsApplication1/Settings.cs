using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace WindowsFormsApplication1
{
    class Settings
    {
        public struct ColorSettings
        {
            public Color buttonColorActive;
            public Color buttonColorNotActive;
            public Color groupBoxColor;
            public Color formColor;
            public Color digitalColor;
        }
        [Serializable()]
        public struct ColorTemplate
        {
            //Color buttonOnBack, Color buttonOnText, Color buttonOffBack, Color buttonOffText
            public Color buttonOnBack;
            public Color buttonOnText;
            public Color buttonOffBack;
            public Color buttonOffText;
            
            public Color digitalColorBack;
            public Color digitalColorText;
            public Color digitalColorAlarmBack;
            public Color digitalColorAlarmText;

            public int yellowValueWheel;
            public int redValueWheel;
            public int yellowValuePump;
            public int redValuePump;

            public int MaxOutValue;
        }

    }
}
