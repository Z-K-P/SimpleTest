using System;
using System.Text.RegularExpressions;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TestRead.ReadConfig
{
    class TestConfig
    {

        private ExeConfigurationFileMap map = new ExeConfigurationFileMap();
        private Configuration config;
        public TestConfig()
        {
            map.ExeConfigFilename = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "\\file.config";
            config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
        }
        /// <summary>
        /// 读取App.config文件
        /// App.config的配置文件需要在启动项的目录下面
        /// </summary>
        public void Read()
        {
            string str = ConfigurationManager.AppSettings["test"].ToString();
            Console.WriteLine(str);
        }

        /// <summary>
        /// 读取自定义位置的config文件
        /// </summary>
        public void CustomRead()
        {
            //读取普通配置节点
            string simpleNodeValue = config.AppSettings.Settings["simpleNode"].Value;
            //读取数据源配置节点
            string dataNodeValue = config.ConnectionStrings.ConnectionStrings["dataNode"].ConnectionString;
        }

        /// <summary>
        /// 修改节点，自定义位置的config文件
        /// </summary>
        public void CustomUpdate()
        {
            //修改普通配置节点
            config.AppSettings.Settings["simpleNode"].Value = "CustomValue";
            //修改数据源配置节点
            config.ConnectionStrings.ConnectionStrings["dataNode"].ConnectionString = "CustomValue";
            Refresh();
        }
        /// <summary>
        /// 添加节点，自定义位置的config文件
        /// </summary>
        public void CustomInsert()
        {
            config.AppSettings.Settings.Add("testkey","testvalue");
            config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("testData","testDataValue"));
            Refresh();
        }
        /// <summary>
        /// 删除节点，自定义位置的config文件
        /// </summary>
        public void CustomDelete()
        {
            config.AppSettings.Settings.Remove("testkey");
            config.ConnectionStrings.ConnectionStrings.Remove("testData");
            Refresh();
        }

       /// <summary>
       /// 指定节点是否存在
       /// </summary>
       /// <param name="strNode"></param>
       /// <returns></returns>
        public bool hasNode(string strNode)
        {
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (strNode.Equals(key))
                {
                    return true;
                }
            }
            foreach (string key in ConfigurationManager.ConnectionStrings)
            {
                if (strNode.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 将修改同步到本地文件
        /// </summary>
        public void Refresh()
        {
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            ConfigurationManager.RefreshSection("configSections");
        }

    }
}
