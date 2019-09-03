using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindos.选择类控件
{
    public partial class TestCheckBox : Form
    {
        public TestCheckBox()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string check="";
            if (this.checkBox1.Checked)
            {
                check += this.checkBox1.Text;
            }
            if (this.checkBox2.Checked)
            {
                check += this.checkBox2.Text;
            }
            if (this.checkBox2.Checked)
            {
                check += this.checkBox2.Text;
            }
            MessageBox.Show(check);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string check2="";
         
            for ( int i=0;i< this.checkedListBox1.Items.Count; i++)
            {
                if (this.checkedListBox1.GetItemChecked(i))
                {
                        check2 += this.checkedListBox1.GetItemText(checkedListBox1.Items[i]);
                }
            }
            MessageBox.Show(check2);
        }

        private void TestCheckBox_Load(object sender, EventArgs e)
        {
            this.checkedListBox1.Items.Add("测试1", false);
            this.checkedListBox1.Items.Add("测试2", false);
            this.checkedListBox1.Items.Add("测试3", false);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
