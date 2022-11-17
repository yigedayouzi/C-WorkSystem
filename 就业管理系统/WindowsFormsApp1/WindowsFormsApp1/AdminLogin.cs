using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            var username = this.username.Text;
            var password = this.password.Text;
            var res = conn.AdminLogin(username, password);
            if (res == true)
            {
                DialogResult dr = MessageBox.Show("登录成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                admin_control messageForm = new admin_control();
                messageForm.Show();
                this.Close();
            }
            else
            {
                DialogResult dr = MessageBox.Show("登录失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
