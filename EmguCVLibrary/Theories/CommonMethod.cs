using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing;
using Emgu.CV.Util;
using Newtonsoft.Json;
using CommonLibrary;
using MyLibrary;

namespace EmguCVLibrary.Theories
{
    public partial class CommonMethod : BaseMethod
    {
        #region 构造函数
        public CommonMethod()
        {
            InitializeComponent();
        }

        public CommonMethod(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #endregion

        #region 定义变量
        ColorConversion ColorConversion;//图像转换类型
        double Threshold;//阈值化值
        double ThresholdMaxValue;//阈值化最大值
        ThresholdType ThresholdType;//阈值化类型
        OutPutType DstImageType;//输出图像类型
        #endregion

        #region 重构基类函数
        /// <summary>
        /// 初始化参数
        /// </summary>
        public override void InitialParameter()
        { 
            CommonMethod_Para Para = new CommonMethod_Para();
            Para = JsonConvert.DeserializeObject<CommonMethod_Para>(Params);//将字符串转换为参数变量
            //变量赋值
            ColorConversion = Para.ColorConversion;
            Threshold = Para.Threshold;
            ThresholdMaxValue = Para.ThresholdMaxValue;
            ThresholdType = Para.ThresholdType;
            DstImageType = Para.DstImageType;
        }
        #endregion

        #region 处理函数
        /// <summary>
        /// 处理图像
        /// </summary>
        public override void ProcessImge<ImgDataStruct>(ref ImgDataStruct ImgData)
        { 
            ImgData = new T();
            ImgData.DstImage = new Mat();//初始化DstImage
            Mat TmpImage = new Mat();//初始化TmpImage
            Mat[] channels = ImgData.SrcImage.Split();
            VectorOfMat vChannels = new VectorOfMat();
            switch (DstImageType)
            {
                case OutPutType.R:
                    TmpImage = channels[2];
                    break;
                case OutPutType.G:
                    TmpImage = channels[1];
                    break;
                case OutPutType.B:
                    TmpImage = channels[0];
                    break;
                case OutPutType.RG:
                    channels[0].SetTo(new MCvScalar(0));
                    vChannels.Push(channels[0]);                    
                    vChannels.Push(channels[1]);
                    vChannels.Push(channels[2]);
                    CvInvoke.Merge(vChannels, TmpImage);
                    CvInvoke.CvtColor(TmpImage, TmpImage, ColorConversion);//转化图像
                    break;
                case OutPutType.RB:
                    channels[1].SetTo(new MCvScalar(0));
                    vChannels.Push(channels[0]);
                    vChannels.Push(channels[1]);
                    vChannels.Push(channels[2]);
                    CvInvoke.Merge(vChannels, TmpImage);
                    CvInvoke.CvtColor(TmpImage, TmpImage, ColorConversion);//转化图像
                    break;
                case OutPutType.GB:
                    channels[2].SetTo(new MCvScalar(0));
                    vChannels.Push(channels[0]);
                    vChannels.Push(channels[1]);
                    vChannels.Push(channels[2]);
                    CvInvoke.Merge(vChannels, TmpImage);
                    CvInvoke.CvtColor(TmpImage, TmpImage, ColorConversion);//转化图像
                    break;
                default:
                    TmpImage = ImgData.SrcImage.Clone();
                    break;
            }

            //图像处理
            if (DstImageType == OutPutType.All)
            {
                CvInvoke.CvtColor(TmpImage, ImgData.DstImage, ColorConversion);//转化图像
                CvInvoke.Threshold(ImgData.DstImage, ImgData.DstImage, Threshold, ThresholdMaxValue, ThresholdType);//阈值化图像
            }
            else
            {
                CvInvoke.Threshold(TmpImage, ImgData.DstImage, Threshold, ThresholdMaxValue, ThresholdType);//阈值化图像
            }

            //释放TmpImage
            if (TmpImage != null) TmpImage.Dispose();

            //Gc回收
            GC.Collect();
        }
        #endregion
    }
    /// <summary>
    /// 本组件的参数变量
    /// </summary>
    public class CommonMethod_Para
    {
        [DescriptionAttribute("结果图像类型"),
         CategoryAttribute("Setting"),
         DisplayName("ColorConversion")]
        public OutPutType DstImageType { get; set; } 

        [DescriptionAttribute("图像转换类型"),
        CategoryAttribute("Setting"),
        DisplayName("ColorConversion")]
        public ColorConversion ColorConversion { get; set; }

        [DescriptionAttribute("阈值化值"),
        CategoryAttribute("Setting"),
        DisplayName("Threshold")]
        public double Threshold { get; set; }

        [DescriptionAttribute("阈值化最大值"),
        CategoryAttribute("Setting"),
        DisplayName("ThresholdMaxValue")]
        public double ThresholdMaxValue { get; set; }

        [DescriptionAttribute("阈值化类型 "),
        CategoryAttribute("Setting"),
        DisplayName("ThresholdType")]
        public ThresholdType ThresholdType { get; set; }

        [DescriptionAttribute("阈值化类型 "),
        CategoryAttribute("Setting"),
        DisplayName("ThresholdType"),
        TypeConverterAttribute(typeof(PointFConverter))]
        public PointF Pos { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public CommonMethod_Para()
        {
            DstImageType = OutPutType.All;
            ColorConversion = ColorConversion.Bgra2Gray;
            Threshold = 100;
            ThresholdMaxValue = 255;
            ThresholdType = ThresholdType.BinaryInv;
        }

    }
    /// <summary>
    /// 结果图像
    /// All - 全
    /// R - 红色通道
    /// G - 绿色通道
    /// B - 蓝色通道
    /// </summary>
    public enum OutPutType
    {
        All = 0,
        R = 2,
        G = 4,
        B = 8,
        RG = 16,
        RB = 32,
        GB = 64
    }
   
}
