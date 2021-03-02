using OpenGLShapesPainterControl.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OpenGLShapesPainterControl.Algoritm
{
    class PointPaint : IPaintAlgoritm
    {
        public void Paint(RenderControl control, IEnumerable<FloatPoint> figure, Color color)
        {
            var point = figure.First();
            control.CurrentPointSize = 9;
            control.SetPaintColor(color);
            control.PaintPoint(point);
        }
    }
}
