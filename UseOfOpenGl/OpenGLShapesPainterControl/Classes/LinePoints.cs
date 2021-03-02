using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenGLShapesPainterControl.Classes
{
    public struct LinePoints
    {
        public float StartX { get; set; }
        public float EndX { get; set; }
        public float StartY { get; set; }
        public float EndY { get; set; }
        public LinePoints(float startX, float startY, float endX, float endY)
        {
            StartX = startX;
            StartY = startY;
            EndX = endX;
            EndY = endY;
        }

    }
}
