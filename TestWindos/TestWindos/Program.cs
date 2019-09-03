using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestWindos.TestOpenFile;
using TestWindos.选择类控件;
namespace TestWindos

{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //测试ListBox
            //TestListBox listbox = new TestListBox();
            //listbox.ShowDialog();
            //测试Check
            //TestCheckBox check = new TestCheckBox();
            //check.ShowDialog();

            //TestPanel panel = new TestPanel();
            //panel.ShowDialog();

            ShowFile file = new ShowFile();
            file.ShowDialog();
        }
    }
}
