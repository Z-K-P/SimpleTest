using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TestWindos.TestOpenFile
{
    class FileStreamUtil
    {

        StreamReader reader;
        public List<string> ReaderFile(string filename)
        {
            string line= "";
            try
            {
                reader = new StreamReader(filename);
                line = reader.ReadLine();
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("取消了选择");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("取消了选择");
            }
            List<string> list = new List<string>();

            Console.WriteLine(line);
            while(!string.IsNullOrEmpty(line))
            {
                list.Add(line+"\r\n");
             line = reader.ReadLine();
            }
            reader.Close();
            reader.Dispose();
            return list;
        }
        public void WriterFile(string filename,string value)
        {
            Console.WriteLine(filename);
            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }
            StreamWriter writer = new StreamWriter(filename);

            writer.Write(value);
            writer.Flush();
            writer.Close();
            writer.Dispose();
        }
        public void CreateFile(string path)
        {
            File.Create(path);
        }
    }
}
