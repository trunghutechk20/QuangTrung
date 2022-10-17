using QuanLyPhongTro.ChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class frmMain : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {


        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {
            var f = new frmWelcome();
            AddForm(f);
        }
        private void AddForm(Form f)
        {
            this.grbContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;   
            f.Dock = DockStyle.Fill;
            this.grbContent.Controls.Add(f);
            f.Show();
        }

        private void loaiPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmLoaiPhong();
            AddForm(f);
        }

        private void phongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmPhong();
            AddForm(f);
        }

        private void dichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDichVu();
            AddForm(f);
        }
    }
}
