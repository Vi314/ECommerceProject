using Microsoft.AspNetCore.Mvc;
using NetECommerce.BLL.AbstractService;
using NetECommerce.Entity.Entity;
using NetECommerce.MVC.Areas.Dashboard.ViewModels;
using System.Linq;

namespace NetECommerce.MVC.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View(_orderService.GetAllOrders().ToList());
        }

        public IActionResult Update(int id)
        {
            return View(_orderService.FindOrder(id));
        }
        [HttpPost]
        public IActionResult Update(Order order)
        {
            var updateResult = _orderService.UpdateOrder(order);
            TempData["Result"] = updateResult;
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var deleteResult = _orderService.DeleteOrder(_orderService.FindOrder(id));
            TempData["Result"] = deleteResult;
            return RedirectToAction("Index");
        }

    }
}
