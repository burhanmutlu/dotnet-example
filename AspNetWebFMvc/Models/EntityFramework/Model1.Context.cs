﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspNetWebFMvc.Models.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbMvcOkulEntities1 : DbContext
    {
        public DbMvcOkulEntities1()
            : base("name=DbMvcOkulEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_dersler> tbl_dersler { get; set; }
        public virtual DbSet<tbl_kulupler> tbl_kulupler { get; set; }
        public virtual DbSet<tbl_notlar> tbl_notlar { get; set; }
        public virtual DbSet<tbl_ogrenciler> tbl_ogrenciler { get; set; }
    }
}