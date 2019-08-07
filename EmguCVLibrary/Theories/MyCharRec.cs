using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
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
    public partial class MyCharRec : ProjectBaseMethod
    {
        #region 构造函数
        public MyCharRec()
        {
            InitializeComponent();
        }

        public MyCharRec(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #endregion
        #region 定义变量
        private VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();

        public RetrType R_Type { get; set; } = RetrType.External;//轮廓查找模式        
        public ChainApproxMethod CA_Method { get; set; } = ChainApproxMethod.ChainApproxNone;//轮廓逼近方式
        public Size Rec_Size { get; set; } = new Size(30,30);//明确Rectangle基准大小,单位Piexel
        public int Tolerate { get; set; } = 30;//容许误差，单位pixel
        private Mat Element = new Mat();//基准数据
        public ElementShape EShape { get; set; } = ElementShape.Rectangle;//卷积核形状
        public Size Esize { get; set; } = new Size(3, 3);//卷积核尺寸
        public Point Eanchor { get; set; } = new Point(3, 3);//卷积核锚的位置
        public Point Anchor { get; set; } = new Point(-1, -1);//锚的位置
        public int Iterations { get; set; } = 1;//迭代次数
        public BorderType BType { get; set; } = BorderType.Default;//边界类型
        public MCvScalar BValue { get; set; } = new MCvScalar();//边界值
        public int MSize { get; set; }
        #endregion

        #region 重构基类函数
        /// <summary>
        /// 初始化参数
        /// </summary>
        public override void InitialParameter()
        {
            MyCharRec_Para Para = new MyCharRec_Para();
            Para = JsonConvert.DeserializeObject<MyCharRec_Para>(Params);//将字符串转换为参数变量
            //变量赋值
            R_Type = Para.R_Type;
            CA_Method = Para.CA_Method;
            Rec_Size = Para.Rec_Size;
            Tolerate = Para.Tolerate;
            EShape = Para.EShape;
            Esize = Para.Esize;
            Eanchor = Para.Eanchor;
            Anchor = Para.Anchor;
            Iterations = Para.Iterations;
            BType = Para.BType;
            BValue = Para.BValue;
            MSize = Para.MSize;
        }
        #endregion

        #region 处理函数
        /// <summary>
        /// 处理图像
        /// </summary>
        public override void ProcessImge(ref ImgDataStruct ImgData)
        {
            List<RotatedRect> rotatedRects = new List<RotatedRect>();//统计数量
            //查找轮廓
            CvInvoke.FindContours(ImgData.DstImage, contours, null, R_Type, CA_Method);
            //查找指定大小的最小外接矩形
            for (int i = 0; i < contours.Size; i++)
            {
                RotatedRect rotatedRect = CvInvoke.MinAreaRect(contours[i]);
                //判断
                if (Math.Abs(
                    Math.Sqrt(rotatedRect.Size.Width * rotatedRect.Size.Width + rotatedRect.Size.Height * rotatedRect.Size.Height) 
                    - Math.Sqrt(Rec_Size.Width * Rec_Size.Width + Rec_Size.Height * Rec_Size.Height)) 
                    <= Tolerate)
                {
                    PointF[] pts = rotatedRect.GetVertices(); //返回外接矩形的顶点
                    //绘制矩形区域
                    //for (int j = 0; j < pts.Length; j++)
                    //    CvInvoke.Line(ImgData.TmpImage, new Point((int)pts[j].X, (int)pts[j].Y), new Point((int)pts[(j + 1) % 4].X, (int)pts[(j + 1) % 4].Y),
                    //                                new MCvScalar(255, 255, 255), 2);
                    //追加数据
                    rotatedRects.Add(rotatedRect);
                }
            }
            //创建ROi区域
            if (rotatedRects.Count == 1)
            {
                //处理数据
                ImgData.TplImage = new Mat(ImgData.TmpImage, rotatedRects[0].MinAreaRect()).Clone();
                //Mat rotateM = new Mat();
                //float angle = 0;
                //if (0 < Math.Abs(rotatedRects[0].Angle) && Math.Abs(rotatedRects[0].Angle) <= 45)  //逆时针
                //    angle = rotatedRects[0].Angle;
                //else if (45 < Math.Abs(rotatedRects[0].Angle) && Math.Abs(rotatedRects[0].Angle) < 90) //顺时针
                //    angle = 90 - Math.Abs(rotatedRects[0].Angle);
                //CvInvoke.GetRotationMatrix2D(rotatedRects[0].Center, angle, 1, rotateM);
                //CvInvoke.WarpAffine(ImgData.TplImage, ImgData.TplImage, rotateM, ImgData.TplImage.Size);

                ////初始化Element
                //Element = CvInvoke.GetStructuringElement(EShape, Esize, Eanchor);
                ////初始化BValue
                //BValue = new MCvScalar();
                ////Dilate
                //CvInvoke.Dilate(ImgData.TplImage, ImgData.TplImage, Element, Anchor, Iterations, BType, BValue);
                CvInvoke.MedianBlur(ImgData.TplImage, ImgData.TplImage, MSize);
                //释放卷积核
                Element.Dispose();

            }
            else
            {
                //抛出异常
            }
            //Gc回收
            GC.Collect();
        }
        #endregion
    }
    /// <summary>
    /// 膨胀参数
    /// </summary>
    public class MyCharRec_Para
    {
        [DescriptionAttribute("轮廓查找模式 "),
         CategoryAttribute("Setting"),
         DisplayName("RetrType")]
        public RetrType R_Type { get; set; }

        [DescriptionAttribute("轮廓逼近方式"),
        CategoryAttribute("Setting"),
        DisplayName("ChainApproxMethod")]
        public ChainApproxMethod CA_Method { get; set; }

        [DescriptionAttribute("Rectangle基准大小,单位Piexel"),
        CategoryAttribute("Setting"),
        DisplayName("Rec_Size")]
        public Size Rec_Size { get; set; }

        [DescriptionAttribute("容许误差"),
        CategoryAttribute("Setting"),
        DisplayName("Tolerate")]
        public int Tolerate { get; set; }

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

        [DescriptionAttribute("中值滤波值 "),
        CategoryAttribute("Setting"),
        DisplayName("MSize")]
        public int MSize { get; set; } 

        /// <summary>
        /// 构造函数
        /// </summary>
        public MyCharRec_Para() 
        {
            R_Type = RetrType.External;//轮廓查找模式        
            CA_Method = ChainApproxMethod.ChainApproxNone;//轮廓逼近方式
            Rec_Size = new Size(30, 30);//明确Rectangle基准大小,单位Piexel
            Tolerate = 10;//容许误差，单位pixel
            EShape = ElementShape.Rectangle;//卷积核形状
            Esize = new Size(3, 3);//卷积核尺寸
            Eanchor = new Point(-1, -1);//卷积核锚的位置
            Anchor = new Point(-1, -1);//锚的位置
            Iterations = 1;//迭代次数
            BType = BorderType.Default;//边界类型
            BValue = new MCvScalar();//边界值
            MSize = 5;
        }
    }
}
