﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PraktikumAB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KontaktiRaamatEntities : DbContext
    {
        public KontaktiRaamatEntities()
            : base("name=KontaktiRaamatEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Inimesed> Inimesed { get; set; }
        public virtual DbSet<KontaktiTyyp> KontaktiTyyp { get; set; }
        public virtual DbSet<Kontaktid> Kontaktid { get; set; }
    }
}
