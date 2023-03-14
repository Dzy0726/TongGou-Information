using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DBTest.GoodsInfoStatis;
using MySql.Data.MySqlClient;

namespace DBTest
{
    class StoreInfoStatis
    {
        public struct StoreInfo
        {
            public int id;
            public string name;
            public string type;
            public int quantity;
            public double proceeds;
            public double assessment;
        };

        static public List<StoreInfo> StoreStatInfo = new List<StoreInfo>();

        /*  查询各种类店铺销量、销售额；按年月日查询，可为空；
         *  searchType = 1查销量    =2 查销售额
         *  如果不具备某一参数 则令其为-1 如：2020年8月 则参数2020，8，-1  */
        static public void StoreSpecifyDate(int year, int month, int day, int searchType)
        {
            StoreInfo temp = new StoreInfo();
            string date = Date(year, month, day);

            string connString = "server=localhost;database=db_mall;uid=root;pwd=dzy123.0";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql;
                if (searchType == 1)
                {
                    sql = "select type,sum(num),sum(cost*num) from goods_order natural join store natural join `order` where date like @date group by type order by sum(num) desc";
                }
                else
                {
                    sql = "select type,sum(num),sum(cost*num) from goods_order natural join store natural join `order` where date like @date group by type order by sum(cost*num) desc";
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
                    temp.proceeds = reader.GetDouble(2);
                    StoreStatInfo.Add(temp);
                }
            }
        }


        /*  查询指定种类 指定日期 店铺销量、销售额
         *   按降序排列                 */
        static public void StoreSalesRank(int year,int month,int day, string storeType, int searchType)
        {
            StoreInfo temp = new StoreInfo();

            string DT = Date(year, month, day);

            string connString = "server=localhost;database=db_mall;uid=root;pwd=dzy123.0";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql;
                if (searchType == 1)
                {
                    sql = "select store_name,sum(num),sum(num*cost) from  goods_order natural join store natural join `order` where type = @Type and date like @date group by store_name order by sum(num) desc";
                }
                else
                {
                    sql = "select store_name,sum(num),sum(num*cost) from  goods_order natural join store natural join `order` where type = @Type and date like @date group by store_name order by sum(num*cost) desc";
                }
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@date", DT));
                cmd.Parameters.Add(new MySqlParameter("@Type", storeType));
                cmd.ExecuteNonQuery();//用来执行sql语句
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    temp.name = reader.GetString(0);
                    temp.quantity = reader.GetInt32(1);
                    temp.proceeds = reader.GetDouble(2);
                    temp.type = storeType;
                    StoreStatInfo.Add(temp);
                }
            }
        }

        /*  查询店铺评分 降序排列  可按日期查询  */
        static public void StoreAssessRank(int year,int month,int day,string storeType)
        {
            StoreInfo temp = new StoreInfo();
            string DT = Date(year, month, day);
            string connString = "server=localhost;database=db_mall;uid=root;pwd=dzy123.0";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql = "SELECT store_id,store_name,avg(assessment) from goods_order natural join assess natural join `order` natural join store where date like @date and type = @Type group by store_id order by avg(assessment) desc";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@date", DT));
                cmd.Parameters.Add(new MySqlParameter("@Type", storeType));
                cmd.ExecuteNonQuery();//用来执行sql语句
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    temp.id = reader.GetInt32(0);
                    temp.name = reader.GetString(1);
                    temp.assessment = reader.GetDouble(2);
                    temp.type = storeType;
                    StoreStatInfo.Add(temp);
                }
            }
        }
    }
}
