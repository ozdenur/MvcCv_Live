﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCv.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBCvEntities3 : DbContext
    {
        public DBCvEntities3()
            : base("name=DBCvEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TblAdmin> TblAdmin { get; set; }
        public virtual DbSet<TblDeneyimlerim> TblDeneyimlerim { get; set; }
        public virtual DbSet<TblEgitimlerim> TblEgitimlerim { get; set; }
        public virtual DbSet<TblHakkimda> TblHakkimda { get; set; }
        public virtual DbSet<TblHobilerim> TblHobilerim { get; set; }
        public virtual DbSet<Tbliletsim> Tbliletsim { get; set; }
        public virtual DbSet<TblSertifaklarım> TblSertifaklarım { get; set; }
        public virtual DbSet<TblYeteneklerim> TblYeteneklerim { get; set; }
    }
}
