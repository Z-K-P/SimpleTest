using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using NPOI;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;

namespace TestCaseExcel
{
    class CaseExcel
    {
        FileStream fileStream;
            string filename = @"C:\Users\Administrator\Desktop\excel.xls";
        public void Writer()
        {
            
             DataSet set = SQLUtil.getData(); //获取数据源
             System.Data.DataTable table = set.Tables[0];//获取表数据

            HSSFWorkbook workbook = new HSSFWorkbook();//创建一个Excel对象
            ISheet sheet = workbook.CreateSheet("Sheet1");//设置Sheet 

            IRow firstrow = sheet.CreateRow(0); //将第一行设置为标题
             ICell firstcell = firstrow.CreateCell(0);
            firstcell.SetCellValue("测试表");  //设置第一行第一列value值

            ICellStyle style= workbook.CreateCellStyle();   //创建样式

            IFont font = workbook.CreateFont();
            font.FontHeight = 20 * 20;  //设置字体大小
            style.SetFont(font);    //设置字体样式

            style.Alignment = HorizontalAlignment.Center;   //设置居中样式
            firstcell.CellStyle = style;    //指定单元格应用指定样式

            sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(0,0,0,2));//合并单元格起始第几行，结束第几行，起始第几列，结束第几列


            for (int j = 1; j < table.Rows.Count; j++)  //遍历表数据的行数,由于第一行为标题（0行）需要从1开始
            {
                IRow row= sheet.CreateRow(j);   //创建Excel行
                sheet.CreateRow(j).Height=20*20; //设置行高，值为20的倍数
                for (int i = 0; i < table.Columns.Count; i++)   //遍历表数据的列数
                {
                    row.CreateCell(i).SetCellValue(table.Rows[j][i].ToString());    //填充数据
                    sheet.SetColumnWidth(0,20*256); //设置列宽,第一个值从0开始计数,第二个值为宽度
                }
            }
            fileStream = new FileStream(filename, FileMode.OpenOrCreate);
            workbook.Write(fileStream); //将数据写入Excel表中
            fileStream.Close();
            workbook.Close();
        }
        public void Reader()
        {
           DataTable table = new DataTable("book"); //创建表数据容器

            table.Columns.Add(new DataColumn("name1",typeof(string)));  //初始化列
            table.Columns.Add(new DataColumn("name2",typeof(string)));
            table.Columns.Add(new DataColumn("id",typeof(string)));

            DataRow dr=null;    //声明DataRow行
            FileStream stream = new FileStream(filename,FileMode.Open);

           HSSFWorkbook wb = new HSSFWorkbook(stream);  // 读取Excel数据
           ISheet sheet = wb.GetSheet("sheet1");    //指定Sheet

            for (int i=1;i<sheet.LastRowNum;i++)    //遍历Excel的行数，由于该表第一行为标题（0行）需要从1开始
            {
                IRow row = sheet.GetRow(i); //获取Execl行数据
                dr  = table.NewRow();    //创建DataRow
                for (int j = 0; j < row.Cells.Count;j++)    //遍历Excel的列数
                {
                   string value = row.GetCell(j).ToString();    //获取指定行指定列的数据
                   dr[j] = value;   //给DataRow赋值
                }
                table.Rows.Add(dr); //  将DataRow数据添加到DataTable数据表中
            }

            /**
             遍历DataTalbe
             */
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j=0; j < table.Columns.Count; j++)
                {
                string strName1 = table.Rows[i][j].ToString();
                Console.WriteLine(strName1);
                }
            }
            Console.ReadKey();
        }
    }
}
