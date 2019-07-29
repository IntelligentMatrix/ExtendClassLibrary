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
    /// ProjectComponent
    /// </summary>
    public static class ProjectComponentDefine
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
        static ProjectComponentDefine()
        {
            
            componmentParamDictionary = new Dictionary<string, ComponentParam>();//初始化
            //
            /**
             * 图像处理通用组件
             * 二值化处理
             * **/
            componmentParamDictionary.Add("Emgucv_ComonMethod", new ComponentParam
            {
                ComponentType = asm.GetType("EmguCVLibrary.Theories.CommonMethod"),
                ParamType = asm.GetType("EmguCVLibrary.Theories.CommonMethod_Para")
            });
            /**
             * 光学字符识别组件
             * 
             * **/
            componmentParamDictionary.Add("Emgucv_OCR_Recognition", new ComponentParam
            {
                ComponentType = asm.GetType("EmguCVLibrary.Theories.OCR_Recognition"),
                ParamType = asm.GetType("EmguCVLibrary.Theories.OCR_Recognition_Para")
            });
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
