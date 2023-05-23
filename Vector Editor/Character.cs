using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_Editor
{
    public class Character
    {
        public Rectangle Bounds { get; set; }
        public Color Color { get; set; }
        public Font Font { get; set; }
        public FontStyle Style { get; set; }
    }
}
