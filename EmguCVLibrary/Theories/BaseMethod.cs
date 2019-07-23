using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.Util;
using System.Drawing;
using Emgu.CV.Util;
using System.IO;
using CommonLibrary;

namespace EmguCVLibrary.Theories
{
    public partial class BaseMethod : Component
    {
        #region
        public BaseMethod()
        {
            InitializeComponent();
        }

        public BaseMethod(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #endregion

        #region 公有字段
        protected string ComponentName;//组件名
        public string Params;//参数字符串   
        #endregion


        #region Virtual接口函数
        /// <summary>
        /// 初始化参数变量
        /// </summary>
        public virtual void InitialParameter() { } 

        /// <summary>
        /// 处理图像
        /// </summary>
        public virtual void ProcessImge(ref ImgDataStruct ImgData) { }
        #endregion

        #region 私有函数
        
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

