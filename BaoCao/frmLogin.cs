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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tendn = txtDN.Text.Trim();
            string matkhau = MaHoa.ToShA1(txtMK.Text.Trim());
            ThanhVienDAO tvDAO = new ThanhVienDAO();
            ThanhVien thanhvien = tvDAO.getRow(tendn, matkhau);
            if (thanhvien == null)
            {
                lblThongBao.Text = "Tài khoản không chính xác";
            }
            else
            {
                frmMain.thanhvien = thanhvien;
                this.Close();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }

        }
    }
}
