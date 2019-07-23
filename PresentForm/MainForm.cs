using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLibrary.FormAndUser;
using EmguCVLibrary;
using Newtonsoft.Json;

namespace PresentForm
{
    public partial class MainForm : Form
    {
        TestClass testClass;
        ImgDataStruct Imgdata = new ImgDataStruct();
        public MainForm()
        {
            InitializeComponent();
            testClass = new TestClass();
            propertyGrid1.SelectedObject = para;
            propertyGrid2.SelectedObject = Ocr_Para;

        }
        //定义图像处理参数
        EmguCVLibrary.Theories.CommonMethod_Para para = new EmguCVLibrary.Theories.CommonMethod_Para()
        {
            ColorConversion = Emgu.CV.CvEnum.ColorConversion.Bgra2Gray,
            Threshold = 100,
            ThresholdMaxValue = 255,
            ThresholdType = Emgu.CV.CvEnum.ThresholdType.BinaryInv
        };
        //定义OCR识别参数
        EmguCVLibrary.Theories.OCR_Recognition_Para Ocr_Para = new EmguCVLibrary.Theories.OCR_Recognition_Para()
        {
            DataPath = Application.StartupPath + @"\OcrData\",
            Language = EmguCVLibrary.Theories.LanguageType.英文,
            EngineMode = Emgu.CV.OCR.OcrEngineMode.Default,
            WhiteList = null,
            EnforceLocale = false
        };


        private void Button1_Click(object sender, EventArgs e)
        {
            picShow1.FocusPic(new Point(-2948,-566),2.5f);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //testClass.IniMapper();
            string filepath = "";
            // 获取文件名       
            OpenFileDialog openfile = new OpenFileDialog
            {
                Filter = "图片|*.jpg;*.png;*.gif;*.jpeg;*.bmp"
            };
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                 filepath = openfile.FileName;
            }
            else
            {
                return;
            }
            if (Imgdata.SrcImage != null) Imgdata.SrcImage.Dispose();
            Imgdata.ReadSrcImg(filepath);//读取Src图像
            picShow1.LoadPic(new Bitmap(Imgdata.SrcImage.Bitmap));
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //初始化参数
            commonMethod1.Params = JsonConvert.SerializeObject(propertyGrid1.SelectedObject);
            commonMethod1.InitialParameter();
            //处理图像
            commonMethod1.ProcessImge(ref Imgdata);
            picShow2.LoadPic(new Bitmap(Imgdata.DstImage.Bitmap));
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //初始化参数
            ocR_Recognition1.Params = JsonConvert.SerializeObject(propertyGrid2.SelectedObject);
            ocR_Recognition1.InitialParameter();
            //OCR识别
            string textStr = ocR_Recognition1.GetOCR(ref Imgdata);
            MessageBox.Show(textStr);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ConfigForm Test = new ConfigForm();
            Test.ShowDialog();
        }
    }
}
