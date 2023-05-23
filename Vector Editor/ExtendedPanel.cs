using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Vector_Editor.Controls
{
    public partial class ExtendedPanel : Control
    {
        public Keys pressedKey = Keys.None;

        public ExtendedPanel()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.KeyDown += ExtendedPanel_KeyDown;
            this.KeyUp += ExtendedPanel_KeyUp;
        }

        private void ExtendedPanel_KeyDown(object sender, KeyEventArgs e)
        {
            pressedKey = (Keys)e.KeyValue;
            OnKeyPressed?.Invoke(this, e);
        }

        private void ExtendedPanel_KeyUp(object sender, KeyEventArgs e)
        {
            pressedKey = (Keys)e.KeyValue;
            OnKeyPressed?.Invoke(this, e);
        }

        public event EventHandler OnKeyPressed;

        public void KeyPressed(object sender, KeyEventArgs e)
        {
            if(OnKeyPressed != null)
            {
                OnKeyPressed(this, e);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(
                new Pen(
                    Brushes.Black,
                    1.0f
                    ),
                0,
                0,
                this.Width - 1.0f,
                this.Height - 1.0f
                );

            base.OnPaint(e);
        }

        private void ExtendedPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if(this.CanSelect)
            {
                this.Select();
            }
        }
    }
}
