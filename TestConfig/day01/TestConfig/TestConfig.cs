using System;
using System.Text.RegularExpressions;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace day01.TestDay02Config
{
    class TestConfig
    {
        //读取App.config文件
        public void read()
        {
            string str = ConfigurationManager.AppSettings["test"].ToString();
            Console.WriteLine(str);
        }

        //读取自定义config文件

    }
}
