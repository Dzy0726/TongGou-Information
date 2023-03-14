using AD_CostomerInfo;
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
    public partial class Administrator_Customer : UITitlePage
    {
        public Administrator_Customer()
        {
            InitializeComponent();
        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(uiComboBox1.SelectedIndex==0)//选择年-月-日
            {
                uiLabel1.Visible = true;
                uiAvatar1.Visible = true;
                uiLabel5.Visible = true;
                dtp_avg.Visible = true;
                btn_avg.Visible = true;
                dtp_avg.DateFormat = "yyyy - MM - dd";
                uiLabel5.Text = "日期(年-月-日)";
                btn_avg.Location=new System.Drawing.Point(542, 390);
            }
            if (uiComboBox1.SelectedIndex == 1)//选择年-月
            {
                uiLabel1.Visible = true;
                uiAvatar1.Visible = true;
                uiLabel5.Visible = true;
                dtp_avg.Visible = true;
                btn_avg.Visible = true;
                dtp_avg.DateFormat = "yyyy - MM";
                uiLabel5.Text = "日期(年-月)";
                btn_avg.Location = new System.Drawing.Point(542, 390);
            }
            if (uiComboBox1.SelectedIndex == 2)//选择年
            {
                uiLabel1.Visible = true;
                uiAvatar1.Visible = true;
                uiLabel5.Visible = true;
                dtp_avg.Visible = true;
                btn_avg.Visible = true;
                dtp_avg.DateFormat = "yyyy";
                uiLabel5.Text = "日期(年)";
                btn_avg.Location = new System.Drawing.Point(542, 390);
            }
            if (uiComboBox1.SelectedIndex == 3)//选择历史累计
            {
                uiLabel1.Visible = true;
                uiAvatar1.Visible = false;
                uiLabel5.Visible = false;
                dtp_avg.Visible = false;
                btn_avg.Visible = true;
                btn_avg.Location = new System.Drawing.Point(284, 392);
            }
        }

        private void btn_day_Click(object sender, EventArgs e)
        {
            CustomerInfoStatis.CostForEachDay(uiDatetimePicker1.Value.Year, uiDatetimePicker1.Value.Month);
            AD_DATE.year = uiDatetimePicker1.Value.Year;
            AD_DATE.month = uiDatetimePicker1.Value.Month;
            Form AD_CUS_COSTDAY = new AD_CUS_COSTDAY();
            AD_CUS_COSTDAY.Show(this);
        }

        private void btn_month_Click(object sender, EventArgs e)
        {
            CustomerInfoStatis.CostForEachMonth(uiDatetimePicker2.Value.Year);
            AD_DATE.year = uiDatetimePicker2.Value.Year;
            Form AD_CUS_COSTMONTH = new AD_CUS_COSTMONTH();
            AD_CUS_COSTMONTH.Show(this);
        }

        private void btn_avg_Click(object sender, EventArgs e)
        {
            if (uiComboBox1.SelectedIndex == 0)//选择年-月-日
            {
                CustomerInfoStatis.CustomerAvgCost(dtp_avg.Value.Year, dtp_avg.Value.Month, dtp_avg.Value.Day);
                AD_DATE.year = dtp_avg.Value.Year;
                AD_DATE.month = dtp_avg.Value.Month;
                AD_DATE.day = dtp_avg.Value.Day;
                AD_DATE.type = 0;
                //Form AD_CUS_COSTAVG = new AD_CUS_COSTAVG();
                //AD_CUS_COSTAVG.Show(this);
                this.ShowInfoDialog(AD_DATE.year.ToString() + "年" + AD_DATE.month.ToString() + "月" + AD_DATE.day.ToString() + "日顾客的平均开销为" + CustomerInfoStatis.avg_costs.ToString() + "元", Style);
            }
            if (uiComboBox1.SelectedIndex == 1)//选择年-月
            {
                CustomerInfoStatis.CustomerAvgCost(dtp_avg.Value.Year, dtp_avg.Value.Month, -1);
                AD_DATE.year = dtp_avg.Value.Year;
                AD_DATE.month = dtp_avg.Value.Month;
                AD_DATE.type = 1;
                //Form AD_CUS_COSTAVG = new AD_CUS_COSTAVG();
                //AD_CUS_COSTAVG.Show(this);
                this.ShowInfoDialog(AD_DATE.year.ToString() + "年" + AD_DATE.month.ToString() + "月" + "顾客的平均开销为" + CustomerInfoStatis.avg_costs.ToString() + "元", Style);
            }
            if (uiComboBox1.SelectedIndex == 2)//选择年
            {
                CustomerInfoStatis.CustomerAvgCost(dtp_avg.Value.Year, -1, -1);
                AD_DATE.year = dtp_avg.Value.Year;
                AD_DATE.type = 2;
                //Form AD_CUS_COSTAVG = new AD_CUS_COSTAVG();
                //AD_CUS_COSTAVG.Show(this);
                this.ShowInfoDialog(AD_DATE.year.ToString() + "年" + "顾客的平均开销为" + CustomerInfoStatis.avg_costs.ToString() + "元", Style);
            }
            if (uiComboBox1.SelectedIndex == 3)//选择历史累计
            {
                CustomerInfoStatis.CustomerAvgCost(-1, -1, -1);
                AD_DATE.type = 3;
                //Form AD_CUS_COSTAVG = new AD_CUS_COSTAVG();
                //AD_CUS_COSTAVG.Show(this);
                this.ShowInfoDialog("顾客累计总平均开销为" + CustomerInfoStatis.avg_costs.ToString() + "元", Style);
            }
        }
    }
}
