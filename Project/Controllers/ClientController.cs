using System;
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
    public class ClientController : Controller
    {
        private readonly ICommonDataManagement _service = new CommonDataManagement();

        public ClientController(ICommonDataManagement service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var clients = _service.GetClients();
            return View(clients);
        }

        public IActionResult Details(string id)
        {
            var client = _service.GetClient(id);
            return View(client);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Client model)
        {
            if (ModelState.IsValid)
            {
                _service.AddClient(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Edit(string id)
        {
            var client = _service.GetClient(id);

            if (client is null)
            {
                throw new Exception($"Client with phone number {id} not found");
            }
            return View(client);
        }

        [HttpPost]
        public IActionResult Edit(string id, Client model)
        {
            if (ModelState.IsValid)
            {
                _service.UpdateClient(id, model);

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(string id)
        {
            var client = _service.GetClient(id);
            return View(client);
        }

        [HttpDelete, HttpPost]
        public IActionResult Delete(string id, bool? isDeleted)
        {
            _service.DeleteClient(id);
            return RedirectToAction("Index");
        }
    }
}