using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M1Assignment1.Models;
using Microsoft.EntityFrameworkCore;

namespace M1Assignment1
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
            services.AddDbContext<LocalDbContext>(
                options=>options.UseSqlServer(Configuration.GetConnectionString("localDbStr")));
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddControllersWithViews();
            services.AddMvc();
            //services.AddSingleton<IInstructorsRepository, MockInstructorsRepository>();
            //services.AddSingleton<IStudentsRepository, MockStudentsRepository>();
            //services.AddSingleton<ICoursesRepository, MockCoursesRepository>();
            services.AddScoped<IInstructorsRepository, SQLInstructorsRepository>();
            services.AddScoped<IStudentsRepository, SQLStudentsRepository>();
            services.AddScoped<ICoursesRepository, SQLCoursesRepository>();
            services.AddScoped<IStudentsCoursesRepository, SQLStudentsCoursesRepository>();
            //services.AddScoped  services.AddSingleton services.AddTransient
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
