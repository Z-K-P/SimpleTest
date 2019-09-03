using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TestSQlServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Application.Run(new DataShow());
            //new TestTransaction().insert();
            TestDataAdpter adpter = new TestDataAdpter();
            //adpter.select();
            //adpter.update();
            
            /**
              测试带参数的存储过程
             */
            Testprocedure.Testprocedure test = new Testprocedure.Testprocedure();
            test.exeproc();
            Console.ReadLine();
            
        }
    }
}
