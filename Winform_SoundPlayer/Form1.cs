using System.Media;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;
using System;
using System.Drawing.Imaging;
using System.Runtime.InteropServices.ComTypes;

namespace Winform_SoundPlayer
{
    public partial class Form1 : Form
    {
        public string command { get; set; }

        public string pathFileName { get; set; } = @"D:\uni\LTTQ\WpfApp4\Chuong4_NguyenThaiDangKhoa_22520679\Winform_SoundPlayer\Assets\champion-80bpm-132686.mp3";
        [DllImport("winmm.dll")]
        private static extern int mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);
        public Form1()
        {
            InitializeComponent();
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = pathFileName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "WAV File|*.wav|MIDI File|*.midi|MP3 file|*.mp3";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pathFileName = dlg.FileName;
            }
            command = "open \"" + pathFileName + "\" type mpegvideo alias MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command = "play MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            command = "close MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            command = "pause MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }
    }
}
