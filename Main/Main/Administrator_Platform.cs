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
using TransInfo;
using DBTest;

namespace Main
{
    public partial class Administrator_platform : UITitlePage
    {
        public Administrator_platform()
        {
            InitializeComponent();
            platformInfoStatis.Customer_num();
            platformInfoStatis.Store_num();
            tb_customer.Text = platformInfoStatis.customer_num.ToString();
            tb_store.Text = platformInfoStatis.store_num.ToString();
            tb_customer.ReadOnly = true;
            tb_store.ReadOnly = true;
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
                btn_salemoney.Location = new System.Drawing.Point(503, 248);
                btn_sale.Location = new System.Drawing.Point(503, 180);
                dtp_salemoney.Visible = true;
                dtp_sale.Visible = true;
                uiAvatar1.Visible = true;
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年-月-日)";
            }
            else if (uiComboBox1.SelectedIndex == 1)//选择年-月
            {
                dtp_sale.DateFormat = "yyyy - MM";
                dtp_salemoney.DateFormat = "yyyy - MM";
                btn_salemoney.Visible = true;
                btn_sale.Visible = true;
                btn_salemoney.Location = new System.Drawing.Point(503, 248);
                btn_sale.Location = new System.Drawing.Point(503, 180);
                dtp_salemoney.Visible = true;
                dtp_sale.Visible = true;
                uiAvatar1.Visible = true;
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年-月)";
            }
            else if (uiComboBox1.SelectedIndex == 2)//选择年
            {
                dtp_sale.DateFormat = "yyyy";
                dtp_salemoney.DateFormat = "yyyy";
                btn_salemoney.Visible = true;
                btn_sale.Visible = true;
                btn_salemoney.Location = new System.Drawing.Point(503, 248);
                btn_sale.Location = new System.Drawing.Point(503, 180);
                dtp_salemoney.Visible = true;
                dtp_sale.Visible = true;
                uiAvatar1.Visible = true;
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年)";

            }
            else if (uiComboBox1.SelectedIndex == 3)//选择历史累计
            {
                btn_salemoney.Visible = true;
                btn_sale.Visible = true;
                dtp_salemoney.Visible = false;
                dtp_sale.Visible = false;
                uiAvatar1.Visible = false;
                uiLabel5.Visible = false;
                btn_salemoney.Location = new System.Drawing.Point(277, 248);
                btn_sale.Location = new System.Drawing.Point(277, 180);
            }
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

            platformInfoStatis.Platform_quantity(year, month, day);
            // tb_sale.Text = platformInfoStatis.platform_quantity.ToString();
            this.ShowInfoDialog("当日平台销量为" + platformInfoStatis.platform_quantity.ToString(),Style);
        }

        private void btn_salemoney_Click(object sender, EventArgs e)
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

            platformInfoStatis.Platform_proceeds(year, month, day);
            //tb_salemoney.Text = platformInfoStatis.platform_proceeds.ToString();
            this.ShowInfoDialog("当日平台销售额为" + platformInfoStatis.platform_proceeds.ToString()+"元",Style);
        }
    }
}
