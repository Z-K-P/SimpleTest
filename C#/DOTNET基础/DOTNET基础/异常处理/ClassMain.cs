using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET基础.异常处理
{
    /*
     异常处理规范
        只捕捉能处理的异常
            例如，视图打开使用中的文件进行独占式读/写访问会抛出一个System.Io.IOException。

        不要隐藏不能完全处理的异常
            除非代码执行显示的操作处理异常，或显示确定异常无害，否则catch块应重新抛出异常。

        尽量少用System.Exception和常规catch块
            在CLR 4和更高版本中，会强制采取关闭应用程序操作，可以考虑重新抛出。

        避免在调用栈较低的位置报告或记录异常
            例如，在无人值守的命令行进程中显示对话框。
            日志记录和与异常相关的用户界面应保留到调用栈中较高的位置。

        在catch块中使用trow;而不是throw <异常对象>语句
            重新抛出会将栈追踪重置为重新抛出的位置。
            只要不是重新抛出不同的异常类型，或故意隐藏原始调用栈，应使用throw;语句，允许相同的异常在调用栈中先上传播。
        
        想好异常条件来避免在catch块中重新抛出异常
            优化异常条件，从一开始就避免捕捉。
        
        避免在异常条件表达式中抛出异常
            考虑在一个单独的方法中执行复杂的条件判断，用try/catch块包装该方法调用，来显示处理异常。

        避免以后可能变化的异常条件表达式

        重新抛出不同异常时要小心
            根据以下情况重新抛出不同的异常
                更改异常类型可更好地澄清问题
                私有数据是原始异常的一部分
                异常类型过于具体，以至于调用者不能恰当地处理
                    例如，不要抛出数据库系统的专有异常
         */
    class ClassMain
    {
        public void Case()
        {
            try
            {
                //...

            }
            catch (Win32Exception exception)
                when (exception.NativeErrorCode == 42) //C#6.0后只有when条件为true catch块才会处理异常 
            {
                //Handle Win32Exception where ErrorCode is 42
            }
            catch (NullReferenceException exception)
            {
                //Handle NullReferenceException
            }
            catch (ArgumentException exception)
            {
                //Handle ArgumentException
            }
            catch (InvalidOperationException exception)
            {
                bool excetpionHanled = false;
                //Handle InvalidOperationException
                /*
                  这样会造成catch块先成为异常的"处理程序",条件不满足时难以改为使用一个不同的catch块
                  如果条件表达式本身抛出异常，新异常会被忽略，且条件视为false
                */
                if (!excetpionHanled)
                {
                    /*
                     虽然当前catch块的范围内有一个exception可供重新抛出，但还是使用一个独立的throw语句
                     如果抛出具体异常，会更新所有栈信息来匹配新的抛出位置，导致指示异常最初发生位置的所有栈信息丢失
                     只能在catch块中使用 throw;

                     */
                    throw;
                }
            }
            catch (Exception exception)
            {
                //Handle Exception
            }
            /*
             C#团队称其为常规catch块,捕捉前面catch块没有捕捉到的所有异常，不管是否从System.Exception派生
             缺点在于没有一个可供访问的异常实例，常规catch块应保存任何易失的数据

            常规catch块对应的CIL代码是一个catch(object)块。不管抛出什么类型，空catch块都能捕捉到它
             */
            catch
            {
                //Handle
            }
            finally
            {
                //...
            }

        }

        /// <summary>
        /// 在不重置栈跟踪信息或使用空 throw 语句的前提下重新抛出异常
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public object Case(object obj)
        {
            try
            {
                if ((int)obj > 0)
                {
                    //...
                }
            }
            catch (AggregateException exception)
            {
                exception = exception.Flatten();
                ExceptionDispatchInfo.Capture(
                    exception.InnerException).Throw();
                //不得不跟随一个return语句，即使该语句在运行时永远不会执行（相反是抛出异常）
                return null;
            }
            finally
            {

            }
            return obj;
        }

        #region checked/unchecked
        /// <summary>
        /// 溢出报告异常
        /// 计算只涉及常量，默认就是checked
        /// </summary>
        public void Checked()
        {
            checked
            {
                int n = int.MaxValue;
                n = n + 1;
            }
        }
        /// <summary>
        /// 它会将数据截短，不会报告溢出错误
        /// </summary>
        public void UnChecked()
        {
            unchecked
            {
                int n = int.MaxValue;
                n = n + 1;
            }
        }
        #endregion
    }
}
