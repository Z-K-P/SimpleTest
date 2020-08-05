using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace TestRead.TestReadINI
{
    class TestINI
    {
        private string strFilePath;
        public TestINI()
        {
            strFilePath = AppDomain.CurrentDomain.BaseDirectory + "file.ini";
        }
        //section标题头，key键，value值
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        /// <summary>
        /// 修改ini配置
        /// </summary>
        /// <param name="section">节点名称</param>
        /// <param name="key">键名</param>
        /// <param name="value">键值</param>
        /// <param name="filePath">文件路径</param>
        /// <returns>非零表示成功，零表示失败</returns>
        public long iniWriteValue(string section, string key, string value, string filePath)
        {
            return WritePrivateProfileString(section, key, value, strFilePath);
        }
        /// <summary>
        /// 读取ini配置
        /// </summary>
        /// <param name="section">节点名</param>
        /// <param name="key">键</param>
        /// <param name="def">未取到值时返回的默认值</param>
        /// <param name="filePath">INI文件完整路径</param>
        // <returns>读取的值</returns>
        public string iniReadValue(string section, string key, string def,string filePath)
        {
            StringBuilder builder = new StringBuilder(500);
            GetPrivateProfileString(section, key, def, builder, 500, strFilePath);
            return builder.ToString();
        }
        /// <summary>
        /// 修改ini配置
        /// </summary>
        /// <param name="section">节点名称</param>
        /// <param name="key">键名</param>
        /// <param name="value">键值</param>
        /// <param name="filePath">文件路径</param>
        /// <returns>非零表示成功，零表示失败</returns>
        public long DeleteSection(string section, string filePath)
        {
          return iniWriteValue(section, null, null, filePath);
        }
    }
}
