using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmguCVLibrary.Theories
{
    /// <summary>
    /// Dilate 膨胀
    /// </summary>
    public partial class Dilate : ProjectBaseMethod
    {
        #region 构造函数
        public Dilate()
        {
            InitializeComponent();
        }

        public Dilate(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #endregion

        #region 定义变量
        private Mat Element = new Mat();//基准数据
        public ElementShape EShape { get; set; } = ElementShape.Rectangle;//卷积核形状
        public Size Esize { get; set; } = new Size(3,3);//卷积核尺寸
        public Point Eanchor { get; set; } = new Point(3, 3);//卷积核锚的位置
        public Point Anchor { get; set; } = new Point(-1, -1);//锚的位置
        public int Iterations { get; set; } = 1;//迭代次数
        public BorderType BType { get; set; } = BorderType.Default;//边界类型
        public MCvScalar BValue { get; set; } =new MCvScalar() ;//边界值

        #endregion

        #region 重构基类函数
        /// <summary>
        /// 初始化参数
        /// </summary>
        public override void InitialParameter()
        {
            Dilate_Para Para = new Dilate_Para();
            Para = JsonConvert.DeserializeObject<Dilate_Para>(Params);//将字符串转换为参数变量
            //变量赋值
            EShape = Para.EShape;
            Esize = Para.Esize;
            Eanchor = Para.Eanchor;
            Anchor = Para.Anchor;
            Iterations = Para.Iterations;
            BType = Para.BType;
            BValue = Para.BValue;
        }
        #endregion

        #region 处理函数
        /// <summary>
        /// 处理图像
        /// </summary>
        public override void ProcessImge(ref ImgDataStruct ImgData)
        {
            //初始胡Element
            Element = CvInvoke.GetStructuringElement(EShape, Esize, Eanchor);
            //初始化BValue
            BValue = new MCvScalar();
            //Dilate
            CvInvoke.Dilate(ImgData.DstImage, ImgData.DstImage, Element,Anchor, Iterations, BType, BValue);
            
            //释放卷积核
            Element.Dispose();

            //Gc回收
            GC.Collect();
        }
        #endregion
    }
    /// <summary>
    /// 膨胀参数
    /// </summary>
    public class Dilate_Para
    {
        [DescriptionAttribute("卷积核形状"),
         CategoryAttribute("Setting"),
         DisplayName("EShape")]
        public ElementShape EShape { get; set; }

        [DescriptionAttribute("卷积核尺寸"),
        CategoryAttribute("Setting"),
        DisplayName("Esize")]
        public Size Esize { get; set; }

        [DescriptionAttribute("卷积核锚点位置"),
        CategoryAttribute("Setting"),
        DisplayName("Eanchor")]
        public Point Eanchor { get; set; }

        [DescriptionAttribute("锚点位置"),
        CategoryAttribute("Setting"),
        DisplayName("Anchor")]
        public Point Anchor { get; set; }

        [DescriptionAttribute("迭代次数"),
        CategoryAttribute("Setting"),
        DisplayName("Iterations")]
        public int Iterations { get; set; }

        [DescriptionAttribute("边界类型 "),
        CategoryAttribute("Setting"),
        DisplayName("BorderType")]
        public BorderType BType { get; set; }

        [DescriptionAttribute("边界值 "),
        CategoryAttribute("Setting"),
        DisplayName("BorderValue")]
        public MCvScalar BValue { get; set; } 

        /// <summary>
        /// 构造函数
        /// </summary>
        public Dilate_Para()
        {
            EShape = ElementShape.Rectangle;//卷积核形状
            Esize = new Size(3, 3);//卷积核尺寸
            Eanchor = new Point(-1, -1);//卷积核锚的位置
            Anchor = new Point(-1, -1);//锚的位置
            Iterations = 1;//迭代次数
            BType = BorderType.Default;//边界类型
            BValue = new MCvScalar();//边界值
        }

    }
}
