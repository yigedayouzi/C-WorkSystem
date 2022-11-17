using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Configuration;
using MySql.Data;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using System.Drawing;

namespace WindowsFormsApp1

{
    class conn
    {
        static string constr = "server=localhost;User Id=root;password=root;Database=text";
        public static string salt = "s8m3k,1l2";



        //学生注册
        public static bool StudentRegister(string username, string password, string email, string phone)
        {
            MySqlConnection mycon = new MySqlConnection(conn.constr);

            mycon.Open();
            string md5 = ComputeHash(salt + password);
            string sql = "insert into student(username,password,email,phone) values('" + username + "','" + md5 + "','" + email + "', '" + phone + "')";

            MySqlCommand mycmd = new MySqlCommand(sql, mycon);
            if (mycmd.ExecuteNonQuery() > 0)
            {
                mycon.Close();
                return true;
            }

            mycon.Close();
            return false;

        }


        //新建简历
        public static bool StudentList(string name, string age, string school, string tech, string awa)
        {
            MySqlConnection mycon = new MySqlConnection(conn.constr);

            mycon.Open();
  
            string sql = "insert into studentlist(name,age,school,tech,awa) values('" + name + "','" + age+ "','" + school + "', '" + tech + "', '" + awa + "')";

            MySqlCommand mycmd = new MySqlCommand(sql, mycon);
            if (mycmd.ExecuteNonQuery() > 0)
            {
                mycon.Close();
                return true;
            }

            mycon.Close();
            return false;

        }

        //向企业发送消息
        public static bool StudentChat(string studentName, string campanyName, string say)
        {
            MySqlConnection mycon = new MySqlConnection(conn.constr);

            mycon.Open();

            string sql = "insert into chat(studentName,campanyName,say) values('" + studentName + "','" + campanyName + "','" + say + "')";

            MySqlCommand mycmd = new MySqlCommand(sql, mycon);
            if (mycmd.ExecuteNonQuery() > 0)
            {
                mycon.Close();
                return true;
            }

            mycon.Close();
            return false;

        }


        //向学生发送消息
        public static bool CampanyChat(string studentName, string campanyName, string say)
        {
            MySqlConnection mycon = new MySqlConnection(conn.constr);

            mycon.Open();

            string sql = "insert into chat(studentName,campanyName,say) values('" + studentName + "','" + campanyName + "','" + say + "')";

            MySqlCommand mycmd = new MySqlCommand(sql, mycon);
            if (mycmd.ExecuteNonQuery() > 0)
            {
                mycon.Close();
                return true;
            }

            mycon.Close();
            return false;

        }
        //招聘信息发布
        public static bool LL(string name1, string campany1,string position1,string num1,string require1,string phone1,string el1)
        {
            MySqlConnection mycon = new MySqlConnection(conn.constr);

            mycon.Open();

            string sql = "insert into works(name,campany,position,num,re,phone,el) values('" + name1 + "','" + campany1 + "','" + position1 + "', '" + num1 + "' ,'" + require1 + "','" + phone1 + "','" + el1 + "')";

            MySqlCommand mycmd = new MySqlCommand(sql, mycon);
            if (mycmd.ExecuteNonQuery() > 0)
            {
                mycon.Close();
                return true;
            }

            mycon.Close();
            return false;
        }


            //删除数据
        public static bool DeleteData(string name)
        {
            MySqlConnection mycon = new MySqlConnection(conn.constr);

            mycon.Open();

            string sql = $"delete from works where name='{name}'";

            MySqlCommand mycmd = new MySqlCommand(sql, mycon);

            if (mycmd.ExecuteNonQuery() > 0)
            {
                mycon.Close();
                return true;
            }

            mycon.Close();
            return false;

        }


        //删除员工数据
        public static bool DeleteStudentChoseData(string name)
        {
            MySqlConnection mycon = new MySqlConnection(conn.constr);

            mycon.Open();

            string sql = $"delete from chose_list where student_name='{name}'";

            MySqlCommand mycmd = new MySqlCommand(sql, mycon);

            if (mycmd.ExecuteNonQuery() > 0)
            {
                mycon.Close();
                return true;
            }

            mycon.Close();
            return false;

        }

