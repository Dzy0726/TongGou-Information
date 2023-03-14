using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GoodInfoStatis
{
    public class GoodsInfoStatis
    {
        public struct GoodsInfo
        {
            public string type;//商品类型
            public int quantity;//销售量
            public int proceeds;//销售额
        };

        public List<GoodsInfo> GoodsStatInfo = new List<GoodsInfo>();

        public int[] goods_month_sales = new int[13];//存放1-12月商品销量或销售额 数组下标对应月份

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

        /*  查询各种类商品销量、销售额；按年月日查询，可为空；
         *  searchType = 1查销量    =2 查销售额
         *  如果不具备某一参数 则令其为-1 如：2020年8月 则参数2020，8，-1  */
        public void SalesSpecifyDate(int year, int month, int day, int searchType)
        {
            GoodsInfo temp = new GoodsInfo();
            string date = Date(year, month, day);

            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql;
                if (searchType == 1)
                {
                    sql = "select type,sum(num),sum(cost*num) from goods natural join goods_order natural join `order` where date like @date group by type order by sum(num) desc";
                }
                else
                {
                    sql = "select type,sum(num),sum(cost*num) from goods natural join goods_order natural join `order` where date like @date group by type order by sum(cost*num) desc";
                }
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@date", date));
                cmd.ExecuteNonQuery();//用来执行sql语句

                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                while (reader.Read())//按行执行查询，每次循环查询一行
                {
                    //此时reader会获取一行的内容，返回一个类似字典的结构，key为列名，value为值
                    //对于不同的数据库字段类型，我们需要用不同的方法获取
                    temp.type = reader.GetString(0);
                    temp.quantity = reader.GetInt32(1);
                    temp.proceeds = reader.GetInt32(2);
                    GoodsStatInfo.Add(temp);
                }
            }
        }


        /*  查询指定种类 指定年份 商品各月的销量、销售额
         *   必须有年份才可以查看年报表                  */
        public void SalesForEachMonth(int year, string goodsType, int searchType)
        {
            goods_month_sales[0] = -1;

            string Year = Date(year, -1, -1);

            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql;
                if (searchType == 1)
                {
                    sql = "select sum(num),month(date) from goods natural join goods_order natural join `order` where type = @Type and date like @year group by month(date) order by month(date)";
                }
                else
                {
                    sql = "select sum(num * cost),month(date) from goods natural join goods_order natural join `order` where type = @Type and date like @year group by month(date) order by month(date)";
                }
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@year", Year));
                cmd.Parameters.Add(new MySqlParameter("@Type", goodsType));
                cmd.ExecuteNonQuery();//用来执行sql语句
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    goods_month_sales[reader.GetInt32(1)] = reader.GetInt32(0);
                }
            }
        }
    }
}
