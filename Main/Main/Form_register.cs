using MySql.Data.MySqlClient;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form_register : UIForm
    {
        public Form_register()
        {
            InitializeComponent();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            string type = "";
            if (this.listBox_type.SelectedItem != null)
            {
                type = this.listBox_type.SelectedItem.ToString();
            }
            else
            {
                Point place = new System.Drawing.Point(738, 280);
                UIMessageTip.ShowError(text: " 请选择你要注册的用户类型", point: place);
                //this.ShowInfoDialog("请选择你要注册的用户类型",Style);
                return;
            }

            //输入框输入不能为空判断
            if(textBox_id.Text.ToString()=="")
            {
                Point place = new System.Drawing.Point(738, 280);
                UIMessageTip.ShowError(text: " id输入不能为空", point: place);
                //this.ShowInfoDialog("id输入不能为空",Style);
                return;
            }

            if (textBox_username.Text.ToString() == "")
            {
                Point place = new System.Drawing.Point(738, 280);
                UIMessageTip.ShowError(text: " 用户名输入不能为空", point: place);
                //this.ShowInfoDialog("用户名输入不能为空",Style);
                return;
            }

            if (textBox_password.Text.ToString() == "")
            {
                Point place = new System.Drawing.Point(738, 280);
                UIMessageTip.ShowError(text: " 密码输入不能为空", point: place);
                //this.ShowInfoDialog("密码输入不能为空",Style);
                return;
            }

            string pattern = "^[0-9]*$";
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(textBox_id.Text.ToString()))
            {
                Point place = new System.Drawing.Point(738, 280);
                UIMessageTip.ShowError(text: " 请输入纯数字ID", point: place);
                //this.ShowInfoDialog("请输入纯数字id",Style);
                textBox_id.Clear();
                return;
            }

            if (textBox_id.Text.ToString().Length > 9)
            {
                Point place = new System.Drawing.Point(738, 280);
                UIMessageTip.ShowError(text: " ID号不能超过9位", point: place);
                //this.ShowInfoDialog("ID号不能超过9位",Style);
                textBox_id.Clear();
                return;
            }

            int id = int.Parse(textBox_id.Text.ToString());

            if (textBox_password.Text.Trim().Length < 6)
            {
                Point place = new System.Drawing.Point(738, 280);
                UIMessageTip.ShowError(text: " 密码太短啦，请输入6位以上密码", point: place);
               // this.ShowInfoDialog("密码太短啦，请输入6位以上密码",Style);
                textBox_password.Clear();
                return;
            }

            if (textBox_password.Text.Trim().Length > 20)
            {
                Point place = new System.Drawing.Point(738, 280);
                UIMessageTip.ShowError(text: " 密码太长啦，请输入20位以下密码", point: place);
                //this.ShowInfoDialog("密码太长啦，请输入20位以下密码",Style);
                textBox_password.Clear();
                return;
            }

            if (textBox_password.Text.LastIndexOf(" ") != -1)
            {
                Point place = new System.Drawing.Point(738, 280);
                UIMessageTip.ShowError(text: " 密码中不能含有空格", point: place);
                //this.ShowInfoDialog("密码中不能含有空格",Style);
                textBox_password.Clear();
                return;
            }

            if (textBox_username.Text.Trim().Length > 20)
            {
                Point place = new System.Drawing.Point(738, 280);
                UIMessageTip.ShowError(text: " 用户名太长啦，请输入20位以下用户名", point: place);
              //  this.ShowInfoDialog("用户名太长啦，请输入20位以下用户名",Style);
                textBox_username.Clear();
                return;
            }

            if (register(id, textBox_username.Text.Trim(), textBox_password.Text.Trim(), type))
            {
                Thread.Sleep(500);//延迟0.5秒以显示登录成功轻便提示
                Form_login.id_global = id;
                Form_login.type_global = type;
                if (type == "顾客")
                {
                    //跳转至顾客页面
                    Form_Customer form_Customer = new Form_Customer();
                    form_Customer.Show();
                    Form_login.maincurse = this.Owner;
                    this.Hide();
                }
                else if (type == "卖家")
                {
                    //跳转至卖家页面
                    Form_Seller form_seller = new Form_Seller();
                    form_seller.Show();
                    Form_login.maincurse = this.Owner;
                    this.Hide();
                }
                else if (type == "管理员")
                {
                    //跳转至管理员界面
                    Form_Administrator form_administrator = new Form_Administrator();
                    form_administrator.Show();
                    Form_login.maincurse = this.Owner;
                    this.Hide();
                }
            }
            else
            {
                textBox_id.Clear();
                return;
            }
        }
        private bool register(int userID, string userName, string Pwd, string userType)
        {

            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            MySqlConnection con = new MySqlConnection(connString);
            con.Open();

            // SQL
            MySqlCommand com = new MySqlCommand("select ID from user where ID='" + userID + "'", con);
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataSet ds = new DataSet();

            int n = da.Fill(ds, "register");
            if (n != 0)
            {
                Point place = new System.Drawing.Point(738, 280);
                UIMessageTip.ShowError(text: " id 已存在！ 请换一个", point: place);
                con.Close();
                return false;
            }
            else
            {
                // SQL
                com = new MySqlCommand("insert into user values ("
                    + userID + ",'" + userName + "','" + Pwd + "','" + userType + "')", con);
                com.ExecuteNonQuery();
                com = null;
                if (userType == "顾客")//在此处写上代表customer的标识
                {
                    //同时在customer表中插入
                    com = new MySqlCommand("insert into customer values ("
                    + userID + ",'" + userName + "','" + 0 + "','" + 0 + "')", con);
                    com.ExecuteNonQuery();
                    com = null;
                }
                else if(userType=="卖家")
                {
                    //同时在seller表中插入
                    com = new MySqlCommand("insert into seller values ("
                    + userID + ",'" + userName + "','" + 0  + "')", con);
                    com.ExecuteNonQuery();
                    com = null;
                }
                else
                {
                    //同时在administrator表中插入
                    com = new MySqlCommand("insert into administrator values ("
                    + userID + ",'" + userName + "')", con);
                    com.ExecuteNonQuery();
                    com = null;

                }

                Point place = new System.Drawing.Point(738, 280);
                UIMessageTip.ShowOk(text: " 注册成功！即将自动登录", point: place);
                //this.ShowInfoDialog("注册成功！即将自动登录",Style);
                con.Close();
                return true;
            }

        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Form_register_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

       
    }
}
