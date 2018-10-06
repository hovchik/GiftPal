using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftPalServer.DbContext;
using GiftPalServer.Hubs;
using GiftPalServer.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Models;
using NJsonSchema;
using NSwag.AspNetCore;

namespace GiftPalServer
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            var connection = @"Server=tcp:giftpal.database.windows.net,1433;Initial Catalog=GiftPal;Persist Security Info=False;User ID=giftpaladmin;Password=!QAZ2wsx;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            services.AddDbContext<GiftPalDbContext>(options => options.UseSqlServer(connection));
            services.AddSwagger();
            services.AddTransient<IUnitOfWork, UnitOfWorks>();
            services.AddSignalR();

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
                app.UseHsts();
            }
            app.UseSwaggerUi3WithApiExplorer(settings =>
            {
                settings.GeneratorSettings.DefaultPropertyNameHandling =
                    PropertyNameHandling.CamelCase;
            });
            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseSignalR(opt => opt.MapHub<NotificationHub>("notificationHub"));
        }
    }
}
