using System;
using AOPSampleApp.Areas.Identity.Data;
using AOPSampleApp.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AOPSampleApp.Areas.Identity.IdentityHostingStartup))]
namespace AOPSampleApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AOPContent>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AOPContentConnection")));

                services.AddDefaultIdentity<AOPUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                })
                    .AddEntityFrameworkStores<AOPContent>();
            });
        }
    }
}