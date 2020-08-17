using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET基础.委托
{
    /*
     
         设计规范

            要在调用委托前检查它的值是不是空值
            要从C#6.0起在调用Invoke()前使用空条件操作符(.?)。

         */
    class ClassMain
    {
        /*
         
            委托是引用类型，但不想要new实例化，
                C#2.0开始，从方法组（为方法命名的表达式）向委托类型的转换，会自动创建新的委托对象
         
            许多时候无需自定义委托类型，但若能显著提高代码可读性，还是应该考虑声明自定义的委托类型
            Func 
                Func系列委托代表有返回值的方法
            Action
                Action系列委托代表返回void的方法
             */
        #region 常规类型的委托类型
        public void Play(Action<string> Event)
        {
            Event("玩锤子");
        }

        public void Learn(Func<DateTime,string,string> Event)
        {
            string strResult = Event(DateTime.Now,"学毛线");
        }
        #endregion

        /// <summary>
        /// 自定义委托类型
        /// </summary>
        /// <param name="first">参数1</param>
        /// <param name="second">参数2</param>
        /// <returns></returns>
        delegate object Comparer(int first,int second);


        #region .Net委托类型不具备结构相等性
        /*
         
             不能将一个委托类型的对象引用转换成一个不相关的委托类型，即使两者的形参和返回值类型一致
             唯一的方式就是创建新委托，并让它引用旧的委托的Invoke方法。
             */
        public void Test1(Func<int,int,object> func)
        {
            Comparer comparer = new Comparer(Add);
            func = comparer.Invoke;

        }
        /*
         
            C#4.0 添加的对可变性的支持

             委托的协变和逆变
                适合任何对象的行动必定适合任何字符串。
                反之则不然，只适合字符串的行动不适合每个对象。
            
             */
        public void Test2()
        {
            Action<object> objAction = (object data) =>
            {
                //...
            };
            Action<string> strAction = objAction;



            Func<string> strFunc = () =>
            {
                return "string";
            };
            Func<object> objFunc = strFunc;



            //string不是基本数据类型，是引用类型
            Func<object,string> Func1 = (object obj) =>
            {
                return "";
            };
            Func<string,object> Func2 = Func1;

        }

        private object Add(int number1,int number2)
        {
            return number1 + number2;
        }
        #endregion

        #region 捕捉循环变量
        /*
         
             结果在C#5.0的输出
                one
                two
                three
            结果在C#4.0的输出
                three
                three
                three
            Lambda表达式捕捉变量并总是使用其最新的值，而不是捕捉并保留变量在委托创建时的值。

            GetItem3()的输出
                three
                three
           
            GetItem2更改不适用与for循环，for语句中声明的任何循环变量在被捕捉时，都被看成是同一个外部变量。
             */
        public void GetItem1()
        {
            string[] items = new string[] { "one","two","three"};
            List<Action> actions = new List<Action>();
            foreach (string item in items)
            {
                actions.Add(() => { Console.WriteLine(item); });
            }
            foreach (Action action in actions)
            {
                action();
            }
        }
        public void GetItem2()
        {
            string[] items = new string[] { "one", "two", "three" };
            List<Action> actions = new List<Action>();
            foreach (string item in items)
            {
                //区别之处
                string strItem = item;
                actions.Add(() => { Console.WriteLine(strItem); });
            }
            foreach (Action action in actions)
            {
                action();
            }
        }
        public void GetItem3()
        {
            string[] items = new string[] { "one", "two", "three" };
            List<Action> actions = new List<Action>();
            for(int i = 0 ; i<items.Length-1; i++)
            {
                actions.Add(() => { Console.WriteLine(items[i]); });
            }
            foreach (Action action in actions)
            {
                action();
            }
        }

        #endregion

        public void Run()
        {
            Test2();
            GetItem1();
            GetItem2();
            GetItem3();

        }


    }
}
