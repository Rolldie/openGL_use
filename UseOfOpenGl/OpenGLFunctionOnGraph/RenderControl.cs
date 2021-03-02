using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using static System.Math;

namespace OpenGLFunctionOnGraph
{
    [ToolboxItem(true), ToolboxBitmap(typeof(RenderControl), "RenderControl.bmp")]
    public partial class RenderControl : OpenGL
    {
        public double XMin { get; set; } = 0;
        public double XMax { get; set; } = 10;
        public double YMin { get; set; } = -10;
        public double YMax { get; set; } = 10;
        public float GraphDiv = 0.2f;

        public double PointsCount { get; set; } = 1000;
        public bool IsYDifferenceAuto { get; set; } = false;

        private double BaseFunc(double m) => 0;

        private List<PointF> zeroPoints;
        private List<PointF> figurePoints;
        private float autoYMin, autoYMax;
        private const float LIMITLESS_VALUE = 3000000;

        private Func<double, double> func;
        public Func<double, double> GraphFunction
        {
            get => func;
            set
            {
                zeroPoints = new List<PointF>();
                figurePoints = new List<PointF>();
                func = value;
                if (func == null) return;
                else UpdateLists();
            }
        }
        private void UpdateLists()
        {
            zeroPoints = new List<PointF>();
            figurePoints = new List<PointF>();
            double h = (Abs(XMax) + Abs(XMin)) / (PointsCount - 1);
            double minY = GraphFunction(XMin), maxY = minY;
            for (double i = XMin; i <= XMax; i += h)
            {
                double y = GraphFunction(i);

                figurePoints.Add(new PointF((float)i, (float)y));

                if ((y <= 0 && GraphFunction(i + h) >= 0) || (y >= 0 && GraphFunction(i + h) <= 0))
                    zeroPoints.Add(new PointF((float)(i + i + h) / 2, 0));
            }
            autoYMin = figurePoints.Min(e => e.Y);
            autoYMax = figurePoints.Max(e => e.Y);
        }
        public RenderControl() : base(false)
        {
            InitializeComponent();
            GraphFunction = new Func<double, double>(BaseFunc);
        }

        // A once-called method after the OpenGL initialization
        public override void OnStartingOpenGL()
        {
            glClearColor(Color.FromArgb(250, 250, 250, 250));
        }

        // The image rendering commands must be inside of this method
        public override void OnRender()
        {
            // Clear buffers and affine transforms
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT | GL_STENCIL_BUFFER_BIT);
            glLoadIdentity();
            // Coordinate system setting
            glViewport(0, 0, Width - 1, Height - 1);

            if (IsYDifferenceAuto)
            {
                if (autoYMin < -LIMITLESS_VALUE) YMin = -XMax;
                else YMin = autoYMin - 0.1;
                if (LIMITLESS_VALUE < autoYMax) YMax = XMax;
                else YMax = autoYMax + 0.1;
            }
            double spaceBetweenX = 0.01 * (Abs(XMax) + Abs(XMin));
            double spaceBetweenY = 0.01 * (Abs(YMax) + Abs(YMin));
            gluOrtho2D(XMin - spaceBetweenX, XMax + spaceBetweenX, YMin - spaceBetweenY, YMax + spaceBetweenY);
            glPolygonMode(GL_FRONT_AND_BACK, GL_LINE);
            glLineWidth(1);
            PaintGraph();

            glBegin(GL_QUADS);
            glColor(Color.Gray);
            glVertex2d(XMin, YMin);
            glVertex2d(XMax, YMin);
            glVertex2d(XMax, YMax);
            glVertex2d(XMin, YMax);
            glEnd();
            PaintByFunc();
            foreach (var point in zeroPoints) PaintPoint(point.X, point.Y);
            // PaintFunctionBreaks();
        }
        private void PaintByFunc()
        {
            if (GraphFunction == null) return;
            double h = (Abs(XMax) + Abs(XMin)) / (PointsCount - 1);
            glPointSize(2);
            glBegin(GL_POINTS);
            foreach (var point in figurePoints)
            {
                if (point.Y > YMax || point.Y < YMin) continue;
                glVertex2d(point.X, point.Y);
            }
            glEnd();
        }

        public void PaintFunctionBreaks()
        {
            double h = (Abs(XMax) + Abs(XMin)) / (PointsCount - 1);
            for (double move = XMin; move <= XMax; move += h)
            {
                if (GraphFunction(move) > LIMITLESS_VALUE)
                    PaintPoint(move, 0);
            }
        }
        private void PaintPoint(double x, double y)
        {
            glPointSize(5);
            glColor(Color.Red);
            glBegin(GL_POINTS);
            glVertex2d(x, y);
            glEnd();
        }
        private void PaintGraph()
        {
            glColor(Color.Black);
            glBegin(GL_LINES);
            glVertex2d(XMin, 0);
            glVertex2d(XMax, 0);
            glVertex2d(0, YMin);
            glVertex2d(0, YMax);
            double spaceBetweenY = 0.006 * (Abs(YMax) + Abs(YMin));
            double spaceBetweenX = 0.006 * (Abs(XMax) + Abs(XMin));
            for (float i = GraphDiv; i <= XMax; i += GraphDiv)
            {
                glVertex2d(i, 0 - spaceBetweenY);
                glVertex2d(i, 0 + spaceBetweenY);
            }
            for (float i = -GraphDiv; i >= XMin; i -= GraphDiv)
            {
                glVertex2d(i, 0 - spaceBetweenY);
                glVertex2d(i, 0 + spaceBetweenY);
            }
            for (float i = GraphDiv; i <= YMax; i += GraphDiv)
            {
                glVertex2d(0 - spaceBetweenX, i);
                glVertex2d(0 + spaceBetweenX, i);
            }
            for (float i = -GraphDiv; i >= YMin; i -= GraphDiv)
            {
                glVertex2d(0 + spaceBetweenX, i);
                glVertex2d(0 - spaceBetweenX, i);
            }
            glEnd();
            for (float i = GraphDiv; i <= XMax; i += GraphDiv)
            {
                OutText(i.ToString("0.0"), i, 0 - 1 / (Height * 0.06));
            }
            for (float i = -GraphDiv; i >= XMin; i -= GraphDiv)
            {
                OutText(i.ToString("0.0"), i, 0 + 1 / (Height * 0.1));
            }
            for (float i = GraphDiv; i <= YMax; i += GraphDiv)
            {
                OutText(i.ToString("0.0"), 0 + 1 / (Width * 0.006), i - spaceBetweenY);
            }
            for (float i = -GraphDiv; i >= YMin; i -= GraphDiv)
            {
                OutText(i.ToString("0.0"), 0 - 1 / (Width * 0.0025), i);
            }
        }
    }
}
