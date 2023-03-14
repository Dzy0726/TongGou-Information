using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AD_CostomerInfo;
using Sunny.UI;

namespace Main
{
    public partial class AD_CUS_COSTDAY : UIForm
    {
        public AD_CUS_COSTDAY()
        {
            InitializeComponent();
            //listView1.Columns.Add(" ", 100);
            //listView1.Columns.Add("日期", 100);
            //listView1.Columns.Add("顾客开销", 100);
            //label2.Text = AD_DATE.year + "年 " + AD_DATE.month + "月 ";
            //for(int i=1;i<32;i++)
            //{
            //    listView1.Items.Add((i + 0).ToString());
            //    listView1.Items[i - 1].SubItems.Add(i + "日");
            //    listView1.Items[i - 1].SubItems.Add(Convert.ToString(CustomerInfoStatis.customer_day_costs[i]));
            //    CustomerInfoStatis.customer_day_costs[i] = 0;
            //}
            label2.Text = AD_DATE.year + "年 " + AD_DATE.month + "月 ";
            for (int i = 1; i < 32; i++)
            {
                uiDataGridView1.Rows.Add();
                uiDataGridView1.Rows[i - 1].Cells[0].Value = i.ToString()+"日";
                uiDataGridView1.Rows[i - 1].Cells[1].Value = CustomerInfoStatis.customer_day_costs[i].ToString();
            }
        }

        private void AD_CUS_COSTDAY_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
