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
    public partial class admin_control : Form
    {
        public admin_control()
        {
            InitializeComponent();
        }

        private void studentlogin_Click(object sender, EventArgs e)
        {
            student_control messageForm = new student_control();
            messageForm.init();
            messageForm.Show();
            this.Close();
        }

        private void adminlogin_Click(object sender, EventArgs e)
        {
            work_control messageForm = new work_control();
            messageForm.init();
            messageForm.Show();
            this.Close();
        }

        private void campanylogin_Click(object sender, EventArgs e)
        {
            campany_control messageForm = new campany_control();
            messageForm.init();
            messageForm.Show();
            this.Close();
        }
    }
}
