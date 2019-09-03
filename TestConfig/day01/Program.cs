using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using day01.TestDay02Config;
using day01.TestDay04ADO;
using System.Windows.Forms;
using System.Configuration;

namespace day01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testday01
            //using (TestDay01.Login login = new TestDay01.Login())
            //{
            //    login.ShowDialog();
            //}

            //TestDay02Config
            //TestStream test = new TestStream();
            //test.ReaderFile();

            //TestINI test2 = new TestINI();
            //test2.filepath = @"C:\Users\Administrator\source\repos\day01\day01\TestDay02Config\TextFile.ini";
            //test2.iniWriteValue("数据库配置", "database", "test1");
            //string result = test2.iniReadValue("数据库配置", "database");
            //Console.WriteLine(result);

            //TestConfig config = new TestConfig();
            //config.read();

            //TestXML xml = new TestXML();
            //xml.insert();
            //xml.delete();


            //TestDay04ADO
            //ShowData data = new ShowData();
            //data.ShowDialog();s

            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());


            Console.ReadLine();


        }
    }
}
