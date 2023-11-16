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
    public partial class frmGiay : Form
    {
        QuanLyBanGiayContext db = new QuanLyBanGiayContext();
        GiayDAO gDAO = new GiayDAO();

            int rowindex = -1;
        string[] listngonngu = { "BITIS", "ADIDAS","NIKE", "Converse", "Vans" };
        public frmGiay()
        {
            InitializeComponent();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            cbNgonNgu.DataSource = listngonngu;
            dgvDanhSach.DataSource = gDAO.getList();
            ma.Enabled = false;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                GiayDAO giayDAO = new GiayDAO();
                Giay g  = new Giay();
                if (txtTenGiay.Text.Length.Equals(0))
                {
                    throw new Exception("Tên giày không được để trống");
                }
                if (txtKichCo.Text.Length.Equals(0))
                {
                    throw new Exception("Hãng không được để trống");
                }
               
                string ts = txtTenGiay.Text;
                int  tg = Convert.ToInt32(txtKichCo.Text.Trim());
                string nn = cbNgonNgu.Text;
               
                g.TenGiay = ts;
                g.Hang = nn;
                g.KichCo = tg;
                giayDAO.Insert(g);
                dgvDanhSach.DataSource = gDAO.getList();
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
                ma.Text = dgvDanhSach.Rows[rowindex].Cells["MaGiay"].Value.ToString();
                txtTenGiay.Text = dgvDanhSach.Rows[rowindex].Cells["TenGiay"].Value.ToString();
                txtKichCo.Text = dgvDanhSach.Rows[rowindex].Cells["KichCo"].Value.ToString();
                cbNgonNgu.Text = dgvDanhSach.Rows[rowindex].Cells["KichCo"].Value.ToString();

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn giày cần xóa!");
                }
                if (txtTenGiay.Text.Length.Equals(0))
                {
                    throw new Exception("Tên giày không được để trống");
                }
                if (txtKichCo.Text.Length.Equals(0))
                {
                    throw new Exception("Hãng không được để trống");
                }
                int maGiay = Convert.ToInt32(ma.Text.Trim());
                string ts = txtTenGiay.Text;
                int tg = Convert.ToInt32(txtKichCo.Text.Trim());
                string nn = cbNgonNgu.Text;
                Giay giay = gDAO.getRow(maGiay);
                giay.TenGiay = ts;
                giay.Hang = nn;
                giay.KichCo = tg;
                gDAO.Update(giay);
                dgvDanhSach.DataSource = gDAO.getList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maGiay = Convert.ToInt32(ma.Text.Trim());
            Giay g = gDAO.getRow(maGiay);
            gDAO.Delete(g);
            dgvDanhSach.DataSource = gDAO.getList();

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
                this.Hide();
                frmMain sach = new frmMain();
                sach.ShowDialog();
            }

        }
    }
}
