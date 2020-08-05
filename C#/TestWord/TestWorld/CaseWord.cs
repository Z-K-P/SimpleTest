using NPOI.OpenXmlFormats.Wordprocessing;
using NPOI.XWPF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWorld
{
    class CaseWord
    {
        string filename = @"c:/Users/Administrator/Desktop/work.doc";
        public void Write()
        {
            XWPFDocument mydoc = new XWPFDocument();

            //设置页面大小
            CT_SectPr size = new CT_SectPr();
            size.pgSz.w = 11900;
            size.pgSz.h = 16830;
            mydoc.Document.body.sectPr = size;

            //创建段落
             XWPFParagraph p1 = mydoc.CreateParagraph();

            //设置段落样式
            p1.Alignment = ParagraphAlignment.CENTER;//居中
            XWPFRun run1 = p1.CreateRun();
            XWPFRun run3= p1.CreateRun();
            run3.SetText("测试测试测试测试测试测试测试测试测试测试测试测试测试测试测试测试测试");
            run1.FontSize = 16;//设置字体大小
            run1.SetColor("#808080");//设置字体颜色
            run1.SetText("标题文本标题文本标题文本标题文本标题文本");

            //创建段落
             XWPFParagraph p2 = mydoc.CreateParagraph();
            p2.Alignment = ParagraphAlignment.CENTER;//居中
            XWPFRun run2 = p2.CreateRun();
            run2.SetColor("#123456");
            run2.FontSize = 8;
            run2.SetText("时间："+DateTime.Now.ToString());

            //获取数据
            DataSet set = GetData();
            DataTable table = set.Tables[0];
            //创建表单
            XWPFTable table1 = mydoc.CreateTable(table.Rows.Count+1,table.Columns.Count);
           
            //设置第一行表格
            XWPFTableCell firstcell1 = table1.GetRow(0).GetCell(0);
            //XWPFRun firstcell1 = t1.CreateRun();
            firstcell1.SetColor("#FF0000");
            firstcell1.SetText("name1");

            XWPFTableCell firstcell2 = table1.GetRow(0).GetCell(1);
            //XWPFRun firstcell2 = t2.CreateRun();
            firstcell2.SetColor("#FF0000");
            firstcell2.SetText("name2");

            XWPFTableCell firstcell3 = table1.GetRow(0).GetCell(2);
            //XWPFRun firstcell3 = t3.CreateRun();
            firstcell3.SetColor("#FF0000");
            firstcell3.SetText("id");

            /**
             这些单元格默认换行
             */
            for (int row = 0; row < table.Rows.Count; row++)
            {
                for (int colum = 0; colum < table.Columns.Count; colum++)
                {
            table1.GetRow(row + 1).Height = 10;
            XWPFParagraph t = table1.GetRow(row+1).GetCell(colum).AddParagraph();
            XWPFRun rIO = t.CreateRun();
            rIO.FontSize = 5;
            rIO.IsBold = true;
            rIO.SetText(table.Rows[row][colum].ToString());
                }
            }

            //行合并
            //table1.GetRow(2).MergeCells(0, 1);


            FileStream stream = new FileStream(filename,FileMode.Create);
            mydoc.Write(stream);
            stream.Close();
            mydoc.Close();
        }

        public DataSet GetData()
        {
            string data= "Data Source=.;Initial Catalog=TestSQLServer;Persist Security Info=True;User ID=sa;Password=root";
            string sql = "select * from book";
            DataSet set = new DataSet();
            SqlConnection con = new SqlConnection(data);
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            da.Fill(set);
            return set;
        }

        public void Read()
        {
            FileStream stream = new FileStream(filename,FileMode.Open);
            XWPFDocument doc = new XWPFDocument(stream);

            //解析段落
            foreach (XWPFParagraph para in doc.Paragraphs)
            {
                string text = para.ParagraphText;
                Console.WriteLine(text);
                //另一种方式
                //foreach (XWPFRun run in para.Runs)
                //{
                //    text = run.ToString();
                //    Console.Write(text+"text");
                //}
            }

            //解析表格
            XWPFTable table = doc.Tables[0];
            for (int row=1; row<table.Rows.Count; row++)
            {
                XWPFTableRow r = table.Rows[row];
                foreach (XWPFTableCell cell in r.GetTableCells())
                {
                     string str= cell.GetText();
                    Console.Write(str+"\t");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
