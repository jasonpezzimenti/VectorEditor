using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_Editor
{
    public class Pixel
    {
        public Rectangle Bounds { get; set; }
        public Color Color { get; set; }
        public bool Highlighted { get; set; }
        public bool Selected { get; set; }
    }
}
