using System;
using System.Collections.Generic;
using System.Linq;
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
        public int Opacity { get; set; }
    }
}
