﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using app.Data;
using app.Models;
using app.Services;

namespace app
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
            // Database connection string.
            // Make sure to update the Password value below from "your_password" to your actual password.
            var connection = @"Server=db;Database=master;User=sa;Password=goes-here;";
            var prodConnection = @"Server=db;Database=Products;User=sa;Password=GVgjR3Wy4j7ZL*2Ay*keT6;";

            // This line uses 'UseSqlServer' in the 'options' parameter
            // with the connection string defined above.
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(connection));

            services.AddDbContext<ProductContext>(
                options => options.UseSqlServer(prodConnection));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddMvc();

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();
        }

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
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "products",
                    template: "{controller=Products}/{action=Index}/{id?}");

            });
        }
    }
}
