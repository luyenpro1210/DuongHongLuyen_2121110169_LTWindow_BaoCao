using BaoCao.EF;
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
    public partial class frmKhachHangcs : Form
    {
        QuanLyBanGiayContext db = new QuanLyBanGiayContext();
        ThanhVienDAO gDAO = new ThanhVienDAO();
        public frmKhachHangcs()
        {
            InitializeComponent();
        }
        int rowindex = -1;
        string[] listGioiTinh = { "Nam", "Nữ" };
        private void btnTDS_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHT.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên khách hàng không để trống");
                }
                string hoten = txtHT.Text;
                string matv = mtxtMTV.Text;
                string ngaysinh = mtxtNS.Text;
                string gioitinh = cbGioiTinh.Text;

                int row = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[row].Cells["MaTV"].Value = matv;
                dgvDanhSach.Rows[row].Cells["TenTV"].Value = hoten;
                dgvDanhSach.Rows[row].Cells["NgaySinh"].Value = ngaysinh;
                dgvDanhSach.Rows[row].Cells["GioiTinh"].Value = gioitinh;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

        }

        private void btnXDS_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn giày để xóa");
                }
                dgvDanhSach.Rows.RemoveAt(rowindex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHT.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên khách hàng không để trống");
                }
                string hoten = txtHT.Text;
                string matv = mtxtMTV.Text;
                string ngaysinh = mtxtNS.Text;
                string gioitinh = cbGioiTinh.Text;

                dgvDanhSach.Rows[rowindex].Cells["MaTV"].Value = matv;
                dgvDanhSach.Rows[rowindex].Cells["TenTV"].Value = hoten;
                dgvDanhSach.Rows[rowindex].Cells["NgaySinh"].Value = ngaysinh;
                dgvDanhSach.Rows[rowindex].Cells["GioiTinh"].Value = gioitinh;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if (rowindex != -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
            {
                mtxtMTV.Text = dgvDanhSach.Rows[rowindex].Cells["MaTV"].Value.ToString();
                txtHT.Text = dgvDanhSach.Rows[rowindex].Cells["TenTV"].Value.ToString();
                mtxtNS.Text = dgvDanhSach.Rows[rowindex].Cells["NgaySinh"].Value.ToString();
                string gioitinh = dgvDanhSach.Rows[rowindex].Cells["GioiTinh"].Value.ToString();
                int i = 0;
                while (i < listGioiTinh.Length && listGioiTinh[i] != gioitinh)
                {
                    i++;
                }
                cbGioiTinh.SelectedIndex = i;
            }

        }

        private void frmKhachHangcs_Load(object sender, EventArgs e)
        {
            cbGioiTinh.DataSource = listGioiTinh;
            dgvDanhSach.DataSource = gDAO.getList();

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            int matv = int.Parse(cbGioiTinh.SelectedItem.ToString());
            dgvDanhSach.DataSource = listGioiTinh;
        }
    }
}
