using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class studentListChange : Form
    {

        
        public studentListChange()
        {
            InitializeComponent();
        }


        public void init()
        {
            MySqlConnection MysqlConnection = new MySqlConnection();
            string constr = "server=localhost;User Id=root;password=root;Database=text";
            MysqlConnection.ConnectionString = constr;
            MySqlCommand MysqlCommand = new MySqlCommand();
            MysqlCommand.Connection = MysqlConnection;
            MysqlCommand.CommandText = "select * from studentlist where name='" + StudentLogin.student_name + "'";
            MysqlCommand.Parameters.AddWithValue("@name", this.name.Text);
            MysqlConnection.Open();
            MySqlDataReader MySqlDataReader = MysqlCommand.ExecuteReader();
            if (MySqlDataReader.Read())
            {
                this.name.Text = MySqlDataReader["name"].ToString();
                this.age.Text = MySqlDataReader["age"].ToString();
                this.school.Text = MySqlDataReader["school"].ToString();
                this.tech.Text = MySqlDataReader["tech"].ToString();
                this.awa.Text = MySqlDataReader["awa"].ToString();
            }
            MySqlDataReader.Close();
        }


        private void bd_Load(object sender, EventArgs e)
        {


            MySqlConnection MysqlConnection = new MySqlConnection();
            string constr = "server=localhost;User Id=root;password=root;Database=text";
            MysqlConnection.ConnectionString = constr;
            MySqlCommand MysqlCommand = new MySqlCommand();
            MysqlCommand.Connection = MysqlConnection;
            MysqlCommand.CommandText = "select * from studentlist where name='" + StudentLogin.student_name + "'";
            MysqlCommand.Parameters.AddWithValue("@name", this.name.Text);
            MysqlConnection.Open();
            MySqlDataReader MySqlDataReader = MysqlCommand.ExecuteReader();
            if(MySqlDataReader.Read())
            {
                this.name.Text = MySqlDataReader["name"].ToString();
                this.age.Text= MySqlDataReader["age"].ToString();
                this.school.Text = MySqlDataReader["school"].ToString();
                this.tech.Text = MySqlDataReader["tech"].ToString();
                this.awa.Text = MySqlDataReader["awa"].ToString();
            }
            MySqlDataReader.Close();
        }


        //返回
        private void button2_Click(object sender, EventArgs e)
        {
            studentFunction messageForm = new studentFunction();

            messageForm.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.name.Text = "";
            this.age.Text = "";
            this.school.Text = "";
            this.tech.Text = "";
            this.awa.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "server=localhost;User Id=root;password=root;Database=text";

            string name;
            string age;
            string school;
            string tech;
            string awa;

            name = this.name.Text;
            age = this.age.Text;
            school = this.school.Text;
            tech = this.tech.Text;
            awa = this.awa.Text;


            MySqlConnection MyConnection = new MySqlConnection(constr);

            string MyUpdate = "Update studentlist set age='" +age + "',school='" + school + "',tech='" + tech + "',awa='" + awa + "'  Where name='"+name+"'";


            MySqlCommand MyCommand = new MySqlCommand(MyUpdate, MyConnection);
            try
            {
                MyConnection.Open();
                MyCommand.ExecuteNonQuery();
                MyConnection.Close();
                this.name.Text = "";
                this.age.Text = "";
                this.school.Text = "";
                this.tech.Text = "";
                this.awa.Text = "";
                init();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
