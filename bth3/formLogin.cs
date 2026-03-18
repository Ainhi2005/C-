using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bth3
{
    public partial class formLogin : Form
    {
        BindingSource bs = new BindingSource();
        public formLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPw.Text == "0020868" && txtName.Text=="NhiNTA")
            {
                formSV f = new formSV();
                f.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Sai mật khẩu");
        } }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
