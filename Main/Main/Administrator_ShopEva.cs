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
    public partial class Administrator_ShopEva : UITitlePage
    {
        public Administrator_ShopEva()
        {
            InitializeComponent();
        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            uiLabel1.Visible = true;
            if (uiComboBox1.SelectedIndex != -1 && uiComboBox2.SelectedIndex != -1)
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
                button_query.Location = new System.Drawing.Point(567, 305);
            }
            else if (uiComboBox1.SelectedIndex == 1)//选择年-月
            {
                dateTimePicker_date.DateFormat = "yyyy - MM";
                dateTimePicker_date.Visible = true;
                uiAvatar1.Visible = true;
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年-月)";
                button_query.Location = new System.Drawing.Point(567, 305);
            }
            else if (uiComboBox1.SelectedIndex == 2)//选择年
            {
                dateTimePicker_date.DateFormat = "yyyy";
                dateTimePicker_date.Visible = true;
                uiAvatar1.Visible = true;
                uiLabel5.Visible = true;
                uiLabel5.Text = "日期(年)";
                button_query.Location = new System.Drawing.Point(567, 305);
            }
            else if (uiComboBox1.SelectedIndex == 3)//选择历史累计
            {
                button_query.Location = new System.Drawing.Point(277, 306);
                dateTimePicker_date.Visible = false;
                uiAvatar1.Visible = false;
                uiLabel5.Visible = false;
            }
        }

        private void uiComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiComboBox1.SelectedIndex != -1 && uiComboBox2.SelectedIndex != -1)
            {
                button_query.Visible = true;
            }
        }

        private void button_query_Click(object sender, EventArgs e)
        {
            int year = -1;//年，初始为空
            int month = -1;//月，初始为空
            int day = -1;//日，初始为空
            string date = "历史累计";//年月日，初始为历史累计
            if (uiComboBox1.SelectedIndex == 0 || uiComboBox1.SelectedIndex == 1 || uiComboBox1.SelectedIndex == 2)//选择了“年”
            {
                year = dateTimePicker_date.Value.Year;//获取所选年份
                date = year.ToString() + "年";
            }
            if (uiComboBox1.SelectedIndex == 0 || uiComboBox1.SelectedIndex == 1)//选择了“月”
            {
                month = dateTimePicker_date.Value.Month;//获取所选月份
                date = date + month.ToString() + "月";
            }
            if (uiComboBox1.SelectedIndex == 0)//选择了“日”
            {
                day = dateTimePicker_date.Value.Day;//获取所选天数
                date = date + day.ToString() + "日";
            }
            string store_type = null;//店铺种类，初始为空
            store_type = uiComboBox2.SelectedItem.ToString();//获取店铺种类
            //调用StoreInfoStatis进行查询
            StoreInfoStatis query = new StoreInfoStatis();
            query.StoreAssessRank(year, month, day, store_type);
            Form_EvaResult EvaResult = new Form_EvaResult();//创建“店铺评价查询结果”窗体实例
            Form_EvaResult.info_result info = new Form_EvaResult.info_result();
            int num = 0;
            num = query.StoreStatInfo.Count();//获取查询结果有多少项
            for (int i = 0; i < num; i++)//复制查询结果
            {
                info.id = query.StoreStatInfo[i].id;//店铺ID
                info.name = query.StoreStatInfo[i].name;//店铺名称
                info.assessment = query.StoreStatInfo[i].assessment;//店铺评价
                EvaResult.result.Add(info);
            }
            Form_EvaResult.date = date;//复制年月日
            Form_EvaResult.type = store_type;//复制店铺种类
            EvaResult.Show();//打开“店铺评价查询结果”窗体
        }

        private void Administrator_ShopEva_Load(object sender, EventArgs e)
        {
            //添加店铺种类
            StoreInfoStatis type = new StoreInfoStatis();
            type.AllStoreType();
            int num = type.all_store_type.Count;
            for (int i = 0; i < num; i++)
            {
                uiComboBox2.Items.Add(type.all_store_type[i]);
            }
        }
    }
}
