namespace bth3
{
    partial class formDSSVTheoLop
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelThongTin;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblSiSo;
        private System.Windows.Forms.Panel panelTimKiem;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Label lblKetQuaTim;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblSiSo = new System.Windows.Forms.Label();
            this.panelTimKiem = new System.Windows.Forms.Panel();
            this.lblKetQuaTim = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.panelThongTin.SuspendLayout();
            this.panelTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelThongTin
            // 
            this.panelThongTin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelThongTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelThongTin.Controls.Add(this.lblTieuDe);
            this.panelThongTin.Controls.Add(this.lblMaLop);
            this.panelThongTin.Controls.Add(this.lblMonHoc);
            this.panelThongTin.Controls.Add(this.lblGhiChu);
            this.panelThongTin.Controls.Add(this.lblSiSo);
            this.panelThongTin.Location = new System.Drawing.Point(12, 12);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(960, 120);
            this.panelThongTin.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.lblTieuDe.Location = new System.Drawing.Point(350, 10);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(281, 29);
            this.lblTieuDe.TabIndex = 4;
            this.lblTieuDe.Text = "DANH SÁCH LỚP HỌC";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMaLop.Location = new System.Drawing.Point(20, 50);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(77, 20);
            this.lblMaLop.TabIndex = 0;
            this.lblMaLop.Text = "Mã lớp: ";
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMonHoc.Location = new System.Drawing.Point(20, 80);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(83, 20);
            this.lblMonHoc.TabIndex = 1;
            this.lblMonHoc.Text = "Môn học: ";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGhiChu.Location = new System.Drawing.Point(350, 50);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(72, 20);
            this.lblGhiChu.TabIndex = 2;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // lblSiSo
            // 
            this.lblSiSo.AutoSize = true;
            this.lblSiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSiSo.ForeColor = System.Drawing.Color.Red;
            this.lblSiSo.Location = new System.Drawing.Point(730, 60);
            this.lblSiSo.Name = "lblSiSo";
            this.lblSiSo.Size = new System.Drawing.Size(178, 25);
            this.lblSiSo.TabIndex = 3;
            this.lblSiSo.Text = "Sĩ số: 0 sinh viên";
            this.lblSiSo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelTimKiem
            // 
            this.panelTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTimKiem.Controls.Add(this.lblKetQuaTim);
            this.panelTimKiem.Controls.Add(this.txtTim);
            this.panelTimKiem.Controls.Add(this.lblTimKiem);
            this.panelTimKiem.Location = new System.Drawing.Point(12, 138);
            this.panelTimKiem.Name = "panelTimKiem";
            this.panelTimKiem.Size = new System.Drawing.Size(960, 60);
            this.panelTimKiem.TabIndex = 1;
            // 
            // lblKetQuaTim
            // 
            this.lblKetQuaTim.AutoSize = true;
            this.lblKetQuaTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.lblKetQuaTim.ForeColor = System.Drawing.Color.Green;
            this.lblKetQuaTim.Location = new System.Drawing.Point(600, 20);
            this.lblKetQuaTim.Name = "lblKetQuaTim";
            this.lblKetQuaTim.Size = new System.Drawing.Size(0, 18);
            this.lblKetQuaTim.TabIndex = 2;
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTim.Location = new System.Drawing.Point(150, 15);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(400, 26);
            this.txtTim.TabIndex = 1;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTimKiem.Location = new System.Drawing.Point(20, 18);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(109, 20);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm kiếm SV:";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(12, 204);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(960, 380);
            this.dgvSinhVien.TabIndex = 2;
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButton.Controls.Add(this.btnLamMoi);
            this.panelButton.Controls.Add(this.btnXuatExcel);
            this.panelButton.Controls.Add(this.btnDong);
            this.panelButton.Location = new System.Drawing.Point(12, 590);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(960, 60);
            this.panelButton.TabIndex = 3;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.Location = new System.Drawing.Point(300, 10);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 35);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.Location = new System.Drawing.Point(550, 10);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(120, 35);
            this.btnXuatExcel.TabIndex = 1;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnDong.Location = new System.Drawing.Point(800, 10);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 35);
            this.btnDong.TabIndex = 0;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // formDSSVTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.panelTimKiem);
            this.Controls.Add(this.panelThongTin);
            this.Name = "formDSSVTheoLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên theo lớp";
            this.Load += new System.EventHandler(this.formDSSVTheoLop_Load);
            this.panelThongTin.ResumeLayout(false);
            this.panelThongTin.PerformLayout();
            this.panelTimKiem.ResumeLayout(false);
            this.panelTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}