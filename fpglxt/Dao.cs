using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fpglxt
{
    class Dao
    {
        SqlConnection sqlConnection;
        public SqlConnection connect()
        {
            string str = @"Data Source=LAPTOP-A1U7D07l;Initial Catalog=PersonDB;Integrated Security=True";
            //建立数据库连接对象
            sqlConnection = new SqlConnection(str);
            //打开数据库
            sqlConnection.Open();
            //返回数据库连接对象
            return sqlConnection;
        }
        public SqlCommand command(string sql)
        {
            SqlCommand sqlCommand = new SqlCommand(sql, connect());
            return sqlCommand;
        }

        //更新数据操作
        public int execute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }
        
        //查找数据操作
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }

        public void close()
        {
            //关闭数据库连接
            sqlConnection.Close();
        }
    }
}
