using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StudentRegister : Form
    {
        public StudentRegister()
        {
            InitializeComponent();
        }

        private void reinput_Click(object sender, EventArgs e)
        {
            this.username.Text = "";
            this.password.Text = "";
            this.email.Text = "";
            this.phone.Text = "";
        }

        private void regbutton_Click(object sender, EventArgs e)
        {
            var username = this.username.Text;
            var password = this.password.Text;
            var email = this.email.Text;
            var phone = this.phone.Text;
            var res = conn.StudentRegister(username, password, email, phone);
            if(res == true)
            {
                //如果注册成功，提示
                DialogResult dr = MessageBox.Show("注册成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //打开学生登录界面并关闭当前页面
                StudentLogin messageForm = new StudentLogin();
                messageForm.Show();
                this.Close();
            }
            else
            {
                //如果注册失败，提示
                DialogResult dr = MessageBox.Show("注册失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void phone_Click(object sender, EventArgs e)
        {

        }
    }
}
