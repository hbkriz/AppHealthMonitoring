﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Monitor.DomainDrivenDesign.Configurations
{
    public class ServiceEnvironmentStatusConfiguration : IEntityTypeConfiguration<ServiceEnvironmentStatus>
    {
        public void Configure(EntityTypeBuilder<ServiceEnvironmentStatus> builder)
        {
            // Mapping for table
            builder.ToTable("ServiceEnvironmentStatus", "dbo");

            // Set key for entity
            builder.HasKey(p => p.ServiceEnvironmentStatusID);

            // Set identity for entity (auto increment)
            builder.Property(p => p.ServiceEnvironmentStatusID).UseSqlServerIdentityColumn();
        }
    }
}
