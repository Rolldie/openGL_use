//#define PERFORMANCE

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace OpenGLShapesPainterControl
{
   // [ToolboxItem(false), DefaultEvent("Dummy")]
    public partial class OpenGL : UserControl
    {
        public const int CS_VREDRAW = 0x01;
        public const int CS_HREDRAW = 0x02;
        public const int CS_OWNDC = 0x20;
        public const int WS_CLIPCHILDREN = 0x02000000;
        public const int WS_CLIPSIBLINGS = 0x04000000;
        public const int WS_CHILD = 0x40000000;
        public const int WS_VISIBLE = 0x10000000;
        public const int GCL_HBRBACKGROUND = (-10);

        private string errorMessage;
        protected bool hideDesigner = true;

        public delegate void RenderEvent();
        public event RenderEvent OnUpdatePicture;


        public OpenGL()
        {
            InitializeComponent();
            InitializationOpenGL();
        }

        public OpenGL(bool flag)
        {
            hideDesigner = flag;

            OnUpdatePicture += OnRender;
            InitializeComponent();
            InitializationOpenGL();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CS_VREDRAW | CS_HREDRAW | CS_OWNDC;
                cp.Style = cp.Style | WS_CLIPCHILDREN | WS_CLIPSIBLINGS | WS_CHILD | WS_VISIBLE;
                return cp;
            }
        }

        /// <summary>
        /// OpenGL render context
        /// </summary>
        protected IntPtr hRC { get; private set; }
        protected IntPtr hWnd { get { return this.Handle; } }

        public static bool IsInDesignMode
        {
            get { return System.Reflection.Assembly.GetExecutingAssembly().Location.Contains("VisualStudio"); }
        }

        private void InitializationOpenGL()
        {
            if (IsInDesignMode && hideDesigner)
            {
                Paint += OnPaintDesigner;
                return;
            }

            SetStyle(ControlStyles.Opaque, true);
            SetClassLong(hWnd, GCL_HBRBACKGROUND, 0);

            IntPtr hDC = GetDC(hWnd);

            try
            {
                hRC = IntPtr.Zero;
                PIXELFORMATDESCRIPTOR pfd = pfdDefault;
                int pixelFormat = ChoosePixelFormat(hDC, ref pfd);
                int result = SetPixelFormat(hDC, pixelFormat, ref pfd);
                hRC = wglCreateContext(hDC);

                Disposed += new EventHandler(DisposeContext);

                wglMakeCurrent(hDC, hRC);

                LoadFont(hDC);
                Paint += OnFirstPaint;

                wglMakeCurrent(hDC, IntPtr.Zero);
            }
            catch (Exception x)
            {
                errorMessage = x.Message;
                this.Paint += OnPaintError;
            }

            ReleaseDC(hWnd, hDC);
        }

        private void ControlParentChanged(object sender, EventArgs e)
        {
            if (Parent is Form)
                (Parent as Form).FormClosing += FinalizationOpenGL;
        }

        void FinalizationOpenGL(object sender, FormClosingEventArgs e)
        {
            IntPtr hDC = glBeginRender(hWnd);

            OnFinishingOpenGL();

            glEndRender(hDC);

            DisposeContext(null, null);
        }

        void DisposeContext(object sender, EventArgs e)
        {
            if (hRC == IntPtr.Zero) return;

            int res = wglDeleteContext(hRC);
            hRC = IntPtr.Zero;
        }

        private void OnFirstPaint(object sender, PaintEventArgs e)
        {
            IntPtr hDC = glBeginPaint(e.Graphics);

            try
            {
                OnStartingOpenGL();
                OnUpdatePicture.Invoke();
            }
            catch (Exception x)
            {
                OnRenderError(x.Message);
            }

            wglSwapBuffers(hDC);

            glEndRender(hDC);

            Paint -= OnFirstPaint;
            Paint += OnPaint;
        }

#if PERFORMANCE
            Stopwatch sw = new Stopwatch();
            ulong counter = 0;
#endif

        public void OnPaint(object sender, PaintEventArgs e)
        {
#if PERFORMANCE
                sw.Start();
#endif

            IntPtr hDC = glBeginPaint(e.Graphics);
            try
            {
                OnUpdatePicture.Invoke();
            }
            catch (Exception x)
            {
                OnRenderError(x.Message);
            }

            wglSwapBuffers(hDC);

            glEndRender(hDC);

#if PERFORMANCE
                sw.Stop();
                Debug.WriteLine("FPS = " + ((++counter * 1000.0) / sw.ElapsedMilliseconds).ToString());
#endif
        }
        private IntPtr glBeginPaint(Graphics g)
        {
            IntPtr hDC = g.GetHdc();
            wglMakeCurrent(hDC, hRC);
            return hDC;
        }

        private IntPtr glBeginRender(IntPtr hWnd)
        {
            IntPtr hDC = GetDC(hWnd);
            wglMakeCurrent(hDC, hRC);
            return hDC;
        }

        private void glEndRender(IntPtr hDC)
        {
            wglMakeCurrent(hDC, IntPtr.Zero);
            ReleaseDC(hWnd, hDC);
        }

        private void OnPaintDesigner(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(new SolidBrush(BackColor), this.ClientRectangle);
            g.DrawString("Open GL control. Design mode", Font, new SolidBrush(ForeColor), 5, 10);
        }

        private void OnPaintError(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, this.ClientRectangle);
            g.DrawString("GDI. " + errorMessage, DefaultFont, Brushes.Red, 10, 10);
        }

        public virtual void OnRenderError(string msg)
        {
            glLoadIdentity();
            glClearColor(Color.White);
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT | GL_STENCIL_BUFFER_BIT);

            glViewport(0, 0, Width, Height);
            glOrtho(0, Width - 1, Height - 1, 0, -1, 1);

            glColor(Color.Red);
            OutText("OpenGL. " + msg, 10, 15);
        }

        public virtual void OnStartingOpenGL() { }
        public virtual void OnFinishingOpenGL() { }

        public virtual void OnRender() { }
    }
}
