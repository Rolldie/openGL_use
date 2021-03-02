using OpenGLShapesPainterControl.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OpenGLShapesPainterControl
{
    public partial class MainForm : Form
    {
        private GLGraphRenderer graph;
        public MainForm()
        {
            InitializeComponent();
            graph = new Classes.GLGraphRenderer(renderControl1);
            graph.IsShowGrid = true;
        }

        private void MainForm_Load(object sender, System.EventArgs arg)
        {
            float x1 = -3.5f, x2 = 1, y1 = -0.5f, y2 = 1.5f;

            graph.SetCountOfDivisions(11, 6);
            graph.SetGraphBaseCoordinates(x1, y1, x2, y2);

            //only if x1<0 and x2>0
            float stepX = (Math.Abs(x1) + Math.Abs(x2)) / 11;
            float stepY = (Math.Abs(y1) + Math.Abs(y2)) / 6;

            List<FloatPoint> figurePoints = new List<FloatPoint>
               {
                new FloatPoint(x1+stepX,y1+stepY*2),
                new FloatPoint(x1+stepX,y1+stepY*4),
                new FloatPoint(x1+stepX*3,y1+stepY*5),
                new FloatPoint(x1+stepX*4,y1+stepY*3),
                new FloatPoint(x1+stepX*4,y1+stepY)
               };
            Element shape = new Shape(figurePoints, Color.Brown);
            graph.AddFigure(shape);

            foreach (var point in figurePoints.Select(e => new FloatPoint(e.X + stepX * 5, e.Y)))
            {
                graph.AddFigure(new Classes.Point(Color.Red, point));
            }
            graph.UpdateGraph();
        }
    }
}
