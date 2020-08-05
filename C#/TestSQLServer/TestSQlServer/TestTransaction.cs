using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Transactions;
using System.Threading;
namespace TestSQlServer
{
    class TestTransaction
    {


        string sql = "INSERT INTO book(name,author) values(@name,@author)";
        public void insert()
        {

            using (TransactionScope tran = new TransactionScope())
            {
            exe();
                Thread t = new Thread(new ThreadStart(delegate ()
                {
                    Console.WriteLine("new Thtread");
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TestSQLServer;Persist Security Info=True;User ID=sa;Password=root");
                    con.Open();
                    string sql = "INSERT INTO book(name,author) values(@name,@author)";
                    SqlCommand com = new SqlCommand(sql, con);
                    com.Parameters.Add(new SqlParameter("name", "123"));
                    com.ExecuteNonQuery();
                }));
                t.Start();
            exe();
            exe();
            tran.Complete();
            }
        }

        private void exe2()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TestSQLServer;Persist Security Info=True;User ID=sa;Password=root");
            con.Open();
            string sql = "INSERT INTO book(name,author) values(@name,@author)";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.Add(new SqlParameter("name", "123"));
            com.ExecuteNonQuery();
        }

        int count=0;
        private  void exe()
        {
            Console.WriteLine(count++);
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TestSQLServer;Persist Security Info=True;User ID=sa;Password=root");
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.Add(new SqlParameter("name", "abc"));
            com.Parameters.Add(new SqlParameter("author", "abc"));
            com.ExecuteNonQuery();
        }
    }
}
