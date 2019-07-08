using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Hurtownia.Data;
using Hurtownia.Data.Migrations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace Hurtownia.Api
{
    public class Startup
    {
        private IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<HurtowniaDbContext>(options => options
                .UseMySQL(Configuration.GetConnectionString("HurtowniaDbContext")));
            services.AddTransient<DatabaseSeed>();

            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            }).AddFluentValidation();

            

        }

        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<HurtowniaDbContext>();
                var databaseSeed = serviceScope.ServiceProvider.GetRequiredService<DatabaseSeed>();
                //var databaseSeed = new DatabaseSeed(context);
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                databaseSeed.Seed();
            }


            if (env.IsDevelopment())
            {
                    app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.Run(async (context) => { await context.Response.WriteAsync("Hurtownia API"); });
            
        }
    }
}