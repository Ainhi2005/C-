using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bth3
{
    public partial class formSV : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-83E5VHI\SQLEXPRESS01;Initial Catalog=QLSV;Integrated Security=True");
        string maLopDuocChon = "";

        public formSV(string malop)
        {
            InitializeComponent();
            maLopDuocChon = malop;
        }

        public formSV()
        {
            InitializeComponent();
        }

        // 1. Nạp danh sách mã lớp từ bảng LopHoc vào ComboBox
        void LoadComboBoxLop()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string sql = "SELECT MaLop FROM LopHoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                cboMaLop.Items.Clear();
                while (dr.Read())
                {
                    cboMaLop.Items.Add(dr["MaLop"].ToString());
                }
                dr.Close(); // Luôn đóng reader sau khi dùng
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi nạp mã lớp: " + ex.Message); }
        }

        // 2. Sự kiện Load Form (Chỉ giữ lại 1 cái duy nhất)
        private void formSV_Load(object sender, EventArgs e)
        {
            LoadComboBoxLop();

            if (cboGioiTinh.Items.Count > 0)
                cboGioiTinh.SelectedIndex = 0; // Mặc định chọn mục đầu tiên (Nam)

            if (string.IsNullOrEmpty(maLopDuocChon))
                LoadSinhVien();
            else
            {
                LoadSinhVienTheoLop(maLopDuocChon);
                cboMaLop.Text = maLopDuocChon; // Hiển thị luôn lớp đang chọn lên combo
            }
        }

        void LoadSinhVien()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string sql = "SELECT * FROM sinhvien";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSinhVien.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load dữ liệu: " + ex.Message); }
        }

        void LoadSinhVienTheoLop(string malop)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string sql = "SELECT * FROM sinhvien WHERE malop=@malop";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@malop", malop);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSinhVien.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string sql = "INSERT INTO sinhvien(mssv,hoten,gioitinh,ngaysinh,malop) VALUES (@mssv,@hoten,@gioitinh,@ngaysinh,@malop)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@mssv", txtMSSV.Text);
                cmd.Parameters.AddWithValue("@hoten", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@gioitinh", cboGioiTinh.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", dtpNgaySinh.Value); // Dùng Value của DateTimePicker
                cmd.Parameters.AddWithValue("@malop", cboMaLop.Text); // Dùng Text của ComboBox

                cmd.ExecuteNonQuery();
                conn.Close();
                LoadSinhVien();
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string sql = "UPDATE sinhvien SET hoten=@hoten, gioitinh=@gioitinh, ngaysinh=@ngaysinh, malop=@malop WHERE mssv=@mssv";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@mssv", txtMSSV.Text);
                cmd.Parameters.AddWithValue("@hoten", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@gioitinh", cboGioiTinh.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@malop", cboMaLop.Text);

                cmd.ExecuteNonQuery();
                conn.Close();
                LoadSinhVien();
                MessageBox.Show("Sửa thành công");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    string sql = "DELETE FROM sinhvien WHERE mssv=@mssv";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@mssv", txtMSSV.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadSinhVien();
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string sql = "SELECT * FROM sinhvien WHERE mssv LIKE @tim OR hoten LIKE @tim OR malop LIKE @tim";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@tim", "%" + txtTim.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSinhVien.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMSSV.Clear();
            txtHoTen.Clear();
            cboGioiTinh.SelectedIndex = 0; // Quay về Nam
            dtpNgaySinh.Value = DateTime.Now; // Quay về ngày hiện tại
            cboMaLop.SelectedIndex = -1; // Bỏ chọn lớp
            txtTim.Clear();
            LoadSinhVien();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtMSSV.Text = dgvSinhVien.Rows[i].Cells[0].Value.ToString();
                txtHoTen.Text = dgvSinhVien.Rows[i].Cells[1].Value.ToString();
                cboGioiTinh.Text = dgvSinhVien.Rows[i].Cells[2].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(dgvSinhVien.Rows[i].Cells[3].Value);
                cboMaLop.Text = dgvSinhVien.Rows[i].Cells[4].Value.ToString();
            }
        }

        private void btnqllh_Click(object sender, EventArgs e)
        {
            formQLLH f = new formQLLH();
            f.Show();
            this.Hide();
        }
    }
}