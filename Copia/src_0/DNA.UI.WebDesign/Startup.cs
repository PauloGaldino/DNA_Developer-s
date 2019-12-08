using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.Configuration;
using InfraData.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DNA.UI.WebDesign
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    
        public void ConfigureServices(IServiceCollection services)
        {

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //===================SQLSERVER=======================================
            services.AddDbContext<DbContexto>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            ////======================Mysql===========================================
            //services.AddDbContext<ApplicationDbContext>(options =>
            //   options.UseMySql(
            //       Configuration.GetConnectionString("DefaultConnection")));

            //services.AddDbContext<DbContextoGeral>(options =>
            //  options.UseMySql(
            //      Configuration.GetConnectionString("DefaultConnection")));


            //services.AddDbContext<DbContextoGeral>(options =>
            //  options.UseMySql(
            //      Configuration.GetConnectionString("DefaultConnection")));

            ////================Fim Mysql=========================================

      
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
