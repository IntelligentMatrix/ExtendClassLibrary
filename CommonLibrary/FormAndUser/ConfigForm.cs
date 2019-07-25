using AutoMapper;
using DataAccessLibrary;
using DataAccessLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonLibrary.FormAndUser
{
    public partial class ConfigForm : Form
    {
        #region 
        public ConfigForm(string host)
        {
            InitializeComponent();
            SolutionName = host;

        }
        public ConfigForm():this(Environment.MachineName)
        {
        }
        #endregion

        public string SolutionName { get; set; }//主机名
        DataEFEntity DB = new DataEFEntity();//数据库连接
        SolutionData solutionData = new SolutionData();//方案数据
        /// <summary>
        /// 页面加载
        /// 1、加载主机名
        /// 2、加载各选项/组件名
        /// 3、加载默认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigForm_Load(object sender, EventArgs e)
        {
            Mapper.Initialize(cfg => { });
            //初始化Solution名称
            textBox_OptionName.Text = SolutionName;

            //检测Solution是否存在
            //var Solution = from c in DB.Solutions where c.SolutionName == SolutionName select c;
            //if(Solution == null)//如果为空，则创建Solution
            //{

            //}

            //分组初始化 
            comboBox_Option.DataSource = BindComboxEnumType<OptionType>.BindTyps;
            comboBox_Option.DisplayMember = "Name";
            comboBox_Option.ValueMember = "Type";

            //comboBox_Option.Items.AddRange(DB.GetOptionType().ToArray());
            //if (comboBox_Option.Items.Count > 0)
            //{
            //    comboBox_Option.SelectedIndex = 0;
            //}
        }
        /// <summary>
        /// 组件分类更改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_Option_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Option_Text = comboBox_Option.Text;
            //检索当前项目该选项的内容
            comboBox_OptionList.Items.AddRange(DB.GetPlc(Option_Text).Select(o => o.Name).ToList().ToArray());

        }
        /// <summary>
        /// 增加选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_AddOption_Click(object sender, EventArgs e)
        {
            
            ProjectListData projectList01 = new ProjectListData()
            {
                Name = "Test",
                Paras = "Para",
                Component = "NewComponent"
            };
            ProjectData project = new ProjectData()
            {
                Type = "project",
                Name = "Test",
            };
            SolutionData solution = new SolutionData()
            {
                Name = "Test4"
            };
            //Mapper.Initialize(cfg => { cfg.CreateMap<SolutionData, Solution>(); });
            
            //Solution
            var Solution = (from c in DB.Solutions where c.Name == solution.Name select c).FirstOrDefault();
            if (Solution == null)//如果为空，则创建Solution
            {
                Solution solution1 = AutoMapHelper.MapTo<Solution>(solution);
                DB.Solutions.Add(solution1);//追加Solution
                DB.SaveChangesAsync();
                return;
            }
            //Project
            var Proiquery = from r in Solution.Projects where r.Type == project.Type && r.Name == project.Name select r;
            Project project1 = Proiquery.FirstOrDefault();
            if (project1 == null)
            {
                Solution.Projects.Add(AutoMapHelper.MapTo<Project>(project));
                DB.SaveChangesAsync();
                return;
            }
            //projectList
            var ProListiquery = from r in project1.ProjectLists where r.Name == projectList01.Name select r;
            ProjectList projectList1 = ProListiquery.FirstOrDefault();
            if (projectList1 == null)
            {
                project1.ProjectLists.Add(AutoMapHelper.MapTo<ProjectList>(projectList01));
                DB.SaveChangesAsync();
                return;
            }
        }
        /// <summary>
        /// 删除选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_DelOption_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox_Option.SelectedValue.ToString());
            ProjectList projectList01 = new ProjectList()
            {
                Name = "Test",
                Paras = "Para",
                Component = "NewComponent"
            };
            Project project = new Project()
            {
                Type = "project",
                Name = "Test",
            };
            Solution solution = new Solution()
            {
                Name = "Test2"
            };

            //Solution
            var Solution = (from c in DB.Solutions where c.Name == solution.Name select c).FirstOrDefault();
            if (Solution == null)//如果为空，则创建Solution
            {
                DB.Solutions.Add(solution);//追加Solution
                DB.SaveChangesAsync();
                return;
            }
            //Project
            var Proiquery = from r in Solution.Projects where r.Type == project.Type && r.Name == project.Name select r;
            Project project1 = Proiquery.FirstOrDefault();
            if (project1 == null)
            {
                Solution.Projects.Add(project);
                DB.SaveChangesAsync();
                return;
            }
            //projectList
            var ProListiquery = from r in project1.ProjectLists where r.Name == projectList01.Name select r;
            ProjectList projectList1 = ProListiquery.FirstOrDefault();
            if (projectList1 == null)
            {
                project1.ProjectLists.Add(projectList01);
                DB.SaveChangesAsync();
                return;
            }
        }

    }
    public enum OptionType
    {
        Plc = 0,
        Project =2,
        DataBase = 4
    }
}
