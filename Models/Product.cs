using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm_Project_ASP_MVC.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string Id { get; internal set; }
        [Required]
        public string Name { get; set; }
        public decimal FullPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public int PercentOff { get; set; }
        [Required]
        public string ImagePath { get; set; }
        public int StarRating { get; set; }
    }
}
