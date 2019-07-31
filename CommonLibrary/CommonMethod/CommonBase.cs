using EmguCVLibrary.Theories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommonLibrary.CommonMethod
{
    /// <summary>
    /// 基类
    /// </summary>
    class CommonBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public CommonBase()
        {

        }
        #region
        //Project
        protected List<ProjectArch> projectList =new List<ProjectArch>();
        public List<ProjectArch> ProjectList { get { return projectList; } }
        //解决方案名
        public string SolutionName { get { return Environment.MachineName; } }
        //请求标志
        protected bool isRequesting = false;
        public bool IsRequesting
        {
            get
            {
                return isRequesting;
            }
        }

        #endregion

        #region 虚函数
        public virtual void Start() { }
        public virtual void Stop() { }
        #endregion

        #region 初始化采集主机、采集的各站
        /// <summary>
        /// 终止指定类型，指定名称的Option运行
        /// </summary>
        /// <param name="type"></param>
        /// <param name="sitecode"></param>
        public void StopSingleOption(OptionType type, string sitecode)
        {
            //DCSBaseComponent station = stationList.Find(x => x.SiteCode == sitecode);
            //if (station != null)
            //{
            //    station.StopStation();
            //}
        }
        //public void StartSingleStation(string sitecode)
        //{
        //    DCSBaseComponent station = stationList.Find(x => x.SiteCode == sitecode);
        //    if (station != null)
        //    {
        //        station.InitParams();
        //        station.InitDataParams();
        //        station.StartStation();
        //    }
        //}
        ///// <summary>
        ///// 配置采集主机信息
        ///// </summary>
        //public virtual void InitCollectionHost()
        //{
        //    dcsDBEntities dcs = new dcsDBEntities();
        //    List<CentralizedCollectionConfig> stations = dcs.GetCollectionConfigByHostIP(this.HostName);//获取该站点列表
        //    if (stations.Count == 0)
        //        throw new DcsException("Configurations of the station is null,please configure it firstly.");//此站的没有配置采集的站点信息，请先配置需要采集的站信息！

        //    //重新初始化站点信息
        //    stationList.Clear();//清除原来的站点，重新加载
        //    for (int i = 0; i < stations.Count; i++)
        //    {
        //        CentralizedCollectionConfig station = stations[i];
        //        string tmpS = station.Component;//组件名
        //        if (GlobalDefine.ComponmentParamDictionary.ContainsKey(tmpS))//校验是否包含该组件
        //        {
        //            Type type = GlobalDefine.ComponmentParamDictionary[tmpS].ComponentType;//获取组件类型
        //            DCSBaseComponent dcsCom = (DCSBaseComponent)System.Activator.CreateInstance(type);//创建该组件                    
        //            dcsCom.InitCollectComonent(station.SiteCode, station.Component, station.Params);//从服务器初始化数据参数
        //            dcsCom.DataReceived += collectionStation_StationDataChanged;
        //            stationList.Add(dcsCom);
        //        }
        //        else
        //        {
        //            throw new Exception(string.Format("the component doesn't exist：{0}.", station.Component));
        //        }
        //    }
        //}
        #endregion
    }

    public enum OperateType
    {
        Start = 2,
        Stop = 4
    }
}
