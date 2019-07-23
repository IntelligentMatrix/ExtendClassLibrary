using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmguCVLibrary
{
    //1、声明可序列化（用于进行系列化，当然如果你不需要序列化。那么可以不声明为可序列化的）
    //2、如果你的异常是需要写入文件的，如日志等，则需要将异常类声明为可序列化的[Serializable]
    //3、添加一个默认的构造函数，实现一个无参数的构造函数，因为可能会抛出无参异常
    //4、添加包含message的构造函数
    //5、添加一个包含message,及内部异常类型参数的构造函数
    //6、添加一个序列化信息相关参数的构造函数.
    //7、添加自己的错误识别数据成员和处理函数
    [Serializable]
    class MyException:ApplicationException
    {
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public MyException() { }
        public MyException(string message)
            : base(message) { }
        public MyException(string message, Exception inner)
            : base(message, inner) { }
        public MyException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
