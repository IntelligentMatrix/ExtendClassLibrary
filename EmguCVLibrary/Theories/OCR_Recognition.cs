using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV.OCR;
using System.Windows.Forms;
using MyLibrary;

namespace EmguCVLibrary.Theories
{
    /// <summary>
    /// OCR光学字符识别
    /// </summary>
    public partial class OCR_Recognition : ProjectBaseMethod
    {
        #region 构造函数
        public OCR_Recognition()
        {
            InitializeComponent();
        }

        public OCR_Recognition(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #endregion

        #region 变量定义
        public Tesseract Tesseract_OCR;//光学识别引擎
        public string DataPath { get; set; }        
        public string Language { get; set; }
        public OcrEngineMode EngineMode { get; set; }
        public string WhiteList { get; set; } = null;
        public bool EnforceLocale { get; set; } = false;
        public LanguageType LanguageType
        {
            get
            {
                if (Language == "chi_sim")
                {
                    return LanguageType.简体中文;
                }
                else if (Language == "chi_tra")
                {
                    return LanguageType.繁体中文;
                }
                else if (Language == "jpn")
                {
                    return LanguageType.日语;
                }
                else if (Language == "custom")
                {
                    return LanguageType.自定义;
                }
                else
                {
                    return LanguageType.英文;
                }

                
            }
            set
            {
                switch (value)
                {
                    case LanguageType.简体中文:
                        Language = "chi_sim";
                        break;
                    case LanguageType.繁体中文:
                        Language = "chi_tra";
                        break;
                    case LanguageType.日语:
                        Language = "jpn"; 
                        break;
                    case LanguageType.自定义:
                        Language = "custom";
                        break;
                    default:
                        Language = "eng";
                        break;
                }
            }
        }
        #endregion

        #region 重构基类函数
        /// <summary>
        /// 初始化参数
        /// </summary>
        public override void InitialParameter()
        {
            OCR_Recognition_Para Para = new OCR_Recognition_Para();
            Para = JsonConvert.DeserializeObject<OCR_Recognition_Para>(Params);//将字符串转换为参数变量
            //变量赋值
            DataPath = Para.DataPath;
            LanguageType = Para.Language;
            EngineMode = Para.EngineMode;
            WhiteList = Para.WhiteList;
            EnforceLocale = Para.EnforceLocale;
        }
        #endregion

        #region 自定义函数定义
        /// <summary>
        /// 初始化Ocr引擎
        /// </summary>
        public void IniOcr()
        {
            Tesseract_OCR = new Tesseract(DataPath, Language, EngineMode, WhiteList, EnforceLocale);//初始化引擎参数
            //Tesseract_OCR = new Tesseract();
            //Tesseract_OCR.Init(DataPath, Language, EngineMode);
        }
        /// <summary>
        /// 识别字符
        /// </summary>
        /// <param name="ImgData"></param>
        /// <returns></returns>
        public string GetOCR(ref ImgDataStruct ImgData)
        {
            IniOcr();
            string Result = "";
            Tesseract_OCR.SetImage(ImgData.DstImage);//设置识别图片
            Tesseract_OCR.Recognize();//识别
            Result = Tesseract_OCR.GetUTF8Text();          
            return Result; 
        }
        #endregion

    }

    /// <summary>
    /// OCR光学字符识别 参数
    /// </summary>
    public class OCR_Recognition_Para
    { 
        [DescriptionAttribute("语言包路劲"),
         CategoryAttribute("Setting"),
         DisplayName("DataPath")]
        public string DataPath { get; set; }

        [DescriptionAttribute("识别语言"),
         CategoryAttribute("Setting"),
         DisplayName("Language")]
        public LanguageType Language { get; set; }

        [DescriptionAttribute("引擎模式"),
         CategoryAttribute("Setting"),
         DisplayName("EngineMode")]
        public OcrEngineMode EngineMode { get; set; }

        [DescriptionAttribute("白名单"),
         CategoryAttribute("Setting"),
         DisplayName("WhiteList")]
        public string WhiteList { get; set; } = null;

        [DescriptionAttribute("强制本地"),
         CategoryAttribute("Setting"),
         DisplayName("EnforceLocale")]
        public bool EnforceLocale { get; set; } = false;

        /// <summary>
        /// 构造函数
        /// </summary>
        public OCR_Recognition_Para()
        {
            DataPath = Application.StartupPath + @"\OcrData\";
            Language = LanguageType.英文;
            EngineMode = OcrEngineMode.Default;
            WhiteList = null;
            EnforceLocale = false;
        }
    }
    /// <summary>
    /// 语言类型
    /// </summary>
    public enum LanguageType
    {
        简体中文 = 0,
        繁体中文 = 2,
        英文 = 4,
        日语 = 8,
        自定义 = 16
    }

}
