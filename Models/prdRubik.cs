using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm_Project_ASP_MVC.Models
{
    public class prdRubik
    {
        [Key]
        public string Id { get; set; }

        public string Maker { get; set; }
        public string img { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Ratings { get; set; }
    }
}
