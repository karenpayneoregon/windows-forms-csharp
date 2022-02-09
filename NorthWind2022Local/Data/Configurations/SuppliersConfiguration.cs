using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using NorthWind2022Local.Data;
using NorthWind2022Local.Models;
using System;

namespace NorthWind2022Local.Data.Configurations
{
    public partial class SuppliersConfiguration : IEntityTypeConfiguration<Suppliers>
    {
        public void Configure(EntityTypeBuilder<Suppliers> entity)
        {
            entity.HasKey(e => e.SupplierID);

            entity.Property(e => e.City).HasMaxLength(15);

            entity.Property(e => e.CompanyName)
                .IsRequired()
                .HasMaxLength(40);

            entity.Property(e => e.ContactName).HasMaxLength(30);

            entity.Property(e => e.ContactTitle).HasMaxLength(30);

            entity.Property(e => e.Fax).HasMaxLength(24);

            entity.Property(e => e.HomePage).HasColumnType("ntext");

            entity.Property(e => e.Phone).HasMaxLength(24);

            entity.Property(e => e.PostalCode).HasMaxLength(10);

            entity.Property(e => e.Region).HasMaxLength(15);

            entity.Property(e => e.Street).HasMaxLength(60);

            entity.HasOne(d => d.CountryIdentifierNavigation)
                .WithMany(p => p.Suppliers)
                .HasForeignKey(d => d.CountryIdentifier)
                .HasConstraintName("FK_Suppliers_Countries");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Suppliers> entity);
    }
}
