
namespace OpenGLRadioButtonsAndTessellation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericVertical = new System.Windows.Forms.NumericUpDown();
            this.numericHorizontal = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.renderControl1 = new OpenGLRadioButtonsAndTessellation.RenderControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHorizontal)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fill";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 51);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Lines";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 74);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(54, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "Points";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(331, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 109);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // numericVertical
            // 
            this.numericVertical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericVertical.Location = new System.Drawing.Point(413, 20);
            this.numericVertical.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericVertical.Name = "numericVertical";
            this.numericVertical.Size = new System.Drawing.Size(39, 20);
            this.numericVertical.TabIndex = 5;
            this.numericVertical.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericVertical.ValueChanged += new System.EventHandler(this.OnCountChanged);
            // 
            // numericHorizontal
            // 
            this.numericHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericHorizontal.Location = new System.Drawing.Point(413, 46);
            this.numericHorizontal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHorizontal.Name = "numericHorizontal";
            this.numericHorizontal.Size = new System.Drawing.Size(39, 20);
            this.numericHorizontal.TabIndex = 6;
            this.numericHorizontal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHorizontal.ValueChanged += new System.EventHandler(this.OnCountChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "vertical";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "horizontal";
            // 
            // renderControl1
            // 
            this.renderControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renderControl1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.renderControl1.CountOfHorizontalShapes = 1;
            this.renderControl1.CountOfVerticleShapes = 1;
            this.renderControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.renderControl1.ForeColor = System.Drawing.Color.Black;
            this.renderControl1.Location = new System.Drawing.Point(12, 12);
            this.renderControl1.Name = "renderControl1";
            this.renderControl1.OriginColor = System.Drawing.Color.White;
            this.renderControl1.ShapesStyle = OpenGLRadioButtonsAndTessellation.ShowStyle.Fill;
            this.renderControl1.Size = new System.Drawing.Size(310, 294);
            this.renderControl1.TabIndex = 0;
            this.renderControl1.TextAlignment = OpenGLRadioButtonsAndTessellation.OpenGL.Vertical.Baseline;
            this.renderControl1.TextJustification = OpenGLRadioButtonsAndTessellation.OpenGL.Horizontal.Left;
            this.renderControl1.TextOrigin = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(464, 318);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericHorizontal);
            this.Controls.Add(this.numericVertical);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.renderControl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(480, 357);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHorizontal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

















        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericVertical;
        private System.Windows.Forms.NumericUpDown numericHorizontal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private OpenGLRadioButtonsAndTessellation.GLRadioButtons userControl12;
    }
}

