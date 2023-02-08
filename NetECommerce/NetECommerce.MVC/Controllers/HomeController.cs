using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetEcommerce.DAL.Context;
using NetECommerce.BLL.AbstractService;
using NetECommerce.Common;
using NetECommerce.Entity.Entity;
using NetECommerce.MVC.Models;
using NetECommerce.MVC.ViewModels.Identity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NetECommerce.MVC.Controllers
{
    public class HomeController : Controller
    {
        private IProductService productService;
        private ProjectContext db;
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signInManager;

        public HomeController(IProductService productService,
                              ProjectContext context,
                              UserManager<AppUser> userManager,
                              SignInManager<AppUser> signInManager)
        {
            db = context;
            this.productService = productService;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            ViewBag.Products = productService.GetAllProducts().ToList();
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                 AppUser newUser = new AppUser
                {
                    UserName = registerVM.Username,
                    Email = registerVM.Email,

                };
                var result = await userManager.CreateAsync(newUser, registerVM.ConfirmPassword);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(registerVM);
                }
            }
            else
            {
                return View(registerVM);
            }
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                AppUser login = await userManager.FindByEmailAsync(model.Email);
                if (login != null)
                {
                    var result = await signInManager.PasswordSignInAsync(login, model.Password, false, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(model);
                    }
                }
                else
                {
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
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

        #region Error - Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        } 
        #endregion
    }
}
