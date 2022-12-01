using BusinessLayer.Concrete;
using DataLayer;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UI.Models;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        TasksManager _tasks = new TasksManager();
        tasks _singletask;
        Context db = new Context();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            var Gorevler = _tasks.List();
            return View(Gorevler);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult durum(int id)
        {
            _singletask = _tasks.GetById(id);
            if (_singletask.Status == "Süreçte")
            {
                _singletask.Status = "Yapıldı";
                _tasks.Update(_singletask);
            }
            else if (_singletask.Status == "Oluşturuldu")
            {
                _singletask.Status = "Süreçte";
                _tasks.Update(_singletask);
            }
            _tasks.Update(_singletask);
            return RedirectToAction("Index");
        }
    }
}
