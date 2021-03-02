using System;
using static System.Math;
using System.ComponentModel;
using System.Windows.Forms;

namespace OpenGLFunctionOnGraph
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ReadProperties();
        }
        private void ReadProperties()
        {
            renderControl1.YMax = (double)MaxY.Value;
            renderControl1.YMin = (double)LowY.Value;
            renderControl1.XMax = (double)MaxX.Value;
            renderControl1.XMin = (double)LowX.Value;
            renderControl1.PointsCount = (int)PointsCount.Value;
            renderControl1.GraphDiv = (float)GraphDivs.Value;
            if (radioButton6.Checked) AutoPropState(false);
            else AutoPropState(true);
            if (radioButton1.Checked)
                renderControl1.GraphFunction = new Func<double, double>((x) => Tan(PI / 2 * Cos(PI * x)) + Sin(2 * PI * x));
            else
                renderControl1.GraphFunction = new Func<double, double>((x) => Pow(Sin(x + 1), 2) * Pow(Cos(2 * x - 1), 3));
        }

        private void AutoPropState(bool state)
        {
            SetAdditionalPropControlsState(state);
            renderControl1.IsYDifferenceAuto = !state;
        }
        public void SetAdditionalPropControlsState(bool state)
        {
            LowY.Enabled = state;
            MaxY.Enabled = state;
        }

        private void XValidattion(object sender, CancelEventArgs e)
        {
            if (MaxX.Value <= LowX.Value)
            {
                MessageBox.Show("Правая граница должна быть больше левой!");
                e.Cancel = true;
            }
        }
        private void YValidattion(object sender, CancelEventArgs e)
        {
            if (MaxY.Value <= LowY.Value)
            {
                MessageBox.Show("Нижняя граница должна быть меньше верхней!");
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadProperties();
            renderControl1.Invalidate();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            AutoPropState(true);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            AutoPropState(false);
        }
    }
}
