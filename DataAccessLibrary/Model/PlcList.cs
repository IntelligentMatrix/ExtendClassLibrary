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
    public partial class PlcList
    {
        public int Id { get; set; }
        public int PlcId { get; set; }
        public string Name { get; set; }
        public string Paras { get; set; }
        public string Component { get; set; }
    
        public virtual Plc Plc { get; set; }
    }
}
