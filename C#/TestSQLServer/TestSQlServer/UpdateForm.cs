using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestSQlServer.TestCon;

namespace TestSQlServer
{
    public partial class UpdateForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Book NewBook { get; set; }
        public TestSQLUtil Execute { get; set; }
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewBook.name = this.textBox1.Text;
           NewBook.author = this.textBox2.Text;
           int result = this.Execute.update(NewBook);
            if (result > 0)
            {
                MessageBox.Show("修改成功");
                this.Close();
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = this.NewBook.name;
            this.textBox2.Text = this.NewBook.author;
            this.label4.Text = Convert.ToString(this.NewBook.Id);
        }
    }
}
