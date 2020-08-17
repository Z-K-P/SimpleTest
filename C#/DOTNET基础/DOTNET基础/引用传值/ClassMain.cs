using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET基础.引用传值
{
    class ClassMain
    {
        private string strPath;
        private string strFileName;
        public void Run()
        {
            /*
              C#默认参数
              
              参数值会拷贝到目标参数中
              Combine方法返回前，即使将null赋值给strPath，Combine的参数值仍然不会发生变化
              当方法执行结束，拷贝的数据会被丢弃
             */
            string strFullName;
            strPath = "./Test/";
            strFileName = "新建文件1.txt";
            strFullName = Combine(strPath,strFileName);
            Console.WriteLine("strFullName"+strFullName);
            Console.WriteLine("strPath"+strPath);

            /*
               ref引用参数
               
               ref传递变量的引用地址，更新值，方法参数也会改变
               用作ref参数的变量必须在传给方法前赋值，否则编译器就报错
               调用者应该初始化传引用的局部变量，防止参数未初始化
             */
            //strPath = "./Test/";
            //strFileName = "新建文件2.txt";
            strFullName = Combine(ref strPath,ref strFileName);
            Console.WriteLine("strFullName" + strFullName);
            Console.WriteLine("strPath" + strPath);

            /*
              out引用参数
              
              out参数功能与ref完全一致
              唯一区别是，如果参数被标记为out,编译器会在方法所有正产返回的代码路径中，
              是否都对该参数进行了赋值，否则编译器就报错
              C#7.0允许完全放弃out参数, GetParameter(out _,out _);
             */
            strPath = "./Test/";
            strFileName = "新建文件3.txt";
            strFullName = GetParameter(out strPath, out strFileName);
            Console.WriteLine("strFullName" + strFullName);
            Console.WriteLine("strPath" + strPath);

            /*
             in只读参数

            C#7.2 支持以引用的方式传入只读值类型
            使用in修饰符，方法中任何对只读参数重新赋值操作，都会造成编译错误
             */
            strPath = "./Test/";
            strFileName = "新建文件4.txt";
            strFullName = ReadOnley(in strPath,in strFileName);
            Console.WriteLine("strFullName" + strFullName);
            Console.WriteLine("strPath" + strPath);
        }
        
        private string Combine(string path,string fileName)
        {
            strPath = null;
            return path += fileName;
        }

        private string Combine(ref string path,ref string fileName)
        {
            strPath = "./Run/";
            return path += fileName;
        }

        private string GetParameter(out string path,out string fileName)
        {
            path = "./master/";
            fileName = "临时.txt";
            return path += fileName;
        }

        private string ReadOnley(in string path,in string filName)
        {
            return path + filName;
        }
    }
}
