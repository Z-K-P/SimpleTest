using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestWindos.TestOpenFile
{
    public partial class ShowFile : Form
    {
            List<string> filenames = new List<string>();

        
        private int selectindex=0;
        public ShowFile()
        {
            InitializeComponent();
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 打开ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            this.openFileDialog1.FileName = Environment.CurrentDirectory;
            if (this.listBox1.Items.Count>=2)
            {
            SaveListBox();
            }
            this.openFileDialog1.ShowDialog();
            string filename = this.openFileDialog1.FileName;
            filenames.Add(filename);
            FileStreamUtil filestream = new FileStreamUtil();
            List<string> list= filestream.ReaderFile(filename);
            foreach (string str in list)
            {
                this.textBox1.Text += str;
            }
            this.listBox1.Items.Add(Path.GetFileName(filename));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;
            if (index == 0 ||selectindex==index)
            {
                return;
            }
            selectindex = index;
            SaveListBox();
        }

        private void SaveListBox()
        {
            int index = this.listBox1.SelectedIndex;
            DialogResult result = MessageBox.Show("是否保留当前修改", "警告", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string text = this.textBox1.Text;
                MessageBox.Show(text);
                FileStreamUtil filestream = new FileStreamUtil();
                filestream.WriterFile(filenames[index], text);
            }
                this.textBox1.Clear();
                this.listBox1.Items.RemoveAt(index);
                filenames.RemoveAt(index);
        }

        private void ShowFile_Load(object sender, EventArgs e)
        {
            this.selectindex = 0;
            filenames.Add("文本");
        }

        private void ShowINI_Activated(object sender, EventArgs e)
        {
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveListBox();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveListBox();
            this.Close();
        }

        private void 新建ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            saveFileDialog1.FileName = "测试";
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "文本文件|*.txt";
            saveFileDialog1.Title = "浏览文本文件";
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.RestoreDirectory = true;
            DialogResult result = this.saveFileDialog1.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            string path = saveFileDialog1.FileName.ToString();

            FileStreamUtil stream = new FileStreamUtil();
            stream.CreateFile(path);
            filenames.Add(path);
            string  filename = Path.GetFileName(saveFileDialog1.FileName);
            listBox1.Items.Add(filename);
        }
    }
}
