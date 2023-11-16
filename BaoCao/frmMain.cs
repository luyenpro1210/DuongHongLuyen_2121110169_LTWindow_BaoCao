using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static ThanhVien thanhvien = null;
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (thanhvien == null)
            {
                this.Hide();
                Form frmdn = new frmLogin();
                frmdn.ShowDialog();
            }
            if (thanhvien != null)
            {
                //ToolStripStatusLabelThanhVien.Text = thanhvien.TenDN;
                //TabControlMain.ImageList = loadImageList();
            }

        }

        private void btnLS_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoaiGiay loaiSach = new frmLoaiGiay();
            loaiSach.ShowDialog();

        }

        private void btnSa_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGiay sach = new frmGiay();
            sach.ShowDialog();
        }

        private void btnLS_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmLoaiGiay loaiSach = new frmLoaiGiay();
            loaiSach.ShowDialog();
        }

        private void btnSa_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmGiay sach = new frmGiay();
            sach.ShowDialog();
        }

        private void btnKh_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmKhachHangcs sach = new frmKhachHangcs();
            sach.ShowDialog();

        }

        private void btnGiaGiay_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGiaGiay sach = new frmGiaGiay();
            sach.ShowDialog();

        }
    }
}
