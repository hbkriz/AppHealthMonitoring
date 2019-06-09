using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Monitor.BusinessLayer;
using Monitor.BusinessLayer.Contracts;
using Monitor.Controllers;
using Monitor.DomainDrivenDesign;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace Monitor
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // Loggers
            services.AddScoped<ILogger, Logger<BaseService>>();
            services.AddScoped<ILogger, Logger<DashboardController>>();
            services.AddScoped<ILogger, Logger<AdministrationController>>();

            // Services
            services.AddScoped<IDashboardService, DashboardService>();
            services.AddScoped<IAdministrationService, AdministrationService>();


            const string MonitorConnection = nameof(MonitorConnection);
            var connectionString = Configuration.GetConnectionString(MonitorConnection);
            services.AddDbContext<ServiceMonitorDbContext>(options => options.UseSqlServer(connectionString));

            services.AddSwaggerGen(action =>
               action.SwaggerDoc(Configuration["SwaggerInfo:Version"],
                   new Info
                   {
                       Title = Configuration["SwaggerInfo:ApplicationName"],
                       Version = Configuration["SwaggerInfo:Version"]
                   }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(action =>
            {
                action.RoutePrefix = "";
                action.SwaggerEndpoint($"/swagger/{Configuration["SwaggerInfo:Version"]}/swagger.json",
                    Configuration["SwaggerInfo:ApplicationName"]);
                action.DocExpansion(DocExpansion.None);
            });
        }
    }
}
