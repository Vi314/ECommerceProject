using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetEcommerce.DAL.Context;
using NetECommerce.BLL.AbstractService;
using NetECommerce.Common;
using NetECommerce.Entity.Entity;
using NetECommerce.MVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NetECommerce.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;
        private readonly ProjectContext db;

        public HomeController(IProductService productService,ProjectContext context)
        {
            this.productService = productService;
            db = context;
        }

        public IActionResult Index()
        {
            ViewBag.Products = db.Products.ToList();
            return View();
        }


        public IActionResult AddToCart(int id)
        {

            Cart cartSession;

            if (SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "sepet") == null)
            {
                cartSession = new Cart();
            }
            else
            {
                cartSession = SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "sepet");
            }



            var product = db.Products.Find(id);

            CartItem cartItem = new CartItem();
            cartItem.Id = product.Id;
            cartItem.ProductName = product.ProductName;
            cartItem.UnitPrice = product.UnitPrice;

            cartSession.AddItem(cartItem);
            SessionHelper.SetSessionJson(HttpContext.Session, "sepet", cartSession);

            ViewData["ItemCount"] = Convert.ToInt32(cartSession._myCart.Count);
            return RedirectToAction("Index");
        }

        public IActionResult MyCart()
        {
            if (SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "sepet") != null)
            {
                var sepet = SessionHelper.GetProductFromJson<Cart>(HttpContext.Session, "sepet");
                ViewBag.Cart = sepet;
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
