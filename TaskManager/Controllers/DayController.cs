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
    public class DayController : Controller
    {
        DayManager dayManager = new DayManager(new EfDayDal());
        [Authorize]
        public IActionResult Index()
        {
            
            var obj = dayManager.TGetList();
            return View(obj);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Day parametre)
        {
            dayManager.TAdd(parametre);

            return RedirectToAction("Index");
           
        }
        public IActionResult Delete(int id)
        {
            var values = dayManager.TGetByID(id);
            dayManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var values = dayManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(Day day)
        {
            dayManager.TUpdate(day);
            return RedirectToAction("Index");
        }
    }
}
