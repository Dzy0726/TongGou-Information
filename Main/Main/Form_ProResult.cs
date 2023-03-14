using GoodInfoStatis;
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
    public partial class Form_ProResult : UIForm
    {
        public Form_ProResult()
        {
            InitializeComponent();
        }

        public struct info_result
        {
            public string type;//店铺类型
            public int proceeds;//销售额
        };
        public List<info_result> result = new List<info_result>();

        static public string date;//年月日

        private void Form_ProResult_Load(object sender, EventArgs e)
        {
           // this.Owner.Hide();//隐藏所有者窗体
            lbl_date.Text = lbl_date.Text + date;//年月日
            int num = result.Count;//获取查询结果有多少项
            for (int i = 0; i < num; i++)
            {
                uiDataGridView1.Rows.Add();
                uiDataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();//序号
                uiDataGridView1.Rows[i].Cells[1].Value = result[i].type;//店铺类型
                uiDataGridView1.Rows[i].Cells[2].Value = result[i].proceeds.ToString();//销售额
            }
        }

    }
}
