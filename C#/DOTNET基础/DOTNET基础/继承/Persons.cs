using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET基础.继承
{
    /*
        sealed修饰符
            禁止从其派生
        virtual修饰符
            Java的方法默认为虚方法，希望非虚的方法必须显示密封，C#默认非虚
            C#应用于派生类的override关键字是必须的，virtual和override要对应
            Persion类Name属性不使用virtual会报错，
            Man类Name属性不使用override会生成警告
         */
    class Persons
    {

        public virtual string Name
        { get; set; }
    }
    class Man : Persons
    {
        public override string Name
        { get; set; }
    }
}
