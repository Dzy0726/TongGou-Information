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
    public partial class Seller_ShopEvaResult : UIForm
    {
        public Seller_ShopEvaResult()
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
                label1.Text = "历史总销量";
            }


            for (int i = 0; i < 200; i++)
            {
                if (SELLER_INFO.goods_id_asse[i] == 0)
                {
                    continue;
                }
                uiDataGridView1.Rows.Add();
                uiDataGridView1.Rows[i].Cells[0].Value = SELLER_INFO.goods_id_asse[i];
                uiDataGridView1.Rows[i].Cells[1].Value = SELLER_INFO.goods_name_asse[i];
                uiDataGridView1.Rows[i].Cells[2].Value = SELLER_INFO.goods_asse[i];
                SELLER_INFO.goods_id_asse[i] = 0;
                SELLER_INFO.goods_asse[i] = 0;
                SELLER_INFO.goods_name_asse[i] = "";
            }
        }
    }
}
