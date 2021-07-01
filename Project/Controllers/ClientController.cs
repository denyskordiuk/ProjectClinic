using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.Models;
using Project.Models.Services;

namespace Project.Controllers
{
    public class ClientController : Controller
    {
        private readonly ICommonDataManagement _service;

        public ClientController(ICommonDataManagement service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var client = _service.GetClients();
            return Json(client);
            //return View();
        }
    }
}