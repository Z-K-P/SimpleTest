using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET基础.异常处理
{
    class ClassDBException : System.Exception
    {
        public ClassDBException()
        {

        }
        public ClassDBException(string strMessage,System.Data.SqlClient.SqlException exception):base(strMessage,exception)
        {
         //...
        }
        public ClassDBException(string strMessage):base(strMessage)
        {
            //...
        }
        /// <summary>
        /// 可序列化异常
        /// </summary>
        /// <param name="serializationInfo"></param>
        /// <param name="streamingContext"></param>
        public ClassDBException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
        {

        }

    }
}
