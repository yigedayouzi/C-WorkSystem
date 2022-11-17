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
    public partial class StudentChose : Form
    {
        public StudentChose()
        {
            InitializeComponent();
        }

        static string constr = "server=localhost;User Id=root;password=root;Database=text";

        public void init()
        {
            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();

            var sql = "select * from chose_list where work_campany='" + CampanyLogin.campany_name + "'";
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);

            mycmd.CommandText = sql;

            MySqlDataAdapter adap = new MySqlDataAdapter(mycmd);

            DataSet ds = new DataSet();

            adap.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }

  

        private void button1_Click(object sender, EventArgs e)
        {

            string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取名称
            label2.Text = name;

            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();

            var sql = "update chose_list set status='allow' where student_name='" + name + "'";
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);
            mycmd = new MySqlCommand(sql, mycon);
            if (mycmd.ExecuteNonQuery() > 0)
            {
                mycon.Close();
                init();
                DialogResult dr2 = MessageBox.Show("审核成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
               
            }
        }


     

        private void button2_Click(object sender, EventArgs e)
        {

            campanyFunction messageForm = new campanyFunction();
            messageForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取名称
            label2.Text = name;
            DialogResult dr = MessageBox.Show("是否删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                var res = conn.DeleteStudentChoseData(name);
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

        private void button4_Click(object sender, EventArgs e)
        {
            string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取名称
            label2.Text = name;

            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();

            var sql = "update chose_list set status='' where student_name='" + name + "'";
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);
            mycmd = new MySqlCommand(sql, mycon);
            if (mycmd.ExecuteNonQuery() > 0)
            {
                mycon.Close();
                init();
                DialogResult dr2 = MessageBox.Show("取消审核成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
               
            }
        }
    }
}
