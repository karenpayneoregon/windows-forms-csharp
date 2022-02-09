﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using NorthWind2022Local.Data;
using NorthWind2022Local.Models;
using System;

namespace NorthWind2022Local.Data.Configurations
{
    public partial class RegionConfiguration : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> entity)
        {
            entity.HasKey(e => e.RegionID)
                .IsClustered(false);

            entity.Property(e => e.RegionID).ValueGeneratedNever();

            entity.Property(e => e.RegionDescription)
                .IsRequired()
                .HasMaxLength(50)
                .IsFixedLength(true);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Region> entity);
    }
}
