﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VetClinicApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBVetClinicaEntities : DbContext
    {
        public DBVetClinicaEntities()
            : base("name=DBVetClinicaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<TreatmentСase> TreatmentСase { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
