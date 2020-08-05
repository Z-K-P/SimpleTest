using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;

namespace TestWindos.选择类控件
{
    public partial class TestListBox : Form
    {
        public TestListBox()
        {
            InitializeComponent();
        }

        private void but_AddLeft_Click(object sender, EventArgs e)
        {
            //添加
            if (this.LeftList.Items.Contains(this.LeftAddTxtBox.Text))
            {
                MessageBox.Show("集合不能重复");
                this.LeftAddTxtBox.Clear();
                return;
            }
            this.LeftList.Items.Add(this.LeftAddTxtBox.Text);
            this.LeftAddTxtBox.Clear();
        }

        private void but_AddRight_Click(object sender, EventArgs e)
        {
            //添加
            if (this.RightList.Items.Contains(this.RightAddTextBox.Text))
            {
                MessageBox.Show("集合不能重复");
                this.RightAddTextBox.Clear();
                return;
            }
            this.RightList.Items.Add(this.RightAddTextBox.Text);
            this.RightAddTextBox.Clear();
        }

        private void LeftToRight_Click(object sender, EventArgs e)
        {
            object obj = this.LeftList.SelectedItem;
            this.LeftList.Items.Remove(obj);
            this.RightList.Items.Add(obj);
        }

        private void RightToLeft_Click(object sender, EventArgs e)
        {
            object obj = this.RightList.SelectedItem;
                this.RightList.Items.Remove(obj);
                this.LeftList.Items.Add(obj);
        }

        private void LeftList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RightToLeft.Enabled = false;
            this.LeftToRight.Enabled = true;
        }

        private void RightList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LeftToRight.Enabled = false;
            this.RightToLeft.Enabled = true;
        }
    }
}
