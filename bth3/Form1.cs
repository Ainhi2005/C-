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
    public partial class Form1 : Form
    {
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPw.Text == "123456" && txtName.Text=="NhiNTA")
            {
                formSV f = new formSV();
                f.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Sai mật khẩu");
        } }

    }
}
