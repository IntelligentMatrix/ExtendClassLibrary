using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonLibrary.Define
{
    /// <summary>
    /// PlcComponent
    /// </summary>
    public static class PlcComponentDefine
    {
        static string path = Application.StartupPath + @"\EmguCVLibrary.dll";//引用地址
        static Assembly asm = Assembly.LoadFile(path);//加载DLL库
        private static Dictionary<string, ComponentParam> componmentParamDictionary;
        public static Dictionary<string, ComponentParam> ComponmentParamDictionary
        {
            get { return componmentParamDictionary; }
        }
        /// <summary>
        /// 构造函数，添加字典对
        /// </summary>
        static PlcComponentDefine()
        {
            componmentParamDictionary = new Dictionary<string, ComponentParam>();//初始化
            //
            /**
             * 
             * 
             * **/
        }
        /// <summary>
        /// 创建实例
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static object CreatInstance(Type type)
        {
            //return System.Activator.CreateInstance(type);
            return asm.CreateInstance(type.FullName);
        }
    }
}
