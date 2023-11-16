namespace BaoCao
{
    partial class frmMain
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
            this.btnSa = new System.Windows.Forms.Button();
            this.btnLS = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGiaGiay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSa
            // 
            this.btnSa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSa.Location = new System.Drawing.Point(593, 102);
            this.btnSa.Name = "btnSa";
            this.btnSa.Size = new System.Drawing.Size(255, 148);
            this.btnSa.TabIndex = 3;
            this.btnSa.Text = "Giày";
            this.btnSa.UseVisualStyleBackColor = false;
            this.btnSa.Click += new System.EventHandler(this.btnSa_Click_1);
            // 
            // btnLS
            // 
            this.btnLS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLS.Location = new System.Drawing.Point(248, 271);
            this.btnLS.Name = "btnLS";
            this.btnLS.Size = new System.Drawing.Size(261, 148);
            this.btnLS.TabIndex = 2;
            this.btnLS.Text = "Loại Giày";
            this.btnLS.UseVisualStyleBackColor = false;
            this.btnLS.Click += new System.EventHandler(this.btnLS_Click_1);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.Location = new System.Drawing.Point(248, 102);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(261, 148);
            this.btnKhachHang.TabIndex = 3;
            this.btnKhachHang.Text = "Thành viên";
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKh_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BaoCao.Properties.Resources.Hinh_anh_bau_troi_trong_xanh_dep;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1082, 571);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnGiaGiay
            // 
            this.btnGiaGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaGiay.Location = new System.Drawing.Point(593, 271);
            this.btnGiaGiay.Name = "btnGiaGiay";
            this.btnGiaGiay.Size = new System.Drawing.Size(255, 151);
            this.btnGiaGiay.TabIndex = 4;
            this.btnGiaGiay.Text = "Giá Giày";
            this.btnGiaGiay.UseVisualStyleBackColor = true;
            this.btnGiaGiay.Click += new System.EventHandler(this.btnGiaGiay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Admin";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1082, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiaGiay);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.btnSa);
            this.Controls.Add(this.btnLS);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSa;
        private System.Windows.Forms.Button btnLS;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnGiaGiay;
        private System.Windows.Forms.Label label1;
    }
}

