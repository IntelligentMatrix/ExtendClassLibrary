using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DataAccessLibrary.Model;
using MyLibrary;
namespace DataAccessLibrary.Model
{
    public partial class DataEFEntity
    {

        /// <summary>
        /// 检验登陆用户
        /// </summary>
        /// <param name="user">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public bool ValidateApplicationUser(string user, string password)
        {
            return (
                (from u in Users
                 where u.Name == user && u.Password == password
                 select u).Count() == 1
                       );
        }
        /// <summary>
        /// 判断用户是否Admin
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool IsUserAdmin(string user)
        {
            var q = from s in Users where s.Name == user select s;
            if (q != null)
                return q.FirstOrDefault().IsAdmin;
            else
                return false;
        }

        #region 封装常用功能
        /// <summary>
        /// 获取选项类型
        /// </summary>
        /// <returns></returns>
        public List<string> GetOptionType()
        {
            return (from c in OptionTypes select c.Type).ToList();
        }
        /// <summary>
        /// 获取Plc 名
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listName"></param>
        /// <returns></returns>
        public List<Plc> GetPlc(string listName)
        {
            return (from c in Plcs
                    where c.Type == listName
                    select c)
                    .ToList();
        }
        /// <summary>
        /// 获取Project
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listName"></param>
        /// <returns></returns>
        public List<Project> GetProject(string listName)
        {
            return (from c in Projects
                    where c.Type == listName
                    select c)
                    .ToList();
        }
        /// <summary>
        /// 获取DataBase
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listName"></param>
        /// <returns></returns>
        public List<DataBase> GetDataBase(string listName)
        {
            return (from c in DataBases
                    where c.Type == listName
                    select c)
                    .ToList();
        }
        #endregion
        /// <summary>
        /// 添加/更新Solution数据
        /// </summary>
        /// <param name="solutionData"></param>
        public void UpdateSolutionData(SolutionData solutionData)
        {
            //1、更新solution数据
            var solutionQuery = from r in Solutions where r.Name == solutionData.Name select r;
            Solution solution = solutionQuery.FirstOrDefault();
            if (solution == null)
            {
                Solutions.Add(AutoMapHelper.MapTo<Solution>(solutionData));
                this.SaveChanges();
                Thread.Sleep(20);
                solutionQuery = from r in Solutions where r.Name == solutionData.Name select r;
                solution = solutionQuery.FirstOrDefault();
            }
            //2、更新2层项内容
            if (solutionData.Plc.Count >0)//PLC模块数据
            {
                foreach (var o in solutionData.Plc)
                {
                    var plcQuery = from r in solution.Plcs where r.Name == o.Name select r;
                    Plc plc = plcQuery.FirstOrDefault();

                    //添加或更新
                    if (plc != null)
                    {
                        //更新数据
                        plc.Type = o.Type;
                        plc.Name = o.Name;
                        //更新3层数据
                        if (o.PlcList.Count > 0)
                        {
                            foreach (var p in o.PlcList)
                            {
                                var plcListQuery = from r in plc.PlcLists
                                                   where r.Name == p.Name
                                                   select r;
                                var plcList = plcListQuery.FirstOrDefault();
                                if (plcList != null)//数据存在，则更新(本层更新)
                                {
                                    plcList.Name = p.Name;
                                    plcList.Paras = p.Paras;
                                    plcList.Component = p.Component;
                                }
                                else//数据不存在，则添加(上一层添加)
                                {
                                    plc.PlcLists.Add(AutoMapHelper.MapTo<PlcList>(p));
                                }
                            }
                        }
                    }
                    else
                    {
                        //追加父级
                        solution.Plcs.Add(AutoMapHelper.MapTo<Plc>(o));
                        this.SaveChanges();
                        Thread.Sleep(20);
                        plcQuery = from r in solution.Plcs where r.Name == o.Name select r;
                        plc = plcQuery.FirstOrDefault();
                        //添加子集
                        if (o.PlcList.Count > 0)
                        {
                            foreach (var p in o.PlcList)
                            {
                                var plcListQuery = from r in plc.PlcLists
                                                   where r.Name == p.Name
                                                   select r;
                                var plcList = plcListQuery.FirstOrDefault();
                                if (plcList != null)//数据存在，则更新(本层更新)
                                {
                                    plcList.Name = p.Name;
                                    plcList.Paras = p.Paras;
                                    plcList.Component = p.Component;
                                }
                                else//数据不存在，则添加(上一层添加)
                                {
                                    plc.PlcLists.Add(AutoMapHelper.MapTo<PlcList>(p));
                                }
                            }
                        }
                    }
                }
            }
            if (solutionData.Project.Count > 0)//Project模块数据
            {
                foreach (var o in solutionData.Project)
                {
                    var projectQuery = from r in solution.Projects where r.Name == o.Name select r;
                    Project project = projectQuery.FirstOrDefault();
                    //添加或更新
                    if (project != null)
                    {
                        //更新数据
                        project.Type = o.Type;
                        project.Name = o.Name;
                        //更新3层数据
                        if (o.ProjectList.Count > 0)
                        {
                            foreach (var p in o.ProjectList)
                            {
                                var projectListQuery = from r in project.ProjectLists
                                                       where r.Name == p.Name
                                                       select r;
                                var projectList = projectListQuery.FirstOrDefault();
                                if (projectList != null)//数据存在，则更新(本层更新)
                                {
                                    projectList.Name = p.Name;
                                    projectList.Paras = p.Paras;
                                    projectList.Component = p.Component;
                                }
                                else//数据不存在，则添加(上一层添加)
                                {
                                    project.ProjectLists.Add(AutoMapHelper.MapTo<ProjectList>(p));
                                }
                            }
                        }
                    }
                    else
                    {
                        //追加父级
                        solution.Projects.Add(AutoMapHelper.MapTo<Project>(o));
                        this.SaveChanges();
                        Thread.Sleep(20);
                        projectQuery = from r in solution.Projects where r.Name == o.Name select r;
                        project = projectQuery.FirstOrDefault();
                        //添加子集
                        if (o.ProjectList.Count > 0)
                        {
                            foreach (var p in o.ProjectList)
                            {
                                var projectListQuery = from r in project.ProjectLists
                                                       where r.Name == p.Name
                                                       select r;
                                var projectList = projectListQuery.FirstOrDefault();
                                if (projectList != null)//数据存在，则更新(本层更新)
                                {
                                    projectList.Name = p.Name;
                                    projectList.Paras = p.Paras;
                                    projectList.Component = p.Component;
                                }
                                else//数据不存在，则添加(上一层添加)
                                {
                                    project.ProjectLists.Add(AutoMapHelper.MapTo<ProjectList>(p));
                                }
                            }
                        }
                    }
                }
            }
            if (solutionData.DataBase.Count > 0)//DatatBase模块数据
            {
                foreach (var o in solutionData.DataBase)
                {
                    var dataBaseQuery = from r in solution.DataBases where r.Name == o.Name select r;
                    DataBase dataBase = dataBaseQuery.FirstOrDefault();
                    //添加或更新
                    if (dataBase != null)
                    {
                        //更新数据
                        dataBase.Type = o.Type;
                        dataBase.Name = o.Name;
                        //更新3层数据
                        if (o.DataBaseList.Count > 0)
                        {
                            foreach (var p in o.DataBaseList)
                            {
                                var dataBaseListQuery = from r in dataBase.DataBaseLists
                                                        where r.Name == p.Name
                                                        select r;
                                var dataBaseList = dataBaseListQuery.FirstOrDefault();
                                if (dataBaseList != null)//数据存在，则更新(本层更新)
                                {
                                    dataBaseList.Name = p.Name;
                                    dataBaseList.Paras = p.Paras;
                                    dataBaseList.Component = p.Component;
                                }
                                else//数据不存在，则添加(上一层添加)
                                {
                                    dataBase.DataBaseLists.Add(AutoMapHelper.MapTo<DataBaseList>(p));
                                }

                            }
                        }
                    }
                    else
                    {
                        //追加父级
                        solution.DataBases.Add(AutoMapHelper.MapTo<DataBase>(o));
                        this.SaveChanges();
                        Thread.Sleep(20);
                        dataBaseQuery = from r in solution.DataBases where r.Name == o.Name select r;
                        dataBase = dataBaseQuery.FirstOrDefault();
                        //添加子集
                        if (o.DataBaseList.Count > 0)
                        {
                            foreach (var p in o.DataBaseList)
                            {
                                var dataBaseListQuery = from r in dataBase.DataBaseLists
                                                        where r.Name == p.Name
                                                        select r;
                                var dataBaseList = dataBaseListQuery.FirstOrDefault();
                                if (dataBaseList != null)//数据存在，则更新(本层更新)
                                {
                                    dataBaseList.Name = p.Name;
                                    dataBaseList.Paras = p.Paras;
                                    dataBaseList.Component = p.Component;
                                }
                                else//数据不存在，则添加(上一层添加)
                                {
                                    dataBase.DataBaseLists.Add(AutoMapHelper.MapTo<DataBaseList>(p));
                                }
                            }
                        }
                    }
                }
            }
            //3、保存修改到数据库
            this.SaveChangesAsync();
        }
        /// <summary>
        /// 拆分solution
        /// </summary>
        /// <param name="solutionData"></param>
        /// <returns></returns>
        public Solution Solution(SolutionData solutionData)
        {
            return new Solution()
            {
                Name = solutionData.Name
            };
        }
    }
}
