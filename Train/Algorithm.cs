using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.ML;
using Emgu.CV.ML.MlEnum;

namespace Train
{
    class Algorithm
    {
        static string filefilter = ".png";
        static string imgPath = @"D:\Extend\TrainImg";

        static int sample_mun_perclass = 390;//训练字符每类数量
        const int class_mun = 63;//训练字符类数

        const int width = 64;//图像大小width
        const int height = 64;//图像大小height
        string fileReadName, fileReadPath;

        #region Generate the traning data and classes
        Matrix<float> trainData = new Matrix<float>(class_mun * sample_mun_perclass,width * height);//训练数据,width,height,channel
        Matrix<float> trainClasses = new Matrix<float>(class_mun * sample_mun_perclass, class_mun);//类别，数量，分类量

        /// <summary>
        /// 生成训练数据
        /// </summary>
        public void CreateDate()
        {
            List<DirectoryInfo> classDirlist = GetFilePath(imgPath);//获取子目录下的所有分类文件夹
            if(classDirlist == null)
            {
                MessageBox.Show("训练文件夹数据为空！！");
                return;
            }
            //加载
            for(int i = 0;i < classDirlist.Count;i++)
            {
                //加载文件
                List<FileInfo> fileInfos = GetFile(classDirlist[i].FullName, filefilter);
                if(fileInfos == null)
                {
                    MessageBox.Show("训练文件数据为空！！");
                    return;
                }
                for (int j = 0;j < fileInfos.Count;j++)
                {
                    //读取
                    Mat img = CvInvoke.Imread(fileInfos[j].FullName,Emgu.CV.CvEnum.ImreadModes.Grayscale);
                    //缩放
                    CvInvoke.Resize(img,img,new System.Drawing.Size(width,height),0,0,Emgu.CV.CvEnum.Inter.Linear);
                    //数据填充
                    for (int k = 0; k < height; k++)
                    {
                        for (int l = 0;l < width;l++)
                        {
                            trainData[i * sample_mun_perclass + j,k * height + l]= img.Data[k].;
                        }                        
                    }
                }
            }
        }

        /// <summary>
        /// 获得目录下所有文件或指定文件类型文件
        /// </summary>
        /// <param name="path">文件夹路径</param>
        /// <param name="extName">扩展名可以多个 例如 .mp3.wma.rm</param>
        /// <returns>List<FileInfo></returns>
        public static List<FileInfo> GetFile(string path, string extName)
        {
            if (!Directory.Exists(path)) return null;
            try
            {
                List<FileInfo> lst = new List<FileInfo>();
                string[] dir = Directory.GetDirectories(path); //文件夹列表   
                DirectoryInfo fdir = new DirectoryInfo(path);
                FileInfo[] file = fdir.GetFiles();
                if (file.Length != 0 || dir.Length != 0) //当前目录文件或文件夹不为空                   
                {
                    foreach (FileInfo f in file) //显示当前目录所有文件   
                    {
                        if (extName.ToLower().IndexOf(f.Extension.ToLower()) >= 0)
                        {
                            lst.Add(f);
                        }
                    }
                    //递归访问下一级，即所有文件包含子文件
                    //foreach (string d in dir)
                    //{
                    //    GetFile(d, extName);//递归   
                    //}
                }
                return lst;
            }
            catch (Exception e)
            {
                throw new Exception("GetFile" + e.Message);
            }
        }
        /// <summary>
        /// 获得目录下文件夹
        /// </summary>
        /// <param name="path">文件夹路径</param>
        /// <param name="extName">扩展名可以多个 例如 .mp3.wma.rm</param>
        /// <returns>List<FileInfo></returns>
        public static List<DirectoryInfo> GetFilePath(string path)
        {
            List<DirectoryInfo> Result = new List<DirectoryInfo>();
            if (!Directory.Exists(path)) return Result;
            try
            {
                string[] dir = Directory.GetDirectories(path); //文件夹列表  
                foreach (var o in dir)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(o);
                    Result.Add(dirInfo);
                }
                return Result;
            }
            catch (Exception e)
            {
                throw new Exception("GetFilePath" + e.Message);
            }
        }
    }


}