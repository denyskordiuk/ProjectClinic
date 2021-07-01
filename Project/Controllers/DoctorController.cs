using System;
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
    public class DoctorController : Controller
    {
        private readonly IDataManagement _service = new DataManagement();
        public IActionResult Index()
        {
            var doctors = _service.GetDoctors();
            return View(doctors);
        }

        public IActionResult Details(string license)
        {
            var doctor = _service.GetDoctor(license);
            return View(doctor);
        }
    }
}