        //删除学生
        public static bool DeleteStudentData(string username)
        {
            MySqlConnection mycon = new MySqlConnection(conn.constr);

            mycon.Open();

            string sql = $"delete from student where username='{username}'";

            MySqlCommand mycmd = new MySqlCommand(sql, mycon);

            if (mycmd.ExecuteNonQuery() > 0)
            {
                mycon.Close();
                return true;
            }

            mycon.Close();
            return false;

        }


        //删除企业
        public static bool DeleteCampanyData(string username)
        {
            MySqlConnection mycon = new MySqlConnection(conn.constr);

            mycon.Open();

            string sql = $"delete from campany where username='{username}'";

            MySqlCommand mycmd = new MySqlCommand(sql, mycon);

            if (mycmd.ExecuteNonQuery() > 0)
            {
                mycon.Close();
                return true;
            }

            mycon.Close();
            return false;

        }

        //企业注册
        public static bool CampanyRegister(string username, string password, string campany_name)
        {
            MySqlConnection mycon = new MySqlConnection(conn.constr);

            mycon.Open();
            string md5 = ComputeHash(salt + password);
            string sql = "insert into campany(username,password,campany_name) values('" + username + "','" + md5 + "','" + campany_name + "')";

            MySqlCommand mycmd = new MySqlCommand(sql, mycon);
            if (mycmd.ExecuteNonQuery() > 0)
            {
                mycon.Close();
                return true;
            }

            mycon.Close();
            return false;

        }


        //学生登录
        public static bool StudentLogin(string username, string password)
        {
            MySqlConnection mycon = new MySqlConnection(conn.constr);
            mycon.Open();
            var sql = "select status from student where username='" + username + "'";
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);
            MySqlDataReader dr = mycmd.ExecuteReader();
            var res = "";
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    res = dr.GetString(0);
                }
                if (res == "")
                {
                    dr.Close();
                    return false;
                }
            }
            dr.Close();
            var md5 = ComputeHash(salt + password);
            sql = "select password from student where username='" + username + "'";
            MySqlCommand mycmd1 = new MySqlCommand(sql, mycon);          
            MySqlDataReader dr1 = mycmd1.ExecuteReader();
            res = "";
            if (dr1.HasRows)
　　　　    {
　　　　 　　    while (dr1.Read())
　　　　　　     {
                    res = dr1.GetString(0);
　　　　  　     }
                if(md5 == res)
                {
                    dr1.Close();
                    return true;
                }
　　　　    }
　　　　    dr1.Close();
            mycon.Close();
            return false;
        }



        //企业登录
        public static bool CampanyLogin(string username, string password)
        {
            MySqlConnection mycon = new MySqlConnection(conn.constr);
            mycon.Open();
            var sql = "select status from campany where username='" + username + "'";
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);
            MySqlDataReader dr = mycmd.ExecuteReader();
            var res = "";
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    res = dr.GetString(0);
                }
                if (res == "")
                {
                    dr.Close();
                    return false;
                }
            }
            dr.Close();
            var md5 = ComputeHash(salt + password);
            sql = "select password from campany where username='" + username + "'";
            MySqlCommand mycmd1 = new MySqlCommand(sql, mycon);
            MySqlDataReader dr1 = mycmd1.ExecuteReader();
            res = "";
            if (dr1.HasRows)
            {
                while (dr1.Read())
                {
                    res = dr1.GetString(0);
                }
                if (md5 == res)
                {
                    dr1.Close();
                    return true;
                }
            }
            dr1.Close();
            mycon.Close();
            return false;
        }


        //管理员登录
        public static bool AdminLogin(string username, string password)
        {
            MySqlConnection mycon = new MySqlConnection(conn.constr);
            mycon.Open();

            var md5 = ComputeHash(salt + password);
            var sql = "select password from admin where username=" + username;
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);

            MySqlDataReader dr = mycmd.ExecuteReader();

            var res = "";
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    res = dr.GetString(0);
                }
                if (md5 == res)
                {
                    dr.Close();
                    return true;
                }
            }


            dr.Close();
            mycon.Close();
            return false;
        }

        public static string ComputeHash(string sourceText, bool toUpper = true)
        {
            if (sourceText == null)
                return null;

            StringBuilder result = new StringBuilder();
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(sourceText));
                if (toUpper)
                    for (int i = 0; i < data.Length; i++)
                        result.Append(data[i].ToString("X2"));
                else
                    for (int i = 0; i < data.Length; i++)
                        result.Append(data[i].ToString("x2"));
            }

            return result.ToString();
        }
    }

}