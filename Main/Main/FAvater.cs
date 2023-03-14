using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Sunny.UI.Demo
{
    public partial class FAvatar : UITitlePage
    {
        public FAvatar()
        {
            InitializeComponent();
        }


        private void button_login_Click(object sender, EventArgs e)
        {
            if(uiTextBox1.Text.ToString()=="" )
            {
                MessageBox.Show("ID输入不能为空!");
                return;
            }
            if (uiTextBox2.Text.ToString() == "")
            {
                MessageBox.Show("密码输入不能为空!");
                return;
            }
            string pattern = "^[0-9]*$";
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(uiTextBox1.Text.ToString()))
            {
                MessageBox.Show("请输入纯数字id");
                uiTextBox1.Clear();
                return;
            }

            if (uiTextBox1.Text.ToString().Length > 9)
            {
                MessageBox.Show("ID号不能超过9位");
                uiTextBox1.Clear();
                return;
            }

            int id = int.Parse(uiTextBox1.Text.ToString());

            string type = login(id, uiTextBox2.Text.Trim());

            if (type == "Buyer")
            {
                //跳转至买家页面
                this.Hide();
            }
            else if (type == "Seller")
            {
                //跳转至卖家页面
                this.Hide();
            }
            else if (type == "administrator")
            {
                //跳转至管理员界面
                this.Hide();
            }
            else
            {
                uiTextBox2.Clear();
                return;
            }
        }

        private string login(int userID, string pwd)
        {
            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            MySqlConnection con = new MySqlConnection(connString);
            con.Open();

            //SQL
            using (MySqlCommand cmd = new MySqlCommand("select ID, password, type from user", con))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32("ID");
                    string p = reader.GetString("password");
                    string type = reader.GetString("type");
                    if (id == userID && p == pwd)
                    {
                        MessageBox.Show("登录成功！即将跳转至" + type + "界面");
                        return type;
                    }
                }

                MessageBox.Show("登录失败！id 或者密码不正确");
            }

            con.Close();
            return "false";
        }
        //private void uiAvatar4_Click(object sender, EventArgs e)
        //{
        //    uiContextMenuStrip1.Show(uiAvatar4, 0, uiAvatar4.Height);
        //}
    }
}