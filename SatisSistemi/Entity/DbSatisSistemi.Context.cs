﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SatisSistemi.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbmusteriEntities : DbContext
    {
        public dbmusteriEntities()
            : base("name=dbmusteriEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblkasa> tblkasa { get; set; }
        public virtual DbSet<tblmusteri> tblmusteri { get; set; }
        public virtual DbSet<tblmusteriborc> tblmusteriborc { get; set; }
        public virtual DbSet<tblodeme> tblodeme { get; set; }
        public virtual DbSet<tblolcutler> tblolcutler { get; set; }
        public virtual DbSet<tblpersonel> tblpersonel { get; set; }
        public virtual DbSet<tblsatis> tblsatis { get; set; }
        public virtual DbSet<tblsatisdetay> tblsatisdetay { get; set; }
        public virtual DbSet<tblurun> tblurun { get; set; }
        public virtual DbSet<tblusers> tblusers { get; set; }
    }
}
