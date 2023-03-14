using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TransInfo
{
    public class TransInfoStatis
    {
        public struct transInfo
        {
            public int id;//运输单id
            public string departure;//发货地
            public string destination;//目的地
            public double fare;//运费
        };

        public List<transInfo> transInfoList = new List<transInfo>();

        public Double avg_trandfare;

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

        //查询平均运费
        //如果不具备某一参数 则令其为-1 如：2020年8月 则参数2020，8，-1
        public void TransfareSpecifyDate(int year, int month, int day)
        {
            string date = Date(year, month, day);
            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql;
                sql = "select avg(fare) from `order` natural join order_trans natural join transportinfo where date like @date;";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@date", date));
                cmd.ExecuteNonQuery();//用来执行sql语句

                MySqlDataReader reader = cmd.ExecuteReader();//创建一个执行命令的对象,但是还没有执行命令
                while (reader.Read())
                {
                    if (reader.IsDBNull(0))
                    {
                        break;
                    }
                    avg_trandfare = reader.GetDouble(0);
                }
            }
        }

        //  查询运费 降序排列  可按日期查询
        public void TransfareRank(int year, int month, int day)
        {
            transInfo temp = new transInfo();
            string date = Date(year, month, day);
            string connString = "server=106.14.99.150;database=db_mall;uid=root;pwd=db123";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())//创建查询命令
            {
                string sql = "select trans_id,departure,destination,fare from `order` natural join order_trans natural join transportinfo where date like @date order by fare;";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new MySqlParameter("@date", date));
                cmd.ExecuteNonQuery();//用来执行sql语句
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    temp.id = reader.GetInt32(0);
                    temp.departure = reader.GetString(1);
                    temp.destination = reader.GetString(2);
                    temp.fare = reader.GetDouble(3);
                    transInfoList.Add(temp);
                }
            }
        }
    }
}
