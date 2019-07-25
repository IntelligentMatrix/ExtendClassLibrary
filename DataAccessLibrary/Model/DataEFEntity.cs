using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Model;
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
        /// 更新Solution数据
        /// </summary>
        /// <param name="solutionData"></param>
        public void UpdateSolutionData(SolutionData solutionData)
        {
            //1、更新solution数据
            var solutionQuery = from r in Solutions where r.Name == solutionData.Name select r;
            Solution solution = solutionQuery.FirstOrDefault();
            if (solution == null)
            {
                Solutions.Add(new Model.Solution() { Name = solutionData.Name });
                solutionQuery = from r in Solutions where r.Name == solutionData.Name select r;
                solution = solutionQuery.FirstOrDefault();
            }
            //2、更新2层项内容


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
