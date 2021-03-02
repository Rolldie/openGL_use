using OpenGLShapesPainterControl.Algoritm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OpenGLShapesPainterControl.Classes
{
    public class Point : Element
    {
        public override IEnumerable<FloatPoint> ElementPoints { get; set; }
        public override Color ElementColor { get; set; }
        public override IPaintAlgoritm Algoritm { get; set; }

        public Point(Color color, FloatPoint point)
        {
            ElementColor = color;
            Algoritm = new PointPaint();
            ElementPoints = new List<FloatPoint> { point };
        }

    }
}
