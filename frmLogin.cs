using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo.BusinessAccessLayer;

namespace ToDoAplication
{
    public partial class frmLogin : Form
    {
        private readonly AccountBAL _accountBAL;
        public frmLogin()
        {
            InitializeComponent();
            _accountBAL = new AccountBAL();
        }

        private void btnLoginSignup_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (email == "" || password == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ Tên đăng nhập & Mật khẩu!");
                return;
            }
            string error;
            if (_accountBAL.KiemTraDangNhap(email, password, out error))
            {
                MessageBox.Show("Đăng nhập thành công!","Thông báo",MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập sai\n","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
