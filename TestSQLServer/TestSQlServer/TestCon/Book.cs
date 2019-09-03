using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSQlServer.TestCon
{
   public class Book
    {
        public string name { get; set; }
        public int Id { set; get; }
        public string author { get; set; }

        public Book()
        {

        }

        public Book(string name, string author)
        {
            this.name = name;
            this.author = author;
        }

        public Book(string name, int id, string author)
        {
            this.name = name;
            Id = id;
            this.author = author;
        }
    }
}
