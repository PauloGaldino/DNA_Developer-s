using InfraData.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;

namespace DNA_UI.WebDesign
{
    public class Startup
    {
        //private Container container = new Container();
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //===================SQLSERVER=======================================
            //services.AddDbContext<DbContexto>(options =>
            //    options.UseSqlServer(
            //        Configuration.GetConnectionString("DefaultConnection")));

            ////======================Mysql===========================================
            services.AddDbContext<DbContexto>(options =>
               options.UseMySql(
                   Configuration.GetConnectionString("DefaultConnection")));


            ////================Fim Mysql=========================================


            services.AddMvc();
        }

        /// <summary>
        /// https://simpleinjector.readthedocs.io/en/latest/aspnetintegration.html
        /// https://github.com/simpleinjector/SimpleInjector/blob/master/src/SimpleInjector.Integration.AspNetCore.Mvc.Core/SimpleInjectorControllerActivator.cs
        /// </summary>
        /// <param name="services"></param>
        /// 
     

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                      name: "default",
                      template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
       
    }
}

