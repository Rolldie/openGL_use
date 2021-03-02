using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using static System.Math;

namespace OpenGLRadioButtonsAndTessellation
{
    public enum ShowStyle
    {
        Fill,
        Line,
        Point
    }

    [ToolboxItem(true), ToolboxBitmap(typeof(RenderControl), "RenderControl.bmp")]

    public partial class RenderControl : OpenGL
    {
        public int CountOfVerticleShapes { get; set; } = 1;
        public int CountOfHorizontalShapes { get; set; } = 1;
        public ShowStyle ShapesStyle { get; set; } = ShowStyle.Fill;
        public List<PointD> FirstShapePoints { get; set; }
        public List<PointD> SecondShapePoints { get; set; }

        private double top = 0, bottom = 0, left = 0, right = 0;
        private int a = 100;
        private double diag = 0;
        private double shapeWidthAfterFirst = 0;
        private double firstShapeWidth = 0;

        private int buttonClick;
        public RenderControl() : base(false)
        {
            InitializeComponent();
            diag = a * Cos(45 * PI / 180);
            shapeWidthAfterFirst = diag * 2 + a;
            firstShapeWidth = diag * 3 + a;

            glRadioButtons1.OnButtonClick += UpdateShapeStateByRadioButtons;
            CreateShapes();
        }
        public void UpdateShapeStateByRadioButtons(int buttonIndex)
        {
            if (buttonIndex < 3 && buttonIndex >= 0)
                ShapesStyle = (ShowStyle)buttonIndex;
            Invalidate();
        }
        public void SetNewStyle(ShowStyle style)
        {
            if (style == ShapesStyle) return;
            glRadioButtons1.SetActiveButton((int)style);
        }


        private void CreateShapes()
        {
            PointD startPoint = new PointD(0, firstShapeWidth / 2 + diag / 2);
            FirstShapePoints = new List<PointD>();
            FirstShapePoints.Add(new PointD(startPoint.X, startPoint.Y + a / 2));
            FirstShapePoints.Add(FirstShapePoints.Last().GetMovedBy(0, -a));
            FirstShapePoints.Add(FirstShapePoints.Last().GetMovedBy(diag, -diag));
            FirstShapePoints.Add(FirstShapePoints.Last().GetMovedBy(a, 0));

            SecondShapePoints = new List<PointD>();
            SecondShapePoints.Add(FirstShapePoints.Last());
            SecondShapePoints.Add(SecondShapePoints.Last().GetMovedBy(diag, -diag));
            SecondShapePoints.Add(SecondShapePoints.Last().GetMovedBy(diag, diag));
            SecondShapePoints.Add(SecondShapePoints.Last().GetMovedBy(-diag, diag));

            FirstShapePoints.Add(FirstShapePoints.Last().GetMovedBy(diag, diag));
            FirstShapePoints.Add(FirstShapePoints.Last().GetMovedBy(0, a));
            FirstShapePoints.Add(FirstShapePoints.Last().GetMovedBy(-diag, diag));
            FirstShapePoints.Add(FirstShapePoints.Last().GetMovedBy(-a, 0));
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

            glShadeModel(GL_FLAT);

            if (Height > Width)
                glViewport(0, (Height - Width) / 2, Width, Width);
            else
                glViewport((Width - Height) / 2, 0, Height, Height);
            top = right = bottom = left = 0;

            double space = (firstShapeWidth + (shapeWidthAfterFirst)
                * (CountOfHorizontalShapes > CountOfVerticleShapes ?
                CountOfHorizontalShapes - 1
                :
                CountOfVerticleShapes - 1)) / 8;

            right = firstShapeWidth + shapeWidthAfterFirst * (CountOfHorizontalShapes - 1);
            top = firstShapeWidth + shapeWidthAfterFirst * (CountOfVerticleShapes - 1);
            if (top > right)
                left = -(top - right) / 2;
            else
                bottom = -(right - top) / 2;
            right += -left;
            top += -bottom;

            right += space;
            top += space;
            bottom -= space;
            left -= space;

            gluOrtho2D(left, right, bottom, top);
            glPointSize(3);
            glLineWidth(3);
            UpdateShapesStyle();

            //painting shapes
            for (int i = 0; i < CountOfHorizontalShapes; i++)
            {
                for (int j = 0; j < CountOfVerticleShapes; j++)
                {
                    glBegin(GL_POLYGON);
                    glColor(Color.Red);
                    foreach (var point in FirstShapePoints)
                    {
                        glVertex2d(point.X + shapeWidthAfterFirst * i, point.Y + shapeWidthAfterFirst * j);
                    }
                    glEnd();
                    glBegin(GL_QUADS);
                    glColor(Color.Yellow);
                    foreach (var point in SecondShapePoints)
                    {
                        glVertex2d(point.X + shapeWidthAfterFirst * i, point.Y + shapeWidthAfterFirst * j);
                    }
                    glEnd();
                }
            }
        }
        private void UpdateShapesStyle()
        {
            switch (ShapesStyle)
            {
                case ShowStyle.Fill:
                    glPolygonMode(GL_FRONT, GL_FILL);
                    break;
                case ShowStyle.Line:
                    glPolygonMode(GL_FRONT, GL_LINE);
                    break;
                case ShowStyle.Point:
                    glPolygonMode(GL_FRONT, GL_POINT);
                    break;
            }
        }
    }
}
