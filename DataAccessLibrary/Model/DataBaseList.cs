//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

//第二部分
using System;
using System.Collections.Generic;

namespace DataAccessLibrary.Model
{
    public partial class DataBaseList
    {
        public int Id { get; set; }
        public int DataBaseId { get; set; }
        public string Name { get; set; }
        public string Paras { get; set; }
        public string Component { get; set; }
    
        public virtual DataBase DataBase { get; set; }
    }
}
