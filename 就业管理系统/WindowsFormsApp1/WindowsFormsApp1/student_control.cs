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
    public partial class student_control : Form
    {
        public student_control()
        {
            InitializeComponent();
        }

        private void student_control_Load(object sender, EventArgs e)
        {

        }

        static string constr = "server=localhost;User Id=root;password=root;Database=text";
        
        //获取数据
        public void init()
        {
            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();

            var sql = "select * from student";
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);

            MySqlDataAdapter adap = new MySqlDataAdapter(mycmd);

            DataSet ds = new DataSet();

            adap.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //更新数据
        private void button1_Click(object sender, EventArgs e)
        {

            string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取名称
            label2.Text = name;

            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();

            var sql = "update student set status='allow' where username='" + name + "'";
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);
            mycmd = new MySqlCommand(sql, mycon);
            if (mycmd.ExecuteNonQuery() > 0)
            {
                mycon.Close();
                DialogResult dr2 = MessageBox.Show("审核成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                
                init();  //重新获取数据，刷新页面
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin_control messageForm = new admin_control();
            messageForm.Show();
            this.Close();
        }

        private void delete(object sender, EventArgs e)
        {
            string username = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取名称
            label2.Text = username;
            DialogResult dr = MessageBox.Show("是否删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                var res = conn.DeleteStudentData(username);
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
