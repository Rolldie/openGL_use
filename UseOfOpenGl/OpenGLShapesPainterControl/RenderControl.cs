using OpenGLShapesPainterControl.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System;
using System.Linq;
using static System.Math;

namespace OpenGLShapesPainterControl
{
    public enum LineStyle
    {
        Solid,
        Stipple
    }
    public enum PointForm
    {
        Square,
        Round
    }


    [ToolboxItem(true), ToolboxBitmap(typeof(RenderControl), "RenderControl.bmp")]
    public partial class RenderControl : OpenGL
    {
        public float CurrentLineWidth { get; set; } = 1;
        public float CurrentPointSize { get; set; } = 1;

        public LineStyle LineStyle { get; set; } = LineStyle.Solid;
        public PointForm PointStyle { get; set; } = PointForm.Square;

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

        }


        public void SetCoordinateBase(float x1, float y1, float x2, float y2)
        {
            glViewport(0, 0, Width, Height);
            gluOrtho2D(x1, x2, y1, y2);
        }
        public void SetPaintColor(Color color)
        {
            glColor(color);
        }
        public void SetLineStyle(LineStyle style)
        {
            switch (style)
            {
                case LineStyle.Stipple:
                    glEnable(GL_LINE_STIPPLE);
                    glLineStipple(1, 0xfff);
                    break;
                case LineStyle.Solid:
                    glDisable(GL_LINE_STIPPLE);
                    break;
                default:
                    break;
            }
        }
        public void PaintLine(LinePoints points)
        {
            glLineWidth(CurrentLineWidth);
            glBegin(GL_LINES);

            glVertex2d(points.StartX, points.StartY);
            glVertex2d(points.EndX, points.EndY);
            glEnd();

        }
        public void PaintPoint(FloatPoint point)
        {
            glPointSize(CurrentPointSize);
            glBegin(GL_POINTS);
            glVertex2d(point.X, point.Y);
            glEnd();
        }
        public void PaintShape(IEnumerable<FloatPoint> points, bool isLoop)
        {
            glLineWidth(CurrentLineWidth);
            if (isLoop)
                glBegin(GL_LINE_LOOP);
            else
                glBegin(GL_LINES);
            foreach (var point in points)
            {
                glVertex2d(point.X, point.Y);
            }
            glEnd();
        }
        public void ClearScreenAndBrush()
        {
            // Clear buffers and affine transforms
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT | GL_STENCIL_BUFFER_BIT);
            glLoadIdentity();
        }

        public void PaintParallelLanes(LinePoints line, float xStep, float yStep, float count)
        {
            float sumHbyX = 0;
            float sumHbyY = 0;

            for (int i = 0; i < count; i++)
            {
                var lineToPaint = new LinePoints(
                    line.StartX + sumHbyX,
                    line.StartY + sumHbyY,
                    line.EndX + sumHbyX,
                    line.EndY + sumHbyY
                );
                PaintLine(lineToPaint);
                sumHbyX += xStep;
                sumHbyY += yStep;
            }

        }
    }
}
