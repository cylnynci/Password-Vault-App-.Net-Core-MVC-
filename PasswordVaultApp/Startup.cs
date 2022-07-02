
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Session;

namespace PasswordVaultApp
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
            services.AddSession();
            services.AddHttpContextAccessor();


            services.AddMvc(options => options.EnableEndpointRouting = false);

            services.AddMvc();
              services.AddEntityFrameworkNpgsql().AddDbContext<Context>(opt =>
                  opt.UseNpgsql(Configuration.GetConnectionString("MyWebApiConnection")));
                  //services.AddControllersWithViews();

            services.AddMvc();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie(options =>
                    {
                        options.LoginPath = "/Account/Login/";
                    });
            services.AddDistributedMemoryCache();
            

            //services.AddMvc();
            //services.AddDbContext<Context>(opt=>
            //    opt.UseNpgsql(Configuration.GetConnectionString("MyWebApiConnection")));
            //services.AddControllersWithViews();

            services.AddScoped<IUserService, UserService>();

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

            /*app.UseStaticFiles();  */ //wwwroot klasörü içindeki herþey(css,js,images vs.) web tarayýcýsý tarafýndan eriþime açýlmýþ oluyor.

            //Controller/Action veya Home/Index  (Varsayýlan olarak bir Route ekliyoruz.)
            //app.UseMvc(routes =>    //app.UseMvcWithDefaultRoute() alternatif olarak kullanýlabilir.(Hazýr metot)
            //{
            //    routes.MapRoute(
            //        name: "Default",
            //        template: "{controller=Home}/{action=Index}/{id?}");  //id-->optional(isteðe baðlý)  //Default deðerler
            //});

            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseAuthentication();

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