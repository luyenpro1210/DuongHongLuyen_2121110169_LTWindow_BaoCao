namespace BaoCao
{
    partial class frmKhachHangcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.mtxtMTV = new System.Windows.Forms.MaskedTextBox();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.gbDS = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.btnXDS = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnTDS = new System.Windows.Forms.Button();
            this.gbCN = new System.Windows.Forms.GroupBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLogo = new System.Windows.Forms.Label();
            this.gbNTT = new System.Windows.Forms.GroupBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.mtxtNS = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.gbDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.gbCN.SuspendLayout();
            this.gbNTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // mtxtMTV
            // 
            this.mtxtMTV.Location = new System.Drawing.Point(170, 52);
            this.mtxtMTV.Mask = "21000";
            this.mtxtMTV.Name = "mtxtMTV";
            this.mtxtMTV.Size = new System.Drawing.Size(149, 22);
            this.mtxtMTV.TabIndex = 10;
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(170, 93);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(149, 22);
            this.txtHT.TabIndex = 6;
            // 
            // gbDS
            // 
            this.gbDS.Controls.Add(this.dgvDanhSach);
            this.gbDS.Location = new System.Drawing.Point(430, 228);
            this.gbDS.Name = "gbDS";
            this.gbDS.Size = new System.Drawing.Size(650, 290);
            this.gbDS.TabIndex = 7;
            this.gbDS.TabStop = false;
            this.gbDS.Text = "Danh sách";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(6, 21);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(635, 150);
            this.dgvDanhSach.TabIndex = 1;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // btnXDS
            // 
            this.btnXDS.Location = new System.Drawing.Point(282, 40);
            this.btnXDS.Name = "btnXDS";
            this.btnXDS.Size = new System.Drawing.Size(75, 34);
            this.btnXDS.TabIndex = 0;
            this.btnXDS.Text = "Xóa DS";
            this.btnXDS.UseVisualStyleBackColor = true;
            this.btnXDS.Click += new System.EventHandler(this.btnXDS_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(521, 40);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(75, 34);
            this.btnE.TabIndex = 0;
            this.btnE.Text = "Thoát";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnTDS
            // 
            this.btnTDS.Location = new System.Drawing.Point(18, 40);
            this.btnTDS.Name = "btnTDS";
            this.btnTDS.Size = new System.Drawing.Size(105, 34);
            this.btnTDS.TabIndex = 0;
            this.btnTDS.Text = "Thêm vào DS";
            this.btnTDS.UseVisualStyleBackColor = true;
            this.btnTDS.Click += new System.EventHandler(this.btnTDS_Click);
            // 
            // gbCN
            // 
            this.gbCN.Controls.Add(this.btnLoc);
            this.gbCN.Controls.Add(this.btnSua);
            this.gbCN.Controls.Add(this.btnXDS);
            this.gbCN.Controls.Add(this.btnE);
            this.gbCN.Controls.Add(this.btnTDS);
            this.gbCN.Location = new System.Drawing.Point(426, 101);
            this.gbCN.Name = "gbCN";
            this.gbCN.Size = new System.Drawing.Size(654, 100);
            this.gbCN.TabIndex = 6;
            this.gbCN.TabStop = false;
            this.gbCN.Text = "Chức năng";
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(391, 40);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(79, 34);
            this.btnLoc.TabIndex = 1;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(165, 40);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 34);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Thành Viên";
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogo.ForeColor = System.Drawing.Color.Red;
            this.lbLogo.Location = new System.Drawing.Point(383, 25);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(361, 32);
            this.lbLogo.TabIndex = 5;
            this.lbLogo.Text = "THÔNG TIN THÀNH VIÊN";
            // 
            // gbNTT
            // 
            this.gbNTT.Controls.Add(this.cbGioiTinh);
            this.gbNTT.Controls.Add(this.mtxtNS);
            this.gbNTT.Controls.Add(this.mtxtMTV);
            this.gbNTT.Controls.Add(this.txtHT);
            this.gbNTT.Controls.Add(this.label5);
            this.gbNTT.Controls.Add(this.label4);
            this.gbNTT.Controls.Add(this.label3);
            this.gbNTT.Controls.Add(this.label2);
            this.gbNTT.Location = new System.Drawing.Point(12, 101);
            this.gbNTT.Name = "gbNTT";
            this.gbNTT.Size = new System.Drawing.Size(393, 417);
            this.gbNTT.TabIndex = 4;
            this.gbNTT.TabStop = false;
            this.gbNTT.Text = "Nhập thông tin";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(170, 175);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(149, 24);
            this.cbGioiTinh.TabIndex = 12;
            // 
            // mtxtNS
            // 
            this.mtxtNS.Location = new System.Drawing.Point(170, 138);
            this.mtxtNS.Mask = "00/00/0000";
            this.mtxtNS.Name = "mtxtNS";
            this.mtxtNS.Size = new System.Drawing.Size(149, 22);
            this.mtxtNS.TabIndex = 11;
            this.mtxtNS.ValidatingType = typeof(System.DateTime);
            // 
            // frmKhachHangcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1112, 619);
            this.Controls.Add(this.gbDS);
            this.Controls.Add(this.gbCN);
            this.Controls.Add(this.lbLogo);
            this.Controls.Add(this.gbNTT);
            this.Name = "frmKhachHangcs";
            this.Text = "frmKhachHangcs";
            this.Load += new System.EventHandler(this.frmKhachHangcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.gbDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.gbCN.ResumeLayout(false);
            this.gbNTT.ResumeLayout(false);
            this.gbNTT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.GroupBox gbDS;
        private System.Windows.Forms.GroupBox gbCN;
        private System.Windows.Forms.Button btnXDS;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnTDS;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.GroupBox gbNTT;
        private System.Windows.Forms.MaskedTextBox mtxtMTV;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtNS;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.ComboBox cbGioiTinh;
    }
}