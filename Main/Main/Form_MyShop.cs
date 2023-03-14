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

    public partial class Form_MyShop : UITitlePage
    {
        public Form_MyShop()
        {
            InitializeComponent();
            My_Shop shops = new My_Shop();
            shops.Seller_Store(Form_login.id_global.ToString());

            uiDataGridView1.ReadOnly = true;

            //测试数据
            uiDataGridView1.Rows.Add();
            uiDataGridView1.Rows[0].Cells[0].Value = "1";
            uiDataGridView1.Rows[0].Cells[1].Value = "喜茶";
            uiDataGridView1.Rows[0].Cells[2].Value = "进入店铺";

            for (int i = 0; i < shops.seller_store.Count(); i++)
            {
                uiDataGridView1.Rows.Add();
                uiDataGridView1.Rows[i].Cells[0].Value = shops.seller_store[i].store_ID;
                uiDataGridView1.Rows[i].Cells[1].Value = shops.seller_store[i].store_NAME;
                uiDataGridView1.Rows[i].Cells[2].Value = "进入店铺";

            }
        }

        private void uiDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (uiDataGridView1.CurrentCell.FormattedValue.ToString() == "进入店铺")
            {
                SELLER_date.store_id_get = uiDataGridView1.CurrentRow.Cells[0].Value.ToString();
                //OrderPage form1 = new OrderPage();
                //form1.Show();
                Seller_Shop.shop_name = uiDataGridView1.CurrentRow.Cells[1].Value.ToString();
                Seller_Shop shop1 = new Seller_Shop();
                shop1.Show();
                

            }
        }


    }
}
