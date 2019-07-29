using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;
using DataAccessLibrary.Model;
using DataAccessLibrary;
using CommonLibrary.Define;
using Newtonsoft.Json;

namespace CommonLibrary.FormAndUser
{
    public partial class AddForm : Form
    {
        #region 
        public AddForm(string host)
        {
            InitializeComponent();
            SolutionName = host;

        }
        public AddForm():this(Environment.MachineName)
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

            //初始化Solution名称
            textBox_Solution.Text = SolutionName;

            //检测Solution是否存在
            //var Solution = from c in DB.Solutions where c.SolutionName == SolutionName select c;
            //if(Solution == null)//如果为空，则创建Solution
            //{

            //}

            //分组初始化 
            comboBox_Option.DataSource = MyLibrary.BindComboxEnumType<OptionType>.BindTyps;
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
            //该类型组件列表刷新
            //listView_ComponentList.Items.Clear();
            //listView_ComponentList.Items.AddRange(DB.GetPlc(Option_Text).Select(o => o.Name).ToList().ToArray());
            RefreshOptionInfo();
            InitialOptionComponentListView();
            RefreshComponent();
        }
        /// <summary>
        /// 增加选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_AddOption_Click(object sender, EventArgs e)
        {
            //Type type = Type.GetType("EmguCVLibrary.Theories.CommonMethod");

            //Type type1 = Type.GetType("CommonLibrary.FormAndUser.AddForm");

            SolutionData solution = new SolutionData()
            {
                Name = SolutionName
            };
            for (int i = 0; i < 10; i++)//外层
            {
                solution.Plc.Add(new PlcData()
                {
                    Type = $"PlcType{i + 20}",
                    Name = $"PlcName{i}"
                });
                solution.Project.Add(new ProjectData()
                {
                    Type = $"ProjectType{i + 20}",
                    Name = $"ProjectName{i}"
                });
                solution.DataBase.Add(new DataBaseData()
                {
                    Type = $"DataBaseType{i + 20}",
                    Name = $"DataBaseName{i}"
                });

                for (int j = 0; j < 10; j++)//内层
                {
                    solution.Plc[i].PlcList.Add(new PlcListData()
                    {
                        Name = $"PlcListName{j}",
                        Paras = $"PlcListParas{j + 10}",
                        Component = $"PlcListComponent{j + 20}"
                    });
                    solution.DataBase[i].DataBaseList.Add(new DataBaseListData()
                    {
                        Name = $"DataBaseListName{j}",
                        Paras = $"DataBaseListParas{j + 10}",
                        Component = $"DataBaseListComponent{j + 20}"
                    });
                    solution.Project[i].ProjectList.Add(new ProjectListData()
                    {
                        Name = $"ProjectListName{j}",
                        Paras = $"ProjectListParas{j + 10}",
                        Component = $"ProjectListComponent{j + 20}"
                    });
                }
            }
            //更新
            DB.UpdateSolutionData(solution);

            //Mapper.Initialize(cfg => { cfg.CreateMap<SolutionData, Solution>(); });

            //Solution
            //var Solution = (from c in DB.Solutions where c.Name == solution.Name select c).FirstOrDefault();
            //if (Solution == null)//如果为空，则创建Solution
            //{
            //    Solution solution1 = AutoMapHelper.MapTo<SolutionData,Solution>(solution);
            //    DB.Solutions.Add(solution1);//追加Solution
            //    DB.SaveChangesAsync();
            //    return;
            //}
            ////Project
            //var Proiquery = from r in Solution.Projects where r.Type == project.Type && r.Name == project.Name select r;
            //Project project1 = Proiquery.FirstOrDefault();
            //if (project1 == null)
            //{
            //    Solution.Projects.Add(AutoMapHelper.MapTo<Project>(project));
            //    DB.SaveChangesAsync();
            //    return;
            //}
            ////projectList
            //var ProListiquery = from r in project1.ProjectLists where r.Name == projectList01.Name select r;
            //ProjectList projectList1 = ProListiquery.FirstOrDefault();
            //if (projectList1 == null)
            //{
            //    project1.ProjectLists.Add(AutoMapHelper.MapTo<ProjectList>(projectList01));
            //    DB.SaveChangesAsync();
            //    return;
            //}
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
        
        /// <summary>
        /// 刷新option信息
        /// </summary>
        private void RefreshOptionInfo()
        {
            comboBox_OptionList.Items.Clear();
            //检索分类
            if (Enum.TryParse<OptionType>(comboBox_Option.Text, out OptionType result))
            {
                switch (result)
                {
                    case OptionType.Plc:
                        comboBox_OptionList.Items.AddRange((from r in DB.Plcs where r.Solution.Name == SolutionName select r).Select(o => o.Name).ToArray());
                        if (comboBox_OptionList.Items.Count > 0) comboBox_OptionList.SelectedIndex = 0;
                        break;
                    case OptionType.Project:
                        comboBox_OptionList.Items.AddRange((from r in DB.Projects where r.Solution.Name == SolutionName select r).Select(o => o.Name).ToArray());
                        if (comboBox_OptionList.Items.Count > 0) comboBox_OptionList.SelectedIndex = 0;
                        break;
                    case OptionType.DataBase:
                        comboBox_OptionList.Items.AddRange((from r in DB.DataBases where r.Solution.Name == SolutionName select r).Select(o => o.Name).ToArray());
                        if (comboBox_OptionList.Items.Count > 0) comboBox_OptionList.SelectedIndex = 0;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                return;
            }
        }
        bool Sperate = false;//false - database，true - component
        /// <summary>
        /// 刷新组件参数,用于数据库中
        /// </summary>
        /// <param name="item"></param>
        private void RefreshComponentPara_ByDByData(ListViewItem item)
        {
            string component = item.SubItems[0].Text;
            //检索分类
            if (Enum.TryParse<OptionType>(comboBox_Option.Text, out OptionType result))
            {
                switch (result)
                {
                    case OptionType.Plc:
                        if (PlcComponentDefine.ComponmentParamDictionary.ContainsKey(component))
                        {
                            Type type = PlcComponentDefine.ComponmentParamDictionary[component].ParamType;
                            object paramObj = PlcComponentDefine.CreatInstance(type);
                            if (!Sperate) paramObj = JsonConvert.DeserializeObject((string)item.Tag,paramObj.GetType());
                            propertyGrid_Para.SelectedObject = paramObj;
                        }
                        else
                        {
                            throw new Exception(string.Format("The component doesn't exist：{0}.", component));
                        }
                        break;
                    case OptionType.Project:
                        if (ProjectComponentDefine.ComponmentParamDictionary.ContainsKey(component))
                        {
                            Type type = ProjectComponentDefine.ComponmentParamDictionary[component].ParamType;
                            object paramObj = ProjectComponentDefine.CreatInstance(type);
                            if (!Sperate) paramObj = JsonConvert.DeserializeObject((string)item.Tag, paramObj.GetType());
                            propertyGrid_Para.SelectedObject = paramObj;
                        }
                        else
                        {
                            throw new Exception(string.Format("The component doesn't exist：{0}.", component));
                        }
                        break;
                    case OptionType.DataBase:
                        if (DataBaseComponentDefine.ComponmentParamDictionary.ContainsKey(component))
                        {
                            Type type = DataBaseComponentDefine.ComponmentParamDictionary[component].ParamType;
                            object paramObj = DataBaseComponentDefine.CreatInstance(type);
                            if (!Sperate) paramObj = JsonConvert.DeserializeObject((string)item.Tag, paramObj.GetType());
                            propertyGrid_Para.SelectedObject = paramObj;
                        }
                        else
                        {
                            throw new Exception(string.Format("The component doesn't exist：{0}.", component));
                        }
                        break;
                    default:
                        break;
                }
                Sperate = false;
            }
            else
            {
                Sperate = false;
                return;
            }
        }
        

        /// <summary>
        /// 刷新组件列表
        /// </summary>
        private void RefreshComponent()
        {
            //检索列表
            listView_ComponentList.Items.Clear();
            //检索分类
            if (Enum.TryParse<OptionType>(comboBox_Option.Text, out OptionType result))
            {
                ListViewItem.ListViewSubItem[] subItems;
                ListViewItem item = null;
                switch (result)
                {
                    case OptionType.Plc:
                        //tmp = PlcComponentDefine.ComponmentParamDictionary.Keys.ToArray();
                        foreach (var o in PlcComponentDefine.ComponmentParamDictionary)
                        {
                            item = new ListViewItem(o.Key, 0);
                            item.Tag = PlcComponentDefine.CreatInstance(o.Value.ParamType);
                            subItems = new ListViewItem.ListViewSubItem[]{
                                new ListViewItem.ListViewSubItem(item, o.Value.ComponentType.Name)};
                            item.SubItems.AddRange(subItems);
                            subItems = new ListViewItem.ListViewSubItem[]{
                                new ListViewItem.ListViewSubItem(item, o.Value.ParamType.Name)};
                            item.SubItems.AddRange(subItems);
                            listView_ComponentList.Items.Add(item);
                        }
                        break;
                    case OptionType.Project:
                        foreach (var o in ProjectComponentDefine.ComponmentParamDictionary)
                        {
                            item = new ListViewItem(o.Key, 0);
                            item.Tag = ProjectComponentDefine.CreatInstance(o.Value.ParamType);
                            subItems = new ListViewItem.ListViewSubItem[]{
                                new ListViewItem.ListViewSubItem(item, o.Value.ComponentType.Name)};
                            item.SubItems.AddRange(subItems);
                            subItems = new ListViewItem.ListViewSubItem[]{
                                new ListViewItem.ListViewSubItem(item, o.Value.ParamType.Name)};
                            item.SubItems.AddRange(subItems);
                            listView_ComponentList.Items.Add(item);
                        }
                        break;
                    case OptionType.DataBase:
                        foreach (var o in DataBaseComponentDefine.ComponmentParamDictionary)
                        {
                            item = new ListViewItem(o.Key, 0);
                            item.Tag = DataBaseComponentDefine.CreatInstance(o.Value.ParamType);
                            subItems = new ListViewItem.ListViewSubItem[]{
                                new ListViewItem.ListViewSubItem(item, o.Value.ComponentType.Name)};
                            item.SubItems.AddRange(subItems);
                            subItems = new ListViewItem.ListViewSubItem[]{
                                new ListViewItem.ListViewSubItem(item, o.Value.ParamType.Name)};
                            item.SubItems.AddRange(subItems);
                            listView_ComponentList.Items.Add(item);
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// 刷新选项组件列表
        /// </summary>
        private void InitialOptionComponentListView()
        {
            if (string.IsNullOrEmpty(comboBox_OptionList.Text)) return;
            //提取检索ID
            int sortID = 0; 

            //检索列表
            listView_OptionComponent.Items.Clear();
            //检索分类
            if(Enum.TryParse<OptionType>(comboBox_Option.Text, out OptionType result))
            {
                ListViewItem.ListViewSubItem[] subItems;
                ListViewItem item = null;
                switch (result)
                {
                    case OptionType.Plc:
                        sortID = (from r in DB.Plcs where r.Solution.Name == SolutionName && r.Name == comboBox_OptionList.Text select r).FirstOrDefault().Id;
                        var sqlsortPlc = from r in DB.PlcLists where r.PlcId == sortID select r;
                        foreach (var o in sqlsortPlc)
                        {
                            item = new ListViewItem(o.Id.ToString(), 0);
                            item.Tag = o.Paras;
                            subItems = new ListViewItem.ListViewSubItem[]{
                                new ListViewItem.ListViewSubItem(item, o.Name)};
                            item.SubItems.AddRange(subItems);
                            subItems = new ListViewItem.ListViewSubItem[]{
                                new ListViewItem.ListViewSubItem(item, o.Component)};
                            item.SubItems.AddRange(subItems);
                            listView_OptionComponent.Items.Add(item);
                        }
                        break;
                    case OptionType.Project:
                        sortID = (from r in DB.Projects where r.Solution.Name == SolutionName && r.Name == comboBox_OptionList.Text select r).FirstOrDefault().Id;
                        var sqlsortProject = from r in DB.ProjectLists where r.ProjectId == sortID select r;
                        foreach (var o in sqlsortProject)
                        {
                            item = new ListViewItem(o.Id.ToString(), 0);
                            item.Tag = o.Paras;
                            subItems = new ListViewItem.ListViewSubItem[]{
                                new ListViewItem.ListViewSubItem(item, o.Name)};
                            item.SubItems.AddRange(subItems);
                            subItems = new ListViewItem.ListViewSubItem[]{
                                new ListViewItem.ListViewSubItem(item, o.Component)};
                            item.SubItems.AddRange(subItems);
                            listView_OptionComponent.Items.Add(item);
                        }
                        break;
                    case OptionType.DataBase:
                        sortID = (from r in DB.DataBases where r.Solution.Name == SolutionName && r.Name == comboBox_OptionList.Text select r).FirstOrDefault().Id;
                        var sqlsortDataBase = from r in DB.DataBaseLists where r.DataBaseId == sortID select r;
                        foreach (var o in sqlsortDataBase)
                        {
                            item = new ListViewItem(o.Id.ToString(), 0);
                            item.Tag = o.Paras;
                            subItems = new ListViewItem.ListViewSubItem[]{
                                new ListViewItem.ListViewSubItem(item, o.Name)};
                            item.SubItems.AddRange(subItems);
                            subItems = new ListViewItem.ListViewSubItem[]{
                                new ListViewItem.ListViewSubItem(item, o.Component)};
                            item.SubItems.AddRange(subItems);
                            listView_OptionComponent.Items.Add(item);
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                return;
            }
        }
        /// <summary>
        /// 刷新组件列表
        /// </summary>
        private void InitialComponentListView()
        {

        }
        
        /// <summary>
        /// 组件列表选中修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView_ComponentList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Sperate = true;
            try
            {

                if (e.IsSelected)
                {
                    ListViewItem item = e.Item;
                    RefreshComponentPara_ByDByData(item);
                    //CurListViewItem = e.Item;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
