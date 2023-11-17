using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_TextureBrush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private TextureBrush brush = null;
        private void TextureBrushEx_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(200, 200);
            brush = new TextureBrush(bmp);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(10, 10, 400, 300);
            g.FillRectangle(brush, rect);
        }
    }
}