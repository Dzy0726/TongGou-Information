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
    public partial class Seller_ShopStaff : UITitlePage
    {
        public Seller_ShopStaff()
        {
            InitializeComponent();
            uiDataGridView1.ReadOnly = true;
            SELLER_INFO.staff_info();
            for (int i = 0; i < 200; i++)
            {
                if (SELLER_INFO.staff_id[i] == 0)
                {
                    continue;
                }
                uiDataGridView1.Rows.Add();
                uiDataGridView1.Rows[i].Cells[0].Value = SELLER_INFO.staff_id[i];
                uiDataGridView1.Rows[i].Cells[1].Value = SELLER_INFO.staff_name[i];
                uiDataGridView1.Rows[i].Cells[2].Value = SELLER_INFO.staff_phnum[i];
                SELLER_INFO.staff_id[i] = 0;
                SELLER_INFO.staff_name[i] = "";
                SELLER_INFO.staff_phnum[i] = 0;
            }
        }
    }
}
