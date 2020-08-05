using gregn6Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestGRID__
{
    public partial class TestGRID : Form
    {
        public TestGRID()
        {
            InitializeComponent();
        }

        //报表打印预览
        private void button1_Click(object sender, EventArgs e)
        {
            GridppReport Report = new GridppReport();
            //将参数传递到报表模板中
            string str="test";
            Report.ParameterByName("参数名").Value = str;

            Report.LoadFromFile(@"C:\Users\Administrator\Desktop\test.grf");

            //打印预览
            Report.PrintPreview(true);
        }

        private void TestGRID_Load(object sender, EventArgs e)
        {

        }
    }
}
