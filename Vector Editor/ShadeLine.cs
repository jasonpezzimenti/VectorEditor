using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector_Editor
{
    public partial class ShadeLine : Control
    {
        private Point currentMouseLocation;
        private bool isMoving;

        [Browsable(true)]
        [Category("Appearance")]
        public int LineThickness { get; set; }

        public enum Colors
        {
            Red = 0,
            Green,
            Blue
        }

        [Browsable(true)]
        [Category("Appearance")]
        public Colors LineColor { get; set; }

        [Browsable(true)]
        [Category("Appearance")]
        public Color Color { get; set; }

        [Browsable(true)]
        [Category("Data")]
        public int Value { get; set; }

        public ShadeLine()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Point(
                    0,
                    10
                    ),
                new Point(
                    this.Width,
                    10
                    ),
                Color.White,
                Color
                )
                )
            {
                using (Pen pen = new Pen(
                    brush,
                    LineThickness
                    )
                    )
                {
                    e.Graphics.DrawLine(
                        pen,
                        0,
                        10,
                        this.Width,
                        10
                        );
                }
            }



            if(isMoving)
            {
                Point[] points2 = new Point[]
{
                new Point(
                    currentMouseLocation.X - 3,
                    0
                    ),
                new Point(
                    currentMouseLocation.X + 3,
                    0
                    ),
                new Point(
                    currentMouseLocation.X,
                    3
                    )
};

                e.Graphics.DrawPolygon(new Pen(Brushes.Black, 1.0f), points2);
                e.Graphics.FillPolygon(Brushes.Black, points2);
            }
            else
            {
                Point[] points = new Point[]
{
                new Point(
                    0,
                    0
                    ),
                new Point(
                    6,
                    0
                    ),
                new Point(
                    3,
                    3
                    )
};

                e.Graphics.DrawPolygon(new Pen(Brushes.Black, 1.0f), points);
                e.Graphics.FillPolygon(Brushes.Black, points);
            }
        }

        private void ShadeLine_SizeChanged(object sender, EventArgs e)
        {
            this.Height = LineThickness;
            this.Refresh();
        }

        private void ShadeLine_MouseMove(object sender, MouseEventArgs e)
        {
            currentMouseLocation = e.Location;

            isMoving = true;

            this.Refresh();
        }

        private void ShadeLine_MouseLeave(object sender, EventArgs e)
        {
            isMoving = false;
            this.Refresh();
        }
    }
}
