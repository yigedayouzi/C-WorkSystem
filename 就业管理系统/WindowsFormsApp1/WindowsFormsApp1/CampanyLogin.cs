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
    public partial class CampanyLogin : Form
    {
        public CampanyLogin()
        {
            InitializeComponent();
        }

        public static string campany_name = "";

        private void login_Click(object sender, EventArgs e)
        {
            var username = this.username.Text;
            var password = this.password.Text;
            var res = conn.CampanyLogin(username, password);
            if (res == true)
            {
                campany_name = username;
                DialogResult dr = MessageBox.Show("登陆成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                campanyFunction messageForm = new campanyFunction();
                messageForm.Show();
                this.Close();
            }
            else
            {
                DialogResult dr = MessageBox.Show("不能成功登录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            campanyRegister messageForm = new campanyRegister();
            messageForm.Show();
            this.Close();
        }
    }
}
