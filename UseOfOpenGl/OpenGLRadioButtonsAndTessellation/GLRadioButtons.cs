using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenGLRadioButtonsAndTessellation
{
    [ToolboxItem(true), ToolboxBitmap(typeof(GLRadioButtons), "RenderControl.bmp")]
    public partial class GLRadioButtons : OpenGL
    {
        private List<Button> buttons;
        public bool RightOrientation { get; set; } = false;
        private int currentButtonIndex = 0;

        public delegate void ButtonClick(int buttonIndex);
        public event ButtonClick OnButtonClick;
        public int CurrentIndex
        {
            get
            {
                return currentButtonIndex;
            }
        }
        public GLRadioButtons() : base(false)
        {
            InitializeComponent();
            buttons = new List<Button>();


            var firstButton = new Button()
            {
                Text = "Fill",
                IsChecked = true
            };
            buttons.Add(firstButton);
            var secondButton = new Button()
            {
                Text = "Lines"
            };
            buttons.Add(secondButton);
            var thirdButton = new Button()
            {
                Text = "Points"
            };
            buttons.Add(thirdButton);
        }
        public override void OnStartingOpenGL()
        {
            glClearColor(BackColor);
        }

        // A once-called method before the OpenGL finalization
        public override void OnFinishingOpenGL()
        {
        }

        // The image rendering commands must be inside of this method
        public override void OnRender()
        {
            // Clear buffers and affine transforms
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT | GL_STENCIL_BUFFER_BIT);
            glLoadIdentity();
            glViewport(0, 0, Width, Height);
            gluOrtho2D(0, Width, 0, Height);

            if (RightOrientation)
            {

            }
            else
            {
                int buttonNumber = 0;
                foreach (var button in buttons)
                {
                    button.StartPoint = new Point(Width / buttons.Count * buttonNumber + 2, 2);
                    button.EndPoint = new Point(Width / buttons.Count * ++buttonNumber, Height - 2);
                    button.PaintLinesButton();
                    button.PaintButtonBackGroundButton();
                    OutText(button.Text,
                        (button.StartPoint.X + button.EndPoint.X) / 2 - button.Text.Length * 5,
                        (button.StartPoint.Y + button.EndPoint.Y) / 2 - 5);
                }
            }

        }
        public void SetActiveButton(int index)
        {
            if (index == currentButtonIndex) return;
            foreach (var button in buttons)
            {
                button.IsActive = false;
                button.IsChecked = false;
            }
            CheckButton(buttons[index]);
            this.Invalidate();
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.Button != MouseButtons.Left
                || !buttons.Any(m => m.MouseEnter)) return;

            foreach (var button in buttons)
            {

                if (button.MouseEnter)
                {
                    CheckButton(button);
                }
                else
                {
                    button.IsActive = false;
                    button.IsChecked = false;
                }
            }
            this.Invalidate();
        }
        private void CheckButton(Button button)
        {
            button.IsActive = true;
            button.IsChecked = true;
            currentButtonIndex = buttons.IndexOf(button);
            OnButtonClick(currentButtonIndex);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            foreach (var button in buttons)
            {
                if (button.IsInButton(e.Location))
                {
                    button.IsActive = true;
                    button.MouseEnter = true;
                }
                else
                {
                    button.IsActive = false;
                    button.MouseEnter = false;
                }

            }
            this.Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            foreach (var button in buttons)
            {
                if (button.IsChecked) continue;
                button.IsActive = false;
            }
            this.Invalidate();
        }

        private class Button
        {
            public Point StartPoint { get; set; }
            public Point EndPoint { get; set; }
            public string Text { get; set; } = "Value";
            public Color BackColor { get; set; } = Color.Blue;
            public Color LineColor { get; set; } = Color.Black;
            public Color ActiveButtonColor { get; set; } = Color.GreenYellow;
            public bool IsActive { get; set; } = false;
            public bool MouseEnter { get; set; } = false;
            public bool IsChecked { get; set; } = false;
            public bool IsInButton(Point position)
            {
                if (StartPoint.X <= position.X
                   && EndPoint.X >= position.X
                   && StartPoint.Y <= position.Y
                   && EndPoint.Y >= position.Y)
                    return true;
                else return false;
            }
            public void PaintLinesButton()
            {
                glColor(LineColor);
                glLineWidth(1);
                glPolygonMode(GL_FRONT, GL_LINE);
                glBegin(GL_QUADS);
                glVertex2d(StartPoint.X, StartPoint.Y);
                glVertex2d(EndPoint.X, StartPoint.Y);
                glVertex2d(EndPoint.X, EndPoint.Y);
                glVertex2d(StartPoint.X, EndPoint.Y);
                glEnd();
            }
            public void PaintButtonBackGroundButton()
            {
                if (IsActive || IsChecked)
                    glColor(ActiveButtonColor);
                else glColor(BackColor);


                glBegin(GL_QUADS);
                glPolygonMode(GL_FRONT, GL_FILL);
                glVertex2d(StartPoint.X + 0.1, StartPoint.Y + 0.1);
                glVertex2d(EndPoint.X - 0.1, StartPoint.Y + 0.1);
                glVertex2d(EndPoint.X - 0.1, EndPoint.Y - 0.1);
                glVertex2d(StartPoint.X + 0.1, EndPoint.Y - 0.1);
                glEnd();
            }
        }
    }
}
