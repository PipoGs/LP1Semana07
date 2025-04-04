using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        private readonly byte _red;
        private readonly byte _blue;
        private readonly byte _green;
        private byte _alpha;


        public Color(byte red, byte green, byte blue, byte alpha)
        {
            _red = red;
            _green = green;
            _blue = blue;
            _alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
            _alpha = 255;
        }

        public byte GetRed()
        {
            return _red;
        }

        public byte GetGreen()
        {
            return _green;
        }

        public byte GetBlue()
        {
            return _blue;
        }

        public byte GetAlpha()
        {
            return _alpha;
        }

        public byte GetGrey
        {
            get => (byte)((_red + _green + _blue) / 3);
        }

    }
}