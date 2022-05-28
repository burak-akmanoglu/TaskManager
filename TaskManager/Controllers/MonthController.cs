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
    public class MonthController : Controller
    {
        MonthManager _monthManager = new MonthManager(new EfMonthDal());
        [Authorize]
        public IActionResult Index()
        {
            var obj = _monthManager.TGetList();
            return View(obj);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Month month)
        {
            _monthManager.TAdd(month);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
         var values=   _monthManager.TGetByID(id);
            _monthManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var values= _monthManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(Month month)
        {
            _monthManager.TUpdate(month);
            return RedirectToAction("Index");
        }

    }
}
