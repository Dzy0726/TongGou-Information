using GoodInfoStatis;
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
    public partial class Administrator_Goods : UITitlePage
    {
        public Administrator_Goods()
        {
            InitializeComponent();
        }

        private void btn_sale_Click(object sender, EventArgs e)
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
            GoodsInfoStatis GoodsInfo = new GoodsInfoStatis();
            GoodsInfo.SalesSpecifyDate(year, month, day, 1);
            //
            Form_SaleResult FormResult = new Form_SaleResult();

            //if (查询数据库比较存在该日期)
            //    则执行以下部分在结果框显示结果
            //    把查询主窗体的日期信息传给查询的显示结果窗体
            FormResult.year = year.ToString();
            FormResult.month =month.ToString();
            FormResult.day = day.ToString();
            FormResult.GoodsInfo.GoodsStatInfo = GoodsInfo.GoodsStatInfo;
            FormResult.Show(this);//用formmain唤醒formresult
        }

        private void btn_salemoney_Click(object sender, EventArgs e)
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
            GoodsInfoStatis GoodsInfo = new GoodsInfoStatis();
            GoodsInfo.SalesSpecifyDate(year, month, day, 2);
            //
            Form_SaleMoneyResult FormResult = new Form_SaleMoneyResult();
            //if (查询数据库比较存在该日期)
            //    则执行以下部分在结果框显示结果
            //    把查询主窗体的日期信息传给查询的显示结果窗体
            FormResult.year = year.ToString();
            FormResult.month = month.ToString();
            FormResult.day = day.ToString();
            FormResult.GoodsInfo.GoodsStatInfo = GoodsInfo.GoodsStatInfo;
            FormResult.Show(this);//用formmain唤醒formresult
        }

        private void btn_monthsale_Click(object sender, EventArgs e)
        {
            if (tb_type.Text.ToString() == "")
            {
                Point place = new System.Drawing.Point(738, 280);
                UIMessageTip.ShowError(text: " 商品种类不能为空!", point: place);
                //MessageBox.Show("商品种类不能为空!");
            }
            else
            {
                String GoodsType = tb_type.Text.ToString();
                int year = int.Parse(dtp_monthsale.Value.Year.ToString());
                GoodsInfoStatis GoodsInfo = new GoodsInfoStatis();
                GoodsInfo.SalesForEachMonth(year, GoodsType, 1);
                //
                Form_MonthSaleResult FormResult = new Form_MonthSaleResult();
                //if (查询数据库比较存在该日期)
                //    则执行以下部分在结果框显示结果
                //    把查询主窗体的日期信息传给查询的显示结果窗体
                FormResult.GoodsType = GoodsType;
                FormResult.year = dtp_monthsale.Value.Year.ToString();
                FormResult.GoodsInfo.goods_month_sales = GoodsInfo.goods_month_sales;
                FormResult.Show(this);
            }//用formmain唤醒formresult
        }

        private void btn_monthsalemoney_Click(object sender, EventArgs e)
        {
            if (tb_typemoney.Text.ToString() == "")
            {
                Point place = new System.Drawing.Point(738, 280);
                UIMessageTip.ShowError(text: " 商品种类不能为空!", point: place);
                //MessageBox.Show("商品种类不能为空!");
            }
            else
            {
                String GoodsType = tb_typemoney.Text.ToString();
                int year = int.Parse(dtp_monthsalemoney.Value.Year.ToString());
                GoodsInfoStatis GoodsInfo = new GoodsInfoStatis();
                GoodsInfo.SalesForEachMonth(year, GoodsType, 2);
                //
                Form_MonthSaleMoneyResult FormResult = new Form_MonthSaleMoneyResult();
                //if (查询数据库比较存在该日期)
                //    则执行以下部分在结果框显示结果
                //    把查询主窗体的日期信息传给查询的显示结果窗体
                FormResult.GoodsType = GoodsType;
                FormResult.year = dtp_monthsalemoney.Value.Year.ToString();
                FormResult.GoodsInfo.goods_month_sales = GoodsInfo.goods_month_sales;
                FormResult.Show(this);
            }//用formmain唤醒formresult
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
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年-月-日)";
                btn_sale.Location = new System.Drawing.Point(538, 172);
                btn_salemoney.Location = new System.Drawing.Point(538, 240);
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
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年-月)";
                btn_sale.Location = new System.Drawing.Point(538, 172);
                btn_salemoney.Location = new System.Drawing.Point(538, 240);
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
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年)";
                btn_sale.Location = new System.Drawing.Point(538, 172);
                btn_salemoney.Location = new System.Drawing.Point(538, 240);
            }
            else if (uiComboBox1.SelectedIndex == 3)//选择历史累计
            {
                btn_salemoney.Visible = true;
                btn_sale.Visible = true;
                dtp_salemoney.Visible = false;
                dtp_sale.Visible = false;
                uiAvatar1.Visible = false;
                uiLabel5.Visible = false;
                btn_sale.Location = new System.Drawing.Point(280, 174);
                btn_salemoney.Location = new System.Drawing.Point(280, 239);
            }
        }
    }
}
