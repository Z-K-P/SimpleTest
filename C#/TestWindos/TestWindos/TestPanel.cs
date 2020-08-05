using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestWindos.选择类控件;

namespace TestWindos
{
    public partial class TestPanel : Form
    {
        public TestPanel()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TestPanel_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestCheckBox frm = new TestCheckBox();
            //将子窗体设置非最高层，非顶级控件
            frm.TopLevel = false;
            frm.WindowState = FormWindowState.Maximized;
            //去掉窗体边框
            frm.FormBorderStyle = FormBorderStyle.None;
            //指定子窗体显示的容器
            frm.Parent = this.panel1;
            frm.Show();
        }
    }
}
