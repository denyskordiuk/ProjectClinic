using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.Models;
using Project.Models.Services;

namespace Project.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrdersDataManagement _service = new OrdersDataManagement();
        public OrdersController(IOrdersDataManagement service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var orders = _service.GetOrders();
            return View(orders);
        }
    }

}