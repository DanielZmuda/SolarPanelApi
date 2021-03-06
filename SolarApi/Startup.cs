using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.PvSystemBLL;
using DataAccess.DbContexts;
using DataAccess.PvSystemRepository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SolarApi
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
            services.AddScoped<IPvSystemRepository, PvSystemRepository>();
            services.AddScoped<IPvSystemRepositoryBLL, PvSystemRepositoryBLL>();
            services.AddScoped<IPvPanelRepository, PvPanelRepository>();
            services.AddScoped<IPvPanelRepositoryBLL, PvPanelRepositoryBLL>();
            services.AddScoped<IInverterRepositoryBLL, InverterRepositoryBLL>();
            services.AddScoped<IInvertersRepository, InvertersRepository>();
            services.AddDbContext<SolarInstalationDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("PvSystemDb"));
            });

            services.AddControllers().AddNewtonsoftJson();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
