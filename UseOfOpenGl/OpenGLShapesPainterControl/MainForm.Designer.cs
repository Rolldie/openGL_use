
namespace OpenGLShapesPainterControl
{
    partial class MainForm
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.renderControl1 = new OpenGLShapesPainterControl.RenderControl();
            this.SuspendLayout();
            // 
            // renderControl1
            // 
            this.renderControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renderControl1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.renderControl1.CurrentLineWidth = 1F;
            this.renderControl1.CurrentPointSize = 1F;
            this.renderControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.renderControl1.ForeColor = System.Drawing.Color.Black;
            this.renderControl1.LineStyle = OpenGLShapesPainterControl.LineStyle.Solid;
            this.renderControl1.Location = new System.Drawing.Point(12, 12);
            this.renderControl1.Name = "renderControl1";
            this.renderControl1.OriginColor = System.Drawing.Color.White;
            this.renderControl1.PointStyle = OpenGLShapesPainterControl.PointForm.Square;
            this.renderControl1.Size = new System.Drawing.Size(551, 341);
            this.renderControl1.TabIndex = 0;
            this.renderControl1.TextAlignment = OpenGLShapesPainterControl.OpenGL.Vertical.Baseline;
            this.renderControl1.TextJustification = OpenGLShapesPainterControl.OpenGL.Horizontal.Left;
            this.renderControl1.TextOrigin = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(575, 365);
            this.Controls.Add(this.renderControl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лаб1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

















        #endregion

        private RenderControl renderControl1;
    }
}

