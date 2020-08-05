using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TestCaseExcel
{
    class SQLUtil
    {

        public static DataSet getData()
        {
            string str_sql = "Data Source=.;Initial Catalog=TestSQLServer;Persist Security Info=True;User ID=sa;Password=root";
            string sql = "select name,author,Id from book";
            DataSet set = new DataSet();
            SqlConnection con = new SqlConnection(str_sql);
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            con.Close();
            da.Fill(set);
            return set;
        }
    }
}
