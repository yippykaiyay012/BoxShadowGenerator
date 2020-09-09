using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BoxShadowGenerator.Models
{
    public class BoxShadowParameters
    {
        public int XLength { get; set; }
        public int YLength { get; set; }
        public int BlurRadius { get; set; }
        public int SpreadRadius { get; set; }
        public string ShadowColour { get; set; } = "#000000";
        public string BackgroundColour { get; set; } = "#ffffff";
        public string BoxColour { get; set; } = "#000000";
        public float Opacity { get; set; } = 1;
        public ShadowType Type { get; set; } = ShadowType.Outline;

        public string ParamString => $"{XLength}px {YLength}px {BlurRadius}px {SpreadRadius}px {HexToColorString()}";

        public string HexToColorString()
        {         
            string color = "";
            if (ShadowColour.IndexOf('#') != -1)
                color = ShadowColour.Replace("#", "");

            int r, g, b = 0;

            r = int.Parse(color.Substring(0, 2), NumberStyles.AllowHexSpecifier);
            g = int.Parse(color.Substring(2, 2), NumberStyles.AllowHexSpecifier);
            b = int.Parse(color.Substring(4, 2), NumberStyles.AllowHexSpecifier);

            return string.Format("rgba({0}, {1}, {2}, {3});", r, g, b, Opacity);
        }

        public string ToCss()
        {
            return @$"-webkit-box-shadow: {ParamString};
                      -moz-box-shadow: {ParamString};
                       box-shadow: {ParamString};";
        }
    }
}
