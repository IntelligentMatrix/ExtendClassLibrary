using Emgu.CV;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmguCVLibrary
{
    public class ImgDataStruct
    {
        /// <summary>
        /// 源图像数据
        /// </summary>
        public Mat SrcImage { get; set; }

        /// <summary>
        /// 模板图像数据
        /// </summary>
        public Mat TplImage { get; set; }

        /// <summary>
        /// 结果图像数据
        /// </summary>
        public Mat DstImage { get; set; } 
        
        /// <summary>
        /// 构造函数
        /// </summary>
        public ImgDataStruct()
        {
            //初始化参数
            SrcImage = new Mat();
            TplImage = new Mat();
            DstImage = new Mat();
        }
        /// <summary>
        /// 读取Src图像
        /// </summary>
        /// <param name="filePath"></param>
        public void ReadSrcImg(string filePath)
        {
            if (!File.Exists(filePath)) return;
            if(SrcImage != null) SrcImage.Dispose();
            SrcImage = CvInvoke.Imread(filePath); 
        }
        /// <summary>
        /// 读取Tpl图像
        /// </summary>
        /// <param name="filePath"></param>
        public void ReadTplImg(string filePath) 
        {
            if (!File.Exists(filePath)) return;
            if (TplImage != null) TplImage.Dispose();
            TplImage = CvInvoke.Imread(filePath);
        }
        /// <summary>
        /// 读取Dst图像
        /// </summary>
        /// <param name="filePath"></param>
        public void ReadDstImg(string filePath)
        {
            if (!File.Exists(filePath)) return;
            if (DstImage != null) DstImage.Dispose();
            DstImage = CvInvoke.Imread(filePath);
        }
    }
    public class ImgPosFocus
    {

    }
}
