using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day01.TestDay01
{
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = textBox1.Text;
            if("Yes".Equals(result) || "yes".Equals(result))
            {
                MessageBox.Show("可以查看");
                this.Close();
            }
        }
    }
}
