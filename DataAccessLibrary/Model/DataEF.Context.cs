﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLibrary.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DataEFEntity : DbContext
    {
        public DataEFEntity()
            : base("name=DataEFEntity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CentralConfig> CentralConfigSet { get; set; }
        public virtual DbSet<HostContext> HostContextSet { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Solution> Solutions { get; set; }
        public virtual DbSet<Plc> Plcs { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<DataBase> DataBases { get; set; }
        public virtual DbSet<PlcList> PlcLists { get; set; }
        public virtual DbSet<ProjectList> ProjectLists { get; set; }
        public virtual DbSet<DataBaseList> DataBaseLists { get; set; }
    }
}
