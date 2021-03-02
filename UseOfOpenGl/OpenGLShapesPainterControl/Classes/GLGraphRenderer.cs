using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OpenGLShapesPainterControl.Classes
{
    public class GLGraphRenderer
    {
        public bool IsShowGrid { get; set; } = false;

        private RenderControl _glRenderControl;

        private float startX = 0, startY = 0;
        private float endX = 10, endY = 10;
        private int countOfXLines = 10, countOfYLines = 10;

        private List<Element> elementsToDraw;

        public GLGraphRenderer(RenderControl glRenderControl)
        {
            _glRenderControl = glRenderControl;
            _glRenderControl.OnUpdatePicture += PaintGraph;
            elementsToDraw = new List<Element>();
        }

        public void AddFigure(Element element)
        {
            elementsToDraw.Add(element);
        }

        public void SetGraphBaseCoordinates(float xStart, float yStart, float xEnd, float yEnd)
        {
            _glRenderControl.ClearScreenAndBrush();
            this.startX = xStart;
            this.endX = xEnd;
            this.startY = yStart;
            this.endY = yEnd;
        }

        public void SetCountOfDivisions(int xCount, int yCount)
        {
            countOfXLines = xCount;
            countOfYLines = yCount;
        }

        public void UpdateGraph()
        {
            _glRenderControl.Refresh();
        }

        private void PaintGraph()
        {
            _glRenderControl.ClearScreenAndBrush();
            _glRenderControl.SetCoordinateBase(startX, startY, endX, endY);
            _glRenderControl.CurrentLineWidth = 3;
            if (IsShowGrid)
            {
                _glRenderControl.SetPaintColor(Color.Green);
                RenderGrid();
            }
            foreach (var element in elementsToDraw)
            {
                _glRenderControl.CurrentLineWidth = 10;
                _glRenderControl.SetPaintColor(element.ElementColor);
                element.Algoritm.Paint(_glRenderControl, element.ElementPoints, element.ElementColor);
            }
        }

        private void RenderGrid()
        {
            _glRenderControl.CurrentLineWidth = 5;
            _glRenderControl.PaintLine(new LinePoints(startX, startY, startX, endY));
            _glRenderControl.PaintLine(new LinePoints(startX, startY, endX, startY));

            _glRenderControl.SetLineStyle(LineStyle.Stipple);

            float xStep = (Math.Abs(startX) + Math.Abs(endX)) / countOfXLines;
            float yStep = (Math.Abs(startY) + Math.Abs(endY)) / countOfYLines;

            _glRenderControl.CurrentLineWidth = 2;
            _glRenderControl.PaintParallelLanes(
                new LinePoints(startX + xStep, startY, startX + xStep, endY),
                xStep,
                0,
                countOfXLines - 1
            );
            _glRenderControl.PaintParallelLanes(
                new LinePoints(startX, startY + yStep, endX, startY + yStep),
                0,
                yStep,
                countOfYLines - 1
             );
            _glRenderControl.SetLineStyle(LineStyle.Solid);
        }
    }
}
