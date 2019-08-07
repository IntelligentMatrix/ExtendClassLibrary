using CommonLibrary.CommonMethod;
using CommonLibrary.Define;
using CommonLibrary.FormAndUser;
using DataAccessLibrary.Model;
using EmguCVLibrary;
using EmguCVLibrary.Theories;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PresentForm
{
    public partial class SolutionTest : Form
    {
        public SolutionTest()
        {
            InitializeComponent();
        }
        ProjectArch projectArch = new ProjectArch();
        ImgDataStruct imgDataStruct = new ImgDataStruct();
        /// <summary>
        /// 启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Button_Click(object sender, EventArgs e)
        {
            projectArch.Run(ref imgDataStruct);
            picShow1.LoadPic(new Bitmap(imgDataStruct.DstImage.Bitmap));
            if (!imgDataStruct.TmpImage.IsEmpty) picShow_Tmp.LoadPic(new Bitmap(imgDataStruct.TmpImage.Bitmap));
            if (!imgDataStruct.TplImage.IsEmpty) picShow_Tmlate.LoadPic(new Bitmap(imgDataStruct.TplImage.Bitmap));
        }
        /// <summary>
        /// 停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stop_Button_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 测试按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Test_Button_Click(object sender, EventArgs e)
        {
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
            imgDataStruct.ReadSrcImg(filepath);
        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ini_Button_Click(object sender, EventArgs e)
        {
            DataEFEntity DB = new DataEFEntity();//数据库连接
            var prolist = (from r in DB.ProjectLists where r.Project.Solution.Name == Environment.MachineName && r.Project.Name == "Project" select r).ToList();
            projectArch.Name = "Project";
            projectArch.ProjectList.Clear();
            //初始化组件及其参数
            for (int i = 0; i < prolist.Count; i++)
            {
                ProjectList projectList = prolist[i];
                string component = projectList.Component;
                //检索是否存在该组件,并追加组件
                if (ProjectComponentDefine.ComponmentParamDictionary.ContainsKey(component))
                {
                    Type type = ProjectComponentDefine.ComponmentParamDictionary[component].ComponentType;
                    ProjectBaseMethod projectMethod = (ProjectBaseMethod)ProjectComponentDefine.CreatInstance(type);
                    projectMethod.IniComponent(prolist[i].Component, prolist[i].Paras);
                    projectArch.ProjectList.Add(projectMethod);
                }
            }


        }
        /// <summary>
        /// 配置界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Config_Button_Click(object sender, EventArgs e)
        {
            ConfigForm Test = new ConfigForm();
            Test.ShowDialog();
        }
    }
}
