namespace bth3
{
    partial class formQLLH
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimm;
        private System.Windows.Forms.Button tbnTimm;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMonHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnxemDS;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnThemm;
        private System.Windows.Forms.Button btnSuaa;
        private System.Windows.Forms.Button btnXoaa;
        private System.Windows.Forms.Button btnLamMoii;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView dataLopHoc;
        private System.Windows.Forms.Panel panelPagination;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblTotalRecords;

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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimm = new System.Windows.Forms.TextBox();
            this.tbnTimm = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.btnxemDS = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMonHoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnThemm = new System.Windows.Forms.Button();
            this.btnSuaa = new System.Windows.Forms.Button();
            this.btnXoaa = new System.Windows.Forms.Button();
            this.btnLamMoii = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dataLopHoc = new System.Windows.Forms.DataGridView();
            this.panelPagination = new System.Windows.Forms.Panel();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLopHoc)).BeginInit();
            this.panelPagination.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1200, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ LỚP HỌC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.label2);
            this.panelSearch.Controls.Add(this.txtTimm);
            this.panelSearch.Controls.Add(this.tbnTimm);
            this.panelSearch.Location = new System.Drawing.Point(12, 70);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1176, 70);
            this.panelSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm Kiếm:";
            // 
            // txtTimm
            // 
            this.txtTimm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimm.Location = new System.Drawing.Point(120, 20);
            this.txtTimm.Name = "txtTimm";
            this.txtTimm.Size = new System.Drawing.Size(400, 30);
            this.txtTimm.TabIndex = 1;
            this.txtTimm.TextChanged += new System.EventHandler(this.txtTimm_TextChanged);
            // 
            // tbnTimm
            // 
            this.tbnTimm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbnTimm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbnTimm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbnTimm.ForeColor = System.Drawing.Color.White;
            this.tbnTimm.Location = new System.Drawing.Point(530, 18);
            this.tbnTimm.Name = "tbnTimm";
            this.tbnTimm.Size = new System.Drawing.Size(100, 30);
            this.tbnTimm.TabIndex = 2;
            this.tbnTimm.Text = "Tìm kiếm";
            this.tbnTimm.UseVisualStyleBackColor = false;
            this.tbnTimm.Click += new System.EventHandler(this.btnTimm_click);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.groupBoxInfo);
            this.panelLeft.Controls.Add(this.panelButtons);
            this.panelLeft.Location = new System.Drawing.Point(12, 150);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(350, 567);
            this.panelLeft.TabIndex = 2;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.btnxemDS);
            this.groupBoxInfo.Controls.Add(this.label3);
            this.groupBoxInfo.Controls.Add(this.txtMaLop);
            this.groupBoxInfo.Controls.Add(this.label6);
            this.groupBoxInfo.Controls.Add(this.txtMonHoc);
            this.groupBoxInfo.Controls.Add(this.label5);
            this.groupBoxInfo.Controls.Add(this.txtGhiChu);
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.groupBoxInfo.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(350, 270);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "THÔNG TIN LỚP HỌC";
            // 
            // btnxemDS
            // 
            this.btnxemDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnxemDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxemDS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnxemDS.ForeColor = System.Drawing.Color.White;
            this.btnxemDS.Location = new System.Drawing.Point(20, 220);
            this.btnxemDS.Name = "btnxemDS";
            this.btnxemDS.Size = new System.Drawing.Size(150, 35);
            this.btnxemDS.TabIndex = 7;
            this.btnxemDS.Text = "Xem DS Sinh Viên";
            this.btnxemDS.UseVisualStyleBackColor = false;
            this.btnxemDS.Click += new System.EventHandler(this.btnxemDS_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã lớp:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaLop.Location = new System.Drawing.Point(100, 27);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(230, 27);
            this.txtMaLop.TabIndex = 1;
            this.txtMaLop.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Môn học:";
            // 
            // txtMonHoc
            // 
            this.txtMonHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMonHoc.Location = new System.Drawing.Point(100, 67);
            this.txtMonHoc.Name = "txtMonHoc";
            this.txtMonHoc.Size = new System.Drawing.Size(230, 27);
            this.txtMonHoc.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGhiChu.Location = new System.Drawing.Point(100, 107);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(230, 60);
            this.txtGhiChu.TabIndex = 5;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGV_TextChanged);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Controls.Add(this.btnThemm);
            this.panelButtons.Controls.Add(this.btnSuaa);
            this.panelButtons.Controls.Add(this.btnXoaa);
            this.panelButtons.Controls.Add(this.btnLamMoii);
            this.panelButtons.Controls.Add(this.button1);
            this.panelButtons.Location = new System.Drawing.Point(0, 280);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(350, 280);
            this.panelButtons.TabIndex = 1;
            // 
            // btnThemm
            // 
            this.btnThemm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnThemm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemm.ForeColor = System.Drawing.Color.White;
            this.btnThemm.Location = new System.Drawing.Point(30, 20);
            this.btnThemm.Name = "btnThemm";
            this.btnThemm.Size = new System.Drawing.Size(120, 40);
            this.btnThemm.TabIndex = 0;
            this.btnThemm.Text = "THÊM";
            this.btnThemm.UseVisualStyleBackColor = false;
            this.btnThemm.Click += new System.EventHandler(this.btnThemm_click);
            // 
            // btnSuaa
            // 
            this.btnSuaa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnSuaa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSuaa.ForeColor = System.Drawing.Color.White;
            this.btnSuaa.Location = new System.Drawing.Point(180, 20);
            this.btnSuaa.Name = "btnSuaa";
            this.btnSuaa.Size = new System.Drawing.Size(120, 40);
            this.btnSuaa.TabIndex = 1;
            this.btnSuaa.Text = "SỬA";
            this.btnSuaa.UseVisualStyleBackColor = false;
            this.btnSuaa.Click += new System.EventHandler(this.btnSuaa_click);
            // 
            // btnXoaa
            // 
            this.btnXoaa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoaa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaa.ForeColor = System.Drawing.Color.White;
            this.btnXoaa.Location = new System.Drawing.Point(30, 80);
            this.btnXoaa.Name = "btnXoaa";
            this.btnXoaa.Size = new System.Drawing.Size(120, 40);
            this.btnXoaa.TabIndex = 2;
            this.btnXoaa.Text = "XÓA";
            this.btnXoaa.UseVisualStyleBackColor = false;
            this.btnXoaa.Click += new System.EventHandler(this.btnXoaa_click);
            // 
            // btnLamMoii
            // 
            this.btnLamMoii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnLamMoii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoii.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoii.ForeColor = System.Drawing.Color.White;
            this.btnLamMoii.Location = new System.Drawing.Point(180, 80);
            this.btnLamMoii.Name = "btnLamMoii";
            this.btnLamMoii.Size = new System.Drawing.Size(120, 40);
            this.btnLamMoii.TabIndex = 3;
            this.btnLamMoii.Text = "LÀM MỚI";
            this.btnLamMoii.UseVisualStyleBackColor = false;
            this.btnLamMoii.Click += new System.EventHandler(this.btnLamMoii_click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(30, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "QUẢN LÝ SINH VIÊN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.dataLopHoc);
            this.panelRight.Controls.Add(this.panelPagination);
            this.panelRight.Location = new System.Drawing.Point(380, 150);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(808, 567);
            this.panelRight.TabIndex = 3;
            // 
            // dataLopHoc
            // 
            this.dataLopHoc.AllowUserToAddRows = false;
            this.dataLopHoc.AllowUserToDeleteRows = false;
            this.dataLopHoc.BackgroundColor = System.Drawing.Color.White;
            this.dataLopHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLopHoc.Location = new System.Drawing.Point(10, 10);
            this.dataLopHoc.Name = "dataLopHoc";
            this.dataLopHoc.ReadOnly = true;
            this.dataLopHoc.RowHeadersWidth = 51;
            this.dataLopHoc.RowTemplate.Height = 24;
            this.dataLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLopHoc.Size = new System.Drawing.Size(785, 490);
            this.dataLopHoc.TabIndex = 0;
            this.dataLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLopHoc__CellClick);
            this.dataLopHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLopHoc_CellContentClick);
            // 
            // panelPagination
            // 
            this.panelPagination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelPagination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPagination.Controls.Add(this.lblTotalRecords);
            this.panelPagination.Controls.Add(this.btnFirst);
            this.panelPagination.Controls.Add(this.btnPrevious);
            this.panelPagination.Controls.Add(this.lblPageInfo);
            this.panelPagination.Controls.Add(this.btnNext);
            this.panelPagination.Controls.Add(this.btnLast);
            this.panelPagination.Location = new System.Drawing.Point(10, 510);
            this.panelPagination.Name = "panelPagination";
            this.panelPagination.Size = new System.Drawing.Size(785, 45);
            this.panelPagination.TabIndex = 1;
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblTotalRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTotalRecords.Location = new System.Drawing.Point(20, 14);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(80, 20);
            this.lblTotalRecords.TabIndex = 5;
            this.lblTotalRecords.Text = "Tổng: 0 lớp";
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(181, 11);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(70, 27);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "Đầu";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(257, 11);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(70, 27);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Trước";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblPageInfo.Location = new System.Drawing.Point(370, 14);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(86, 20);
            this.lblPageInfo.TabIndex = 2;
            this.lblPageInfo.Text = "Trang 1 / 1";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(495, 11);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(70, 27);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLast.ForeColor = System.Drawing.Color.White;
            this.btnLast.Location = new System.Drawing.Point(571, 11);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(70, 27);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = "Cuối";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // formQLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1200, 730);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "formQLLH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Lớp Học";
            this.Load += new System.EventHandler(this.formQLLH_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLopHoc)).EndInit();
            this.panelPagination.ResumeLayout(false);
            this.panelPagination.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}