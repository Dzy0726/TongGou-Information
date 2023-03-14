using System;
using System.Windows.Forms;
using Main;

namespace Sunny.UI.Demo
{
    public partial class FMain : UIHeaderAsideMainFrame
    {
        public FMain()
        {
            InitializeComponent();
            //设置侧边栏的按键
            int pageIndex = 1000;
            Header.SetNodePageIndex(Header.Nodes[0], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[0], 61451);
            TreeNode parent = Aside.CreateNode("主页", 61451, 24, pageIndex);
            //通过设置PageIndex关联

            pageIndex = 2000;
            Header.SetNodePageIndex(Header.Nodes[1], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[1], 62141);
            //通过设置GUID关联，节点字体图标和大小由UIPage设置

            pageIndex = 3000;
            Header.SetNodePageIndex(Header.Nodes[2], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[2], 62142);

            Header.SetNodeSymbol(Header.Nodes[3], 61502);
            var styles = UIStyles.PopularStyles();
            foreach (UIStyle style in styles)
            {
                Header.CreateChildNode(Header.Nodes[3], style.DisplayText(), style.Value());
            }

            Aside.SelectFirst();
        }

        private void Header_MenuItemClick(string text, int menuIndex, int pageIndex)
        {
            switch (menuIndex)
            {
                case 0:
                    break;
                case 1:
                    this.Hide();
                    Form_login form_login = new Form_login();
                    form_login.Show(this);
                    break;
                case 2:
                    this.Hide();
                    Form_register form_reg = new Form_register();
                    form_reg.Show(this);
                    break;
                case 3:
                    UIStyle style = (UIStyle)pageIndex;
                    StyleManager.Style = style;
                    break;

            }
        }

      

        
    }
}