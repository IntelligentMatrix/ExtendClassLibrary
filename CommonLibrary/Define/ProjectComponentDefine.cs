using System;
using System.Collections.Generic;
using System.Reflection;
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
            componmentParamDictionary.Add("Initialization", new ComponentParam
            {
                ComponentType = asm.GetType("EmguCVLibrary.Theories.Initialization"),
                ParamType = asm.GetType("EmguCVLibrary.Theories.Initialization_Para")
            });
            /**
             * 光学字符识别组件
             * 
             * **/
            componmentParamDictionary.Add("Ocr", new ComponentParam
            {
                ComponentType = asm.GetType("EmguCVLibrary.Theories.Ocr"),
                ParamType = asm.GetType("EmguCVLibrary.Theories.Ocr_Para")
            });
            /**
             * 膨胀
             * 
             * **/
            componmentParamDictionary.Add("Dilate", new ComponentParam
            {
                ComponentType = asm.GetType("EmguCVLibrary.Theories.Dilate"),
                ParamType = asm.GetType("EmguCVLibrary.Theories.Dilate_Para")
            });
            /**
             * 腐蚀
             * 
             * **/
            componmentParamDictionary.Add("Erode", new ComponentParam
            {
                ComponentType = asm.GetType("EmguCVLibrary.Theories.Erode"),
                ParamType = asm.GetType("EmguCVLibrary.Theories.Erode_Para")
            });
            /**
             * 形态学
             * 
             * **/
            componmentParamDictionary.Add("Morphology", new ComponentParam
            {
                ComponentType = asm.GetType("EmguCVLibrary.Theories.Morphology"),
                ParamType = asm.GetType("EmguCVLibrary.Theories.Morphology_Para")
            });
            /**
             * 自定义查找字符
             * 
             * **/
            componmentParamDictionary.Add("MyCharRec", new ComponentParam
            {
                ComponentType = asm.GetType("EmguCVLibrary.Theories.MyCharRec"),
                ParamType = asm.GetType("EmguCVLibrary.Theories.MyCharRec_Para")
            });
        }
        /// <summary>
        /// 创建实例
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static object CreatInstance(Type type)
        {
            return asm.CreateInstance(type.FullName);
        }
    }
}
