using Microsoft.AspNetCore.Mvc;
using NetECommerce.BLL.AbstractService;
using NetECommerce.BLL.Service;
using NetECommerce.Entity.Entity;
using NetECommerce.MVC.Areas.Dashboard.ViewModels;
using System.Linq;
using System.Net;

namespace NetECommerce.MVC.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class SupplierController : Controller
    {
        private readonly ISupplierService _supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        public IActionResult Index()
        {
            return View(_supplierService.GetAllSuppliers().ToList());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SupplierVM supplierVM)
        {
            if (ModelState.IsValid)
            {
                Supplier supplier = new Supplier
                {
                    CompanyName = supplierVM.CompanyName,
                    ContactTitle = supplierVM.ContactTitle,
                    ContactNumber = supplierVM.ContactNumber,
                    Address = supplierVM.Address,
                    City = supplierVM.City,
                    Region = supplierVM.Region,
                    PostalCode = supplierVM.PostalCode,
                    Country = supplierVM.Country
                };
                TempData["result"] = _supplierService.CreateSupplier(supplier);

                return RedirectToAction("Index");
            }
            else
            {
                return View(supplierVM);
            }
        }

        public IActionResult Delete(int id)
        {
            var deleted = _supplierService.FindSupplier(id);

            if (deleted != null)
            {
                TempData["result"] = _supplierService.DeleteSupplier(deleted);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            return View(_supplierService.FindSupplier(id));
        }
        [HttpPost]
        public IActionResult Update(Supplier updatedSupplier)
        {
            TempData["result"] = _supplierService.UpdateSupplier(updatedSupplier);
            return RedirectToAction("Index");
        }
    }
}
