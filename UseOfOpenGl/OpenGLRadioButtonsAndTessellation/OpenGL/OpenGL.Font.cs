using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace OpenGLRadioButtonsAndTessellation
{
    public partial class OpenGL
    {
        protected uint nFont;
        protected ABC[] abc = new ABC[256];
        protected TEXTMETRIC tm = new TEXTMETRIC();

        private readonly Encoding ascii = Encoding.GetEncoding(1251);
        private readonly Encoding unicode = Encoding.Unicode;

        public enum Vertical { Baseline = 0, Top, Middle, Bottom };
        public enum Horizontal { Left = 0, Centered, Right };

        private Vertical alignment;
        private Horizontal justification;
        private bool origin;
        private Color originColor;

        [Category("OpenGL")]
        public Color OriginColor
        {
            get { return originColor; }
            set { originColor = value; Invalidate(); }
        }

        [Category("OpenGL")]
        public bool TextOrigin
        {
            get { return origin; }
            set { origin = value; Invalidate(); }
        }

        [Category("OpenGL")]
        public Vertical TextAlignment
        {
            get { return alignment; }
            set { alignment = value; Invalidate(); }
        }

        [Category("OpenGL")]
        public Horizontal TextJustification
        {
            get { return justification; }
            set { justification = value; Invalidate(); }
        }

        protected void LoadFont(IntPtr hDC)
        {
            if (glIsList(nFont) != 0)
                glDeleteLists(nFont, 256);

            //Font
            SelectObject(hDC, Font.ToHfont());
            nFont = glGenLists(256);
            wglUseFontBitmaps(hDC, 0, 256, nFont);

            GetCharABCWidths(hDC, 0, 255, ref abc[0]);
            GetTextMetrics(hDC, ref tm);
        }

        private void OnFontChange(object sender, EventArgs e)
        {
            IntPtr hDC = GetDC(hWnd);
            wglMakeCurrent(hDC, hRC);

            LoadFont(hDC);

            wglMakeCurrent(hDC, IntPtr.Zero);
            ReleaseDC(hWnd, hDC);
        }

        protected void OutText(string s, double x, double y, double z = 0)
        {
            byte[] unicodeBytes = unicode.GetBytes(s);
            byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);
            double[] xx = new double[asciiBytes.Length];
            double[] yy = new double[asciiBytes.Length];

            // Origin point
            if (TextOrigin)
            {
                glPushAttrib(GL_CURRENT_BIT);
                glPointSize(1); glColor(OriginColor);
                glBegin(GL_POINTS);
                glVertex3d(x + 0, y + 0, z);
                glVertex3d(x + 2, y + 0, z); glVertex3d(x - 2, y + 0, z);
                glVertex3d(x + 0, y + 2, z); glVertex3d(x + 0, y - 2, z);
                glEnd();
                glPopAttrib();
            }

            RectangleF r = TextRectangle(x, y, s);

            if (TextAlignment == Vertical.Top) y -= (r.Bottom - y);
            else if (TextAlignment == Vertical.Bottom) y += (y - r.Top);
            else if (TextAlignment == Vertical.Middle) y += (y - (r.Top + r.Bottom) / 2);

            if (TextJustification == Horizontal.Right) x -= (r.Right - x);
            else if (TextJustification == Horizontal.Centered) x += (x - (r.Right + r.Left) / 2);

            xx[0] = yy[0] = 0;
            for (int i = 0; i < asciiBytes.Length - 1; i++)
            {
                xx[i + 1] = CharWidth(asciiBytes[i]);
                yy[i + 1] = 0;
            }

            gluScreenToWorld(xx, ref xx, yy, ref yy);

            glListBase(nFont);

            for (int i = 0; i < asciiBytes.Length; i++)
            {
                x += (float)(xx[i] - xx[0]);
                glRasterPos3d(x, y, z);
                glCallList(asciiBytes[i] + (uint)1);
            }
        }

        private long CharWidth(int i)
        {
            return abc[i].abcA + abc[i].abcC + abc[i].abcB;
        }

        /// <summary>
        ///  Measure text width in pixels
        /// </summary>
        /// <param name="s">Measured text</param>
        /// <returns>width in pixels</returns>
        private long MeasureText(string s)
        {
            byte[] unicodeBytes = unicode.GetBytes(s);
            byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);

            long width = 0;

            for (int i = 0; i < asciiBytes.Length; i++)
                width += CharWidth(asciiBytes[i]);

            return width;
        }

        private RectangleF TextRectangle(double x, double y, string s)
        {
            // Tan of italic angle
            const double tan18deg = 0.32491969623290632615587141221513;
            // string witdth in pixels
            double pxWidth = MeasureText(s);
            double tanItalicAngle = tm.tmItalic != 0 ? tan18deg : 0;

            double[] xx = new[] { 0.0, pxWidth, tm.tmDescent * tanItalicAngle, tm.tmAscent * tanItalicAngle };
            double[] yy = new[] { 0.0, tm.tmHeight, tm.tmDescent, tm.tmAscent };

            gluScreenToWorld(xx, ref xx, yy, ref yy);

            x -= (xx[2] - xx[0]); // shift left for italic
            y -= (yy[2] - yy[0]); // shift from baseline to bottom border

            RectangleF r = new RectangleF((float)x, (float)y, (float)(xx[1] - 2 * xx[0] + xx[3]), (float)(yy[1] - yy[0]));

            return r;
        }
    }
}