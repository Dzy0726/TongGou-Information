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
using SELL_INFORMATION;

namespace Main
{
    public partial class Seller_ShopSale : UITitlePage
    {
        public Seller_ShopSale()
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

        private void btn_sale_Click(object sender, EventArgs e)
        {
            if (uiComboBox1.SelectedIndex == 0)//选择年-月-日
            {
                SELLER_date.year = dtp_sale.Value.Year;
                SELLER_date.month = dtp_sale.Value.Month;
                SELLER_date.day = dtp_sale.Value.Day;
                SELLER_date.type = 0;
                SELLER_INFO.store_sales_quantity(SELLER_date.year, SELLER_date.month, SELLER_date.day, SELLER_date.store_id_get);
                this.ShowInfoDialog(SELLER_date.year.ToString() + "年" + SELLER_date.month.ToString() + "月" + SELLER_date.day.ToString() + "日，该日销量为" + SELLER_INFO.store_volume.ToString() + "件", Style);
            }
            else if (uiComboBox1.SelectedIndex == 1)//选择年-月
            {
                SELLER_date.year = dtp_sale.Value.Year;
                SELLER_date.month = dtp_sale.Value.Month;
                SELLER_date.day = -1;
                SELLER_date.type = 1;
                SELLER_INFO.store_sales_quantity(SELLER_date.year, SELLER_date.month, SELLER_date.day, SELLER_date.store_id_get);
                this.ShowInfoDialog(SELLER_date.year.ToString() + "年" + SELLER_date.month.ToString() + "月，该月销量为" + SELLER_INFO.store_volume.ToString() + "件", Style);
            }
            else if (uiComboBox1.SelectedIndex == 2)//选择年
            {
                SELLER_date.year = dtp_sale.Value.Year;
                SELLER_date.month = -1;
                SELLER_date.day = -1;
                SELLER_date.type = 2;
                SELLER_INFO.store_sales_quantity(SELLER_date.year, SELLER_date.month, SELLER_date.day, SELLER_date.store_id_get);
                this.ShowInfoDialog(SELLER_date.year.ToString() + "年，该年销量为" + SELLER_INFO.store_volume.ToString() + "件", Style);
            }
            else if (uiComboBox1.SelectedIndex == 3)//选择历史累计
            {
                SELLER_date.year = -1;
                SELLER_date.month = -1;
                SELLER_date.day = -1;
                SELLER_date.type = 3;
                SELLER_INFO.store_sales_quantity(SELLER_date.year, SELLER_date.month, SELLER_date.day, SELLER_date.store_id_get);
                this.ShowInfoDialog("总销量为" + SELLER_INFO.store_volume.ToString() + "件", Style);
            }
        }

        private void btn_salemoney_Click(object sender, EventArgs e)
        {
            if (uiComboBox1.SelectedIndex == 0)//选择年-月-日
            {
                SELLER_date.year = dtp_salemoney.Value.Year;
                SELLER_date.month = dtp_salemoney.Value.Month;
                SELLER_date.day = dtp_salemoney.Value.Day;
                SELLER_date.type = 0;
                SELLER_INFO.store_sales_money(SELLER_date.year, SELLER_date.month, SELLER_date.day, SELLER_date.store_id_get);
                this.ShowInfoDialog(SELLER_date.year.ToString() + "年" + SELLER_date.month.ToString() + "月" + SELLER_date.day.ToString() + "日，该日销售额为" + SELLER_INFO.store_salesmoney.ToString() + "元", Style);
            }
            else if (uiComboBox1.SelectedIndex == 1)//选择年-月
            {
                SELLER_date.year = dtp_salemoney.Value.Year;
                SELLER_date.month = dtp_salemoney.Value.Month;
                SELLER_date.day = -1;
                SELLER_date.type = 1;
                SELLER_INFO.store_sales_money(SELLER_date.year, SELLER_date.month, SELLER_date.day, SELLER_date.store_id_get);
                this.ShowInfoDialog(SELLER_date.year.ToString() + "年" + SELLER_date.month.ToString() + "月，该月销售额为" + SELLER_INFO.store_salesmoney.ToString() + "元", Style);
            }
            else if (uiComboBox1.SelectedIndex == 2)//选择年
            {
                SELLER_date.year = dtp_salemoney.Value.Year;
                SELLER_date.month = -1;
                SELLER_date.day = -1;
                SELLER_date.type = 2;
                SELLER_INFO.store_sales_money(SELLER_date.year, SELLER_date.month, SELLER_date.day, SELLER_date.store_id_get);
                this.ShowInfoDialog(SELLER_date.year.ToString() + "年，该年销售额为" + SELLER_INFO.store_salesmoney.ToString() + "元", Style);
            }
            else if (uiComboBox1.SelectedIndex == 3)//选择历史累计
            {
                SELLER_date.year = -1;
                SELLER_date.month = -1;
                SELLER_date.day = -1;
                SELLER_date.type = 3;
                SELLER_INFO.store_sales_money(SELLER_date.year, SELLER_date.month, SELLER_date.day, SELLER_date.store_id_get);
                this.ShowInfoDialog("总销售额为" + SELLER_INFO.store_salesmoney.ToString() + "元", Style);
            }
        }

        private void btn_monthsale_Click(object sender, EventArgs e)
        {
            SELLER_date.year = dtp_monthsale.Value.Year;
            SELLER_date.month = -1;
            SELLER_date.day = -1;
            SELLER_INFO.store_sales_month_money(SELLER_date.year, SELLER_date.store_id_get);
            Form MONTHSELL = new SEL_storesale_result();
            MONTHSELL.Show(this);
        }

        private void btn_monthsalemoney_Click(object sender, EventArgs e)
        {
            SELLER_date.year = dtp_monthsalemoney.Value.Year;
            SELLER_date.month = -1;
            SELLER_date.day = -1;
            SELLER_INFO.store_sales_month_money(SELLER_date.year, SELLER_date.store_id_get);
            Form MONTHSELL = new SEL_storesale_moneyrusl();
            MONTHSELL.Show(this);
        }
    }
}
