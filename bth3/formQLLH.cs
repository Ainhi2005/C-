using bth3;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace bth3
{
    public partial class formQLLH : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public formQLLH()
        {
            InitializeComponent();
        }

        // Load dữ liệu
        void loadData()
        {
            dataLopHoc.DataSource = db.LopHocs.ToList();
        }
        //cập nhật sĩ số
        void CapNhatSiSo()
        {
            string connStr = @"Data Source=DESKTOP-83E5VHI\SQLEXPRESS01;Initial Catalog=QLSV;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string sql = @"SELECT malop, COUNT(*) AS TongSV 
                       FROM sinhvien 
                       GROUP BY malop";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    string malop = rd["malop"].ToString();
                    int tong = Convert.ToInt32(rd["TongSV"]);

                    var lop = db.LopHocs.SingleOrDefault(x => x.MaLop == malop);

                    if (lop != null)
                    {
                        lop.SiSo = tong;
                    }
                }

                db.SubmitChanges();
            }
        }
        // Form Load
        private void formQLLH_Load(object sender, EventArgs e)
        {
            loadData();
            CapNhatSiSo();
        }

        // Thêm
        private void btnThemm_click(object sender, EventArgs e)
        {
            LopHoc lh = new LopHoc();

            lh.MaLop = txtMaLop.Text;
            lh.MonHoc = txtMonHoc.Text;
            lh.GiangVien = txtGV.Text;
            lh.SiSo = int.Parse(txtSiSo.Text);

            db.LopHocs.InsertOnSubmit(lh);
            db.SubmitChanges();

            loadData();
        }

        // Xóa
        private void btnXoaa_click(object sender, EventArgs e)
        {
            var lop = db.LopHocs.SingleOrDefault(x => x.MaLop == txtMaLop.Text);

            if (lop != null)
            {
                db.LopHocs.DeleteOnSubmit(lop);
                db.SubmitChanges();
                loadData();
            }
        }

        // Sửa
        private void btnSuaa_click(object sender, EventArgs e)
        {
            var lop = db.LopHocs.SingleOrDefault(x => x.MaLop == txtMaLop.Text);

            if (lop != null)
            {
                lop.MonHoc = txtMonHoc.Text;
                lop.GiangVien = txtGV.Text;
                lop.SiSo = int.Parse(txtSiSo.Text);

                db.SubmitChanges();
                loadData();
            }
        }

        // Làm mới
        private void btnLamMoii_click(object sender, EventArgs e)
        {
            txtMaLop.Clear();
            txtMonHoc.Clear();
            txtGV.Clear();
            txtSiSo.Clear();
            txtTimm.Clear();

            loadData();
        }

        // Click DataGridView
        private void dataLopHoc__CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataLopHoc.CurrentRow != null)
            {
                txtMaLop.Text = dataLopHoc.CurrentRow.Cells["MaLop"].Value.ToString();
                txtMonHoc.Text = dataLopHoc.CurrentRow.Cells["MonHoc"].Value.ToString();
                txtGV.Text = dataLopHoc.CurrentRow.Cells["GiangVien"].Value.ToString();
                txtSiSo.Text = dataLopHoc.CurrentRow.Cells["SiSo"].Value.ToString();
            }
        }

        // Tìm kiếm
        private void btnTimm_click(object sender, EventArgs e)
        {
            var kq = db.LopHocs.Where(x => x.MaLop.Contains(txtTimm.Text)
                                       || x.MonHoc.Contains(txtTimm.Text));

            dataLopHoc.DataSource = kq.ToList();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTimm_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataLopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formSV f =new formSV();
            f.Show();
            this.Hide();
        }

        private void btnxemDS_Click(object sender, EventArgs e)
        {
            string malop = txtMaLop.Text;

            if (malop == "")
            {
                MessageBox.Show("Vui lòng chọn lớp");
                return;
            }

            formSV f = new formSV(malop);
            f.Show();
        }

        private void txtGV_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
