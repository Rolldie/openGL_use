using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenGLShapesPainterControl.Classes
{
    public struct FloatPoint
    {
        public float X { get; set; }
        public float Y { get; set; }
        public FloatPoint(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}
