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

namespace Winform_Image1
{
    public partial class Form1 : Form
    {
        public Image curImage {  get; set; }
        public Form1()
        {
            InitializeComponent();
            curImage = Image.FromFile(@"D:\uni\LTTQ\WpfApp4\Chuong4_NguyenThaiDangKhoa_22520679\Winform_Image\Assets\maxresdefault.jpg");

        }

       

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(200, 100, 192, 108);
            g.DrawImage(curImage, rect);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            curImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Rectangle rect = new Rectangle(200, 100, 192, 108);
            g.DrawImage(curImage, rect);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            curImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            Rectangle rect = new Rectangle(200, 100, 192, 108);
            g.DrawImage(curImage, rect);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            curImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
            Rectangle rect = new Rectangle(200, 100, 192, 108);
            g.DrawImage(curImage, rect);
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            curImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Rectangle rect = new Rectangle(200, 100, 192, 108);
            g.DrawImage(curImage, rect);
        }

        private void yToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            curImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
            Rectangle rect = new Rectangle(200, 100, 192, 108);
            g.DrawImage(curImage, rect);
        }

       
    }
}
