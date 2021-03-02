
namespace OpenGLShapesPainterControl
{
    partial class OpenGL
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
            // OpenGL
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ForeColor = System.Drawing.Color.Black;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "OpenGL";
            this.Size = new System.Drawing.Size(200, 150);
            this.FontChanged += new System.EventHandler(this.OnFontChange);
            this.ParentChanged += new System.EventHandler(this.ControlParentChanged);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
