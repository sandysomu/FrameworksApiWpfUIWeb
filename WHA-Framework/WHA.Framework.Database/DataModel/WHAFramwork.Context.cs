﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WHA.Framework.Database.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FrameworkDBEntities : DbContext
    {
        public FrameworkDBEntities()
            : base("name=FrameworkDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAccountName> tblAccountNames { get; set; }
        public virtual DbSet<tblBank> tblBanks { get; set; }
        public virtual DbSet<tblTransactionType> tblTransactionTypes { get; set; }
        public virtual DbSet<tblTransaction> tblTransactions { get; set; }
    }
}
