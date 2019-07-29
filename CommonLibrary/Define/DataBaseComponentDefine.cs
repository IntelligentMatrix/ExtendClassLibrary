using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Define
{
    /// <summary>
    /// DataBaseComponent
    /// </summary>
    public static class DataBaseComponentDefine
    {

        private static Dictionary<string, ComponentParam> componmentParamDictionary;
        public static Dictionary<string, ComponentParam> ComponmentParamDictionary
        {
            get { return componmentParamDictionary; }
        }
        /// <summary>
        /// 构造函数，添加字典对
        /// </summary>
        static DataBaseComponentDefine()
        {
            componmentParamDictionary = new Dictionary<string, ComponentParam>();//初始化
            //
            /**
             * 
             * 
             * **/
            
        }
    }
}
