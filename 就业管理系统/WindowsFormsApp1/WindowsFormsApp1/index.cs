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
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void index_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentLogin messageForm = new StudentLogin();
            messageForm.Show();
        }

        private void campanylogin_Click(object sender, EventArgs e)
        {
            CampanyLogin messageForm = new CampanyLogin();
            messageForm.Show();
        }

        private void adminlogin_Click(object sender, EventArgs e)
        {
            AdminLogin messageForm = new AdminLogin();
            messageForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}