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
    public partial class campanyRegister : Form
    {
        public campanyRegister()
        {
            InitializeComponent();
        }

        private void reinput_Click(object sender, EventArgs e)
        {
            this.username.Text = "";
            this.password.Text = "";
            this.campany_name.Text = "";
            
        }

        private void regbutton_Click(object sender, EventArgs e)
        {
            var username = this.username.Text;
            var password = this.password.Text;
            var campany_name = this.campany_name.Text;
           
            var res = conn.CampanyRegister(username, password, campany_name);
            if (res == true)
            {
                //如果注册成功，提示
                DialogResult dr = MessageBox.Show("注册成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //打开学生登录界面并关闭当前页面
                CampanyLogin messageForm = new CampanyLogin();
                messageForm.Show();
                this.Close();
            }
            else
            {
                //如果注册失败，提示
                DialogResult dr = MessageBox.Show("注册失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
