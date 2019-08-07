using AutoMapper;
using CommonLibrary.CommonMethod;
using CommonLibrary.Define;
using DataAccessLibrary;
using DataAccessLibrary.Model;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Linq;
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
        public ConfigForm() : this(Environment.MachineName)
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
        private bool Add(string name)
        {
            DB.AddSolution(SolutionName);//添加solution
            var solutionQuery = from r in DB.Solutions where r.Name == SolutionName select r;
            var solution = solutionQuery.FirstOrDefault();
            if (solution == null)
            {
                MessageBox.Show("解决方案不存在！");
                return false;
            }
            //功能代码
            if (Differ_Option_OR_List)//optionlist添加
            {
                //检索分类
                if (Enum.TryParse<OptionType>(comboBox_Option.Text, out OptionType result))
                {
                    switch (result)
                    {
                        case OptionType.Plc:
                            //父级层
                            var plcQuery = from r in DB.Plcs where r.Solution.Name == SolutionName && r.Name == comboBox_OptionList.SelectedItem.ToString() select r;
                            Plc plc = plcQuery.FirstOrDefault();
                            if (plc == null) //检测父级层是否存在
                            {
                                MessageBox.Show("父级层为空！");
                                return false;
                            }
                            //子级层
                            var plcListQuery = from r in DB.PlcLists where r.Plc.Solution.Name == SolutionName && r.Plc.Name == comboBox_OptionList.SelectedItem.ToString() && r.Name == name select r;
                            PlcList plcList = plcListQuery.FirstOrDefault();
                            if (plcList != null) //是否存在
                            {
                                MessageBox.Show("该项已存在！");
                                return false;
                            }
                            //追加数据
                            plc.PlcLists.Add(new PlcList()
                            {
                                Name = name,
                                Component = listView_ComponentList.SelectedItems[0].SubItems[0].Text,
                                Paras = JsonConvert.SerializeObject(listView_ComponentList.SelectedItems[0].Tag)
                            }); ;
                            DB.SaveChanges();
                            break;
                        case OptionType.Project:
                            //父级层
                            var projectQuery = from r in DB.Projects where r.Solution.Name == SolutionName && r.Name == comboBox_OptionList.SelectedItem.ToString() select r;
                            Project project = projectQuery.FirstOrDefault();
                            if (project == null) //检测父级层是否存在
                            {
                                MessageBox.Show("父级层为空！");
                                return false;
                            }
                            //子级层
                            var projectListQuery = from r in DB.ProjectLists where r.Project.Solution.Name == SolutionName && r.Project.Name == comboBox_OptionList.SelectedItem.ToString() && r.Name == name select r;
                            ProjectList projectList = projectListQuery.FirstOrDefault();
                            if (projectList != null) //是否存在
                            {
                                MessageBox.Show("该项已存在！");
                                return false;
                            }
                            //追加数据
                            project.ProjectLists.Add(new ProjectList()
                            {
                                Name = name,
                                Component = listView_ComponentList.SelectedItems[0].SubItems[0].Text,
                                Paras = JsonConvert.SerializeObject(listView_ComponentList.SelectedItems[0].Tag)
                            }); ;
                            DB.SaveChanges();
                            break;
                        case OptionType.DataBase:
                            //父级层
                            var dataBaseQuery = from r in DB.DataBases where r.Solution.Name == SolutionName && r.Name == comboBox_OptionList.SelectedItem.ToString() select r;
                            DataBase dataBase = dataBaseQuery.FirstOrDefault();
                            if (dataBase == null) //检测父级层是否存在
                            {
                                MessageBox.Show("父级层为空！");
                                return false;
                            }
                            //子级层
                            var dataBaseListQuery = from r in DB.DataBaseLists where r.DataBase.Solution.Name == SolutionName && r.DataBase.Name == comboBox_OptionList.SelectedItem.ToString() && r.Name == name select r;
                            DataBaseList dataBaseList = dataBaseListQuery.FirstOrDefault();
                            if (dataBaseList != null) //是否存在
                            {
                                MessageBox.Show("该项已存在！");
                                return false;
                            }
                            //追加数据
                            dataBase.DataBaseLists.Add(new DataBaseList()
                            {
                                Name = name,
                                Component = listView_ComponentList.SelectedItems[0].SubItems[0].Text,
                                Paras = JsonConvert.SerializeObject(listView_ComponentList.SelectedItems[0].Tag)
                            }); ;
                            DB.SaveChanges();
                            break;
                        default:
                            MessageBox.Show("Option Error!");
                            return false;
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show("Option Error!");
                    return false;
                }
            }
            else//option添加
            {
                //检索分类
                if (Enum.TryParse<OptionType>(comboBox_Option.Text, out OptionType result))
                {
                    switch (result)
                    {
                        case OptionType.Plc:
                            var plcQuery = from r in DB.Plcs where r.Solution.Name == SolutionName && r.Name == name select r;
                            Plc plc = plcQuery.FirstOrDefault();
                            if (plc != null)//检测是否存在重复数据
                            {
                                MessageBox.Show("该项已存在！");
                                return false;
                            }
                            //追加数据
                            solution.Plcs.Add(new Plc()
                            {
                                Name = name,
                                Type = "Plc",
                            });
                            DB.SaveChanges();
                            return true;
                        case OptionType.Project:
                            var projectQuery = from r in DB.Projects where r.Solution.Name == SolutionName && r.Name == name select r;
                            Project project = projectQuery.FirstOrDefault();
                            if (project != null)//检测是否存在重复数据
                            {
                                MessageBox.Show("该项已存在！");
                                return false;
                            }
                            //追加数据
                            solution.Projects.Add(new Project()
                            {
                                Name = name,
                                Type = "Project",
                            });
                            DB.SaveChanges();
                            break;
                        case OptionType.DataBase:
                            var dataBaseQuery = from r in DB.DataBases where r.Solution.Name == SolutionName && r.Name == name select r;
                            DataBase dataBase = dataBaseQuery.FirstOrDefault();
                            if (dataBase != null)//检测是否存在重复数据
                            {
                                MessageBox.Show("该项已存在！");
                                return false;
                            }
                            //追加数据
                            solution.DataBases.Add(new DataBase()
                            {
                                Name = name,
                                Type = "DataBase",
                            });
                            DB.SaveChanges();
                            break;
                        default:
                            MessageBox.Show("Option Error!");
                            return false;
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show("Option Error!");
                    return false;
                }
            }
        }
        bool Differ_Option_OR_List = false;//false - option，true - optionlist
        /// <summary>
        /// 增加选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_AddOption_Click(object sender, EventArgs e)
        {
            //添加页面
            InputForm inputForm = new InputForm();
            inputForm.Confirm += Add;
            inputForm.ShowDialog();

            //刷新数据
            RefreshOptionInfo();
            InitialOptionComponentListView();
            RefreshComponent();

            //Type type = Type.GetType("EmguCVLibrary.Theories.CommonMethod");

            //Type type1 = Type.GetType("CommonLibrary.FormAndUser.AddForm");

            //SolutionData solution = new SolutionData()
            //{
            //    Name = SolutionName
            //};
            //for (int i = 0; i < 10; i++)//外层
            //{
            //    solution.Plc.Add(new PlcData()
            //    {
            //        Type = $"PlcType{i + 20}",
            //        Name = $"PlcName{i}"
            //    });
            //    solution.Project.Add(new ProjectData()
            //    {
            //        Type = $"ProjectType{i + 20}",
            //        Name = $"ProjectName{i}"
            //    });
            //    solution.DataBase.Add(new DataBaseData()
            //    {
            //        Type = $"DataBaseType{i + 20}",
            //        Name = $"DataBaseName{i}"
            //    });

            //    for (int j = 0; j < 10; j++)//内层
            //    {
            //        solution.Plc[i].PlcList.Add(new PlcListData()
            //        {
            //            Name = $"PlcListName{j}",
            //            Paras = $"PlcListParas{j + 10}",
            //            Component = $"PlcListComponent{j + 20}"
            //        });
            //        solution.DataBase[i].DataBaseList.Add(new DataBaseListData()
            //        {
            //            Name = $"DataBaseListName{j}",
            //            Paras = $"DataBaseListParas{j + 10}",
            //            Component = $"DataBaseListComponent{j + 20}"
            //        });
            //        solution.Project[i].ProjectList.Add(new ProjectListData()
            //        {
            //            Name = $"ProjectListName{j}",
            //            Paras = $"ProjectListParas{j + 10}",
            //            Component = $"ProjectListComponent{j + 20}"
            //        });
            //    }
            //}
            ////更新
            //DB.UpdateSolutionData(solution);

            //Mapper.Initialize(cfg => { cfg.CreateMap<SolutionData, Solution>(); });

            //Solution
            //var Solution = (from c in DB.Solutions where c.Name == solution.Name select c).FirstOrDefault();
            //if (Solution == null)//如果为空，则创建Solution
            //{
            //    Solution solution1 = AutoMapHelper.MapTo<SolutionData,Solution>(solution);
            //    DB.Solutions.Add(solution1);//追加Solution
            //    DB.SaveChanges();
            //    return;
            //}
            ////Project
            //var Proiquery = from r in Solution.Projects where r.Type == project.Type && r.Name == project.Name select r;
            //Project project1 = Proiquery.FirstOrDefault();
            //if (project1 == null)
            //{
            //    Solution.Projects.Add(AutoMapHelper.MapTo<Project>(project));
            //    DB.SaveChanges();
            //    return;
            //}
            ////projectList
            //var ProListiquery = from r in project1.ProjectLists where r.Name == projectList01.Name select r;
            //ProjectList projectList1 = ProListiquery.FirstOrDefault();
            //if (projectList1 == null)
            //{
            //    project1.ProjectLists.Add(AutoMapHelper.MapTo<ProjectList>(projectList01));
            //    DB.SaveChanges();
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

            //判断是否组件选项是否存在
            if (comboBox_OptionList.SelectedIndex < 0)
            {
                MessageBox.Show("请在选项列表选中相应选项！");
                return;
            }
            //删除组件
            if (DialogResult.No == MessageBox.Show("Delete the Option?", "Tip", MessageBoxButtons.YesNo))
                return;

            //检索分类
            if (Enum.TryParse<OptionType>(comboBox_Option.Text, out OptionType result))
            {
                string optionName = comboBox_OptionList.Text;//确认范围
                if (string.IsNullOrEmpty(optionName)) return;
                int id = 0;
                switch (result)
                {
                    case OptionType.Plc:
                        id = (from r in DB.Plcs where r.Solution.Name == SolutionName && r.Name == optionName select r.Id).FirstOrDefault();
                        var plc = from r in DB.Plcs where r.Id == id select r;
                        if (plc != null)
                        {
                            DB.Plcs.Remove(plc.FirstOrDefault());
                            DB.SaveChanges();
                        }
                        break;
                    case OptionType.Project:
                        id = (from r in DB.Projects where r.Solution.Name == SolutionName && r.Name == optionName select r.Id).FirstOrDefault();
                        var project = (from r in DB.Projects where r.Id == id select r).Single();
                        if (project != null)
                        {
                            foreach (var o in project.ProjectLists.ToList())
                            {
                                DB.ProjectLists.Remove(o);
                            }
                            DB.Projects.Remove(project);
                            DB.SaveChanges();
                        }
                        break;
                    case OptionType.DataBase:
                        id = (from r in DB.DataBases where r.Solution.Name == SolutionName && r.Name == optionName select r.Id).FirstOrDefault();
                        var dataBase = from r in DB.DataBases where r.Id == id select r;
                        if (dataBase != null)
                        {
                            DB.DataBases.Remove(dataBase.FirstOrDefault());
                            DB.SaveChanges();
                        }
                        break;
                    default:
                        break;
                }
            }

            //刷新数据
            RefreshOptionInfo();
            InitialOptionComponentListView();
            RefreshComponent();

            ////MessageBox.Show(comboBox_Option.SelectedValue.ToString());
            //ProjectList projectList01 = new ProjectList()
            //{
            //    Name = "Test",
            //    Paras = "Para",
            //    Component = "NewComponent"
            //};
            //Project project = new Project()
            //{
            //    Type = "project",
            //    Name = "Test",
            //};
            //Solution solution = new Solution()
            //{
            //    Name = "Test2"
            //};

            ////Solution
            //var Solution = (from c in DB.Solutions where c.Name == solution.Name select c).FirstOrDefault();
            //if (Solution == null)//如果为空，则创建Solution
            //{
            //    DB.Solutions.Add(solution);//追加Solution
            //    DB.SaveChanges();
            //    return;
            //}
            ////Project
            //var Proiquery = from r in Solution.Projects where r.Type == project.Type && r.Name == project.Name select r;
            //Project project1 = Proiquery.FirstOrDefault();
            //if (project1 == null)
            //{
            //    Solution.Projects.Add(project);
            //    DB.SaveChanges();
            //    return;
            //}
            ////projectList
            //var ProListiquery = from r in project1.ProjectLists where r.Name == projectList01.Name select r;
            //ProjectList projectList1 = ProListiquery.FirstOrDefault();
            //if (projectList1 == null)
            //{
            //    project1.ProjectLists.Add(projectList01);
            //    DB.SaveChanges();
            //    return;
            //}
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

        bool Sperate = false;//false - 组件lie参数显示，true - 组件列表参数
        /// <summary>
        /// 刷新组件参数
        /// </summary>
        /// <param name="item"></param>
        private void Set_ComponentPara(ListViewItem item)
        {
            //查找字段
            string component = "";
            if (Sperate)
            {
                component = item.SubItems[0].Text;
            }
            else
            {
                component = item.SubItems[2].Text;
            }
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
                            if (!Sperate) paramObj = JsonConvert.DeserializeObject((string)item.Tag, paramObj.GetType());
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
        }

        /// <summary>
        /// 刷新选项组件列表
        /// </summary>
        private void InitialOptionComponentListView()
        {
            //检索列表
            listView_OptionComponent.Items.Clear();
            if (string.IsNullOrEmpty(comboBox_OptionList.Text)) return;

            //提取检索ID
            int sortID = 0;

            //检索分类
            if (Enum.TryParse<OptionType>(comboBox_Option.Text, out OptionType result))
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
            Sperate = true;//置位标志
            try
            {
                if (e.IsSelected)
                {
                    ListViewItem item = e.Item;
                    Set_ComponentPara(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Sperate = false;//清除标志
            }
        }
        /// <summary>
        /// 添加选项list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_AddOptionComponent_Click(object sender, EventArgs e)
        {
            //判断是否组件选项是否存在
            if (comboBox_OptionList.SelectedIndex < 0)
            {
                MessageBox.Show("请在选项列表选中相应选项！");
                return;
            }
            //判断是否选定组件
            if (listView_ComponentList.SelectedItems.Count <= 0)
            {
                MessageBox.Show("请在组件列表选中相应组件！");
                return;
            }

            //置位标志
            Differ_Option_OR_List = true;
            //添加页面
            InputForm inputForm = new InputForm();
            inputForm.Confirm += Add;
            inputForm.ShowDialog();
            //清除标志
            Differ_Option_OR_List = false;
            //刷新数据
            RefreshOptionInfo();
            InitialOptionComponentListView();
            RefreshComponent();
        }
        /// <summary>
        /// 删除选项List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_DelOptionCOmponent_Click(object sender, EventArgs e)
        {
            //判断是否组件选项是否存在
            if (comboBox_OptionList.SelectedIndex < 0)
            {
                MessageBox.Show("请在选项列表选中相应选项！");
                return;
            }
            //判断是否选定组件
            if (listView_OptionComponent.SelectedItems.Count <= 0)
            {
                MessageBox.Show("请在选项组件选中相应组件！");
                return;
            }
            //删除组件
            if (DialogResult.No == MessageBox.Show("Delete the Component?", "Tip", MessageBoxButtons.YesNo))
                return;

            //检索分类
            if (Enum.TryParse<OptionType>(comboBox_Option.Text, out OptionType result))
            {
                if (!int.TryParse(listView_OptionComponent.SelectedItems[0].SubItems[0].Text, out int id))
                {
                    return;
                };
                switch (result)
                {
                    case OptionType.Plc:
                        var plcListQuery = from r in DB.PlcLists where r.Id == id select r;
                        DB.PlcLists.Remove(plcListQuery.FirstOrDefault());
                        DB.SaveChanges();
                        break;
                    case OptionType.Project:
                        var projectListQuery = from r in DB.ProjectLists where r.Id == id select r;
                        DB.ProjectLists.Remove(projectListQuery.FirstOrDefault());
                        DB.SaveChanges();
                        break;
                    case OptionType.DataBase:
                        var dataBaseListQuery = from r in DB.DataBaseLists where r.Id == id select r;
                        DB.DataBaseLists.Remove(dataBaseListQuery.FirstOrDefault());
                        DB.SaveChanges();
                        break;
                    default:
                        break;
                }
            }

            //刷新数据
            RefreshOptionInfo();
            InitialOptionComponentListView();
            RefreshComponent();
        }
        /// <summary>
        /// 选项修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView_OptionComponent_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                if (isPorpertyChanged)
                    SavePreStationConfig(e.Item);//切换选项保存参数

                if (e.IsSelected)
                {
                    ListViewItem item = e.Item;
                    Set_ComponentPara(item);
                    CurListViewItem = e.Item;//当前参数副本
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 参数属性值发生更改
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        private void PropertyGrid_Para_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (listView_OptionComponent.SelectedItems.Count <= 0) return;
            isPorpertyChanged = true;
        }
        private bool isPorpertyChanged = false;//属性值有没有发生更改
        private ListViewItem CurListViewItem = null;//参数list
        /// <summary>
        /// 保存参数
        /// </summary>
        /// <param name="item"></param>
        private void SavePreStationConfig(ListViewItem item)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show(this, "Would the configuration changed  be saved？", "Prompt Dialog Box", MessageBoxButtons.YesNo))
                {
                    item.Tag = JsonConvert.SerializeObject(propertyGrid_Para.SelectedObject);
                    if (!int.TryParse(item.SubItems[0].Text, out int id))
                    {
                        return;
                    }
                    //检索分类并保存修改
                    if (Enum.TryParse<OptionType>(comboBox_Option.Text, out OptionType result))
                    {
                        switch (result)
                        {
                            case OptionType.Plc:
                                var plcListQuery = from r in DB.PlcLists where r.Id == id select r;
                                var plclist = plcListQuery.FirstOrDefault();
                                if (plclist != null)
                                {
                                    plclist.Paras = (string)item.Tag;
                                    DB.SaveChanges();
                                }
                                break;
                            case OptionType.Project:
                                var projectListQuery = from r in DB.ProjectLists where r.Id == id select r;
                                var projectlist = projectListQuery.FirstOrDefault();
                                if (projectlist != null)
                                {
                                    projectlist.Paras = (string)item.Tag;
                                    DB.SaveChanges();
                                }
                                break;
                            case OptionType.DataBase:
                                var dataBaseListQuery = from r in DB.DataBaseLists where r.Id == id select r;
                                var dataBaselist = dataBaseListQuery.FirstOrDefault();
                                if (dataBaselist != null)
                                {
                                    dataBaselist.Paras = (string)item.Tag;
                                    DB.SaveChanges();
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                isPorpertyChanged = false;
            }
        }


        /// <summary>
        /// 保存参数按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (isPorpertyChanged)
            {
                SavePreStationConfig(CurListViewItem);
            }
            //窗口关闭完成
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        /// <summary>
        /// 退出窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
