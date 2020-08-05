using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using TestRead.ReadConfig;
using TestRead.ReadFile;
using TestRead.TestReadINI;
using TestRead.TestReadXML;

namespace TestReadConfigFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取 exe文件路径+文件名.后缀
            //System.Windows.Forms.Application.ExecutablePath
            //获取Debug目录
            //AppDomain.CurrentDomain.SetupInformation.ApplicationBase.TrimEnd('\\')

            TestConfig config = new TestConfig();
            config.CustomRead();
            config.CustomInsert();
            config.CustomUpdate();
            config.CustomDelete();
            //ReadFile
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


            //ShowData data = new ShowData();
            //data.ShowDialog();s

            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());


            Console.ReadLine();


        }
    }
}
