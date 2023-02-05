using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NetECommerce.BLL.AbstractService;
using NetECommerce.Common;
using NetECommerce.Entity.Entity;
using NetECommerce.MVC.Areas.Dashboard.ViewModels;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NetECommerce.MVC.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class ProductController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly ISupplierService _supplierService;

        public ProductController(ICategoryService categoryService,IProductService productService,ISupplierService supplierService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _supplierService = supplierService;
        }

        public IActionResult Index()
        {
            ViewBag.Categories = _categoryService.GetAllCategorys().ToList();
            ViewBag.Suppliers = _supplierService.GetAllSuppliers().ToList();
            return View(_productService.GetAllProducts().ToList());
        }

        public IActionResult Create()
        {

            //SelectListItem => Mvc tarafında bize teslim edilen SelectListItem view içerinde oluşturmuş olduğumuz <select></select> etiketi içerisinde selectlist oluşturmamıza olanak sağlayan bir sınıftır.
            ViewBag.Categories = _categoryService.GetAllCategorys().Select(x => new SelectListItem()
            {
                Text = x.CategoryName,
                Value = x.Id.ToString()
            });
            ViewBag.Suppliers = _supplierService.GetAllSuppliers().Select(x => new SelectListItem()
            {
                Text = x.CompanyName,
                Value = x.Id.ToString()
            });


            return View();
        }

        public IActionResult Delete(int id)
        {
            var deleted = _productService.FindProduct(id);

            if (deleted != null)
            {
                TempData["result"] = _productService.DeleteProduct(deleted);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public  async Task<IActionResult> Create(ProductVM productVM,IFormFile ImagePath)//
        {
            if (ImagePath != null)
            {
                string path = "";

                var imageResult = ImageUploader.ImageChangeName(ImagePath.FileName);

                if (imageResult != "1")
                {
                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\product", imageResult);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await ImagePath.CopyToAsync(stream);
                    }
                    productVM.ImagePath = imageResult;


                }
                else
                {
                    TempData["result"] = "format uymuyor!";
                    return View();
                }
            }
            //ImageUploader

            Product product = new Product
            {
                ProductName = productVM.ProductName,
                UnitPrice = productVM.UnitPrice,
                UnitsInStock = productVM.UnitsInStock,
                CategoryId = productVM.CategoryId,
                Description = productVM.Description,
                ImagePath=productVM.ImagePath,
                SupplierId=productVM.SupplierId
            };

           TempData["result"]= _productService.CreateProduct(product);

            return RedirectToAction("Index");
        }


        public IActionResult Update(int Id)
         {
            ViewBag.Categories = _categoryService.GetAllCategorys().Select(x => new SelectListItem()
            {
                Text = x.CategoryName,
                Value = x.Id.ToString()
            }) ;
            Product product = _productService.FindProduct(Id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product product, IFormFile ImagePath,string categoryName)
        {
            product.Status = Entity.Enum.Status.Updated;   
            _productService.UpdateProduct(product);

            return RedirectToAction("Index");
        }
    }
}
