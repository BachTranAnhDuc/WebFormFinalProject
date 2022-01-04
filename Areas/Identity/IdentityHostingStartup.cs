using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Midterm_Project_ASP_MVC.Areas.Identity.Data;
using Midterm_Project_ASP_MVC.Data;

[assembly: HostingStartup(typeof(Midterm_Project_ASP_MVC.Areas.Identity.IdentityHostingStartup))]
namespace Midterm_Project_ASP_MVC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Midterm_Project_ASP_MVCContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Midterm_Project_ASP_MVCContextConnection")));

                services.AddDefaultIdentity<Midterm_Project_ASP_MVCUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<Midterm_Project_ASP_MVCContext>();
            });
        }
    }
}