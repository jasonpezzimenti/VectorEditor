using ALMSTWKND.UI.WindowsForms.Controls;
using Controls;

namespace Vector_Editor
{
    partial class RectangleShapePropertiesWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dashPatternTextField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.borderThicknessNumericField = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.borderStylePreviewPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.borderStyleComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.borderColorPreviewPanel = new System.Windows.Forms.Panel();
            this.borderColorTextField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hasBorderSwitch = new ALMSTWKND.UI.WindowsForms.Controls.Switch();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.hasFillingSwitch = new ALMSTWKND.UI.WindowsForms.Controls.Switch();
            this.fillingColorPreviewPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderThicknessNumericField)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dashPatternTextField);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.borderThicknessNumericField);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.borderStylePreviewPanel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.borderStyleComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.borderColorPreviewPanel);
            this.groupBox1.Controls.Add(this.borderColorTextField);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.hasBorderSwitch);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(472, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Border Properties";
            // 
            // dashPatternTextField
            // 
            this.dashPatternTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashPatternTextField.Location = new System.Drawing.Point(10, 144);
            this.dashPatternTextField.Name = "dashPatternTextField";
            this.dashPatternTextField.Size = new System.Drawing.Size(155, 25);
            this.dashPatternTextField.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Dash Pattern:";
            // 
            // borderThicknessNumericField
            // 
            this.borderThicknessNumericField.DecimalPlaces = 1;
            this.borderThicknessNumericField.Location = new System.Drawing.Point(10, 92);
            this.borderThicknessNumericField.Name = "borderThicknessNumericField";
            this.borderThicknessNumericField.Size = new System.Drawing.Size(63, 25);
            this.borderThicknessNumericField.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Border Thickness:";
            // 
            // borderStylePreviewPanel
            // 
            this.borderStylePreviewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderStylePreviewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.borderStylePreviewPanel.Location = new System.Drawing.Point(271, 144);
            this.borderStylePreviewPanel.Name = "borderStylePreviewPanel";
            this.borderStylePreviewPanel.Size = new System.Drawing.Size(195, 26);
            this.borderStylePreviewPanel.TabIndex = 8;
            this.borderStylePreviewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.borderStylePreviewPanel_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preview:";
            // 
            // borderStyleComboBox
            // 
            this.borderStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.borderStyleComboBox.FormattingEnabled = true;
            this.borderStyleComboBox.Items.AddRange(new object[] {
            "Solid",
            "Dashed"});
            this.borderStyleComboBox.Location = new System.Drawing.Point(170, 144);
            this.borderStyleComboBox.Name = "borderStyleComboBox";
            this.borderStyleComboBox.Size = new System.Drawing.Size(94, 26);
            this.borderStyleComboBox.TabIndex = 6;
            this.borderStyleComboBox.SelectionChangeCommitted += new System.EventHandler(this.borderStyleComboBox_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Border Style:";
            // 
            // borderColorPreviewPanel
            // 
            this.borderColorPreviewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.borderColorPreviewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(129)))), ((int)(((byte)(227)))));
            this.borderColorPreviewPanel.Location = new System.Drawing.Point(384, 23);
            this.borderColorPreviewPanel.Name = "borderColorPreviewPanel";
            this.borderColorPreviewPanel.Size = new System.Drawing.Size(82, 25);
            this.borderColorPreviewPanel.TabIndex = 4;
            this.borderColorPreviewPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.borderColorPreviewPanel_MouseClick);
            // 
            // borderColorTextField
            // 
            this.borderColorTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderColorTextField.Location = new System.Drawing.Point(208, 23);
            this.borderColorTextField.Name = "borderColorTextField";
            this.borderColorTextField.Size = new System.Drawing.Size(170, 25);
            this.borderColorTextField.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Color:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Has Border:";
            // 
            // hasBorderSwitch
            // 
            this.hasBorderSwitch.BackColor = System.Drawing.Color.LightGray;
            this.hasBorderSwitch.BorderThickness = 1;
            this.hasBorderSwitch.CurrentState = ALMSTWKND.UI.WindowsForms.Controls.Switch.SwitchStates.Off;
            this.hasBorderSwitch.Location = new System.Drawing.Point(79, 28);
            this.hasBorderSwitch.Name = "hasBorderSwitch";
            this.hasBorderSwitch.OffStateBackgroundActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(63)))), ((int)(((byte)(92)))));
            this.hasBorderSwitch.OffStateBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            this.hasBorderSwitch.OffStateBackgroundHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.hasBorderSwitch.OffStateBorderActiveColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OffStateBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(30)))), ((int)(((byte)(72)))));
            this.hasBorderSwitch.OffStateBorderHighlightColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OffStateDisabledBackgroundColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OffStateDisabledBorderColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OffStateDisabledToggleBackgroundColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OffStateDisabledToggleBorderColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OffStateToggleBackgroundActiveColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OffStateToggleBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(30)))), ((int)(((byte)(72)))));
            this.hasBorderSwitch.OffStateToggleBackgroundHighlightColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OffStateToggleBorderActiveColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OffStateToggleBorderColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OffStateToggleBorderHighlightColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OnStateBackgroundActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(251)))), ((int)(((byte)(175)))));
            this.hasBorderSwitch.OnStateBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(245)))), ((int)(((byte)(226)))));
            this.hasBorderSwitch.OnStateBackgroundHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(248)))), ((int)(((byte)(205)))));
            this.hasBorderSwitch.OnStateBorderActiveColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OnStateBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(255)))), ((int)(((byte)(136)))));
            this.hasBorderSwitch.OnStateBorderHighlightColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OnStateDisabledBackgroundColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OnStateDisabledBorderColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OnStateDisabledToggleBackgroundColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OnStateDisabledToggleBorderColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OnStateToggleBackgroundActiveColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OnStateToggleBackgroundColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OnStateToggleBackgroundHighlightColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OnStateToggleBorderActiveColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OnStateToggleBorderColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.OnStateToggleBorderHighlightColor = System.Drawing.Color.Empty;
            this.hasBorderSwitch.Size = new System.Drawing.Size(53, 15);
            this.hasBorderSwitch.TabIndex = 0;
            this.hasBorderSwitch.Text = "switch1";
            this.hasBorderSwitch.ToggleBorderThickness = 1;
            this.hasBorderSwitch.ToggleDistanceFromEdge = 5;
            this.hasBorderSwitch.ToggleWidth = 5;
            this.hasBorderSwitch.UsingCustomStyles = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.hasFillingSwitch);
            this.groupBox2.Controls.Add(this.fillingColorPreviewPanel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 102);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filling Properties";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Has Filling:";
            // 
            // hasFillingSwitch
            // 
            this.hasFillingSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(227)))), ((int)(((byte)(224)))));
            this.hasFillingSwitch.BorderThickness = 0;
            this.hasFillingSwitch.CurrentState = ALMSTWKND.UI.WindowsForms.Controls.Switch.SwitchStates.Off;
            this.hasFillingSwitch.Location = new System.Drawing.Point(76, 24);
            this.hasFillingSwitch.Name = "hasFillingSwitch";
            this.hasFillingSwitch.OffStateBackgroundActiveColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OffStateBackgroundColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OffStateBackgroundHighlightColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OffStateBorderActiveColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OffStateBorderColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OffStateBorderHighlightColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OffStateDisabledBackgroundColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OffStateDisabledBorderColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OffStateDisabledToggleBackgroundColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OffStateDisabledToggleBorderColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OffStateToggleBackgroundActiveColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OffStateToggleBackgroundColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OffStateToggleBackgroundHighlightColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OffStateToggleBorderActiveColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OffStateToggleBorderColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OffStateToggleBorderHighlightColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OnStateBackgroundActiveColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OnStateBackgroundColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OnStateBackgroundHighlightColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OnStateBorderActiveColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OnStateBorderColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OnStateBorderHighlightColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OnStateDisabledBackgroundColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OnStateDisabledBorderColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OnStateDisabledToggleBackgroundColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OnStateDisabledToggleBorderColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OnStateToggleBackgroundActiveColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OnStateToggleBackgroundColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OnStateToggleBackgroundHighlightColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OnStateToggleBorderActiveColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OnStateToggleBorderColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.OnStateToggleBorderHighlightColor = System.Drawing.Color.Empty;
            this.hasFillingSwitch.Size = new System.Drawing.Size(53, 15);
            this.hasFillingSwitch.TabIndex = 13;
            this.hasFillingSwitch.Text = "switch1";
            this.hasFillingSwitch.ToggleBorderThickness = 0;
            this.hasFillingSwitch.ToggleDistanceFromEdge = 0;
            this.hasFillingSwitch.ToggleWidth = 0;
            this.hasFillingSwitch.UsingCustomStyles = false;
            // 
            // fillingColorPreviewPanel
            // 
            this.fillingColorPreviewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(129)))), ((int)(((byte)(227)))));
            this.fillingColorPreviewPanel.Location = new System.Drawing.Point(170, 42);
            this.fillingColorPreviewPanel.Name = "fillingColorPreviewPanel";
            this.fillingColorPreviewPanel.Size = new System.Drawing.Size(82, 25);
            this.fillingColorPreviewPanel.TabIndex = 5;
            this.fillingColorPreviewPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fillingColorPreviewPanel_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Color:";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(409, 306);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // RectangleShapePropertiesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(496, 341);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Saira", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RectangleShapePropertiesWindow";
            this.Text = "Shape Properties";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderThicknessNumericField)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Switch hasBorderSwitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox borderColorTextField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox borderStyleComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel borderColorPreviewPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel borderStylePreviewPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown borderThicknessNumericField;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel fillingColorPreviewPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox dashPatternTextField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Switch switch1;
        private Switch hasFillingSwitch;
    }
}