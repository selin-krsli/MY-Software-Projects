﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PortfolioProjectNight.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbMyPortfolioNightEntities1 : DbContext
    {
        public DbMyPortfolioNightEntities1()
            : base("name=DbMyPortfolioNightEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<About> About { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<Experience> Experience { get; set; }
        public virtual DbSet<Expertise> Expertise { get; set; }
        public virtual DbSet<Feature> Feature { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<SocialMedia> SocialMedia { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Trainee> Trainee { get; set; }
    }
}
