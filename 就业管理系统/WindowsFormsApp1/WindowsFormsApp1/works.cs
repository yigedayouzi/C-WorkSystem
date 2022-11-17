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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class works : Form
    {
        public works()
        {
            InitializeComponent();
        }
        

        static string constr = "server=localhost;User Id=root;password=root;Database=text";
        public void init()
        {
            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();

            var sql = "select * from works" ;
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);

            mycmd.CommandText = "select * from works";

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

            var sql = "select name, campany, position, num from works where name= '"+ name+"'";
     
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);

            MySqlDataReader dr = mycmd.ExecuteReader();

            var student_name = StudentLogin.student_name;
            var student_phone = "";
            var student_email = "";
            var work_name = "";
            var work_campany = "";
            var work_position = "";
            var range = 0;
            var status = "";
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    work_name = dr.GetString(0);
                    work_campany= dr.GetString(1);
                    work_position = dr.GetString(2);
                    range = dr.GetInt32(3);
                }
                if(range <= 0)
                {
                    DialogResult dr1 = MessageBox.Show("岗位已满", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            dr.Close();

            sql = "select phone, email from student where username='" + student_name + "'";
            mycmd = new MySqlCommand(sql, mycon);
            dr = mycmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read()) {
                    student_phone = dr.GetString(0);
                    student_email = dr.GetString(1);
                }
            }
           
            dr.Close();
            mycon.Close();

            mycon.Open();
            sql = "insert into chose_list(student_name, student_phone, student_email," +
                "work_name, work_campany,work_position," +
                "status) value('" + student_name + "','" + student_phone + "','" + student_email + "','" + work_name
                + "','" + work_campany + "','" + work_position + "','" + status +"')";
            mycmd = new MySqlCommand(sql, mycon);
            if (mycmd.ExecuteNonQuery() > 0)
            {
                mycon.Close();
                DialogResult dr2 = MessageBox.Show("投递成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            mycon.Close();
            DialogResult dr3 = MessageBox.Show("投递失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            studentFunction messageForm = new studentFunction();
            messageForm.Show();
            this.Close();
        }
    }
}