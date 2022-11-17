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
    public partial class studentList : Form
    {
        public studentList()
        {
            InitializeComponent();
        }


        //重置
        private void reinput_Click(object sender, EventArgs e)
        {
            this.name.Text = "";
            this.age.Text = "";
            this.school.Text = "";
            this.tech.Text = "";
            this.awa.Text = "";
        }

        //返回
        private void button2_Click(object sender, EventArgs e)
        {
            studentFunction messageForm = new studentFunction();

            messageForm.Show();

            this.Close();
        }


      //创建
        private void button1_Click(object sender, EventArgs e)
        {
            var name = this.name.Text;
            var age = this.age.Text;
            var school = this.school.Text;
            var tech = this.tech.Text;
            var awa = this.awa.Text;
            var res = conn.StudentList(name,age,school,tech,awa);
            if (res == true)
            {
                //如果注册成功，提示
                DialogResult dr = MessageBox.Show("创建成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

               
                studentFunction messageForm = new studentFunction();
                messageForm.Show();
                this.Close();
            }
            else
            {
                //如果注册失败，提示
                DialogResult dr = MessageBox.Show("创建失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

    }
}
