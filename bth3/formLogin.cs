using System;
using System.Windows.Forms;

namespace bth3
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();

            // Cho phép nhấn Enter để đăng nhập
            this.AcceptButton = btn;

            // Gán sự kiện KeyDown cho TextBox
            txtName.KeyDown += new KeyEventHandler(txt_KeyDown);
            txtPw.KeyDown += new KeyEventHandler(txt_KeyDown);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtName.Text.Trim();
            string password = txtPw.Text;

            // Kiểm tra thông tin đăng nhập (giữ nguyên logic cũ)
            if (password == "0020868" && username == "NhiNTA")
            {
                // Đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                formSV f = new formSV();
                f.Show();
                this.Hide();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Xóa mật khẩu và focus vào ô mật khẩu
                txtPw.Clear();
                txtPw.Focus();
            }
        }

        // Xử lý nhấn phím Enter trong TextBox
        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        // Xử lý sự kiện Quên mật khẩu
        private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ quản trị viên để được cấp lại mật khẩu!\n\nEmail: admin@example.com\nĐiện thoại: 0123 456 789",
                "Quên mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            // Optional: Hiển thị gợi ý đăng nhập
            txtName.Text = "NhiNTA";
            txtPw.Text = "0020868";

            // Bôi đen text để dễ xóa nếu cần
            txtName.SelectAll();
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}