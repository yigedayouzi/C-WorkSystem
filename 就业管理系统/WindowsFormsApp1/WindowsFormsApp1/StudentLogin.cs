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
    public partial class StudentLogin : Form
    {
        public static string student_name;
        public StudentLogin()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            StudentRegister messageForm = new StudentRegister();
            messageForm.Show();
            this.Close();
        }

        private void login_Click(object sender, EventArgs e)
        {
            var username = this.username.Text;
            var password = this.password.Text;
            var res = conn.StudentLogin(username, password);
            if(res == true)

            {   //登录成功，提示
                DialogResult dr = MessageBox.Show("登陆成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                student_name = username;

                //打开works页面并关闭当前页面
                studentFunction messageForm = new studentFunction();
               
                messageForm.Show();
                this.Close();
            }
            else
            {
                DialogResult dr = MessageBox.Show("不能成功登录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
