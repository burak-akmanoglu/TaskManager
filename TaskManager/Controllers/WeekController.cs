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
    public class WeekController : Controller
    {
        WeekManager weekManager = new WeekManager(new EfWeekDal());
        [Authorize]
        public IActionResult Index()
        {
            var obj = weekManager.TGetList();
            return View(obj);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Week week)
        {
            weekManager.TAdd(week);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var values = weekManager.TGetByID(id);
            weekManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var values = weekManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(Week week)
        {
            weekManager.TUpdate(week);
            return RedirectToAction("Index");
        }
    }
}
