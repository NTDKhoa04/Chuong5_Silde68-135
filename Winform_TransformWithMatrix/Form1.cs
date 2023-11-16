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

namespace Winform_TransformWithMatrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddEllipse(0, 0, 100, 200);

            e.Graphics.DrawPath(Pens.Black, myPath);

            Matrix translateMatrix = new Matrix();
            translateMatrix.Translate(100, 0);
            myPath.Transform(translateMatrix);

            e.Graphics.DrawPath(new Pen(Color.Red, 2), myPath);
        }
    }
}
