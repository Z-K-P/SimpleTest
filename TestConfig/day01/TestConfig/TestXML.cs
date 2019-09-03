using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace day01.TestDay02Confi
{
    class TestXML
    {
        public void insert()
        {
        XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Administrator\source\repos\day01\day01\test.xml");

            //获取节点
            XmlNode node = doc.SelectSingleNode("userlist");
            //创建一个结点，并设置节点属性
            XmlElement xelKey = doc.CreateElement("user");
            //添加节点属性
            XmlAttribute xelType1= doc.CreateAttribute("user1");
            //设置结点属性值
            xelType1.InnerText = "a";
            xelKey.SetAttributeNode(xelType1);

            //创建子节点
            XmlElement xelAuthor = doc.CreateElement("username");
            //设置节点值
            xelAuthor.InnerText = "一号";
            //子节点挂载到父节点
            xelKey.AppendChild(xelAuthor);
            //父节点挂在到node节点
            node.AppendChild(xelKey);
            //保存
            doc.Save(@"C:\Users\Administrator\source\repos\day01\day01\test.xml");
        }

        public void delete()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Administrator\source\repos\day01\day01\test.xml");
            
            XmlElement xe = doc.DocumentElement;
            string.Format("/userlist/user[username='a']");
            //获取符合条件的第一个节点
            XmlElement selectXe = (XmlElement)xe.SelectSingleNode("/userlist/user[username='a']");
            //移除节点
            selectXe.ParentNode.RemoveChild(selectXe);
        }

    }
}
