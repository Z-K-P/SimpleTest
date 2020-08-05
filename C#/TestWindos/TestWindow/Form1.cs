using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindow
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Size endSize;
        double width=1.0;
        double height=1.0;

        private void Form1_Load(object sender, EventArgs e)
        {
            endSize = this.Size;
            this.MinimumSize = new Size(300,300);
            this.button1.MinimumSize = new Size(25,25);
            this.button2.MinimumSize = new Size(25,25);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            width = this.Size.Width * 1.0 / endSize.Width;
            height = this.Size.Height * 1.0 / endSize.Height;
            endSize = this.Size;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
        }
        protected override void WndProc(ref Message m)
        {
            FormWindowState previousWindowState = this.WindowState;
            base.WndProc(ref m);
            FormWindowState currentWindowState = this.WindowState;
            if (previousWindowState != currentWindowState && currentWindowState == FormWindowState.Maximized)
            {
                width = this.Size.Width * 1.0 / endSize.Width;
                height = this.Size.Height * 1.0 / endSize.Height;
                endSize = this.Size;
            }

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control con in this.Controls)
            {
                con.Width = Convert.ToInt32(con.Width * width);
                con.Height = Convert.ToInt32(con.Height * height);
                con.Left = Convert.ToInt32(con.Left * width);
                con.Top = Convert.ToInt32(con.Top * height);
            }

        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MinimumSizeChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MaximizedBoundsChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
