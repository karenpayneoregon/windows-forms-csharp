using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using NorthWind2022Local.Data;
using NorthWind2022Local.Models;
using System;

namespace NorthWind2022Local.Data.Configurations
{
    public partial class TerritoriesConfiguration : IEntityTypeConfiguration<Territories>
    {
        public void Configure(EntityTypeBuilder<Territories> entity)
        {
            entity.HasKey(e => e.TerritoryID)
                .IsClustered(false);

            entity.Property(e => e.TerritoryID).HasMaxLength(20);

            entity.Property(e => e.TerritoryDescription)
                .IsRequired()
                .HasMaxLength(50)
                .IsFixedLength(true);

            entity.HasOne(d => d.Region)
                .WithMany(p => p.Territories)
                .HasForeignKey(d => d.RegionID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Territories_Region");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Territories> entity);
    }
}
