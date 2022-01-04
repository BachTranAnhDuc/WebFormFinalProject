using Microsoft.EntityFrameworkCore;
using Midterm_Project_ASP_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm_Project_ASP_MVC.Data
{
    public class ProdudctRubikDBContext : DbContext
    {
        public ProdudctRubikDBContext(DbContextOptions<ProdudctRubikDBContext> options)
            : base(options)
        {
        }
        public DbSet<prdRubik> prdRubiks { get; set; }
    }
}
