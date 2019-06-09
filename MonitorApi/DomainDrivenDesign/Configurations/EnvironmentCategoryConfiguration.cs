﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Monitor.DomainDrivenDesign.Configurations
{
    public class EnvironmentCategoryConfiguration : IEntityTypeConfiguration<EnvironmentCategory>
    {
        public void Configure(EntityTypeBuilder<EnvironmentCategory> builder)
        {
            // Mapping for table
            builder.ToTable("EnvironmentCategory", "dbo");

            // Set key for entity
            builder.HasKey(p => p.EnvironmentCategoryID);

            // Set identity for entity (auto increment)
            builder.Property(p => p.EnvironmentCategoryID).UseSqlServerIdentityColumn();
        }
    }
}
