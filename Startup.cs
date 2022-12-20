using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JemakEadPro.Data;
using JemakEadPro.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace JemakEadPro
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddControllersWithViews();

            services.AddDbContext<JemakEadProContext>(
                //options => options.UseMySql("Data Source=localhost;Database=jemakeadpro;Uid=root;Pwd=root")
                options => options.UseMySql("Data Source=a2nlmysql29plsk.secureserver.net;Database=jemak;Uid=erickcred;Pwd=Jessica12@")
            );


            // services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            // services.AddMemoryCache();
            // services.AddSession();


            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, option =>
                {
                    option.Cookie.Name = "Usuario";
                    option.LoginPath = new PathString("/login");
                });

            services.AddAuthorization(option =>
            {
                option.AddPolicy("Administrador", policy => policy.RequireRole("Administrador"));
                option.AddPolicy("Aluno", policy => policy.RequireRole("Aluno"));
            });


            // services.AddIdentity<IdentityUser, IdentityRole>(options =>
            // {
                // options.Password.RequireDigit = false;
                // options.Password.RequiredLength = 6;
                // options.Password.RequireNonAlphanumeric = false;
                // options.Password.RequireUppercase = false;
                
            // });
                // .AddDefaultTokenProviders();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            // app.UseSession();

            app.UseAuthentication();
            app.UseAuthorization();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        
    }
}
