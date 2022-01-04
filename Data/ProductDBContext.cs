using Microsoft.EntityFrameworkCore;
using Midterm_Project_ASP_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm_Project_ASP_MVC.Data
{
    public class ProductDBContext :DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options)
            :base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
