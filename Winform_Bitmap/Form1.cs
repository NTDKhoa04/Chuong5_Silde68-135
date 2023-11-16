using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Bitmap
{
    public partial class Form1 : Form
    {
        public static Image image { get; set; }
        public static Bitmap bitmap1 { get; set; }
        public Form1()
        {
            InitializeComponent();
            image = Image.FromFile(@"D:\uni\LTTQ\WpfApp4\Chuong4_NguyenThaiDangKhoa_22520679\Winform_Bitmap\Assets\maxresdefault.jpg");
            bitmap1 = new Bitmap(image);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(bitmap1, 0, 0, bitmap1.Width, bitmap1.Height);
            for (int i = 100; i < 200; i++)
            {
                for (int j = 100; j < 200; j++)
                {
                    Color curColor = bitmap1.GetPixel(i, j);
                    int ret = (curColor.R + curColor.G + curColor.B) / 3;
                    bitmap1.SetPixel(i, j, Color.FromArgb(ret, ret, ret));
                }
            }
            g.DrawImage(bitmap1, 0, 0, bitmap1.Width, bitmap1.Height);
        }
    }
}
