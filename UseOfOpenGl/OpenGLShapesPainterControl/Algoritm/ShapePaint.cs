using OpenGLShapesPainterControl.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OpenGLShapesPainterControl.Algoritm
{
    class ShapePaint : IPaintAlgoritm
    {
        public void Paint(RenderControl control, IEnumerable<FloatPoint> figure, Color color)
        {
            control.CurrentLineWidth = 10;
            control.SetPaintColor(color);
            foreach (var point in figure)
            {
                control.PaintShape(figure, true);
            }
        }
    }
}
