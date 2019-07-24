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

        #endregion
    }
}
