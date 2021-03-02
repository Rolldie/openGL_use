using System;
using System.Windows.Forms;

namespace OpenGLRadioButtonsAndTessellation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            renderControl1.Invalidated += UpdateRadioButtons;
        }
        private bool checkedChanging = true;
        private void UpdateRadioButtons(object sender, InvalidateEventArgs e)
        {
            var style = renderControl1.ShapesStyle;
            checkedChanging = false;
            switch (style)
            {

                case ShowStyle.Fill:
                    radioButton1.Checked = true;
                    break;
                case ShowStyle.Line:
                    radioButton2.Checked = true;
                    break;
                case ShowStyle.Point:
                    radioButton3.Checked = true;
                    break;
            }
            checkedChanging = true;
        }

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkedChanging)
                renderControl1.SetNewStyle(ShowStyle.Fill);
        }


        private void OnCountChanged(object sender, EventArgs arg)
        {
            renderControl1.CountOfHorizontalShapes = (int)numericHorizontal.Value;
            renderControl1.CountOfVerticleShapes = (int)numericVertical.Value;

            renderControl1.Invalidate();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkedChanging)
                renderControl1.SetNewStyle(ShowStyle.Line);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkedChanging)
                renderControl1.SetNewStyle(ShowStyle.Point);
        }
    }
}
