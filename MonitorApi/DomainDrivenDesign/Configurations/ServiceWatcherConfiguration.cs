﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Monitor.DomainDrivenDesign.Configurations
{
    public class ServiceWatcherConfiguration : IEntityTypeConfiguration<ServiceWatcher>
    {
        public void Configure(EntityTypeBuilder<ServiceWatcher> builder)
        {
            // Mapping for table
            builder.ToTable("ServiceWatcher", "dbo");

            // Set key for entity
            builder.HasKey(p => p.ServiceWatcherID);

            // Set identity for entity (auto increment)
            builder.Property(p => p.ServiceWatcherID).UseSqlServerIdentityColumn();
        }
    }
}
