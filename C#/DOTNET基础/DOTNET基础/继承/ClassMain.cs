using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET基础.继承
{
    class ClassA
    {
        public void Print()
        {
            Console.WriteLine("ClassA.Print");
        }
    }
    class ClassB : ClassA
    {
        public virtual void Print()
        {
            Console.WriteLine("ClassB.Print");
        }
    }
    class ClassC : ClassB
    {
        public override void Print()
        {
            Console.WriteLine("ClassC.Print");
        }
    }
    class ClassD : ClassC
    {
        public new void Print()
        {
            Console.WriteLine("ClassD.Print");
        }
    }
    
    /*
        JAVA中虚方法调用的都是基类的实现
        C#相反，总是调用派生得最远的虚成员
        new修饰符，它在基类面前隐藏了派生类重新声明的成员，这时不是调用派生得最远的成员。
        override修饰符，修饰的任何方法自动为虚，只有基类的虚方法才能重写，
            所以重写后的方法还是虚方法
         */
    class ClassMain
    {
        public void Run()
        {
            ClassD classD = new ClassD();
            ClassC classC = classD;
            ClassB classB = classD;
            ClassA classA = classD;

            classD.Print();
            classC.Print();
            classB.Print();
            classA.Print();
            /*
             ClassD.Print
             ClassC.Print
             ClassC.Print
             ClassA.Print

                classD.Print()它下面没有派生类
                classC.Print()重写了基类中虚成员,派生得最远的成员，
                    使用new修饰符的ClassD.Print()被隐藏
                classB.Print()是虚方法，而ClassC.Print()是重写了它的派生最远的成员，
                    和前面一样，使用了new修饰符的ClassD.Print()被隐藏
                classA.Print()没有重新声明任何基类成员，而且非虚，所以被直接调用
             */
        }
    }
}
