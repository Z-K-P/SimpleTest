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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = username.Text.Trim();
            string pwd = password.Text.Trim();
            if (!"888888".Equals(pwd))
            {
                MessageBox.Show("密码错误");
            }
            if (!"admin".Equals(name))
            {
                MessageBox.Show("用户名错误");
            }
            int a=0;
            try
            {

                 a = Convert.ToInt32(ageText.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("输入有效年龄");
                ageText.Focus();
            }
            if (a<10)
            {
                MessageBox.Show("不允许查看");
                
            }
            if (a<18)
            {
                MessageBox.Show("可以查看");
            }
            if (a>=10)
            {
                Select s = new Select();
                  s.ShowDialog();
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
