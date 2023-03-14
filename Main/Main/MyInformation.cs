using Administrator;
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
    public partial class MyInformation : UITitlePage
    {
        public MyInformation()
        {
            InitializeComponent();

            //查询我的信息
            AdmInfoStatis query = new AdmInfoStatis();
            int user_id = Form_login.id_global;//用户ID
            string user_type = Form_login.type_global;//用户类型
            query.AdmInfo(user_id);
            label_ID.Text = user_type + label_ID.Text;
            label_adm_name.Text = user_type + label_adm_name.Text;
            label_ID_data.Text = query.result.id.ToString();//显示ID
            label_adm_name_data.Text = query.result.name;//显示姓名
        }
    }
}
