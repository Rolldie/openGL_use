using OpenGLShapesPainterControl.Algoritm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OpenGLShapesPainterControl.Classes
{
    public class Shape : Element
    {
        public override IEnumerable<FloatPoint> ElementPoints { get; set; }
        public override Color ElementColor { get; set; }
        public override IPaintAlgoritm Algoritm { get; set; }

        public Shape(IEnumerable<FloatPoint> points, Color color)
        {
            Algoritm = new ShapePaint();
            ElementPoints = points;
            ElementColor = color;
        }
    }
}
