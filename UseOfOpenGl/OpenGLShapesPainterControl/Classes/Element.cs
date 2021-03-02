using OpenGLShapesPainterControl.Algoritm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OpenGLShapesPainterControl.Classes
{
    public abstract class Element
    {
        public abstract IEnumerable<FloatPoint> ElementPoints { get; set; }
        public abstract Color ElementColor { get; set; }
        public abstract IPaintAlgoritm Algoritm { get; set; }
    }
}
