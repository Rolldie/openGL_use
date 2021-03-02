using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenGLRadioButtonsAndTessellation
{
    public class PointD
    {
        public double X { get; set; }
        public double Y { get; set; }
        public PointD(double x, double y)
        {
            X = x;
            Y = y;
        }
        public PointD(PointD point)
        {
            X = point.X;
            Y = point.Y;
        }
        public void Offset(double moveByX, double moveByY)
        {
            X += moveByX; Y += moveByY;
        }
        public PointD GetMovedBy(double moveByX, double moveByY)
        {
            var point = new PointD(this);
            point.Offset(moveByX, moveByY);
            return point;

        }
    }
}
