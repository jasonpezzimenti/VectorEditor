using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_Editor
{
    public class Shape
    {
        public enum ShapeTypes
        {
            Ellipse = 0,
            Line,
            Polygon,
            Rectangle,
            Pixel
        }

        public ShapeTypes ShapeType { get; set; }

        public bool Highlighted { get; set; }
        public bool Selected { get; set; }

        public bool HasBorder { get; set; }
        public float BorderThickness { get; set; }

        public List<Pixel> Pixels = new List<Pixel>();

        public enum LineStyles
        {
            Solid = 0,
            Dashed
        }

        public LineStyles LineStyle { get; set; }
        public float[] Dashes { get; set; }
        public Size InitialSize { get; set; }

        public Rectangle Bounds { get; set; }
        
        public class Colors
        {
            public Color BorderColor { get; set; }

            public bool HasFilling { get; set; }

            public class FillingColors
            {
                public Color Color { get; set; }
                public List<GradientColor> Colors = new List<GradientColor>();
            }

            public FillingColors Fillings = new FillingColors();
        }

        public Colors Coloring;

        public Shape()
        {
            Coloring = new Colors();
            Colors.FillingColors Fillings = new Colors.FillingColors();
        }
    }
}
