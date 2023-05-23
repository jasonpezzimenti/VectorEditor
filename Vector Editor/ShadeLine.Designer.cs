namespace Vector_Editor
{
    partial class ShadeLine
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ShadeLine
            // 
            this.SizeChanged += new System.EventHandler(this.ShadeLine_SizeChanged);
            this.MouseLeave += new System.EventHandler(this.ShadeLine_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShadeLine_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
