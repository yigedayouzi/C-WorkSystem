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
    public partial class campanyFunction : Form
    {
        public campanyFunction()
        {
            InitializeComponent();
        }

        private void studentChoose(object sender, EventArgs e)
        {
            StudentChose messageForm = new StudentChose();
            messageForm.init();
            messageForm.Show();
            this.Close();
        }

        private void putMessage(object sender, EventArgs e)
        {
            infoPublish messageForm = new infoPublish();         
            messageForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chat messageForm = new chat();

            messageForm.Show();

            this.Close();
        }
    }
}
