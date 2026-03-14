using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bth3
{
    public partial class formSV : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-83E5VHI\SQLEXPRESS01;Initial Catalog=QLSV;Integrated Security=True");

        public formSV()
        {
            InitializeComponent();
        }

        private void formSV_Load(object sender, EventArgs e)
        {
            LoadSinhVien();
        }

        void LoadSinhVien()
        {
            try
            {
                conn.Open();

                string sql = "SELECT * FROM sinhvien";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvSinhVien.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sql = "INSERT INTO sinhvien(mssv,hoten,gioitinh,ngaysinh,malop) VALUES (@mssv,@hoten,@gioitinh,@ngaysinh,@malop)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@mssv", txtMSSV.Text);
                cmd.Parameters.AddWithValue("@hoten", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@gioitinh", txtGioiTinh.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", DateTime.Parse(txtNgaySinh.Text));
                cmd.Parameters.AddWithValue("@malop", txtMaLop.Text);

                cmd.ExecuteNonQuery();

                conn.Close();

                LoadSinhVien();

                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sql = "UPDATE sinhvien SET hoten=@hoten, gioitinh=@gioitinh, ngaysinh=@ngaysinh, malop=@malop WHERE mssv=@mssv";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@mssv", txtMSSV.Text);
                cmd.Parameters.AddWithValue("@hoten", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@gioitinh", txtGioiTinh.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", DateTime.Parse(txtNgaySinh.Text));
                cmd.Parameters.AddWithValue("@malop", txtMaLop.Text);

                cmd.ExecuteNonQuery();

                conn.Close();

                LoadSinhVien();

                MessageBox.Show("Sửa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sql = "DELETE FROM sinhvien WHERE mssv=@mssv";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@mssv", txtMSSV.Text);

                cmd.ExecuteNonQuery();

                conn.Close();

                LoadSinhVien();

                MessageBox.Show("Xóa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sql = @"SELECT * FROM sinhvien 
                       WHERE mssv LIKE @tim 
                       OR hoten LIKE @tim 
                       OR malop LIKE @tim";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.AddWithValue("@tim", "%" + txtTim.Text + "%");

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvSinhVien.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMSSV.Clear();
            txtHoTen.Clear();
            txtGioiTinh.Clear();
            txtNgaySinh.Clear();
            txtMaLop.Clear();
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
                txtGioiTinh.Text = dgvSinhVien.Rows[i].Cells[2].Value.ToString();
                txtNgaySinh.Text = dgvSinhVien.Rows[i].Cells[3].Value.ToString();
                txtMaLop.Text = dgvSinhVien.Rows[i].Cells[4].Value.ToString();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}