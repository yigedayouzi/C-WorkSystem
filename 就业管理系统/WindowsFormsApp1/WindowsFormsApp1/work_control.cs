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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class work_control : Form
    {
        public work_control()
        {
            InitializeComponent();
        }
        static string constr = "server=localhost;User Id=root;password=root;Database=text";
        public void init()
        {
            MySqlConnection mycon = new MySqlConnection(constr);
            mycon.Open();

            var sql = "select * from works";
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);

            MySqlDataAdapter adap = new MySqlDataAdapter(mycmd);

            DataSet ds = new DataSet();

            adap.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button21_click(object sender, EventArgs e)
        {
            admin_control messageForm = new admin_control();
            messageForm.Show();
            this.Close();
        }

        private void delect(object sender, EventArgs e)
        {
           
                string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取名称
                label2.Text = name;
                DialogResult dr = MessageBox.Show("是否删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK ) 
                {
                    var res = conn.DeleteData(name);
                    if(res == true)
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
