using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector_Editor
{
    public partial class BorderThicknessWindow : Form
    {
        public BorderThicknessWindow()
        {
            InitializeComponent();
        }

        private void BorderThicknessWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            if(e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
            }
        }
    }
}
