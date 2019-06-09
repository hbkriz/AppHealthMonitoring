﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Monitor.DomainDrivenDesign.Configurations
{
    public class ServiceOwnerConfiguration : IEntityTypeConfiguration<ServiceOwner>
    {
        public void Configure(EntityTypeBuilder<ServiceOwner> builder)
        {
            // Mapping for table
            builder.ToTable("ServiceOwner", "dbo");

            // Set key for entity
            builder.HasKey(p => p.ServiceOwnerID);

            // Set identity for entity (auto increment)
            builder.Property(p => p.ServiceOwnerID).UseSqlServerIdentityColumn();
        }
    }
}
