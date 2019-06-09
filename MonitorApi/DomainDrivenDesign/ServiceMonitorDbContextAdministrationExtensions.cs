﻿using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Monitor.DomainDrivenDesign
{
    public static class ServiceMonitorDbContextAdministrationExtensions
    {
        public static async Task<ServiceEnvironmentStatus> GetByServiceEnvironmentAsync(this ServiceMonitorDbContext dbContext, ServiceEnvironment entity)
            => await dbContext.ServiceEnvironmentStatuses.FirstOrDefaultAsync(item => item.ServiceEnvironmentID == entity.ServiceEnvironmentID);
    }
}
