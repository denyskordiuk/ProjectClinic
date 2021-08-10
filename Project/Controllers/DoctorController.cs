using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.Models;
using Project.Models.Entities;
using Project.Models.Services;

namespace Project.Controllers
{
    public class DoctorController : Controller
    {
        private readonly ICommonDataManagement _service = new CommonDataManagement();

        public DoctorController(ICommonDataManagement service)
        {
            _service = service;
        }

        public IActionResult Index(string DoctorLicense, string DoctorName)
        {
            var doctors = _service.GetDoctors(doctorLicense: DoctorLicense, doctorName: DoctorName);
            return View(doctors);
        }

        public IActionResult Details(string id)
        {
            var doctor = _service.GetDoctor(id);
            return View(doctor);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Doctor model)
        {
            if (ModelState.IsValid)
            {
                _service.AddDoctor(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Edit(string id)
        {
            var doctor = _service.GetDoctor(id);

            if (doctor is null)
            {
                throw new Exception($"Doctor with license {id} not found");
            } 
            return View(doctor);
        }

        [HttpPost]
        public IActionResult Edit(string id, Doctor model)
        {
            if (ModelState.IsValid)
            {
                 _service.UpdateDoctor(id, model);

                 return RedirectToAction("Index");
            }
            return View(model);

        }

        public IActionResult Delete(string id)
        {
            var doctor = _service.GetDoctor(id);
            return View(doctor);
        }

        [HttpDelete, HttpPost]
        public IActionResult Delete(string id, bool? isDeleted)
        {
            _service.DeleteDoctor(id);
            return RedirectToAction("Index");
        }
    }
}
