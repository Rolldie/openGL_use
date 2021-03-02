using System.ComponentModel;
using System.Drawing;

namespace OpenGLFunctionOnGraph
{
    [ToolboxItem(true), ToolboxBitmap(typeof(RenderControl), "RenderControl.bmp")]
    public partial class RenderControl : OpenGL
    {
        double x = 10;

        public RenderControl() : base(false)
        {
            InitializeComponent();
        }

        // A once-called method after the OpenGL initialization
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

            // Coordinate system setting
            glViewport(0, 0, Width, Height);
            gluOrtho2D(0, Width - 1, Height - 1, 0);

            glColor(ForeColor);

            // Text output example
            OutText("OpenGL version - " + glGetString(GL_VERSION), x, (2 + FontHeight) * 1);
            OutText("OpenGL vendor - " + glGetString(GL_VENDOR), x, (2 + FontHeight) * 2);
            OutText("Cyrilic test  - ъЪ эЭ юЮ яЯ ёЁ іІ їЇ", x, (2 + FontHeight) * 4);

            // Error handling example
            glOrtho(0, 0, 0, 0, 0, 0); // Error: Coordinate system can't be a point;
            uint error = glGetError();
            OutText("Error handling example: " + gluErrorString(error), x, (2 + FontHeight) * 6);

            // Rectangle example
            glColor3d(1, 0, 0);
            glLineWidth(3);
            glBegin(GL_LINE_LOOP);
            glVertex2d(4, 4);
            glVertex2d(Width - 5, 4);
            glColor3d(1, 1, 0);
            glVertex2d(Width - 5, Height - 5);
            glVertex2d(4, Height - 5);
            glEnd();
        }
    }
}
