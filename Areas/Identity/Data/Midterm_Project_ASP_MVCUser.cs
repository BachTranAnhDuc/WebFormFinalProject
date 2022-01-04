using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Midterm_Project_ASP_MVC.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the Midterm_Project_ASP_MVCUser class
    public class Midterm_Project_ASP_MVCUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }


        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
    }
}