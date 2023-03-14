using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using SELL_INFORMATION;

namespace Main
{
    public partial class SEL_goods_money :UIForm
    {
        public SEL_goods_money()
        {
            InitializeComponent();
            if (SELLER_date.type == 0)
            {
                label1.Text = SELLER_date.year + "年 " + SELLER_date.month + "月 " + SELLER_date.day + "日";
            }
            if (SELLER_date.type == 1)
            {
                label1.Text = SELLER_date.year + "年 " + SELLER_date.month + "月 ";
            }
            if (SELLER_date.type == 2)
            {
                label1.Text = SELLER_date.year + "年 ";
            }
            if (SELLER_date.type == 3)
            {
                label1.Text = "历史总销售额";
            }
            for (int i = 0; i < 200; i++)
            {
                if (SELLER_INFO.goods_id[i] == 0)
                {
                    continue;
                }
                uiDataGridView1.Rows.Add();
                uiDataGridView1.Rows[i].Cells[0].Value = SELLER_INFO.goods_id[i];
                uiDataGridView1.Rows[i].Cells[1].Value = SELLER_INFO.goods_name[i];
                uiDataGridView1.Rows[i].Cells[2].Value = SELLER_INFO.goods_money[i];
                SELLER_INFO.goods_id[i] = 0;
                SELLER_INFO.goods_money[i] = 0;
                SELLER_INFO.goods_name[i] = "";
            }
        }
    }
}
