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
    public partial class DataBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DataBase()
        {
            this.DataBaseLists = new HashSet<DataBaseList>();
        }
    
        public int Id { get; set; }
        public int SolutionId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
    
        public virtual Solution Solution { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataBaseList> DataBaseLists { get; set; }
    }
}
