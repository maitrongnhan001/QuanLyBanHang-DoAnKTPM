using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (this.txtUser.Text == "teonv" && this.txtPass.Text == "123")
                //nếu dùng lệnh thoát form thì sẽ dân để thoát chương trình, do tác dụng của hàm closed
                //vỉ vậy trong tường hợp này nên dùng lệnh ẩn form đăng nhập đi (Hide)
                this.Hide();
            else
            {
                MessageBox.Show("Không đúng tên người dùng ? mật khẩu!!!", "Thông báo");
                this.txtUser.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
                Application.Exit();
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //fix chức năng tắc form đăng nhâp
            //khi tắc form đăng nhập thì tắc luôn form 1
            Application.Exit();
        }
    }
}
