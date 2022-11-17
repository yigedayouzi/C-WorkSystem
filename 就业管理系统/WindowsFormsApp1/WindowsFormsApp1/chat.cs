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
    public partial class chat : Form
    {
        static string constr = "server=localhost;User Id=root;password=root;Database=text";
        public chat()
        {
            InitializeComponent();
        }
        public void init()
        {
            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();

            var sql = "select * from chat where campanyName='" + CampanyLogin.campany_name + "'";
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);

            mycmd.CommandText = sql;

            MySqlDataAdapter adap = new MySqlDataAdapter(mycmd);

            DataSet ds = new DataSet();

            adap.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }
        private void studentChat(object sender, EventArgs e)
        {
            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();

            var sql = "select * from chat where campanyName='" + CampanyLogin.campany_name + "'";
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);

            mycmd.CommandText = sql;

            MySqlDataAdapter adap = new MySqlDataAdapter(mycmd);

            DataSet ds = new DataSet();

            adap.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0].DefaultView;



            MySqlConnection MysqlConnection = new MySqlConnection();
            string cons = "server=localhost;User Id=root;password=root;Database=text";
            MysqlConnection.ConnectionString = cons;
            MySqlCommand MysqlCommand = new MySqlCommand();
            MysqlCommand.Connection = MysqlConnection;
            MysqlCommand.CommandText = "select * from campany where username='" + CampanyLogin.campany_name + "'";
            MysqlCommand.Parameters.AddWithValue("@username", this.campanyName.Text);
            MysqlConnection.Open();
            MySqlDataReader MySqlDataReader = MysqlCommand.ExecuteReader();
            if (MySqlDataReader.Read())
            {
                this.campanyName.Text = MySqlDataReader["username"].ToString();

            }
            MySqlDataReader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            campanyFunction messageForm = new campanyFunction();

            messageForm.Show();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var studentName = this.studentName.Text;
            var campanyName = this.campanyName.Text;
            var say = this.say.Text;

            var res = conn.CampanyChat(studentName, campanyName, say);
            if (res == true)
            {
                //如果注册成功，提示
                DialogResult dr = MessageBox.Show("发送成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                init();

            }
            else
            {
                //如果注册失败，提示
                DialogResult dr = MessageBox.Show("发送失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
