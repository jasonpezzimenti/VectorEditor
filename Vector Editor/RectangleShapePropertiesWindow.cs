using ALMSTWKND.UI.WindowsForms.Controls;
using Controls;
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
    public partial class RectangleShapePropertiesWindow : Form
    {
        public List<float> dashes = new List<float>();

        public Color borderColor = Color.Black,
            fillingColor = Color.Black;
        public bool hasBorder = false;
        public float borderThickness = 1.0f;
        public bool drawDashedLine = false;
        public bool hasFilling = false;

        public RectangleShapePropertiesWindow()
        {
            InitializeComponent();
        }

        private void borderStyleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (borderStyleComboBox.SelectedItem.ToString() == "Solid")
            {
                drawDashedLine = false;
            }
            else
            {
                drawDashedLine = true;
            }

            this.Refresh();
        }

        private void borderStylePreviewPanel_Paint(object sender, PaintEventArgs e)
        {
            dashes.Clear();

            if(drawDashedLine)
            {
                if (dashPatternTextField.Text.Length >= 3)
                {
                    string dashPattern = dashPatternTextField.Text.Replace(" ", String.Empty);
                    string[] numbers = dashPatternTextField.Text.Split(',');

                    foreach (string number in numbers)
                    {
                        float numberValue = 0.00f;
                        float.TryParse(number, out numberValue);

                        dashes.Add(numberValue);
                    }

                    using (Pen pen = new Pen(
                        new SolidBrush(
                            borderColorPreviewPanel.BackColor
                            ),
                        (float)borderThicknessNumericField.Value
                        )
                        )
                    {
                        pen.DashPattern = dashes.ToArray<float>();

                        e.Graphics.DrawLine(
                            pen,
                            0,
                            (borderStylePreviewPanel.Height / 2) - ((int)borderThicknessNumericField.Value / 2),
                            borderStylePreviewPanel.Width,
                            (borderStylePreviewPanel.Height / 2) - ((int)borderThicknessNumericField.Value / 2)
                            );
                    }
                }
                else
                {
                    drawDashedLine = false;
                }    
            }
            else
            {
                using (Pen pen = new Pen(
                    new SolidBrush(
                        borderColorPreviewPanel.BackColor
                        ),
                    (float)borderThicknessNumericField.Value
                    )
                    )
                {
                    e.Graphics.DrawLine(
                        pen,
                        0,
                        (borderStylePreviewPanel.Height / 2) - ((int)borderThicknessNumericField.Value / 2),
                        borderStylePreviewPanel.Width,
                        (borderStylePreviewPanel.Height / 2) - ((int)borderThicknessNumericField.Value / 2)
                        );
                }
            }
        }

        private void borderColorPreviewPanel_MouseClick(object sender, MouseEventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                if(dialog.ShowDialog(this) == DialogResult.OK)
                {
                    borderColorPreviewPanel.BackColor = dialog.Color;
                    borderColorTextField.Text = dialog.Color.R.ToString() + "," + dialog.Color.G.ToString() + "," + dialog.Color.B.ToString();
                }
            }
        }

        private void fillingColorPreviewPanel_MouseClick(object sender, MouseEventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                if(dialog.ShowDialog(this) == DialogResult.OK)
                {
                    fillingColorPreviewPanel.BackColor = dialog.Color;
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            borderColor = borderColorPreviewPanel.BackColor;
            fillingColor = fillingColorPreviewPanel.BackColor;

            float thickness = 1.0f;

            float.TryParse(borderThicknessNumericField.Value.ToString(), out borderThickness);

            borderThickness = thickness;

            if (borderStyleComboBox.SelectedItem != null)
            {
                if (borderStyleComboBox.SelectedItem.ToString() == "Solid")
                {
                    drawDashedLine = false;
                }
                else
                {
                    drawDashedLine = true;
                }
            }

            if (hasBorderSwitch.CurrentState == Switch.SwitchStates.On)
            {
                hasBorder = true;
            }
            else
            {
                hasBorder = false;
            }

            if (hasFillingSwitch.CurrentState == Switch.SwitchStates.On)
            {
                hasFilling = true;
            }
            else
            {
                hasFilling = false;
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
