using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TestRead.ReadFile
{
    class TestStream
    {
        private string strFilePath;
        public TestStream()
        {
            string strFilePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "\\file";
        }
        public void ReaderFile()
        {
            //读取文件
            StreamReader reader = new StreamReader(strFilePath);
            string str = reader.ReadLine();
            string str2 = reader.ReadLine();
            Console.WriteLine(str);
            reader.Close();
        }

           
    }
}
