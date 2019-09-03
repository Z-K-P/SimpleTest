using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestSQlServer.TestCon
{
    public class TestSQLUtil
    {
        string data = "Data Source=.;Initial Catalog=TestSQLServer;Persist Security Info=True;User ID=sa;Password=root";
        private SqlConnection con = new SqlConnection();
        public SqlConnection GetCom()
        {
            con.ConnectionString = data;
            con.Open();
            return con;
        }
        #region Insert
        public void insert(Book book)
        {
            string sql = "INSERT INTO book(name,author) values(@name,@author)";
            SqlConnection con = GetCom();
            SqlCommand com = new SqlCommand(sql,con);
            com.Parameters.Add(new SqlParameter("name",book.name));
            com.Parameters.Add(new SqlParameter("author", book.author));
            int result = com.ExecuteNonQuery();
           
            if (result > 0)
                MessageBox.Show("添加成功");
            con.Close();
        }
        #endregion
        #region Update
        public int update(Book book)
        {
            string sql = "UPDATE book SET name = @name,author = @author WHERE Id = @Id";
            SqlConnection con = GetCom();
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.Add(new SqlParameter("name", book.name));
            com.Parameters.Add(new SqlParameter("author", book.author));
            com.Parameters.Add(new SqlParameter("Id", book.Id));
            int result = com.ExecuteNonQuery();
            con.Close();
            return result;
        }
        #endregion
        #region Delete
        public void delete(List<int> ids)
        {
            string sql = "DELETE book WHERE Id =(@Id)";
            SqlConnection con = GetCom();
            SqlTransaction tran   = con.BeginTransaction();
            SqlCommand com = new SqlCommand(sql, con);
            com.Transaction = tran;

            try
            {
                foreach (int id in ids)
                {
                    SqlParameter parameter = new SqlParameter("Id", id);
                    com.Parameters.Add(parameter);
                    com.ExecuteNonQuery();
                    com.Parameters.Remove(parameter);
                }
                tran.Commit();
                MessageBox.Show("事物提交");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                tran.Rollback();
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
        #region Select
        public List<Book> select()
        {
            string sql = "SELECT Id,name,author FROM book";
            SqlConnection con = GetCom();
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader data = com.ExecuteReader();
            List<Book> list = new List<Book>();
            while (data.Read())
            {
                Book book = new Book();
                book.name = (string)data["name"];
                book.Id = (int)data["Id"];
                book.author = (string)data["author"];
                list.Add(book);
            }
            con.Close();
            return list;
        }
        #endregion


    }
}
