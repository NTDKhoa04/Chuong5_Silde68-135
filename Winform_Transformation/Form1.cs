using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Winform_Transformation
{
    public partial class Form1 : Form
    {
        public static Matrix turn270 {  get; set; }
        public Form1()
        {
            InitializeComponent();
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            GraphicsPath g1=new GraphicsPath();
            g.TranslateTransform(100, 50);
            g.DrawRectangle(Pens.Red, 0, 0, 50, 50);
            g.DrawRectangle(Pens.Green, -25, -25, 50, 50);
            g.RotateTransform(45);
            g.DrawRectangle(Pens.Purple, -25, -25, 50, 50);

            g.RotateTransform(45);
            g.TranslateTransform(100, 50);
            g.DrawRectangle(Pens.Black, -25, -25, 50, 50);


            
        }
    }
}
