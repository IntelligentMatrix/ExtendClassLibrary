using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    /// <summary>
    /// 整体数据
    /// </summary>
    [Serializable]
    public class SolutionData:ICloneable
    {
        
        public string Name { get; set; }

        public List<Plc> Plc { get; set; }
        public List<Project> Project { get; set; }
        public List<DataBase> DataBase { get; set; } 

        /// <summary>
        /// 克隆方法
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, this);
            ms.Seek(0, 0);
            object value = bf.Deserialize(ms);
            ms.Close();
            return value;
        }
    }

    /// <summary>
    /// PLC数据
    /// </summary>
    [Serializable]
    public class Plc : ICloneable 
    {

        public string Name { get; set; }
        public List<PlcList> PlcList { get; set; } 
        /// <summary>
        /// 克隆方法
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, this);
            ms.Seek(0, 0);
            object value = bf.Deserialize(ms);
            ms.Close();
            return value;
        }
    }

    /// <summary>
    /// PlcList数据
    /// </summary>
    [Serializable]
    public class PlcList : ICloneable
    {
        public string Name { get; set; }
        public string Paras { get; set; }
        public string Component { get; set; }
        /// <summary> 
        /// 克隆方法
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, this);
            ms.Seek(0, 0);
            object value = bf.Deserialize(ms);
            ms.Close();
            return value;
        }
    }

    /// <summary>
    /// Project数据
    /// </summary>
    [Serializable]
    public class Project : ICloneable
    {

        public string Name { get; set; }
        public List<ProjectList> ProjectList { get; set; }
        /// <summary>
        /// 克隆方法
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, this);
            ms.Seek(0, 0);
            object value = bf.Deserialize(ms);
            ms.Close();
            return value;
        }
    }
    /// <summary>
    /// ProjectList数据
    /// </summary>
    [Serializable]
    public class ProjectList : ICloneable
    {
        public string Name { get; set; }
        public string Paras { get; set; }
        public string Component { get; set; }
        /// <summary> 
        /// 克隆方法
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, this);
            ms.Seek(0, 0);
            object value = bf.Deserialize(ms);
            ms.Close();
            return value;
        }
    }
    /// <summary>
    /// DataBase数据
    /// </summary>
    [Serializable]
    public class DataBase : ICloneable
    {

        public string Name { get; set; }
        public List<DataBaseList> DataBaseList { get; set; }
        /// <summary>
        /// 克隆方法
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, this);
            ms.Seek(0, 0);
            object value = bf.Deserialize(ms);
            ms.Close();
            return value;
        }
    }
    /// <summary>
    /// DataBaseList数据
    /// </summary>
    [Serializable]
    public class DataBaseList : ICloneable
    {
        public string Name { get; set; }
        public string Paras { get; set; }
        public string Component { get; set; }
        /// <summary> 
        /// 克隆方法
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, this);
            ms.Seek(0, 0);
            object value = bf.Deserialize(ms);
            ms.Close();
            return value;
        }
    }
}
