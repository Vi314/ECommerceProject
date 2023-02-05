using Microsoft.AspNetCore.Mvc;
using NetECommerce.BLL.AbstractService;
using NetECommerce.Entity.Entity;
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




    }
}
