using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Apache.NMS.ActiveMQ;
using Apache.NMS;

namespace TestActiveMQ_MNS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but_生产者_Click(object sender, EventArgs e)
        {
            Queue.生产者1 production = new Queue.生产者1();
            production.ShowDialog();
        }

        private void but_消费者1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
