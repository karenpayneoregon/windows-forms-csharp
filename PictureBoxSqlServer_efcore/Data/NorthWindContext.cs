﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PictureBoxSqlServer_efcore.Classes;
using PictureBoxSqlServer_efcore.Models;

#nullable disable

namespace PictureBoxSqlServer_efcore.Data
{
    public partial class NorthWindContext : DbContext
    {
        public NorthWindContext() { }
        public NorthWindContext(DbContextOptions<NorthWindContext> options) : base(options) { }
        public virtual DbSet<Categories> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Helper.ConnectionString());
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriesConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
