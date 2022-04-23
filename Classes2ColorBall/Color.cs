using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2ColorBall
{
    public class Color
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; }
        public Color(byte r, byte g, byte b, byte alpha)
        {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = alpha;
        }
        public Color(byte r, byte g, byte b)
        {
            Red = r;
            Green = g;
            Blue = b;
            Alpha = 255;
        }

        public int getGrayLvl()
        {
            return (Red + Green + Blue) / 3;
        }
    }
}
