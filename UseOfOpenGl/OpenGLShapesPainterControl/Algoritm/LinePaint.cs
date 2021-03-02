using OpenGLShapesPainterControl.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OpenGLShapesPainterControl.Algoritm
{
    public class LinePaint : IPaintAlgoritm
    {
        public void Paint(RenderControl control, IEnumerable<FloatPoint> figure, Color color)
        {
            control.SetPaintColor(color);
            control.CurrentLineWidth = 10;
            control.PaintLine(new LinePoints(figure.ElementAt(0).X, figure.ElementAt(0).Y,
                figure.ElementAt(1).X, figure.ElementAt(1).Y));
        }
    }
}
