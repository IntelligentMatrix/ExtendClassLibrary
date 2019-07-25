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
        public List<PlcData> Plc { get; set; }
        public List<ProjectData> Project { get; set; }
        public List<DataBaseData> DataBase { get; set; } 

        /// <summary>
        /// 构造函数
        /// </summary>
        public SolutionData()
        {
            Name = "";
            Plc = new List<PlcData>();
            Project = new List<ProjectData>();
            DataBase = new List<DataBaseData>();
        }

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
    public class PlcData : ICloneable 
    {

        public string Name { get; set; }
        public List<PlcListData> PlcList { get; set; } 

        /// <summary>
        /// 构造函数
        /// </summary>
        public PlcData()
        {
            Name = "";
            PlcList = new List<PlcListData>();
        }
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
    public class PlcListData : ICloneable
    {
        public string Name { get; set; }
        public string Paras { get; set; }
        public string Component { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public PlcListData()
        {
            Name = "";
            Paras = "";
            Component = "";
        }
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
    public class ProjectData : ICloneable
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public List<ProjectListData> ProjectList { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public ProjectData()
        {
            Type = "";
            Name = "";
            ProjectList = new List<ProjectListData>();
        }
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
    public class ProjectListData : ICloneable
    {
        public string Name { get; set; }
        public string Paras { get; set; }
        public string Component { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public ProjectListData()
        {
            Name = "";
            Paras = "";
            Component = "";
        }
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
    public class DataBaseData : ICloneable
    {

        public string Name { get; set; }
        public List<DataBaseListData> DataBaseList { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public DataBaseData()
        {
            Name = "";
            DataBaseList = new List<DataBaseListData>();
        }
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
    public class DataBaseListData : ICloneable
    {
        public string Name { get; set; }
        public string Paras { get; set; }
        public string Component { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public DataBaseListData()
        {
            Name = "";
            Paras = "";
            Component = "";
        }

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
