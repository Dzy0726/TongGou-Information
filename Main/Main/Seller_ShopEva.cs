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
    public partial class Seller_ShopEva : UITitlePage
    {
        public Seller_ShopEva()
        {
            InitializeComponent();
        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            uiLabel1.Visible = true;
            if (uiComboBox1.SelectedIndex != -1)
            {
                button_query.Visible = true;
            }
            if (uiComboBox1.SelectedIndex == 0)//选择年-月-日
            {
                dateTimePicker_date.DateFormat = "yyyy - MM - dd";
                dateTimePicker_date.Visible = true;
                uiAvatar1.Visible = true;
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年-月-日)";
                button_query.Location = new System.Drawing.Point(565, 187);
            }
            else if (uiComboBox1.SelectedIndex == 1)//选择年-月
            {
                dateTimePicker_date.DateFormat = "yyyy - MM";
                dateTimePicker_date.Visible = true;
                uiAvatar1.Visible = true;
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年-月)";
                button_query.Location = new System.Drawing.Point(565, 187);
            }
            else if (uiComboBox1.SelectedIndex == 2)//选择年
            {
                dateTimePicker_date.DateFormat = "yyyy";
                dateTimePicker_date.Visible = true;
                uiAvatar1.Visible = true;
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年)";
                button_query.Location = new System.Drawing.Point(565, 187);
            }
            else if (uiComboBox1.SelectedIndex == 3)//选择历史累计
            {
                button_query.Location = new System.Drawing.Point(275, 188);
                dateTimePicker_date.Visible = false;
                uiAvatar1.Visible = false;
                uiLabel5.Visible = false;
            }
        }

        private void button_query_Click(object sender, EventArgs e)
        {
            if (uiComboBox1.SelectedIndex == 0)//选择年-月-日
            {
                SELLER_date.year = dateTimePicker_date.Value.Year;
                SELLER_date.month = dateTimePicker_date.Value.Month;
                SELLER_date.day = dateTimePicker_date.Value.Day;
                SELLER_date.type = 0;
                SELLER_INFO.store_assess(SELLER_date.year, SELLER_date.month, SELLER_date.day);
            }
            else if (uiComboBox1.SelectedIndex == 1)//选择年-月
            {
                SELLER_date.year = dateTimePicker_date.Value.Year;
                SELLER_date.month = dateTimePicker_date.Value.Month;
                SELLER_date.day = -1;
                SELLER_date.type = 1;
                SELLER_INFO.store_assess(SELLER_date.year, SELLER_date.month, SELLER_date.day);
            }
            else if (uiComboBox1.SelectedIndex == 2)//选择年
            {
                SELLER_date.year = dateTimePicker_date.Value.Year;
                SELLER_date.month = -1;
                SELLER_date.day = -1;
                SELLER_date.type = 2;
                SELLER_INFO.store_assess(SELLER_date.year, SELLER_date.month, SELLER_date.day);
            }
            else if (uiComboBox1.SelectedIndex == 3)//选择历史累计
            {
                SELLER_date.year = -1;
                SELLER_date.month = -1;
                SELLER_date.day = -1;
                SELLER_date.type = 3;
                SELLER_INFO.store_assess(SELLER_date.year, SELLER_date.month, SELLER_date.day);
            }
            Form SELL_ASSESS = new Seller_ShopEvaResult();
            SELL_ASSESS.Show(this);
        }
    }
}
