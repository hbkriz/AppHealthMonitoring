﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Monitor.DomainDrivenDesign.Configurations
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            // Mapping for table
            builder.ToTable("Service", "dbo");

            // Set key for entity
            builder.HasKey(p => p.ServiceID);

            // Set identity for entity (auto increment)
            builder.Property(p => p.ServiceID).UseSqlServerIdentityColumn();
        }
    }
}
