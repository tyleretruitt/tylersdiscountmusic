﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCShoppingData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MVCShoppingCartEntities : DbContext
    {
        public MVCShoppingCartEntities()
            : base("name=MVCShoppingCartEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MVCCategory> MVCCategories { get; set; }
        public virtual DbSet<MVCProduct> MVCProducts { get; set; }
        public virtual DbSet<MVCStatus> MVCStatuses { get; set; }
        public virtual DbSet<MVCVendor> MVCVendors { get; set; }
    }
}