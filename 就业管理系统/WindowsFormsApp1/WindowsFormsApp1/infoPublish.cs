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
    public partial class infoPublish : Form
    {
        public infoPublish()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.name.Text = "";
            this.campany.Text = "";
            this.position.Text = "";
            this.num.Text = "";
            this.require.Text = "";
            this.phone.Text = "";
            this.el.Text = "";
        }

        private void regbutton_Click(object sender, EventArgs e)
        {
            var name1 = this.name.Text;
            var campany1= this.campany.Text;
            var position1= this.position.Text;
            var num1= this.num.Text;
            var require1= this.require.Text;
            var phone1= this.phone.Text;
            var el1= this.el.Text;
            var res = conn.LL(name1, campany1, position1, num1, require1, phone1, el1);

            if (res == true)
            {
                //如果注册成功，提示
                DialogResult dr = MessageBox.Show("发布成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //如果注册失败，提示
                DialogResult dr = MessageBox.Show("注册失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            campanyFunction messageForm = new campanyFunction();
            messageForm.Show();
            this.Close();
        }
    }
}
