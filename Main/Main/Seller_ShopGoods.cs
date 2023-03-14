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
    public partial class Seller_ShopGoods : UITitlePage
    {
        public Seller_ShopGoods()
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
                SELLER_INFO.goods_quantity(SELLER_date.year, SELLER_date.month, SELLER_date.day, SELLER_date.store_id_get);
            }
            else if (uiComboBox1.SelectedIndex == 1)//选择年-月
            {
                SELLER_date.year = dtp_sale.Value.Year;
                SELLER_date.month = dtp_sale.Value.Month;
                SELLER_date.day = -1;
                SELLER_date.type = 1;
                SELLER_INFO.goods_quantity(SELLER_date.year, SELLER_date.month, SELLER_date.day, SELLER_date.store_id_get);
            }
            else if (uiComboBox1.SelectedIndex == 2)//选择年
            {
                SELLER_date.year = dtp_sale.Value.Year;
                SELLER_date.month = -1;
                SELLER_date.day = -1;
                SELLER_date.type = 2;
                SELLER_INFO.goods_quantity(SELLER_date.year, SELLER_date.month, SELLER_date.day, SELLER_date.store_id_get);
            }
            else if (uiComboBox1.SelectedIndex == 3)//选择历史累计
            {
                SELLER_date.year = -1;
                SELLER_date.month = -1;
                SELLER_date.day = -1;
                SELLER_date.type = 3;
                SELLER_INFO.goods_quantity(SELLER_date.year, SELLER_date.month, SELLER_date.day, SELLER_date.store_id_get);
            }
            Form goods_qua = new SEL_goods_qua();
            goods_qua.Show(this);
        }

        private void btn_salemoney_Click(object sender, EventArgs e)
        {
            if (uiComboBox1.SelectedIndex == 0)//选择年-月-日
            {
                SELLER_date.year = dtp_sale.Value.Year;
                SELLER_date.month = dtp_sale.Value.Month;
                SELLER_date.day = dtp_sale.Value.Day;
                SELLER_date.type = 0;
                SELLER_INFO.goods_sales_money(SELLER_date.year, SELLER_date.month, SELLER_date.day, SELLER_date.store_id_get);
            }
            else if (uiComboBox1.SelectedIndex == 1)//选择年-月
            {
                SELLER_date.year = dtp_sale.Value.Year;
                SELLER_date.month = dtp_sale.Value.Month;
                SELLER_date.day = -1;
                SELLER_date.type = 1;
                SELLER_INFO.goods_sales_money(SELLER_date.year, SELLER_date.month, SELLER_date.day, SELLER_date.store_id_get);
            }
            else if (uiComboBox1.SelectedIndex == 2)//选择年
            {
                SELLER_date.year = dtp_sale.Value.Year;
                SELLER_date.month = -1;
                SELLER_date.day = -1;
                SELLER_date.type = 2;
                SELLER_INFO.goods_sales_money(SELLER_date.year, SELLER_date.month, SELLER_date.day, SELLER_date.store_id_get);
            }
            else if (uiComboBox1.SelectedIndex == 3)//选择历史累计
            {
                SELLER_date.year = -1;
                SELLER_date.month = -1;
                SELLER_date.day = -1;
                SELLER_date.type = 3;
                SELLER_INFO.goods_sales_money(SELLER_date.year, SELLER_date.month, SELLER_date.day, SELLER_date.store_id_get);
            }
            Form goods_money = new SEL_goods_money();
            goods_money.Show(this);
        }
    }
}
