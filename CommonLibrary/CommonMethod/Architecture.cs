using EmguCVLibrary;
using EmguCVLibrary.Theories;
using System.Collections.Generic;
using System.Threading;

namespace CommonLibrary.CommonMethod
{
    public delegate void ExitEvent();
    /// <summary>
    /// Project 层级Architecture
    /// </summary>
    public class ProjectArch : IModeBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ProjectArch()
        {
            _name = "";
            _ma = new ManualResetEvent(false);
            _runPause = false;
            _running = false;
            _exit = false;
            ProjectList = new List<ProjectBaseMethod>();
        }

        //内部变量
        string _name { get; set; }
        ManualResetEvent _ma { get; set; }
        bool _runPause { get; set; }
        bool _running { get; set; }
        bool _exit { get; set; }
        //接口属性实现
        public bool _Running { get => _running; set => _running = value; }
        public bool _RunPause { get => _runPause; set => _runPause = value; }
        public bool _Exit { get => _exit; set => _exit = value; }
        public ManualResetEvent _Ma { get => _ma; set => _ma = value; }
        public string Name { get => _name; set => _name = value; }
        //本分支内部函数
        public List<ProjectBaseMethod> ProjectList { get; set; } = new List<ProjectBaseMethod>(); //该分支list

        /// <summary>
        /// 退出
        /// </summary>
        public virtual void Exit()
        {
            if (!_Running || _Exit) return;//非运行中/已触发停止，返回
            _Exit = true;
        }
        /// <summary>
        /// 暂停运行
        /// </summary>
        public virtual void Pause()
        {
            if (!_Running) return;//非运行中，返回
            _RunPause = true;//切换至暂停模式
        }
        /// <summary>
        /// 恢复运行
        /// </summary>
        public virtual void Resume()
        {
            if (!_Running) return;//非运行中，返回
            _RunPause = false;//退出暂停模式 
            _Ma.Set();
        }
        /// <summary>
        /// 运行
        /// </summary>
        /// <param name="imgData"></param>
        public virtual void Run(ref ImgDataStruct imgData)
        {
            _Running = true; //置位运行标志
            foreach (var o in ProjectList)
            {
                //启动暂停
                if (_RunPause)
                {
                    _Ma = new ManualResetEvent(false);
                    _Ma.WaitOne();
                }
                //Exit
                if (_Exit)
                {
                    //强制退出流程
                    Reset();
                    return;
                }
                //执行功能
                o.ProcessImge(ref imgData);
            }
            //正常结束流程
            Reset();
        }
        /// <summary>
        /// 重置
        /// </summary>
        public virtual void Reset()
        {
            _ma.Reset();
            _runPause = false;
            _running = false;
            _exit = false;
        }
    }
    /// <summary>
    /// Plc 层级Architecture
    /// </summary>
    public class PlcArch
    {
        string Name { get; set; }//该分支名称
        List<ProjectBaseMethod> ProjectList { get; set; } = new List<ProjectBaseMethod>(); //该分支list
    }
    /// <summary>
    /// Database 层级Architecture
    /// </summary>
    public class DatabaseArch
    {
        string Name { get; set; }//该分支名称
        List<ProjectBaseMethod> ProjectList { get; set; } = new List<ProjectBaseMethod>(); //该分支list
    }
    /// <summary>
    /// 基础运行接口
    /// </summary>
    public interface IModeBase
    {
        ManualResetEvent _Ma { get; set; }//手动置位
        bool _Running { get; set; }//运行中标志
        bool _RunPause { get; set; }//运行/暂停中标志 
        bool _Exit { get; set; }//退出标志 
        /// <summary> 
        /// 该分支名称
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 运行
        /// </summary>
        void Run(ref ImgDataStruct imgData);
        /// <summary>
        /// 暂停
        /// </summary>
        void Pause();
        /// <summary>
        /// 恢复运行
        /// </summary>
        void Resume();
        /// <summary>
        /// 退出
        /// </summary>
        void Exit();
        /// <summary>
        /// 重置
        /// </summary>
        void Reset();
    }
    /// <summary>
    /// 选项分类
    /// </summary>
    public enum OptionType
    {
        Plc = 0,
        Project = 2,
        DataBase = 4
    }
}
