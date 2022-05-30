using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Controllers
{
    public class TaskImportanceController : Controller
    {
        TaskImportanceManager _taskImportanceManager = new TaskImportanceManager(new EfTaskImportanceDal());
        [Authorize]
        public IActionResult Index()
        {
            var values = _taskImportanceManager.TGetList();
            return View(values);
        }
        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TaskImportance taskImportance)
        {
            _taskImportanceManager.TAdd(taskImportance);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var values = _taskImportanceManager.TGetByID(id);
            _taskImportanceManager.TDelete(values);

            return RedirectToAction("Index");
        }
        [Authorize]
        [HttpGet]
        public IActionResult Details(int id)
        {
            var values = _taskImportanceManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(TaskImportance taskImportance)
        {
            _taskImportanceManager.TUpdate(taskImportance);
            return RedirectToAction("Index");
        }
    }
}
