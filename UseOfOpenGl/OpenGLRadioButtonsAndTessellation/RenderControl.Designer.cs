
namespace OpenGLRadioButtonsAndTessellation
{
    partial class RenderControl
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
            this.glRadioButtons1 = new OpenGLRadioButtonsAndTessellation.GLRadioButtons();
            this.SuspendLayout();
            // 
            // glRadioButtons1
            // 
            this.glRadioButtons1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glRadioButtons1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.glRadioButtons1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.glRadioButtons1.ForeColor = System.Drawing.Color.Black;
            this.glRadioButtons1.Location = new System.Drawing.Point(0, 0);
            this.glRadioButtons1.Margin = new System.Windows.Forms.Padding(4);
            this.glRadioButtons1.Name = "glRadioButtons1";
            this.glRadioButtons1.OriginColor = System.Drawing.Color.Empty;
            this.glRadioButtons1.RightOrientation = false;
            this.glRadioButtons1.Size = new System.Drawing.Size(241, 25);
            this.glRadioButtons1.TabIndex = 0;
            this.glRadioButtons1.TextAlignment = OpenGLRadioButtonsAndTessellation.OpenGL.Vertical.Baseline;
            this.glRadioButtons1.TextJustification = OpenGLRadioButtonsAndTessellation.OpenGL.Horizontal.Left;
            this.glRadioButtons1.TextOrigin = false;
            // 
            // RenderControl
            // 
            this.Controls.Add(this.glRadioButtons1);
            this.Name = "RenderControl";
            this.OriginColor = System.Drawing.Color.White;
            this.Size = new System.Drawing.Size(241, 193);
            this.ResumeLayout(false);

        }

        #endregion

        private GLRadioButtons glRadioButtons1;
    }
}
