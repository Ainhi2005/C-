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

        // Phân trang
        private int currentPage = 1;
        private int pageSize = 10;
        private int totalRecords = 0;
        private int totalPages = 0;

        public formQLLH()
        {
            InitializeComponent();
        }

        // Load dữ liệu với phân trang
        void loadData()
        {
            try
            {
                var query = db.LopHocs.OrderBy(x => x.MaLop);
                totalRecords = query.Count();
                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

                if (totalPages == 0) totalPages = 1;
                if (currentPage < 1) currentPage = 1;
                if (currentPage > totalPages) currentPage = totalPages;

                var data = query.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

                dataLopHoc.DataSource = data;

                // Cập nhật thông tin phân trang
                lblTotalRecords.Text = $"Tổng: {totalRecords} lớp";
                lblPageInfo.Text = $"Trang {currentPage} / {totalPages}";

                // Enable/Disable buttons
                btnFirst.Enabled = currentPage > 1;
                btnPrevious.Enabled = currentPage > 1;
                btnNext.Enabled = currentPage < totalPages;
                btnLast.Enabled = currentPage < totalPages;

                // Set column headers
                if (dataLopHoc.Columns.Count > 0)
                {
                    dataLopHoc.Columns["MaLop"].HeaderText = "Mã Lớp";
                    dataLopHoc.Columns["MonHoc"].HeaderText = "Môn Học";
                    dataLopHoc.Columns["GhiChu"].HeaderText = "Ghi Chú";

                    // Auto resize columns
                    dataLopHoc.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear all input fields
        void clearInputs()
        {
            txtMaLop.Clear();
            txtMonHoc.Clear();
            txtGhiChu.Clear();
            txtTimm.Clear();
        }

        // Form Load
        private void formQLLH_Load(object sender, EventArgs e)
        {
            loadData();
        }

        // Thêm
        private void btnThemm_click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) ||
                string.IsNullOrWhiteSpace(txtMonHoc.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin (Mã lớp và Môn học)",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for duplicate MaLop
            var existingLop = db.LopHocs.SingleOrDefault(x => x.MaLop == txtMaLop.Text.Trim());
            if (existingLop != null)
            {
                MessageBox.Show("Mã lớp đã tồn tại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                LopHoc lh = new LopHoc();
                lh.MaLop = txtMaLop.Text.Trim();
                lh.MonHoc = txtMonHoc.Text.Trim();
                lh.GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim();

                db.LopHocs.InsertOnSubmit(lh);
                db.SubmitChanges();

                MessageBox.Show("Thêm lớp học thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearInputs();
                currentPage = totalPages; // Về trang cuối để thấy dữ liệu mới
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xóa
        private void btnXoaa_click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp cần xóa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var lop = db.LopHocs.SingleOrDefault(x => x.MaLop == txtMaLop.Text.Trim());

                    if (lop != null)
                    {
                        db.LopHocs.DeleteOnSubmit(lop);
                        db.SubmitChanges();

                        MessageBox.Show("Xóa lớp học thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clearInputs();

                        // Kiểm tra nếu trang hiện tại không còn dữ liệu thì lùi về trang trước
                        if (totalRecords > 0 && (currentPage - 1) * pageSize >= totalRecords - 1)
                        {
                            currentPage--;
                        }
                        loadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Sửa
        private void btnSuaa_click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp cần sửa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMonHoc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên môn học", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var lop = db.LopHocs.SingleOrDefault(x => x.MaLop == txtMaLop.Text.Trim());

                if (lop != null)
                {
                    lop.MonHoc = txtMonHoc.Text.Trim();
                    lop.GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim();

                    db.SubmitChanges();

                    MessageBox.Show("Cập nhật lớp học thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Làm mới
        private void btnLamMoii_click(object sender, EventArgs e)
        {
            clearInputs();
            currentPage = 1;
            loadData();
        }

        // Click DataGridView
        private void dataLopHoc__CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataLopHoc.CurrentRow != null)
            {
                var row = dataLopHoc.Rows[e.RowIndex];

                if (row.Cells["MaLop"].Value != null)
                    txtMaLop.Text = row.Cells["MaLop"].Value.ToString();

                if (row.Cells["MonHoc"].Value != null)
                    txtMonHoc.Text = row.Cells["MonHoc"].Value.ToString();

                if (row.Cells["GhiChu"].Value != null)
                    txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
            }
        }

        // Tìm kiếm
        private void btnTimm_click(object sender, EventArgs e)
        {
            string searchText = txtTimm.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                currentPage = 1;
                loadData();
                return;
            }

            try
            {
                var kq = db.LopHocs.Where(x =>
                    x.MaLop.Contains(searchText) ||
                    x.MonHoc.Contains(searchText) ||
                    (x.GhiChu != null && x.GhiChu.Contains(searchText))).ToList();

                if (kq.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dataLopHoc.DataSource = kq;

                // Cập nhật thông tin khi tìm kiếm
                lblTotalRecords.Text = $"Tìm thấy: {kq.Count} lớp";
                lblPageInfo.Text = "Kết quả tìm kiếm";

                // Disable phân trang khi tìm kiếm
                btnFirst.Enabled = false;
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Mở form quản lý sinh viên
        private void button1_Click(object sender, EventArgs e)
        {
            formSV f = new formSV();
            f.Show();
            this.Hide();
        }

        // Xem danh sách sinh viên của lớp
        private void btnxemDS_Click(object sender, EventArgs e)
        {
            string malop = txtMaLop.Text.Trim();

            if (string.IsNullOrWhiteSpace(malop))
            {
                MessageBox.Show("Vui lòng chọn lớp cần xem danh sách sinh viên",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lop = db.LopHocs.SingleOrDefault(x => x.MaLop == malop);
            if (lop == null)
            {
                MessageBox.Show("Lớp học không tồn tại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            formDSSVTheoLop f = new formDSSVTheoLop(malop);
            f.ShowDialog();
        }

        // Các sự kiện phân trang
        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            loadData();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                loadData();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                loadData();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            loadData();
        }

        // Unused event handlers
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void txtTimm_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void dataLopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtGV_TextChanged(object sender, EventArgs e) { }
    }
}