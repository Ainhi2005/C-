using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bth3
{
    public partial class formDSSVTheoLop : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-83E5VHI\SQLEXPRESS01;Initial Catalog=QLSV;Integrated Security=True");
        private string maLop;

        public formDSSVTheoLop(string malop)
        {
            InitializeComponent();
            this.maLop = malop;
            this.Text = "DANH SÁCH SINH VIÊN - LỚP: " + malop;
        }

        private void formDSSVTheoLop_Load(object sender, EventArgs e)
        {
            LoadThongTinLop();
            LoadDanhSachSinhVien();
        }

        // Load thông tin lớp học
        private void LoadThongTinLop()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                // Lấy thông tin lớp
                string sqlLop = "SELECT * FROM LopHoc WHERE MaLop = @malop";
                SqlCommand cmdLop = new SqlCommand(sqlLop, conn);
                cmdLop.Parameters.AddWithValue("@malop", maLop);
                SqlDataReader dr = cmdLop.ExecuteReader();

                if (dr.Read())
                {
                    lblMaLop.Text = "Mã lớp: " + dr["MaLop"].ToString();
                    lblMonHoc.Text = "Môn học: " + dr["MonHoc"].ToString();
                    lblGhiChu.Text = "Ghi chú: " + (dr["GhiChu"] != DBNull.Value ? dr["GhiChu"].ToString() : "");
                }
                dr.Close();

                // Đếm sĩ số
                string sqlCount = "SELECT COUNT(*) FROM SinhVien WHERE MaLop = @malop";
                SqlCommand cmdCount = new SqlCommand(sqlCount, conn);
                cmdCount.Parameters.AddWithValue("@malop", maLop);
                int siSo = (int)cmdCount.ExecuteScalar();

                lblSiSo.Text = $"Sĩ số: {siSo} sinh viên";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin lớp: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load danh sách sinh viên
        private void LoadDanhSachSinhVien()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"SELECT mssv as 'MSSV', 
                                      hoten as 'Họ tên', 
                                      gioitinh as 'Giới tính', 
                                      CONVERT(VARCHAR(10), ngaysinh, 103) as 'Ngày sinh'
                               FROM sinhvien 
                               WHERE malop = @malop 
                               ORDER BY mssv";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@malop", maLop);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSinhVien.DataSource = dt;

                // Định dạng DataGridView
                if (dgvSinhVien.Columns.Count > 0)
                {
                    dgvSinhVien.Columns["MSSV"].Width = 120;
                    dgvSinhVien.Columns["Họ tên"].Width = 250;
                    dgvSinhVien.Columns["Giới tính"].Width = 100;
                    dgvSinhVien.Columns["Ngày sinh"].Width = 120;
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách sinh viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút đóng form
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Nút làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadThongTinLop();
            LoadDanhSachSinhVien();
        }

        // Nút xuất Excel (nếu cần)
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang phát triển!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Tìm kiếm trong danh sách sinh viên của lớp
        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTim.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {
                    LoadDanhSachSinhVien();
                    return;
                }

                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"SELECT mssv as 'MSSV', 
                                      hoten as 'Họ tên', 
                                      gioitinh as 'Giới tính', 
                                      CONVERT(VARCHAR(10), ngaysinh, 103) as 'Ngày sinh'
                               FROM sinhvien 
                               WHERE malop = @malop 
                               AND (mssv LIKE @keyword OR hoten LIKE @keyword)
                               ORDER BY mssv";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@malop", maLop);
                da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSinhVien.DataSource = dt;
                lblKetQuaTim.Text = $"Tìm thấy: {dt.Rows.Count} kết quả";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}