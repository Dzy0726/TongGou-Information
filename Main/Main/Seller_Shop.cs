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
    public partial class Seller_Shop : UIHeaderAsideMainFrame
    {
        public Seller_Shop()
        {
            InitializeComponent();

            this.Text = shop_name;

            int pageIndex = 1000;
            Header.SetNodePageIndex(Header.Nodes[0], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[0], 61451);
            TreeNode parent = Aside.CreateNode("店铺销售", 61451, 24, pageIndex);
            Aside.CreateChildNode(parent, 61451, 24, AddPage(new Seller_ShopSale(), ++pageIndex));//  店铺销售

            pageIndex = 2000;
            Header.SetNodePageIndex(Header.Nodes[1], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[1], 61674);
            parent = Aside.CreateNode("店铺商品", 61674, 24, pageIndex);
            Aside.CreateChildNode(parent, 61674, 24, AddPage(new Seller_ShopGoods(), ++pageIndex));//  店铺商品

            pageIndex = 3000;
            Header.SetNodePageIndex(Header.Nodes[2], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[2], 61474);
            parent = Aside.CreateNode("店铺评价", 61474, 24, pageIndex);
            Aside.CreateChildNode(parent, 61474, 24, AddPage(new Seller_ShopEva(), ++pageIndex));  //店铺评价

            pageIndex = 4000;
            Header.SetNodePageIndex(Header.Nodes[3], pageIndex);
            Header.SetNodeSymbol(Header.Nodes[3], 61474);
            parent = Aside.CreateNode("店铺员工", 61474, 24, pageIndex);
            Aside.CreateChildNode(parent, 61474, 24, AddPage(new Seller_ShopStaff(), ++pageIndex));  //店铺员工


            Aside.SelectFirst();
        }

        private void Header_MenuItemClick(string text, int menuIndex, int pageIndex)
        {
            switch (menuIndex)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    Aside.SelectPage(pageIndex);
                    break;
            }
        }

        public static int shop_id;
        public static string shop_name;


        //窗体加载时加载窗体的名字到label_wel
    }
}
