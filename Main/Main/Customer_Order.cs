using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Customer_Order : UITitlePage
    {
        public int searchMode;
        public Customer_Order()
        {
            InitializeComponent();
        }

        private void uiComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(uiComboBox2.SelectedIndex==0)//选择按订单号查询
            {
                uiPanel_Order.Visible = true;
                uiPanel_date.Visible = false;
                searchMode = 0;

            }

            if (uiComboBox2.SelectedIndex == 1)//选择按日期查询
            {
                uiPanel_date.Visible = true;
                uiPanel_Order.Visible = false;
                searchMode = 1;

            }
        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiComboBox1.SelectedIndex == 0)//选择年-月-日
            {
                uiLabel1.Visible = true;
                dtp_date.DateFormat = "yyyy - MM - dd";
                btn_date.Visible = true;
                dtp_date.Visible = true;
                uiAvatar1.Visible = true;
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年-月-日)";
                btn_date.Location = new System.Drawing.Point(514, 123);
            }
            else if (uiComboBox1.SelectedIndex == 1)//选择年-月
            {
                uiLabel1.Visible = true;
                dtp_date.DateFormat = "yyyy - MM";
                btn_date.Visible = true;
                dtp_date.Visible = true;
                uiAvatar1.Visible = true;
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年-月)";
                btn_date.Location = new System.Drawing.Point(514, 123);
            }
            else if (uiComboBox1.SelectedIndex == 2)//选择年
            {
                uiLabel1.Visible = true;
                dtp_date.DateFormat = "yyyy";
                btn_date.Visible = true;
                dtp_date.Visible = true;
                uiAvatar1.Visible = true;
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年)";
                btn_date.Location = new System.Drawing.Point(514, 123);
            }
            else if (uiComboBox1.SelectedIndex == 3)//选择历史累计
            {
                uiLabel1.Visible = false;
                btn_date.Visible = true;
                dtp_date.Visible = false;
                uiAvatar1.Visible = false;
                uiLabel5.Visible = false;
                btn_date.Location = new System.Drawing.Point(465, 17);
            }
        }

        private void btn_order_Click(object sender, EventArgs e)//按订单号查询
        {
            int order_id, customer_id;

            if (TextBox_orderNO.Text.ToString() == "")
            {
                Point place = new System.Drawing.Point(738, 280);
                UIMessageTip.ShowError(text: " 订单号不能为空!", point: place);
            }
            else
            {
                order_id = int.Parse(TextBox_orderNO.Text.ToString());
                customer_id = Form_login.id_global;
                OrderInfo orderInfo1 = new OrderInfo();
                orderInfo1.QueryByOrder(order_id, customer_id);
                OrderDataGridView form1 = new OrderDataGridView();
                form1.orderInfo1.OrderID = orderInfo1.OrderID;
                form1.orderInfo1.OrderTime = orderInfo1.OrderTime;
                form1.Show();
            } 
   

        }

        private void btn_date_Click(object sender, EventArgs e)//按订单日期查询
        {
            int year = -1, month = -1, day = -1;
            int customer_id;
            if (uiComboBox1.SelectedIndex == 0 || uiComboBox1.SelectedIndex == 1 || uiComboBox1.SelectedIndex == 2)
            {
                year = int.Parse(dtp_date.Value.Year.ToString());
            }
            if (uiComboBox1.SelectedIndex == 0 || uiComboBox1.SelectedIndex == 1)
            {
                month = int.Parse(dtp_date.Value.Month.ToString());
            }
            if (uiComboBox1.SelectedIndex == 0)
            {
                day = int.Parse(dtp_date.Value.Day.ToString());
            }
            customer_id = Form_login.id_global;
            OrderInfo orderInfo1 = new OrderInfo();
            orderInfo1.QueryByDate(customer_id, year, month, day);
            OrderDataGridView form1 = new OrderDataGridView();
            form1.orderInfo1.OrderID = orderInfo1.OrderID;
            form1.orderInfo1.OrderTime = orderInfo1.OrderTime;
            form1.Show();
        }
    }
}
