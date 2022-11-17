using MySql.Data.MySqlClient;
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
    public partial class campany_control : Form
    {
        public campany_control()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        static string constr = "server=localhost;User Id=root;password=root;Database=text";
        public void init()
        {
            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();

            var sql = "select * from campany";
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);

            MySqlDataAdapter adap = new MySqlDataAdapter(mycmd);

            DataSet ds = new DataSet();

            adap.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }

         private void button2_click(object sender, EventArgs e)
        {

            admin_control messageForm = new admin_control();
            messageForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取名称
            label2.Text = username;
            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();

            var sql = "update campany set status='allow' where username='" + username + "'";
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);
            mycmd = new MySqlCommand(sql, mycon);
            if (mycmd.ExecuteNonQuery() > 0)
            {
                mycon.Close();
                DialogResult dr2 = MessageBox.Show("审核成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                init();
                return;
            }
        }

        private void delete(object sender, EventArgs e)
        {

            string username = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取名称
            label2.Text = username;
            DialogResult dr = MessageBox.Show("是否删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                var res = conn.DeleteCampanyData(username);
                if (res == true)
                {
                    init();
                    MessageBox.Show("删除成功");
                }

            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }
    }
}
