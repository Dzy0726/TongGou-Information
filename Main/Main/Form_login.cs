using MySql.Data.MySqlClient;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form_login : UIForm
    {
        public Form_login()
        {
            InitializeComponent();
        }

        public static int id_global;
        public static string type_global;
        public static Form maincurse;

        private void button_login_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (!int.TryParse(textBox_id.Text.Trim(), out id))
            {
                Point place = new System.Drawing.Point(738, 280);
                UIMessageTip.ShowError(text: " 请输入纯数字ID", point: place);
                textBox_id.Clear();
                return;
            }

            string type = login(id, textBox_password.Text.Trim());

            id_global = id;
            type_global = type;
            maincurse = this.Owner;

            Thread.Sleep(500);
            if (type == "顾客")
            {
                //跳转至顾客页面
                Form_Customer form_customer = new Form_Customer();
                form_customer.Show();
                this.Hide();
                ClearBox();
            }
            else if (type == "卖家")
            {
                //跳转至卖家页面
                Form_Seller form_seller = new Form_Seller();
                form_seller.Show();
                this.Hide();
                ClearBox();
            }
            else if (type == "管理员")
            {
                //跳转至管理员界面
                Form_Administrator form_administrator = new Form_Administrator();
                form_administrator.Show();
                this.Hide();
                ClearBox();
            }
            else
            {
                textBox_password.Clear();
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
                Point place = new System.Drawing.Point(738, 280);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32("ID");
                    string p = reader.GetString("password");
                    string type = reader.GetString("type");
                    if (id == userID && p == pwd)
                    {
                        UIMessageTip.ShowOk(text: "登录成功！即将跳转至" + type + "界面", point: place);
                        return type;
                    }
                }
                
                UIMessageTip.ShowError(text: " 登录失败！ID 或者密码不正确", point: place);
            }

            con.Close();
            return "false";
        }

        private void Form_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        public void ClearBox()//登录成功后清空textbox,以便注销回来时textbox都是空的
        {
            textBox_id.Clear();
            textBox_password.Clear();
        }
    }
}
