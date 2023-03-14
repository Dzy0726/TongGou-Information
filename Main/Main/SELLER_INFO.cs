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
using MySql.Data.MySqlClient;

namespace SELL_INFORMATION
{
    class SELLER_date
    {
        public static int year;
        public static int month;
        public static int day;
        public static int type;
        public static string store_id_get;
    }



    class SELLER_INFO
    {
        
        static public string Date(int year, int month, int day)//日期处理
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

       
        static public int store_volume ;//存储销量
        static public void store_sales_quantity(int year, int month, int day, string store_id_temp)//////店铺销量查询
        {

            string date = Date(year, month, day);
            string store_id = store_id_temp;
            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
                {
                    string sql = "SELECT sum(num) FROM goods_order join `order` using (order_id) where store_id = @store_id and date like @date; ";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new MySqlParameter("@date", date));
                    cmd.Parameters.Add(new MySqlParameter("@store_id", store_id));
                    cmd.ExecuteNonQuery();//用来执行sql语句
                    

                    MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                    while (reader.Read())//按行执行查询，每次循环查询一行
                    {
                        if (reader.IsDBNull(0))
                        {
                            store_volume = 0;
                            continue;
                            
                        }
                        //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                        //对于不同的数据库字段类型，我们需要用不同的方法获取
                        store_volume = reader.GetInt32(0);
                    }
                }
            }
        }


        static public int[] goods_id = new int[200];//存储物品
        static public string[] goods_name = new string[200];//存储物品
        static public int[] goods_volume = new int[200];//存储销量
        static public int[] goods_money = new int[200];//存储销售额
        static public void goods_quantity(int year, int month, int day,string store_id_temp)//商品销量查询
        {
            string date = Date(year, month, day);
            string store_id = store_id_temp;
            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
                {
                    string sql = "SELECT goods_id,goods_name,sum(num)FROM goods_order natural join goods join `order` using (order_id)WHERE store_id = @store_id and date like @date group by goods_id order by sum(num) desc";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new MySqlParameter("@date", date));
                    cmd.Parameters.Add(new MySqlParameter("@store_id", store_id));
                    cmd.ExecuteNonQuery();//用来执行sql语句
                    MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                    int i = 0;
                    while (reader.Read())//按行执行查询，每次循环查询一行
                    {
                        //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                        //对于不同的数据库字段类型，我们需要用不同的方法获取
                        goods_id[i] = reader.GetInt32(0);
                        goods_name[i] = reader.GetString(1);
                        goods_volume[i] = reader.GetInt32(2);
                        i++;
                    }
                }
            }
        }
        static public int store_salesmoney;//存储销售额
        static public void store_sales_money(int year, int month, int day, string store_id_temp)////////店铺销售额查询
        {
            string date = Date(year, month, day);
            string store_id = store_id_temp;
            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
                {
                    string sql = "SELECT sum(cost), store_id FROM goods_order join `order` using (order_id) where store_id = @store_id and date like @date group by store_id ";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new MySqlParameter("@date", date));
                    cmd.Parameters.Add(new MySqlParameter("@store_id", store_id));
                    cmd.ExecuteNonQuery();//用来执行sql语句

                    MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                    while (reader.Read())//按行执行查询，每次循环查询一行
                    {
                        if (reader.IsDBNull(0))
                        {
                            store_salesmoney = 0;
                            continue;
                        }
                        //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                        //对于不同的数据库字段类型，我们需要用不同的方法获取
                        store_salesmoney = reader.GetInt32(0);
                    }
                }

            }
        }
        static public double[] SELLER_SHOP_money_MONTH = new double[13];//下标对应月份，存放指定年每月店铺销售额

        static public double[] SELLER_SHOP_num_MONTH = new double[13];//下标对应月份，存放指定年每月店铺销量



        static public void store_sales_month_money(int year, string get_store_id)////////店铺月度销售额（年报表）
        {
            string store_id = get_store_id;
            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            string date = Date(year, -1, -1);

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
                {
                    string sql = "SELECT month(date),sum(cost),sum(num) FROM goods_order join `order` using (order_id) where store_id = @store_id and date like @date group by month(date)";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new MySqlParameter("@date", date));
                    cmd.Parameters.Add(new MySqlParameter("@store_id", store_id));
                    cmd.ExecuteNonQuery();//用来执行sql语句
                    MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                    while (reader.Read())//按行执行查询，每次循环查询一行
                    {
                        //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                        //对于不同的数据库字段类型，我们需要用不同的方法获取
                        SELLER_SHOP_money_MONTH[reader.GetInt32(0)] = reader.GetDouble(1);
                        SELLER_SHOP_num_MONTH[reader.GetInt32(0)] = reader.GetDouble(2);
                    }
                }
            }
        }





        static public void goods_sales_money(int year, int month, int day,string get_ID)////////店铺销售额查询
        {
            string date = Date(year, month, day);
            string store_id = get_ID;
            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
                {
                    string sql = "SELECT goods_id,goods_name,sum(cost)FROM goods_order natural join goods join `order` using (order_id) WHERE store_id = @store_id and date like @date group by goods_id order by sum(cost) desc";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new MySqlParameter("@date", date));
                    cmd.Parameters.Add(new MySqlParameter("@store_id", store_id));
                    cmd.ExecuteNonQuery();//用来执行sql语句
                    MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                    int i = 0;
                    while (reader.Read())//按行执行查询，每次循环查询一行
                    {
                        //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                        //对于不同的数据库字段类型，我们需要用不同的方法获取
                        goods_id[i] = reader.GetInt32(0);
                        goods_name[i] = reader.GetString(1);
                        goods_money[i] = reader.GetInt32(2);
                        i++;
                    }
                }
            }
        }


        static public int[] goods_id_asse = new int[200];//存储物品ID
        static public string[] goods_name_asse = new string[200];//存储物品名字
        static public double[] goods_asse = new double[200];//存储评价


        static public void store_assess(int year, int month, int day)     //店铺评价信息
        {
            string date = Date(year, month, day);
            string store_id=SELLER_date.store_id_get;
            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
                {
                    string sql = "SELECT goods_id,goods_name,sum(assessment)/count(order_id) FROM assess natural join goods_order natural join `order` natural join goods where store_id = @store_id and date like @date group by goods_id";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new MySqlParameter("@date", date));
                    cmd.Parameters.Add(new MySqlParameter("@store_id", store_id));
                    cmd.ExecuteNonQuery();//用来执行sql语句

                    MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                    int i = 0;
                    while (reader.Read())//按行执行查询，每次循环查询一行
                    {
                        goods_id_asse[i] = reader.GetInt32(0);
                        goods_name_asse[i] = reader.GetString(1);
                        goods_asse[i] = reader.GetDouble(2);
                        //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                        //对于不同的数据库字段类型，我们需要用不同的方法获取
                        i++;
                    }
                }
            }
        }


        static public int[] staff_id = new int[200];//存储员工ID
        static public string[] staff_name = new string[200];//存储员工名字
        static public int[] staff_phnum = new int[200];//存储员工手机号

        static public void staff_info()         ///////////店铺员工信息
        {

            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
                {
                    string sql = "select *  from staff natural join store_staff where store_id = @store_id ";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new MySqlParameter("@store_id", SELLER_date.store_id_get));
                    MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                    int i = 0;
                    while (reader.Read())//按行执行查询，每次循环查询一行
                    {
                        //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                        //对于不同的数据库字段类型，我们需要用不同的方法获取
                        staff_id[i] = reader.GetInt32(0);
                        staff_name[i] = reader.GetString(1);
                        staff_phnum[i] = reader.GetInt32(2);
                        i++;
                    }
                }

            }
        }










    }
}
