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
    public partial class SEL_storesale_moneyrusl : UIForm
    {
        public SEL_storesale_moneyrusl()
        {
            InitializeComponent();
            label1.Text = SELLER_date.year + "年";
            for (int i = 1; i < 13; i++)
            {
                uiDataGridView1.Rows.Add();
                uiDataGridView1.Rows[i - 1].Cells[0].Value = i.ToString() + "月";
                uiDataGridView1.Rows[i - 1].Cells[1].Value = SELLER_INFO.SELLER_SHOP_money_MONTH[i].ToString();
                SELLER_INFO.SELLER_SHOP_money_MONTH[i] = 0;
            }
        }
    }
}
