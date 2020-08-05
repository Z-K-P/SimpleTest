using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TestSQlServer
{
    class TestDataAdpter
    {
        public  SqlDataAdapter adapter ;
        public SqlConnection con = new SqlConnection("server=.;database=TestSQLServer;Trusted_Connection=yes;");
            DataSet set = new DataSet();
        public void select()
        {
            string sql = "select Id,name,author from book";
            adapter = new SqlDataAdapter(sql, con);
            con.Open();
            adapter.Fill(set,"book");
           DataTable table  = set.Tables["book"];
            foreach (DataRow dr in table.Rows)
            {
                foreach (DataColumn dc in table.Columns)
                {
                    string result = dr[dc].ToString();
                    Console.Write("\t"+result);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            con.Close();
        }
        public void update()
        {
            //string sql = "update book set name = @name,author = @author";
            string sql = "select Id,name,author from book";

            con.Open();
            adapter = new SqlDataAdapter(sql,con);
            SqlCommandBuilder scb = new SqlCommandBuilder(adapter);
            adapter.Fill(set, "book");
            DataTable table = set.Tables["book"];
            table.Rows[0]["name"] = "成功";
            table.Rows[0]["author"] = "无名";
        adapter.Update(set,"book");

        }
    }
}
