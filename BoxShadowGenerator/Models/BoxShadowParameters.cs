using System;
using System.Collections.Generic;
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
        public int ShadowColour { get; set; }
        public int BackgroundColour { get; set; }
        public int BoxColour { get; set; }
        public float Opacity { get; set; } = 1;
        public ShadowType Type { get; set; }

        public string ParamString => $"{XLength}px {YLength}px {BlurRadius}px {SpreadRadius}px {RGBA()}";


        private string RGBA()
        {
            var rgba = $"rgba(0,0,0,{Opacity})";
            return rgba;
        }

        public string ToCss()
        {
            return @$"-webkit-box-shadow: {ParamString};
                      -moz-box-shadow: {ParamString};
                       box-shadow: {ParamString};";
        }
    }
}
