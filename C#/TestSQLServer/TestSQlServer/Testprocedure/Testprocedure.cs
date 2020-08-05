using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TestSQlServer.Testprocedure
{
    class Testprocedure
    {
        public string str = "Data Source=.;Initial Catalog=TestSQLServer;Persist Security Info=True;User ID=sa;Password=root";
        public SqlConnection con;

        public void exeproc()
        {
            con = new SqlConnection(str);
            con.Open();
             SqlCommand com = con.CreateCommand();
            //指定执行存储过程操作
             com.CommandType = CommandType.StoredProcedure;
            //指定存储过程
            com.CommandText = "testproc2";
            SqlParameter parameter = new SqlParameter("@parameter", SqlDbType.Char,10);
            parameter.Value ="测试4";
            com.Parameters.Add(parameter);
            Console.WriteLine("begin2");
           int a = com.ExecuteNonQuery();
            Console.WriteLine("begin3"+a);



        }

    }
}
