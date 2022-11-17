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
    public partial class studentListView : Form
    {
        public studentListView()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentFunction messageForm = new studentFunction();

            messageForm.Show();

            this.Close();
        }

        private void studentListView_Load(object sender, EventArgs e)
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
    }
}
