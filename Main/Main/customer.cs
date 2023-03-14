using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Main
{
    public class OrderInfo
    {

        /* 函数实现功能：按订单号查询
         * 参数：订单号int 顾客id int
         * 查询结果：订单号，订单日期
         * 传送方式：以下两数组 订单最多100个  
         * 注意：没有写查不到orderid的解决方法  orderID为0即未找到）
         *       只有order_id和customer_id同时匹配才可以找到    */
        public int[] OrderID = new int[100];    //存储订单ID
        public string[] OrderTime = new string[100]; //存储对应时间 相同下标表示一组

        public void QueryByOrder(int order_id,int customer_id)
        {
            int i = 0;
            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql = "select order_id,date FROM `order` natural join consume  where order_id = @order_id and customer_id = @customer_id";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@order_id", order_id));
                cmd.Parameters.Add(new MySqlParameter("@customer_id", customer_id));
                cmd.ExecuteNonQuery();//用来执行sql语句

                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    OrderID[i] = reader.GetInt32(0);

                    OrderTime[i] = reader.GetString(1);
                   // MessageBox.Show("订单号：" + OrderID[i]);
                   // MessageBox.Show("订单时间：" + OrderTime[i]);
                    i++;
                }
            }
        }


        /* 函数实现功能：按订单日期查询
         * 参数：顾客id，订单日期 年月日均为int 如缺省则为 -1，全缺 -1，-1，-1为历史累计
         * 查询结果：订单号，订单日期
         * 传送方式：同上，两数组 订单最多100个  */
        public string Date(int year, int month, int day)//日期处理
        {
            string Year, Month, Day;
            string dateTime = "%";
            if (year == -1)
            {
                return dateTime;
            }
            else
            {
                Year = year.ToString();
            }

            if (month == -1)
            {
                dateTime = Year + dateTime;
                return dateTime;
            }
            else if (month > 0 && month < 10)
            {
                Month = "0" + month.ToString();
            }
            else
            {
                Month = month.ToString();
            }

            if (day == -1)
            {
                dateTime = Year + "-" + Month + dateTime;
                return dateTime;
            }
            else if (day > 0 && day < 10)
            {
                Day = "0" + day.ToString();
            }
            else
            {
                Day = day.ToString();
            }
            dateTime = Year + "-" + Month + "-" + Day + dateTime;
            return dateTime;
        }

        public void QueryByDate(int customer_id,int year,int month,int day)
        {
            int i = 0;
            string DT = Date(year,month,day);
            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql = "select order_id,date FROM `order` natural join consume where date like @date and customer_id = @customer_id";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@date", DT));
                cmd.Parameters.Add(new MySqlParameter("@customer_id", customer_id));
                cmd.ExecuteNonQuery();//用来执行sql语句

                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    OrderID[i] = reader.GetInt32(0);
                    OrderTime[i] = reader.GetString(1);
                   // MessageBox.Show("订单号：" + OrderID[i].ToString());
                   // MessageBox.Show("订单时间：" + OrderTime[i]);
                    i++;
                }
            }
        }


        /* 函数实现功能：查询订单简介
         * 参数：顾客ID + 订单号、订单日期或有其一
         * 查询结果：订单号、订单日期 、发出地、目的地、订单金额
         * 传送方式：订单号OrderID[] 订单日期DateTime[] 发出地Departure[] 目的地Destination[] 订单金额 OrderCost[] 
         * 注意：使用订单号或订单日期之一查询，则使另一参数为-1 
         *       如：按订单号查询：1********，-1，-1，-1    
         *           按订单日期查询：-1，2020，9，17    */
        public string[] Departure = new string[100];
        public string[] Destination = new string[100];
        public double[] OrderCost = new double[100];

        public void OrderIntro(int customer_id,int order_id,int year,int month,int day)
        {
            int i = 0;
            string DT = Date(year, month, day);
            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql = "select order_id,date,departure,destination,cost from transportinfo natural join order_trans natural join `order` natural join goods_order natural join consume where customer_id = @customer_id and date like @date";
                if (order_id != -1)
                {
                    sql = sql + " and order_id = @order_id";
                }
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@date", DT));
                cmd.Parameters.Add(new MySqlParameter("@order_id", order_id));
                cmd.Parameters.Add(new MySqlParameter("@customer_id", customer_id));
                cmd.ExecuteNonQuery();//用来执行sql语句

                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    OrderID[i] = reader.GetInt32(0);
                    OrderTime[i] = reader.GetString(1);
                    Departure[i] = reader.GetString(2);
                    Destination[i] = reader.GetString(3);
                    OrderCost[i] = reader.GetDouble(4);
                    // MessageBox.Show("订单号：" + OrderID[i].ToString());
                    // MessageBox.Show("订单时间：" + OrderTime[i]);
                    // MessageBox.Show("发出地：" + Departure[i]);
                    // MessageBox.Show("目的地：" + Destination[i]);
                    // MessageBox.Show("订单花费：" + OrderCost[i]);
                    i++;
                }
            }
        }


        /* 函数实现功能：查询订单详情
         * 参数：顾客ID、订单号、订单日期或有其一
         * 查询结果：订单中的商品名称、商品所属店铺名称 、单件商品金额、订单中商品数量
         * 传送方式：商品名称GoodsName[] 所属店铺StoreName[] 单件商品金额GoodsPrice[] 商品数量GoodsNum[] 通过下标对应
         * 注意：使用订单号或订单日期之一查询，则使另一参数为-1 
         *       如：按订单号查询：1********，-1，-1，-1    
         *           按订单日期查询：-1，2020，9，17    */
        public string[] GoodsName = new string[100];
        public string[] StoreName = new string[100];
        public double[] GoodsPrice = new double[100];
        public int[] GoodsNum = new int[100];

        public void OrderDetail(int customer_id,int order_id,int year,int month,int day)
        {
            int i = 0;
            string DT = Date(year, month, day);
            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql = "select goods_name,store_name,price,num from `order` natural join goods_order natural join goods join store using(store_id) natural join consume where customer_id = @customer_id and date like @date";
                if (order_id != -1)
                {
                    sql = sql + " and order_id = @order_id";
                }
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@date", DT));
                cmd.Parameters.Add(new MySqlParameter("@order_id", order_id));
                cmd.Parameters.Add(new MySqlParameter("@customer_id", customer_id));
                cmd.ExecuteNonQuery();//用来执行sql语句

                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    GoodsName[i] = reader.GetString(0);
                    StoreName[i] = reader.GetString(1);
                    GoodsPrice[i] = reader.GetDouble(2);
                    GoodsNum[i] = reader.GetInt32(3);
                    // MessageBox.Show("商品名：" + GoodsName[i]);
                    // MessageBox.Show("商店名：" + StoreName[i]);
                    // MessageBox.Show("单价：" + GoodsPrice[i]);
                    // MessageBox.Show("总数：" + GoodsNum[i]);
                    i++;
                }
            }
        }


        /* 函数实现功能：顾客 消费金额查询
         * 参数：顾客id，年月日，全为空则为-1，-1，-1
         * 查询结果：消费金额
         * 传送方式：CustomerCost[]      */
        public double[] CustomerCost = new double[100];

        public void CostByDate(int customer_id,int year,int month,int day)
        {
            int i = 0;
            string DT = Date(year, month, day);
            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql = "select sum(cost) from consume natural join goods_order natural join `order` where customer_id = @customer_id and date like @date";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@date", DT));
                cmd.Parameters.Add(new MySqlParameter("@customer_id", customer_id));
                cmd.ExecuteNonQuery();//用来执行sql语句

                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    if (reader.IsDBNull(0))
                    {
                        break;
                    }
                    CustomerCost[i] = reader.GetDouble(0);
                    // MessageBox.Show("消费金额：" + CustomerCost[i]);
                    i++;
                }
            }
        }


        /* 函数实现功能：顾客 月度消费查询（年报表）
         * 参数：顾客id，年
         * 查询结果：月度消费金额 年报表
         * 传送方式：CusCostmonth[13]     下标对应月份 */
        public double[] CusCostMonth = new double[13];
        
        public void CostByMonth(int customer_id,int year)
        {
            string DT = Date(year, -1, -1);
            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql = "select month(date),sum(cost) from consume natural join goods_order natural join `order` where customer_id = @customer_id and date like @date group by month(date)";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@date", DT));
                cmd.Parameters.Add(new MySqlParameter("@customer_id", customer_id));
                cmd.ExecuteNonQuery();//用来执行sql语句

                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    CusCostMonth[reader.GetInt32(0)] = reader.GetDouble(1);
                    // MessageBox.Show("月份：" + reader.GetInt32(0));
                    // MessageBox.Show("消费金额：" + CustomerCost[reader.GetInt32(0)]);
                }
            }
        }

        /* 函数实现功能：顾客 各种类商品消费金额
         * 参数：顾客id，年月日，可为空 降序排列
         * 查询结果：商品类型，对应的消费金额
         * 传送方式：GoodsType[5] CostForType[5]  通过下标对应  */
        public string[] GoodsType = new string[5];
        public double[] CostForType = new double[5];

        public void CostByType(int customer_id,int year,int month,int day)
        {
            int i = 0;
            string DT = Date(year, month, day);
            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql = "select type,sum(cost) from consume natural join goods_order natural join goods natural join `order` where customer_id = @customer_id and date like @date group by type order by sum(cost) desc";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@date", DT));
                cmd.Parameters.Add(new MySqlParameter("@customer_id", customer_id));
                cmd.ExecuteNonQuery();//用来执行sql语句

                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    GoodsType[i] = reader.GetString(0);
                    CostForType[i] = reader.GetDouble(1);
                    // MessageBox.Show("商品类型" + GoodsType[i]);
                    // MessageBox.Show("消费金额：" + CostForType[i]);
                }
            }
        }
    }
}
