﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Contoso.Models;
using Microsoft.AspNetCore.Identity;

namespace Contoso
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            var connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Contoso;Integrated Security=True;Connect Timeout=30;";
            services.AddDbContext<ContosoContext>(options => options.UseSqlServer(connection));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ContosoContext>()
                .AddDefaultTokenProviders();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvcWithDefaultRoute();
            app.UseIdentity();

           /*
            app.UseMvc(
                routes =>
                {
                    routes
                    .MapRoute("Default", "{Controller=Home}/{Action=Index}/{id?}")
                    .MapRoute("Members", "Members/{controller=MemberHome}/{action=Index}/{id?}");
                }
            );
            */

            //app.UseMvc();

            /*
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello Universe!");
            });
            */
        }
    }
}
