using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmguCVLibrary.Theories;
using Newtonsoft.Json;
using AutoMapper;

namespace EmguCVLibrary
{
    public class TestClass
    {
        public string JsonStr = "";

        public string name = "";
        public int age { get; set; }
        public string address = "";
        //测试Json序列化
        public void TestJson()
        {
            User _Para = new User()
            {
                name = "HH",
                age = 10
            };
            JsonStr = JsonConvert.SerializeObject(_Para);
            MessageBox.Show(JsonStr);
        }
        //测试反序列化
        public void DeJson()
        {
            User _Para = JsonConvert.DeserializeObject<User>(JsonStr);
        }
        //mapper初始化
        public void IniMapper()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<User, TestClass>();
            });
        }
        //测试映射关系
        public void TestMap()
        {
            User _Para = new User()
            {
                name = "HH",
                age = 10
            };
            TestClass Tmp = Mapper.Map<User, TestClass>(_Para);
            Mapper.Map<User, TestClass>(_Para);
            string str = $"name:{name},age:{age},address:{address}";
            string Tmpstr = $"name:{Tmp.name},age:{Tmp.age},address:{Tmp.address}";
            MessageBox.Show(str);
            MessageBox.Show(Tmpstr);
        }
    }
    /// <summary>
    /// 类变量
    /// </summary>
    public class User
    {
        public string name { get; set; }
        public int age { get; set; }
    }

    //测试自动赋值类与类

}
