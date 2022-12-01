using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataLayer;
using EntityLayer;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Admin.Controllers
{
    public class TaskController : Controller
    {
        TasksManager _tasks = new TasksManager();
        tasks _singletask;
        Context db = new Context();

        public IActionResult Index()
        { 
            var Gorevler = _tasks.List();
            
            return View(Gorevler);
        }

        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Add(tasks gorevler)
        {
            TaskValidator gorevValidator = new TaskValidator();
            ValidationResult result = gorevValidator.Validate(gorevler);

            if (result.IsValid)
            {
                _tasks.Add(gorevler);
                _singletask = _tasks.GetById(gorevler.Id);
                if (_singletask.Status == null)
                {
                    _singletask.Status = "Oluşturuldu";
                    _tasks.Update(_singletask);
                }
                
                
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        class durum
        {
            public int Id { get; set; }
            public string durumu { get; set; }
        }
        public IActionResult Update(int id)
        {
            List<durum> Status = new List<durum>
        {
            new durum { Id = 1, durumu = "Oluşturuldu" },
            new durum { Id = 2, durumu = "Süreçte" },
            new durum { Id = 3, durumu = "Yapıldı" }
        };
            ViewBag.status = Status.Select(w => new SelectListItem
            {
                Text = w.durumu
            }).ToList();

            _singletask = _tasks.GetById(id);
            return View(_singletask);
        }

        [HttpPost]
        public IActionResult Update(tasks gorevler)
        {
            TaskValidator gorevValidator = new TaskValidator();
            ValidationResult result = gorevValidator.Validate(gorevler);

            if (result.IsValid)
            {
                _tasks.Update(gorevler);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            _singletask = _tasks.GetById(id);
            _tasks.Delete(_singletask);
            return RedirectToAction("Index");
        }

    }
}
