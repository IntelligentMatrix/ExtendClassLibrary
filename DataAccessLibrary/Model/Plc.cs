//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

//第二部分
using System;
using System.Collections.Generic;

namespace DataAccessLibrary.Model
{
    public partial class Plc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plc()
        {
            this.PlcLists = new HashSet<PlcList>();
        }
    
        public int Id { get; set; }
        public int SolutionId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlcList> PlcLists { get; set; }
        public virtual Solution Solution { get; set; }
    }
}
