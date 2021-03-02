
namespace OpenGLFunctionOnGraph
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
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.LowX = new System.Windows.Forms.NumericUpDown();
            this.MaxX = new System.Windows.Forms.NumericUpDown();
            this.LowY = new System.Windows.Forms.NumericUpDown();
            this.MaxY = new System.Windows.Forms.NumericUpDown();
            this.PointsCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.GraphDivs = new System.Windows.Forms.NumericUpDown();
            this.renderControl1 = new OpenGLFunctionOnGraph.RenderControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LowX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphDivs)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(161, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "tg(PI/2*cos(PI*x))+sin(2*PI*x)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(136, 17);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "sin^2(x+1)*cos^3(2*x-1)";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(324, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 70);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Функция";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Location = new System.Drawing.Point(324, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 86);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Режим установки области графика";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 61);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(104, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.Text = "Все параметры";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 38);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(72, 17);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Только X";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // LowX
            // 
            this.LowX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LowX.DecimalPlaces = 1;
            this.LowX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.LowX.Location = new System.Drawing.Point(367, 180);
            this.LowX.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.LowX.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.LowX.Name = "LowX";
            this.LowX.Size = new System.Drawing.Size(47, 20);
            this.LowX.TabIndex = 7;
            this.LowX.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.LowX.Validating += new System.ComponentModel.CancelEventHandler(this.XValidattion);
            // 
            // MaxX
            // 
            this.MaxX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxX.DecimalPlaces = 1;
            this.MaxX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.MaxX.Location = new System.Drawing.Point(367, 206);
            this.MaxX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaxX.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.MaxX.Name = "MaxX";
            this.MaxX.Size = new System.Drawing.Size(47, 20);
            this.MaxX.TabIndex = 8;
            this.MaxX.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MaxX.Validating += new System.ComponentModel.CancelEventHandler(this.XValidattion);
            // 
            // LowY
            // 
            this.LowY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LowY.DecimalPlaces = 1;
            this.LowY.Enabled = false;
            this.LowY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.LowY.Location = new System.Drawing.Point(475, 180);
            this.LowY.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.LowY.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.LowY.Name = "LowY";
            this.LowY.Size = new System.Drawing.Size(47, 20);
            this.LowY.TabIndex = 9;
            this.LowY.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.LowY.Validating += new System.ComponentModel.CancelEventHandler(this.YValidattion);
            // 
            // MaxY
            // 
            this.MaxY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxY.DecimalPlaces = 1;
            this.MaxY.Enabled = false;
            this.MaxY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.MaxY.Location = new System.Drawing.Point(475, 206);
            this.MaxY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaxY.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.MaxY.Name = "MaxY";
            this.MaxY.Size = new System.Drawing.Size(47, 20);
            this.MaxY.TabIndex = 10;
            this.MaxY.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MaxY.Validating += new System.ComponentModel.CancelEventHandler(this.YValidattion);
            // 
            // PointsCount
            // 
            this.PointsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PointsCount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PointsCount.Location = new System.Drawing.Point(437, 232);
            this.PointsCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PointsCount.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PointsCount.Name = "PointsCount";
            this.PointsCount.Size = new System.Drawing.Size(85, 20);
            this.PointsCount.TabIndex = 11;
            this.PointsCount.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Low X";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Max X";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Low Y";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Max Y";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Количество точек";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(324, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "Нарисовать график";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Деления";
            // 
            // GraphDivs
            // 
            this.GraphDivs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphDivs.DecimalPlaces = 1;
            this.GraphDivs.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.GraphDivs.Location = new System.Drawing.Point(437, 258);
            this.GraphDivs.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.GraphDivs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.GraphDivs.Name = "GraphDivs";
            this.GraphDivs.Size = new System.Drawing.Size(85, 20);
            this.GraphDivs.TabIndex = 18;
            this.GraphDivs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // renderControl1
            // 
            this.renderControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renderControl1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.renderControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.renderControl1.ForeColor = System.Drawing.Color.Black;
            this.renderControl1.GraphFunction = null;
            this.renderControl1.IsYDifferenceAuto = false;
            this.renderControl1.Location = new System.Drawing.Point(12, 12);
            this.renderControl1.Name = "renderControl1";
            this.renderControl1.OriginColor = System.Drawing.Color.White;
            this.renderControl1.PointsCount = 1920D;
            this.renderControl1.Size = new System.Drawing.Size(307, 321);
            this.renderControl1.TabIndex = 0;
            this.renderControl1.TextAlignment = OpenGLFunctionOnGraph.OpenGL.Vertical.Baseline;
            this.renderControl1.TextJustification = OpenGLFunctionOnGraph.OpenGL.Horizontal.Left;
            this.renderControl1.TextOrigin = false;
            this.renderControl1.XMax = 10D;
            this.renderControl1.XMin = 0D;
            this.renderControl1.YMax = 10D;
            this.renderControl1.YMin = -10D;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(534, 345);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GraphDivs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PointsCount);
            this.Controls.Add(this.MaxY);
            this.Controls.Add(this.LowY);
            this.Controls.Add(this.MaxX);
            this.Controls.Add(this.LowX);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.renderControl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(550, 384);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LowX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphDivs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

















        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.NumericUpDown LowX;
        private System.Windows.Forms.NumericUpDown MaxX;
        private System.Windows.Forms.NumericUpDown LowY;
        private System.Windows.Forms.NumericUpDown MaxY;
        private System.Windows.Forms.NumericUpDown PointsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown GraphDivs;
    }
}

