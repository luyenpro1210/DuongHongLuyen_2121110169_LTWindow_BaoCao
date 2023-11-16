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
    public partial class frmGiaGiay : Form
    {
        int rowindex = -1;
        string[] listLoaiGiay = { "BITIS", "ADIDAS", "NIKE", "Converse", "Vans" };
        string[] listDVTinh = { "Đôi" };
        public frmGiaGiay()
        {
            InitializeComponent();
        }

        private void frmGiaGiay_Load(object sender, EventArgs e)
        {
            cbLoaiSP.DataSource = listLoaiGiay;
            cbDVTinh.DataSource = listDVTinh;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            double soluong;
            try
            {
                if (this.checkMaSP(mtxtMaSP.Text) == false)
                {
                    throw new Exception("Mã giày đã tồn tại");
                }
                if (txtTenSP.Text.Length.Equals(0))
                {
                    throw new Exception("Tên giày không được để trống");
                }
                if (!double.TryParse(txtSL.Text, out soluong))
                {
                    throw new Exception("Giá không phải số");
                }
                string masp = mtxtMaSP.Text;
                string tensp = txtTenSP.Text;

                string loaisp = cbLoaiSP.Text;
                string gia = txtGia.Text;
                string dvtinh = cbDVTinh.Text;


                int row = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[row].Cells["MaGiay"].Value = masp;
                dgvDanhSach.Rows[row].Cells["TenGiay"].Value = tensp;
                dgvDanhSach.Rows[row].Cells["SoLuong"].Value = soluong;
                dgvDanhSach.Rows[row].Cells["Loai"].Value = loaisp;
                dgvDanhSach.Rows[row].Cells["Gia"].Value = gia;
                dgvDanhSach.Rows[row].Cells["DVTinh"].Value = dvtinh;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        public bool checkMaSP(string masv)
        {
            if (dgvDanhSach.Rows.Count == 0)
            {
                return true;
            }
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaSV"].Value.ToString() == masv)
                {
                    return false;
                }
            }
            return true;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if (rowindex != -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
            {
                mtxtMaSP.Text = dgvDanhSach.Rows[rowindex].Cells["MaGiay"].Value.ToString();
                txtTenSP.Text = dgvDanhSach.Rows[rowindex].Cells["TenGiay"].Value.ToString();
                txtSL.Text = dgvDanhSach.Rows[rowindex].Cells["Loai"].Value.ToString();
                cbLoaiSP.Text = dgvDanhSach.Rows[rowindex].Cells["SoLuong"].Value.ToString();
                txtGia.Text = dgvDanhSach.Rows[rowindex].Cells["Gia"].Value.ToString();

                string thanhtien = dgvDanhSach.Rows[rowindex].Cells["ThanhTien"].Value.ToString();
                int i = 0;
                while (i < listDVTinh.Length && listDVTinh[i] != thanhtien)
                {
                    i++;
                }
                cbLoaiSP.SelectedIndex = i;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            double soluong;
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Mã giày phải 3 ký tự");
                }
                if (this.checkMaSP(mtxtMaSP.Text) == false)
                {
                    throw new Exception("Mã giày đã tồn tại");
                }
                if (txtTenSP.Text.Length.Equals(0))
                {
                    throw new Exception("Tên giày không được để trống");
                }
                if (!double.TryParse(txtSL.Text, out soluong))
                {
                    throw new Exception("Giá không phải số");
                }
                string masv = mtxtMaSP.Text;
                string masp = mtxtMaSP.Text;
                string tensp = txtTenSP.Text;
                string loaisp = cbLoaiSP.Text;
                string gia = txtGia.Text;
                string dvtinh = cbDVTinh.Text;
                int row = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[row].Cells["MaGiay"].Value = masp;
                dgvDanhSach.Rows[row].Cells["TenGiay"].Value = tensp;
                dgvDanhSach.Rows[row].Cells["SoLuong"].Value = soluong;
                dgvDanhSach.Rows[row].Cells["Loai"].Value = loaisp;
                dgvDanhSach.Rows[row].Cells["Gia"].Value = gia;
                dgvDanhSach.Rows[row].Cells["DVTinh"].Value = dvtinh;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên để xóa");
                }
                dgvDanhSach.Rows.RemoveAt(rowindex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát không",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
