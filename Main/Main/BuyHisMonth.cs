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
    public partial class BuyHisMonth : UIForm
    {
        public BuyHisMonth()
        {
            InitializeComponent();
            orderInfo1.CostByMonth(Form_login.id_global, year);
            lbl_date.Text = "查询日期为:" + year.ToString() + "年";
            for (int i = 1; i < 13; i++)
            {
                uiDataGridView1.Rows.Add();
                uiDataGridView1.Rows[i - 1].Cells[0].Value = i.ToString();
                uiDataGridView1.Rows[i - 1].Cells[1].Value = orderInfo1.CusCostMonth[i - 1].ToString();
            }
        }

        public static int year;
        public static OrderInfo orderInfo1=new OrderInfo();
    }
}
