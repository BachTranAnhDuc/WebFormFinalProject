using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Midterm_Project_ASP_MVC.Data;
using Midterm_Project_ASP_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Midterm_Project_ASP_MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProdudctRubikDBContext _db;

        public ProductController(ProdudctRubikDBContext db)
        {
            _db = db;
        }

        public IActionResult Payment()
        {
            return View();
        }

        public IActionResult Finish()
        {
            return View();
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View(await _db.prdRubiks.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Detail(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _db.prdRubiks
                .FirstOrDefaultAsync(m => String.Equals(m.Id, id));
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        //GET ALL PRODUCT
        public List<prdRubik> getAllProduct()
        {
            return _db.prdRubiks.ToList();
        }


        //GET DETAIL PRODUCT

        public prdRubik getDetailProduct(string id)
        {
            var product = _db.prdRubiks.Find(id);
            return product;
        }

        // Cart
        public IActionResult addCart(string id)
        {
            var cart = HttpContext.Session.GetString("cart");//get key cart
            if (cart == null)
            {
                var product = getDetailProduct(id);
                List<CartItem> listCart = new List<CartItem>()
               {
                   new CartItem
                   {
                       prdRubiks = product,
                       quantity = 1
                   }
               };
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));

            }
            else
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                bool check = true;
                for (int i = 0; i < dataCart.Count; i++)
                {
                    if (dataCart[i].prdRubiks.Id == id)
                    {
                        dataCart[i].quantity++;
                        check = false;
                    }
                }
                if (check)
                {
                    dataCart.Add(new CartItem
                    {
                        prdRubiks = getDetailProduct(id),
                        quantity = 1
                    });
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                // var cart2 = HttpContext.Session.GetString("cart");//get key cart
                //  return Json(cart2);
            }

            return RedirectToAction(nameof(Index));

        }

        public IActionResult ListCart()
        {
            var cart = HttpContext.Session.GetString("cart");//get key cart
            if (cart != null)
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    return View();
                }
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult updateCart(string id, int quantity)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                if (quantity > 0)
                {
                    for (int i = 0; i < dataCart.Count; i++)
                    {
                        if (dataCart[i].prdRubiks.Id == id)
                        {
                            dataCart[i].quantity = quantity;
                        }
                    }


                    HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                }
                var cart2 = HttpContext.Session.GetString("cart");
                return Ok(quantity);
            }
            return BadRequest();

        }

        public IActionResult deleteCart(string id)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<CartItem> dataCart = JsonConvert.DeserializeObject<List<CartItem>>(cart);

                for (int i = 0; i < dataCart.Count; i++)
                {
                    if (dataCart[i].prdRubiks.Id == id)
                    {
                        dataCart.RemoveAt(i);
                    }
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                return RedirectToAction(nameof(ListCart));
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
