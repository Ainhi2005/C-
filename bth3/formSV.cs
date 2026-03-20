using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace bth3
{
    public partial class formSV : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-83E5VHI\SQLEXPRESS01;Initial Catalog=QLSV;Integrated Security=True");
        string maLopDuocChon = "";

        // Phân trang
        private int currentPage = 1;
        private int pageSize = 10;
        private int totalRecords = 0;
        private int totalPages = 0;
        private string currentFilter = "";

        public formSV(string malop)
        {
            InitializeComponent();
            maLopDuocChon = malop;
        }

        public formSV()
        {
            InitializeComponent();
        }

        // Nạp danh sách mã lớp từ bảng LopHoc vào ComboBox
        void LoadComboBoxLop()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string sql = "SELECT MaLop FROM LopHoc ORDER BY MaLop";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                cboMaLop.Items.Clear();
                while (dr.Read())
                {
                    cboMaLop.Items.Add(dr["MaLop"].ToString());
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp mã lớp: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện Load Form
        private void formSV_Load(object sender, EventArgs e)
        {
            LoadComboBoxLop();

            if (cboGioiTinh.Items.Count > 0)
                cboGioiTinh.SelectedIndex = 0;

            if (string.IsNullOrEmpty(maLopDuocChon))
                LoadSinhVien();
            else
            {
                currentFilter = maLopDuocChon;
                LoadSinhVienTheoLop(maLopDuocChon);
                cboMaLop.Text = maLopDuocChon;
            }
        }

        // Load tất cả sinh viên với phân trang
        void LoadSinhVien()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                // Đếm tổng số bản ghi
                string sqlCount = "SELECT COUNT(*) FROM sinhvien";
                SqlCommand cmdCount = new SqlCommand(sqlCount, conn);
                totalRecords = (int)cmdCount.ExecuteScalar();

                // Tính tổng số trang
                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                if (totalPages == 0) totalPages = 1;
                if (currentPage < 1) currentPage = 1;
                if (currentPage > totalPages) currentPage = totalPages;

                // Lấy dữ liệu theo trang
                string sql = @"SELECT * FROM sinhvien 
                               ORDER BY mssv 
                               OFFSET @skip ROWS 
                               FETCH NEXT @take ROWS ONLY";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@skip", (currentPage - 1) * pageSize);
                da.SelectCommand.Parameters.AddWithValue("@take", pageSize);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSinhVien.DataSource = dt;

                // Cập nhật thông tin phân trang
                lblTotalRecords.Text = $"Tổng: {totalRecords} sinh viên";
                lblPageInfo.Text = $"Trang {currentPage} / {totalPages}";

                // Enable/Disable buttons
                btnFirst.Enabled = currentPage > 1;
                btnPrevious.Enabled = currentPage > 1;
                btnNext.Enabled = currentPage < totalPages;
                btnLast.Enabled = currentPage < totalPages;

                // Đặt tên cột tiếng Việt
                if (dgvSinhVien.Columns.Count > 0)
                {
                    dgvSinhVien.Columns["mssv"].HeaderText = "MSSV";
                    dgvSinhVien.Columns["hoten"].HeaderText = "Họ tên";
                    dgvSinhVien.Columns["gioitinh"].HeaderText = "Giới tính";
                    dgvSinhVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
                    dgvSinhVien.Columns["malop"].HeaderText = "Mã lớp";

                    // Auto resize columns
                    dgvSinhVien.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load sinh viên theo lớp với phân trang
        void LoadSinhVienTheoLop(string malop)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                // Đếm tổng số bản ghi theo lớp
                string sqlCount = "SELECT COUNT(*) FROM sinhvien WHERE malop=@malop";
                SqlCommand cmdCount = new SqlCommand(sqlCount, conn);
                cmdCount.Parameters.AddWithValue("@malop", malop);
                totalRecords = (int)cmdCount.ExecuteScalar();

                // Tính tổng số trang
                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                if (totalPages == 0) totalPages = 1;
                if (currentPage < 1) currentPage = 1;
                if (currentPage > totalPages) currentPage = totalPages;

                // Lấy dữ liệu theo trang
                string sql = @"SELECT * FROM sinhvien 
                               WHERE malop=@malop
                               ORDER BY mssv 
                               OFFSET @skip ROWS 
                               FETCH NEXT @take ROWS ONLY";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@malop", malop);
                da.SelectCommand.Parameters.AddWithValue("@skip", (currentPage - 1) * pageSize);
                da.SelectCommand.Parameters.AddWithValue("@take", pageSize);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSinhVien.DataSource = dt;

                // Cập nhật thông tin phân trang
                lblTotalRecords.Text = $"Tổng: {totalRecords} sinh viên";
                lblPageInfo.Text = $"Trang {currentPage} / {totalPages}";

                // Enable/Disable buttons
                btnFirst.Enabled = currentPage > 1;
                btnPrevious.Enabled = currentPage > 1;
                btnNext.Enabled = currentPage < totalPages;
                btnLast.Enabled = currentPage < totalPages;

                // Đặt tên cột tiếng Việt
                if (dgvSinhVien.Columns.Count > 0)
                {
                    dgvSinhVien.Columns["mssv"].HeaderText = "MSSV";
                    dgvSinhVien.Columns["hoten"].HeaderText = "Họ tên";
                    dgvSinhVien.Columns["gioitinh"].HeaderText = "Giới tính";
                    dgvSinhVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
                    dgvSinhVien.Columns["malop"].HeaderText = "Mã lớp";

                    // Auto resize columns
                    dgvSinhVien.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(txtMSSV.Text) ||
                    string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                    string.IsNullOrWhiteSpace(cboMaLop.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (conn.State == ConnectionState.Closed) conn.Open();

                // Kiểm tra trùng MSSV
                string sqlCheck = "SELECT COUNT(*) FROM sinhvien WHERE mssv=@mssv";
                SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
                cmdCheck.Parameters.AddWithValue("@mssv", txtMSSV.Text);
                int count = (int)cmdCheck.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("MSSV đã tồn tại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return;
                }

                string sql = "INSERT INTO sinhvien(mssv,hoten,gioitinh,ngaysinh,malop) VALUES (@mssv,@hoten,@gioitinh,@ngaysinh,@malop)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@mssv", txtMSSV.Text.Trim());
                cmd.Parameters.AddWithValue("@hoten", txtHoTen.Text.Trim());
                cmd.Parameters.AddWithValue("@gioitinh", cboGioiTinh.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@malop", cboMaLop.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Về trang cuối để thấy dữ liệu mới
                currentPage = totalPages;
                LoadSinhVien();

                // Clear inputs
                txtMSSV.Clear();
                txtHoTen.Clear();
                cboGioiTinh.SelectedIndex = 0;
                dtpNgaySinh.Value = DateTime.Now;
                cboMaLop.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMSSV.Text))
                {
                    MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = "UPDATE sinhvien SET hoten=@hoten, gioitinh=@gioitinh, ngaysinh=@ngaysinh, malop=@malop WHERE mssv=@mssv";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@mssv", txtMSSV.Text.Trim());
                cmd.Parameters.AddWithValue("@hoten", txtHoTen.Text.Trim());
                cmd.Parameters.AddWithValue("@gioitinh", cboGioiTinh.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@malop", cboMaLop.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Sửa thông tin thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMSSV.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    string sql = "DELETE FROM sinhvien WHERE mssv=@mssv";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@mssv", txtMSSV.Text.Trim());
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Kiểm tra nếu trang hiện tại không còn dữ liệu thì lùi về trang trước
                    if (totalRecords > 0 && (currentPage - 1) * pageSize >= totalRecords - 1)
                    {
                        currentPage--;
                    }
                    LoadSinhVien();

                    // Clear inputs
                    txtMSSV.Clear();
                    txtHoTen.Clear();
                    cboGioiTinh.SelectedIndex = 0;
                    dtpNgaySinh.Value = DateTime.Now;
                    cboMaLop.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string searchText = txtTim.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                currentPage = 1;
                currentFilter = "";
                LoadSinhVien();
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sql = @"SELECT * FROM sinhvien 
                               WHERE mssv LIKE @tim OR hoten LIKE @tim OR malop LIKE @tim
                               ORDER BY mssv";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@tim", "%" + searchText + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSinhVien.DataSource = dt;

                // Cập nhật thông tin khi tìm kiếm
                lblTotalRecords.Text = $"Tìm thấy: {dt.Rows.Count} sinh viên";
                lblPageInfo.Text = "Kết quả tìm kiếm";

                // Disable phân trang khi tìm kiếm
                btnFirst.Enabled = false;
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
                btnLast.Enabled = false;

                conn.Close();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMSSV.Clear();
            txtHoTen.Clear();
            cboGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Now;
            cboMaLop.SelectedIndex = -1;
            txtTim.Clear();
            currentPage = 1;
            currentFilter = "";
            LoadSinhVien();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

                txtMSSV.Text = row.Cells["mssv"].Value?.ToString() ?? "";
                txtHoTen.Text = row.Cells["hoten"].Value?.ToString() ?? "";
                cboGioiTinh.Text = row.Cells["gioitinh"].Value?.ToString() ?? "";

                if (row.Cells["ngaysinh"].Value != null)
                {
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["ngaysinh"].Value);
                }

                cboMaLop.Text = row.Cells["malop"].Value?.ToString() ?? "";
            }
        }

        private void btnqllh_Click(object sender, EventArgs e)
        {
            formQLLH f = new formQLLH();
            f.Show();
            this.Hide();
        }

        // Các sự kiện phân trang
        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            if (string.IsNullOrEmpty(currentFilter))
                LoadSinhVien();
            else
                LoadSinhVienTheoLop(currentFilter);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                if (string.IsNullOrEmpty(currentFilter))
                    LoadSinhVien();
                else
                    LoadSinhVienTheoLop(currentFilter);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                if (string.IsNullOrEmpty(currentFilter))
                    LoadSinhVien();
                else
                    LoadSinhVienTheoLop(currentFilter);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            if (string.IsNullOrEmpty(currentFilter))
                LoadSinhVien();
            else
                LoadSinhVienTheoLop(currentFilter);
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}