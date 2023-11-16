using System.Drawing.Drawing2D;

namespace Winform_Clipping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect1 = new Rectangle(20, 20, 200, 200);
            Rectangle rect2 = new Rectangle(100, 100, 200, 200);
            Region rgn1 = new Region(rect1);
            Region rgn2 = new Region(rect2);
            g.SetClip(rgn1, CombineMode.Exclude);
            g.IntersectClip(rgn2);
            g.FillRectangle(Brushes.Red, 0, 0, 300, 300);
            g.ResetClip();
            g.DrawRectangle(Pens.Green, rect1);
            g.DrawRectangle(Pens.Purple, rect2);
        }
    }
}