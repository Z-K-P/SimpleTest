using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET基础.属性
{
    /*
        设计规范
            属性的支持字段不应该声明为public或protected，通过属性公开
            如果有意义的话，要为Boolean属性附加 "Is" "Can" 或 "Has" 前缀
            要优先使用自动实现的属性而不是字段
            避免从属性取值方法抛出异常
            nameof关键字，优点在于以后若标识符名称发生改变，重构工具能自动修改实参
         */
    class ClassMain
    {
        private string strLastName;
        private string strMyName;

        //C#6.0之后支持该写法
        public string YouName
        { get; set; } = "测试";

        public string FirstName
        {
            get; set;
        }
        public string LastName
        {
            get
            {
                return LastName;
            }
            set
            {
                strLastName = value;
            }
        }
        public string MyName
        {
            get => strMyName;
            set => strMyName = value;
        }
    }
}
