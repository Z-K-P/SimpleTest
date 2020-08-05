using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TestSQlServer.TestCon;

namespace TestSQlServer
{
    public partial class DataShow : Form
    {
        private  List<Book> list = new List<Book>();
        private TestSQLUtil execute = new TestSQLUtil();
        public DataShow()
        {
            InitializeComponent();
        }

        private void but_SELECT_Click(object sender, EventArgs e)
        {
            list = execute.select();
            this.dataGridView1.DataSource = list;
            dataGridView1.Columns[1].HeaderCell.Value = "书名";
            dataGridView1.Columns[2].HeaderCell.Value = "编号";
            dataGridView1.Columns[3].HeaderCell.Value = "作者名";
        }

        private void but_DELETE_Click(object sender, EventArgs e)
        {

            List<int> ids = new List<int>();
            DataGridViewSelectedRowCollection list = this.dataGridView1.SelectedRows;
            if (list != null)
            {
                
            foreach (DataGridViewRow row in list) {
                   ids.Add((int)row.Cells[2].Value);
            }
                   execute.delete(ids);
            this.but_SELECT_Click(sender, e);
            }
        }

        private void but_INSERT_Click(object sender, EventArgs e)
        {
            new AddForm().ShowDialog();
            this.but_SELECT_Click(sender,e);
        }

        private void but_UPDATE_Click(object sender, EventArgs e)
        {
            int index = this.dataGridView1.SelectedRows[0].Index;
             UpdateForm update = new UpdateForm();
            update.NewBook = this.list[index];
            update.Execute = this.execute;
            update.ShowDialog();
            this.but_SELECT_Click(sender,e);
        }

        private void DataShowVie_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format((e.Row.Index+1).ToString());
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
