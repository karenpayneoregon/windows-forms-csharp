﻿
// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

using System.Linq;
using DataAnnotationsEntityFrameworkCoreDates.Data.Configurations;
using DataAnnotationsEntityFrameworkCoreDates.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace DataAnnotationsEntityFrameworkCoreDates.Data
{
    public partial class Context : Microsoft.EntityFrameworkCore.DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<Person1> Person1 { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<TimeTable> TimeTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(BuildConnection());
            }
        }

        private static string BuildConnection()
        {

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            var sections = configuration.GetSection("database").GetChildren().ToList();

            return
                $"Data Source={sections[1].Value};" +
                $"Initial Catalog={sections[0].Value};" +
                $"Integrated Security={sections[2].Value}";

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EventsConfiguration());
            modelBuilder.ApplyConfiguration(new SalesConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
