using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindowFloat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2;
        private void Form1_Load(object sender, EventArgs e)
        {
            f2 = new Form2();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
           
        }
        //设置按鼠标移动窗体，调用外部接口
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                f2 = new Form2();
                 Point point = f2.Location;
                ReleaseCapture();
                SendMessage(Handle,0xA1,0x20,0);
                if (f2.Location ==point)
                {
                    MessageBox.Show("");
                }
            }
        }
    }
}
