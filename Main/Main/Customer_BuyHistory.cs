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
    public partial class Customer_BuyHistory : UITitlePage
    {
        public Customer_BuyHistory()
        {
            InitializeComponent();
        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            uiLabel1.Visible = true;
            uiLabel2.Visible = true;
            if (uiComboBox1.SelectedIndex == 0)//选择年-月-日
            {
                dtp_sale.DateFormat = "yyyy - MM - dd";
                dtp_salemoney.DateFormat = "yyyy - MM - dd";
                btn_salemoney.Visible = true;
                btn_sale.Visible = true;
                dtp_salemoney.Visible = true;
                dtp_sale.Visible = true;
                uiAvatar1.Visible = true;
                uiAvatar4.Visible = true;
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年-月-日)";
                uiLabel4.Visible = true;
                uiLabel4.Text = "日期(年-月-日)";
                btn_sale.Location = new System.Drawing.Point(528, 177);
                btn_salemoney.Location = new System.Drawing.Point(528, 282);
            }
            else if (uiComboBox1.SelectedIndex == 1)//选择年-月
            {
                dtp_sale.DateFormat = "yyyy - MM";
                dtp_salemoney.DateFormat = "yyyy - MM";
                btn_salemoney.Visible = true;
                btn_sale.Visible = true;
                dtp_salemoney.Visible = true;
                dtp_sale.Visible = true;
                uiAvatar1.Visible = true;
                uiAvatar4.Visible = true;
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年-月)";
                uiLabel4.Visible = true;
                uiLabel4.Text = "日期(年-月)";
                btn_sale.Location = new System.Drawing.Point(528, 177);
                btn_salemoney.Location = new System.Drawing.Point(528, 282);
            }
            else if (uiComboBox1.SelectedIndex == 2)//选择年
            {
                dtp_sale.DateFormat = "yyyy";
                dtp_salemoney.DateFormat = "yyyy";
                btn_salemoney.Visible = true;
                btn_sale.Visible = true;
                dtp_salemoney.Visible = true;
                dtp_sale.Visible = true;
                uiAvatar1.Visible = true;
                uiAvatar4.Visible = true;
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年)";
                uiLabel4.Visible = true;
                uiLabel4.Text = "日期(年-月)";
                btn_sale.Location = new System.Drawing.Point(528, 177);
                btn_salemoney.Location = new System.Drawing.Point(528, 282);
            }
            else if (uiComboBox1.SelectedIndex == 3)//选择历史累计
            {
                btn_salemoney.Visible = true;
                btn_sale.Visible = true;
                dtp_salemoney.Visible = false;
                dtp_sale.Visible = false;
                uiAvatar1.Visible = false;
                uiAvatar4.Visible = false;
                uiLabel5.Visible = false;
                uiLabel4.Visible = false;
                btn_sale.Location = new System.Drawing.Point(270, 179);
                btn_salemoney.Location = new System.Drawing.Point(270, 283);
            }
        }

        private void btn_sale_Click(object sender, EventArgs e)//顾客的消费金额查询
        {
            int year = -1, month = -1, day = -1;
            if (uiComboBox1.SelectedIndex == 0 || uiComboBox1.SelectedIndex == 1 || uiComboBox1.SelectedIndex == 2)
            {
                year = int.Parse(dtp_sale.Value.Year.ToString());
            }
            if (uiComboBox1.SelectedIndex == 0 || uiComboBox1.SelectedIndex == 1)
            {
                month = int.Parse(dtp_sale.Value.Month.ToString());
            }
            if (uiComboBox1.SelectedIndex == 0)
            {
                day = int.Parse(dtp_sale.Value.Day.ToString());
            }
            int customer_id = Form_login.id_global;
            OrderInfo orderInfo1 = new OrderInfo();
            orderInfo1.CostByDate(customer_id, year, month, day);
            string date;
            if (day != -1)
            {
                date = year.ToString() + "年" + month.ToString() + "月" + day.ToString() + "日";
            }
            else if (month != -1)
            {
                date = year.ToString() + "年" + month.ToString() + "月";
            }
            else if (year != -1)
            {
                date = year.ToString() + "年" ;
            }
            else
            {
                date = "历史累计";
            }
            this.ShowInfoDialog(date + "消费金额为:" + orderInfo1.CustomerCost[0],Style);
            //customer customer1 = new customer();
            //customer1.SalesSpecifyDate(year, month, day, Form_login.id_global.ToString());
        }

        private void btn_monthsale_Click(object sender, EventArgs e)//顾客月度消费金额
        {
            
            int year = int.Parse(dtp_monthsale.Value.Year.ToString());
            int customer_id = Form_login.id_global;
            //OrderInfo orderInfo1 = new OrderInfo();
            //orderInfo1.CostByMonth(customer_id, year);
            BuyHisMonth.year = year;
            //BuyHisMonth.orderInfo1.CusCostMonth = orderInfo1.CusCostMonth;
            BuyHisMonth form1 = new BuyHisMonth();
            form1.Show();
            //customer customer1 = new customer();
            //customer1.SalesForEachMonth(year,)
        }

        private void btn_salemoney_Click(object sender, EventArgs e)//
        {
            int year = -1, month = -1, day = -1;
            if (uiComboBox1.SelectedIndex == 0 || uiComboBox1.SelectedIndex == 1 || uiComboBox1.SelectedIndex == 2)
            {
                year = int.Parse(dtp_salemoney.Value.Year.ToString());
            }
            if (uiComboBox1.SelectedIndex == 0 || uiComboBox1.SelectedIndex == 1)
            {
                month = int.Parse(dtp_salemoney.Value.Month.ToString());
            }
            if (uiComboBox1.SelectedIndex == 0)
            {
                day = int.Parse(dtp_salemoney.Value.Day.ToString());
            }
            int customer_id = Form_login.id_global;
            //OrderInfo orderInfo1 = new OrderInfo();
            //orderInfo1.CostByType(customer_id, year, month, day);
            BuyMoneyByType.year = year;
            BuyMoneyByType.month = month;
            BuyMoneyByType.day = day;
          //  BuyMoneyByType.orderInfo1.CostForType = orderInfo1.CostForType;//左边引发异常
           // BuyMoneyByType.orderInfo1.GoodsType = orderInfo1.GoodsType;
            BuyMoneyByType form1 = new BuyMoneyByType();
            form1.Show();

        }
    }
}
