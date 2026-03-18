namespace bth3
{
    partial class formQLLH
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimm = new System.Windows.Forms.TextBox();
            this.tbnTimm = new System.Windows.Forms.Button();
            this.dataLopHoc = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemm = new System.Windows.Forms.Button();
            this.btnLamMoii = new System.Windows.Forms.Button();
            this.btnXoaa = new System.Windows.Forms.Button();
            this.btnSuaa = new System.Windows.Forms.Button();
            this.txtGV = new System.Windows.Forms.TextBox();
            this.txtMonHoc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnxemDS = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(455, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ LỚP HỌC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm Kiếm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTimm
            // 
            this.txtTimm.Location = new System.Drawing.Point(373, 88);
            this.txtTimm.Multiline = true;
            this.txtTimm.Name = "txtTimm";
            this.txtTimm.Size = new System.Drawing.Size(337, 41);
            this.txtTimm.TabIndex = 2;
            this.txtTimm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimm.TextChanged += new System.EventHandler(this.txtTimm_TextChanged);
            // 
            // tbnTimm
            // 
            this.tbnTimm.Location = new System.Drawing.Point(779, 90);
            this.tbnTimm.Name = "tbnTimm";
            this.tbnTimm.Size = new System.Drawing.Size(93, 33);
            this.tbnTimm.TabIndex = 3;
            this.tbnTimm.Text = "tìm kiếm";
            this.tbnTimm.UseVisualStyleBackColor = true;
            this.tbnTimm.Click += new System.EventHandler(this.btnTimm_click);
            // 
            // dataLopHoc
            // 
            this.dataLopHoc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLopHoc.Location = new System.Drawing.Point(442, 184);
            this.dataLopHoc.Name = "dataLopHoc";
            this.dataLopHoc.RowHeadersWidth = 51;
            this.dataLopHoc.RowTemplate.Height = 24;
            this.dataLopHoc.Size = new System.Drawing.Size(605, 485);
            this.dataLopHoc.TabIndex = 4;
            this.dataLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLopHoc__CellClick);
            this.dataLopHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLopHoc_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(51, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã lớp :";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMaLop.Location = new System.Drawing.Point(151, 158);
            this.txtMaLop.Multiline = true;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(149, 34);
            this.txtMaLop.TabIndex = 6;
            this.txtMaLop.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(66, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "GV :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(51, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Môn học :";
            // 
            // btnThemm
            // 
            this.btnThemm.Location = new System.Drawing.Point(70, 479);
            this.btnThemm.Name = "btnThemm";
            this.btnThemm.Size = new System.Drawing.Size(108, 35);
            this.btnThemm.TabIndex = 13;
            this.btnThemm.Text = "Thêm";
            this.btnThemm.UseVisualStyleBackColor = true;
            this.btnThemm.Click += new System.EventHandler(this.btnThemm_click);
            // 
            // btnLamMoii
            // 
            this.btnLamMoii.Location = new System.Drawing.Point(251, 556);
            this.btnLamMoii.Name = "btnLamMoii";
            this.btnLamMoii.Size = new System.Drawing.Size(108, 35);
            this.btnLamMoii.TabIndex = 14;
            this.btnLamMoii.Text = "Làm mới";
            this.btnLamMoii.UseVisualStyleBackColor = true;
            this.btnLamMoii.Click += new System.EventHandler(this.btnLamMoii_click);
            // 
            // btnXoaa
            // 
            this.btnXoaa.Location = new System.Drawing.Point(70, 556);
            this.btnXoaa.Name = "btnXoaa";
            this.btnXoaa.Size = new System.Drawing.Size(108, 35);
            this.btnXoaa.TabIndex = 15;
            this.btnXoaa.Text = "Xóa";
            this.btnXoaa.UseVisualStyleBackColor = true;
            this.btnXoaa.Click += new System.EventHandler(this.btnXoaa_click);
            // 
            // btnSuaa
            // 
            this.btnSuaa.Location = new System.Drawing.Point(251, 479);
            this.btnSuaa.Name = "btnSuaa";
            this.btnSuaa.Size = new System.Drawing.Size(108, 35);
            this.btnSuaa.TabIndex = 16;
            this.btnSuaa.Text = "Sửa";
            this.btnSuaa.UseVisualStyleBackColor = true;
            this.btnSuaa.Click += new System.EventHandler(this.btnSuaa_click);
            // 
            // txtGV
            // 
            this.txtGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtGV.Location = new System.Drawing.Point(151, 258);
            this.txtGV.Multiline = true;
            this.txtGV.Name = "txtGV";
            this.txtGV.Size = new System.Drawing.Size(149, 34);
            this.txtGV.TabIndex = 18;
            this.txtGV.TextChanged += new System.EventHandler(this.txtGV_TextChanged);
            // 
            // txtMonHoc
            // 
            this.txtMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMonHoc.Location = new System.Drawing.Point(151, 205);
            this.txtMonHoc.Multiline = true;
            this.txtMonHoc.Name = "txtMonHoc";
            this.txtMonHoc.Size = new System.Drawing.Size(149, 34);
            this.txtMonHoc.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(110, 647);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 41);
            this.button1.TabIndex = 20;
            this.button1.Text = "Quản Lý Sinh Viên";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnxemDS
            // 
            this.btnxemDS.BackColor = System.Drawing.Color.SpringGreen;
            this.btnxemDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxemDS.Location = new System.Drawing.Point(151, 382);
            this.btnxemDS.Name = "btnxemDS";
            this.btnxemDS.Size = new System.Drawing.Size(121, 34);
            this.btnxemDS.TabIndex = 21;
            this.btnxemDS.Text = "XemDS Lớp";
            this.btnxemDS.UseVisualStyleBackColor = false;
            this.btnxemDS.Click += new System.EventHandler(this.btnxemDS_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(66, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sĩ số :";
            // 
            // txtSiSo
            // 
            this.txtSiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSiSo.Location = new System.Drawing.Point(151, 305);
            this.txtSiSo.Multiline = true;
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(149, 34);
            this.txtSiSo.TabIndex = 17;
            // 
            // formQLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 729);
            this.Controls.Add(this.btnxemDS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMonHoc);
            this.Controls.Add(this.txtGV);
            this.Controls.Add(this.txtSiSo);
            this.Controls.Add(this.btnSuaa);
            this.Controls.Add(this.btnXoaa);
            this.Controls.Add(this.btnLamMoii);
            this.Controls.Add(this.btnThemm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataLopHoc);
            this.Controls.Add(this.tbnTimm);
            this.Controls.Add(this.txtTimm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formQLLH";
            this.Text = "X";
            this.Load += new System.EventHandler(this.formQLLH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLopHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimm;
        private System.Windows.Forms.Button tbnTimm;
        private System.Windows.Forms.DataGridView dataLopHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemm;
        private System.Windows.Forms.Button btnLamMoii;
        private System.Windows.Forms.Button btnXoaa;
        private System.Windows.Forms.Button btnSuaa;
        private System.Windows.Forms.TextBox txtGV;
        private System.Windows.Forms.TextBox txtMonHoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnxemDS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSiSo;
    }
}