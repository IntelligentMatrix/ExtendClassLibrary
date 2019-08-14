using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.ML;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmguCVLibrary.Theories
{
    public partial class Ann_Recog : ProjectBaseMethod
    {
        #region 构造函数
        public Ann_Recog()
        {
            InitializeComponent();
        }

        public Ann_Recog(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #endregion
        #region 定义变量
        public ANN_MLP BP { get; set; }//识别网络
        public Size ImgSize { get; set; }//图片尺寸
        public string Ann_File { get; set; }//识别网络训练文件 
        public string Labels { get; set; }
        public int V_MinThresh { get; set; }//垂直字符最小拆分阈值
        public int V_MinRange { get; set; }//垂直字符最小拆分间距
        public int H_MinThresh { get; set; }//水平行最小拆分阈值
        public int H_MinRange { get; set; }//水平行最小拆分间距
        public double RelaxingFactor_Width { get; set; }//Width缩放系数 
        public double RelaxingFactor_Height { get; set; }//Height缩放系数 
        #endregion

        #region 重构基类函数 
        /// <summary>
        /// 初始化参数
        /// </summary>
        public override void InitialParameter()
        {
            Ann_Recog_Para Para = new Ann_Recog_Para();
            Para = JsonConvert.DeserializeObject<Ann_Recog_Para>(Params);//将字符串转换为参数变量
            //参数
            ImgSize = Para.ImgSize;
            Ann_File = Para.Ann_File;
            Labels = Para.Labels;
            V_MinRange = Para.V_MinRange;
            V_MinThresh = Para.V_MinThresh;
            H_MinRange = Para.H_MinRange;
            H_MinThresh = Para.H_MinThresh;
            RelaxingFactor_Width = Para.RelaxingFactor_Width;
            RelaxingFactor_Height = Para.RelaxingFactor_Height;
            //网络初始化
            LoadFile();
        }
        #endregion

        #region 处理函数
        /// <summary>
        /// 处理图像
        /// </summary>
        public override void ProcessImge(ref ImgDataStruct ImgData)
        {
            //处理图片
            if (Emgu.CV.AlgorithmExtensions.IsEmpty(BP)) return;
            //Mat TempImg = ImgData.TplImage.Clone();
            //Mat src = CvInvoke.Imread("D:\\Extend\\3.png", Emgu.CV.CvEnum.ImreadModes.Grayscale);
            //CvInvoke.Imshow("Surce", src);
            Mat TempImg = ImgData.DstImage.Clone();
            //缩放图片
            CvInvoke.Resize(TempImg, TempImg,new Size(), RelaxingFactor_Width, RelaxingFactor_Height, Emgu.CV.CvEnum.Inter.Linear);
            //二值化
            CvInvoke.Threshold(TempImg, TempImg, 40, 1, Emgu.CV.CvEnum.ThresholdType.BinaryInv);
            
            //参数
            int[] V_pos = new int[TempImg.Cols];//垂直投影
            int[] H_pos = new int[TempImg.Rows];//水平投影
            List<Char_Range> h_peek_range = new List<Char_Range>();//行
            List<Mat> ImgLines = new List<Mat>();
            List<Mat> ChaImgs = new List<Mat>(); 
            //获取水平投影
            GetTextProjection(TempImg, ref H_pos, Orientation_Mode.H_PROJECT);
            //获取水平Peek_range
            GetPeekRange(H_pos, ref h_peek_range, V_MinThresh, V_MinRange);
            //获取行
            for (int i = 0; i < h_peek_range.Count; i++)
            {
                Mat line =new Mat(TempImg, new Rectangle(0, h_peek_range[i].Begin, TempImg.Cols, h_peek_range[i].End - h_peek_range[i].Begin)).Clone();
                ImgLines.Add(line);
            }
            //获取字符图片
            for (int i = 0; i < ImgLines.Count; i++)
            {
                Mat line = ImgLines[i];
                int[] vertical_pos = new int[line.Cols];
                List<Char_Range> v_peek_range = new List<Char_Range>();
                GetTextProjection(line,ref vertical_pos, Orientation_Mode.V_PROJECT);
                GetPeekRange(vertical_pos,ref v_peek_range,H_MinThresh,H_MinRange);
                CutCharFromLine(line, v_peek_range,ref ChaImgs); 
            }
            //图片保存,识别
            double maxVal = 0;
            double minVal = 0;
            Point maxLoc = new Point();
            Point minLoc = new Point();
            string result = "";
            for (int i = 0;i < ChaImgs.Count;i++)
            {
                CvInvoke.Threshold(ChaImgs[i], ChaImgs[i], 0, 255, Emgu.CV.CvEnum.ThresholdType.BinaryInv);
                CvInvoke.Resize(ChaImgs[i], ChaImgs[i], new Size(), 0.25, 0.25, Emgu.CV.CvEnum.Inter.Linear);
                CvInvoke.Resize(ChaImgs[i], ChaImgs[i], ImgSize, 0, 0, Emgu.CV.CvEnum.Inter.Linear);
                Mat TestMat = new Mat(1, ImgSize.Height * ImgSize.Width, DepthType.Cv32F, 1);
                for (int k = 0;k< ChaImgs[i].Rows;k++)
                {
                    for (int p = 0; p < ChaImgs[i].Rows; p++)
                    {
                        TestMat.SetValue(0, k * ChaImgs[i].Rows + p, (float)ChaImgs[i].GetValue(k,p));
                    }
                }
                Mat ResultMat = new Mat();                
                BP.Predict(TestMat, ResultMat);
                CvInvoke.MinMaxLoc(ResultMat, ref minVal, ref maxVal, ref minLoc, ref maxLoc);
                int index = maxLoc.X;
                if (index >= 0 && index < Labels.Length)
                {
                    result += Labels[index];
                }
                CvInvoke.Imwrite("./test/" + i.ToString() + ".png", ChaImgs[i]);
            }
            //显示
            CvInvoke.Threshold(TempImg, TempImg, 0, 255, Emgu.CV.CvEnum.ThresholdType.BinaryInv);
            CvInvoke.Imshow("Result", TempImg);
            MessageBox.Show(result);
            //Gc回收
            GC.Collect();
        }
        #endregion

        #region 自定义函数
        /// <summary>
        /// 加载文件
        /// </summary>
        public void LoadFile()
        {
            if (!File.Exists(Ann_File))
            {
                MessageBox.Show("Ann_File is not exist！");
                return;
            }
            //加载文件
            BP = new ANN_MLP();
            Emgu.CV.AlgorithmExtensions.Load(BP, Ann_File);
        }

        /// <summary>
        /// 投影,二值图
        /// </summary>
        /// <param name="src"></param>
        /// <param name="pos"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public int GetTextProjection(Mat src,ref int[] pos, Orientation_Mode mode)
        {
            //数组
            if (mode == Orientation_Mode.V_PROJECT)//垂直投影
            {
                for (int i = 0; i < src.Rows; i++)
                {
                    for (int j = 0; j < src.Cols; j++)
                    {
                        if (src.GetValue(i,j) == 0)
                        {
                            pos[j]++;
                        }
                    }
                }
            }
            else if (mode == Orientation_Mode.H_PROJECT)//水平投影
            {
                for (int i = 0; i < src.Cols; i++)
                {
                    for (int j = 0; j < src.Rows; j++)
                    {
                        if (src.GetValue(j, i) == 0)
                        {
                            pos[j]++;
                        }
                    }
                }
            }
            return 0;
        }

        /// <summary>
        /// 获取每个分割字符的范围，
        /// min_thresh：波峰的最小幅度
        /// min_range：两个波峰的最小间隔
        /// </summary>
        /// <param name="projection_pos"></param>
        /// <param name="peek_range"></param>
        /// <param name="min_thresh"></param>
        /// <param name="min_range"></param>
        /// <returns></returns>
        int GetPeekRange(int[] projection_pos,ref List<Char_Range> peek_range, int min_thresh = 2, int min_range = 10)
        {
            //Temp变量
            int begin = 0;
            int end = 0;
            //提取数据
            for (int i = 0; i < projection_pos.Length; i++)
            {
                if (projection_pos[i] > min_thresh && begin == 0)
                {
                    begin = i;
                }
                else if (projection_pos[i] > min_thresh && begin != 0)
                {
                    continue;
                }
                else if (projection_pos[i] < min_thresh && begin != 0)
                {
                    end = i;
                    if (end - begin >= min_range)
                    {
                        Char_Range tmp = new Char_Range
                        {
                            Begin = begin,
                            End = end
                        };
                        peek_range.Add(tmp);
                        begin = 0;
                        end = 0;
                    }
                }
                else if (projection_pos[i] < min_thresh || begin == 0)
                {
                    continue;
                }
                else
                {
                    //printf("raise error!\n");
                    continue;
                }
            }
            return 0;
        }

        /// <summary>
        /// 从单行图片切分单个字符
        /// </summary>
        /// <param name="img"></param>
        /// <param name="v_peek_range"></param>
        /// <param name="chars_set"></param>
        /// <returns></returns>
        int CutCharFromLine(Mat img, List<Char_Range> v_peek_range,ref List<Mat> chars_set)
        {
	        int count = 0;
            Mat show_img = img.Clone();
	        for (int i = 0; i < v_peek_range.Count; i++)
	        {
		        Rectangle r = new Rectangle(v_peek_range[i].Begin, 0, v_peek_range[i].End - v_peek_range[i].Begin, img.Rows);
                CvInvoke.Rectangle(show_img, r,new Emgu.CV.Structure.MCvScalar(255, 0, 0), 2);
		        Mat single_char =new Mat(img, r).Clone();
                chars_set.Add(single_char);
                count++;
	        }
            CvInvoke.Imshow("cut", show_img);
	        return 0;
        }


        #endregion
    }
    /// <summary>
    /// 膨胀参数
    /// </summary>
    public class Ann_Recog_Para
    {
        [DescriptionAttribute("识别基准尺寸"),
         CategoryAttribute("Setting"),
         DisplayName("ImgSize")]
        public Size ImgSize { get; set; }

        [DescriptionAttribute("ANN训练文件"),
        CategoryAttribute("Setting"),
        DisplayName("Ann_File")]
        public string Ann_File { get; set; }

        [DescriptionAttribute("识别标签"),
        CategoryAttribute("Setting"),
        DisplayName("Labels")]
        public string Labels { get; set; }

        [DescriptionAttribute("垂直最小拆分阈值"),
        CategoryAttribute("Setting"),
        DisplayName("V_MinThresh")]
        public int V_MinThresh { get; set; }

        [DescriptionAttribute("垂直最小拆分间距"),
        CategoryAttribute("Setting"),
        DisplayName("V_MinRange")]
        public int V_MinRange { get; set; }

        [DescriptionAttribute("水平最小拆分阈值"),
        CategoryAttribute("Setting"),
        DisplayName("H_MinThresh")]
        public int H_MinThresh { get; set; }

        [DescriptionAttribute("水平最小拆分间距"),
        CategoryAttribute("Setting"),
        DisplayName("H_MinRange")]
        public int H_MinRange { get; set; }

        [DescriptionAttribute("缩放系数"),
        CategoryAttribute("Setting"),
        DisplayName("RelaxingFactor_Width")]
        public double RelaxingFactor_Width { get; set; }

        [DescriptionAttribute("缩放系数"),
        CategoryAttribute("Setting"),
        DisplayName("RelaxingFactor_Height")]
        public double RelaxingFactor_Height { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public Ann_Recog_Para()
        {
            ImgSize = new Size(64, 64);//图片大小
            Ann_File = "./Ann/MLPModel.xml";//ANN训练文件
            Labels = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_=+!#%@:;\"\'<>?^&*()~{}[]|,";//标签对
            V_MinThresh = 10;
            V_MinRange = 30;
            H_MinThresh = 2;
            H_MinRange = 10;
            RelaxingFactor_Width = 2;
            RelaxingFactor_Height = 4;

        }

    }
    /// <summary>
    /// 方向
    /// </summary>
    public enum Orientation_Mode
    {
        V_PROJECT = 0,//垂直vertical
        H_PROJECT = 2//水平horizontal
    }
    /// <summary>
    /// 字符Range
    /// </summary>
    public class Char_Range
    {
        public int Begin { get; set; }
        public int End { get; set; }
        public Char_Range()
        {
            Begin = 0;
            End = 0;
        }
    }
}
