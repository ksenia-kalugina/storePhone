using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StorePhone.Data;
using StorePhone.Data.Interfaces;
using StorePhone.Data.Models;
using Microsoft.AspNetCore.SpaServices.Webpack;
using StorePhone.Data.Repository;
using System.IO;

namespace StorePhone
{
    public class Startup
    {
        private IConfigurationRoot _confsting;
        public Startup(IHostingEnvironment hostEnv)
        {
            _confsting = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("appsettings.json").Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContext>(option => option.UseSqlServer(_confsting.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllPhones, PhoneRepository>();
            services.AddTransient<IPhonesCategory, CategoryRepository>();
            services.AddTransient<IAllUsers, UserRepository>();


            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            ;

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => //CookieAuthenticationOptions
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
                });


            services.AddScoped(sp => StoreCart.GetCart(sp));
            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseSession();
            app.UseAuthentication();
            app.UseMvc();
            //app.UseMvcWithDefaultRoute();
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(name: "default", template: "{controller=Home}/{action=index}/{id?}");
            //    routes.MapRoute(name: "categoryFilter", template: "Phone/{action}/{category?}", defaults: new { Controller = "Phone", action = "List" });
            //});

            app.Run(async (context) =>
            {
                context.Response.ContentType = "text/html";
                await context.Response.SendFileAsync(Path.Combine(env.WebRootPath, "index.html"));
            });
            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContext content = scope.ServiceProvider.GetRequiredService<AppDBContext>();
                DBObjects.Initial(content);
            }

        }
    }
}
