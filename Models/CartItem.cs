using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm_Project_ASP_MVC.Models
{
    public class CartItem
    {
        public int quantity { set; get; }
        public prdRubik prdRubiks { set; get; }
    }
}
