using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Midterm_Project_ASP_MVC.Areas.Identity.Data;

namespace Midterm_Project_ASP_MVC.Data
{
    public class Midterm_Project_ASP_MVCContext : IdentityDbContext<Midterm_Project_ASP_MVCUser>
    {
        public Midterm_Project_ASP_MVCContext(DbContextOptions<Midterm_Project_ASP_MVCContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}