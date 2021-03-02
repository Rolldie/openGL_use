using OpenGLShapesPainterControl.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OpenGLShapesPainterControl.Algoritm
{
    public interface IPaintAlgoritm
    {
        void Paint(RenderControl control, IEnumerable<FloatPoint> figure, Color color);
    }
}
