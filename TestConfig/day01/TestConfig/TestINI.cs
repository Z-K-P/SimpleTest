using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace day01.TestDay02Config
{
    class TestINI
    {
        //获取项目路径
            string path = AppDomain.CurrentDomain.BaseDirectory + "Text.ini";
        public string filepath { get; set; }
        //section标题头，key键，value值
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        //section标题头，key键，value值
        public void iniWriteValue(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, filepath);
        }

        public string iniReadValue(string section, string key)
        {
            StringBuilder builder = new StringBuilder(500);
            GetPrivateProfileString(section, key, "", builder, 500, filepath);
            return builder.ToString();
        }
    }
}
