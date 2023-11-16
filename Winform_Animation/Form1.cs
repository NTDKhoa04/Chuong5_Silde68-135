using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Animation
{
    public partial class Form1 : Form
    {
        public Bitmap _backBuffer {  get; set; }
        public float _angle { get; set; }
        public bool _doBuffer { get; set; }


        public int x { get; set; } = 0;


        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            _doBuffer = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            checkBox1.Checked = true;
            timer2.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            _angle += 3;
            if (_angle > 359)
                _angle = 0;
            x++;

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_backBuffer == null)
            {
                _backBuffer = new Bitmap(this.ClientSize.Width,
                this.ClientSize.Height);
            }
            Graphics g = null;
            if (_doBuffer)
                g = Graphics.FromImage(_backBuffer);
            else
                g = e.Graphics;
            g.Clear(Color.White);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            int w = this.ClientSize.Width / 2;
            int h = this.ClientSize.Height / 2;
            Matrix mx = new Matrix();
            mx.Rotate(_angle, MatrixOrder.Append);
            mx.Translate(w, h, MatrixOrder.Append);
            g.Transform = mx;
            g.FillRectangle(Brushes.Red, -100, -100, 200, 200);
            mx = new Matrix();
            mx.Rotate(-_angle, MatrixOrder.Append);
            mx.Translate(w, h, MatrixOrder.Append);
            g.Transform = mx;
            g.FillRectangle(Brushes.Green, -75, -75, 149, 149);
            mx = new Matrix();
            mx.Rotate(_angle * 2, MatrixOrder.Append);
            mx.Translate(w, h, MatrixOrder.Append);
            g.Transform = mx;
            g.FillRectangle(Brushes.Blue, -50, -50, 100, 100);
            if (_doBuffer)
            {
                g.Dispose();
                e.Graphics.DrawImageUnscaled(_backBuffer, 0, 0);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                DoubleBuffered = true;
                _doBuffer = true;
            }
            else
            {
                DoubleBuffered = false;
                _doBuffer = false;
            }
        }
    }
}
