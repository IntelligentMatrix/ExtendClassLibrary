using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using MyLibrary;

namespace EmguCVLibrary.Theories
{
    public partial class ProjectBaseMethod : Component
    {
        #region
        public ProjectBaseMethod()
        {
            InitializeComponent();
        }

        public ProjectBaseMethod(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        #endregion

        #region 公有字段
        public string ComponentName;//组件名
        public string Params;//参数字符串   
        #endregion


        #region Virtual函数
        /// <summary>
        /// 初始化参数变量
        /// </summary>
        public virtual void InitialParameter() { } 

        /// <summary>
        /// 处理图像
        /// </summary>
        public virtual void ProcessImge(ref ImgDataStruct ImgData){ } 

        #endregion

        #region 私有函数
        /// <summary>
        /// 组件初始化
        /// </summary>
        /// <param name="componentName"></param>
        /// <param name="paras"></param>
        public void IniComponent(string componentName,string paras)
        {
            this.ComponentName = componentName;
            this.Params = paras;
            try
            {
                InitialParameter();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        #endregion
    }

    /// <summary>
    /// 基础参数
    /// </summary>
    public class BasePara
    {
        [DescriptionAttribute("组件名"),
        CategoryAttribute("Setting"),
        DisplayName("ComponentName")]
        public string ComponentName { get; set; }//组件名

        [DescriptionAttribute("Src初始放大倍率"),
        CategoryAttribute("Setting"),
        DisplayName("SrcIniScale")]
        public float SrcIniScale { get; set; } = 1.0f;
         
        [DescriptionAttribute("Src初始对焦位置 "),
        CategoryAttribute("Setting"),
        DisplayName("SrcIniPos"),
        TypeConverterAttribute(typeof(PointFConverter))]
        public PointF SrcIniPos { get; set; }

        [DescriptionAttribute("Dst初始放大倍率"),
        CategoryAttribute("Setting"),
        DisplayName("DstIniScale")]
        public float DstIniScale { get; set; } = 1.0f;

        [DescriptionAttribute("Dst初始对焦位置 "),
        CategoryAttribute("Setting"),
        DisplayName("DstIniPos"),
        TypeConverterAttribute(typeof(PointFConverter))]
        public PointF DstIniPos { get; set; }
    }
}

