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
    public partial class studentFunction : Form
    {
        public studentFunction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            works messageForm = new works();
            
            messageForm.Show();
            messageForm.init();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentList messageForm = new studentList();

            messageForm.Show();
        
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            studentListChange messageForm = new studentListChange();

            messageForm.Show();

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            studentListView messageForm = new studentListView();

            messageForm.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           studentChat messageForm = new studentChat();

            messageForm.Show();

            this.Close();
        }
    }
}
