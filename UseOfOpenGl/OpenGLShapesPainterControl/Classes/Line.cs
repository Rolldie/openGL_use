using OpenGLShapesPainterControl.Algoritm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OpenGLShapesPainterControl.Classes
{
    public class Line : Element
    {
        public override IEnumerable<FloatPoint> ElementPoints { get; set; }
        public override Color ElementColor { get; set; }
        public override IPaintAlgoritm Algoritm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Line(float x1, float y1, float x2, float y2, Color color)
        {
            Algoritm = new LinePaint();
            ElementPoints = new List<FloatPoint>
            {
                new FloatPoint(x1,y1),
                new FloatPoint(x2,y2)
            };
            ElementColor = color;
        }

    }
}
