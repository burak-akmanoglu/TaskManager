using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using Microsoft.EntityFrameworkCore;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;
using FluentValidation;

namespace TaskManager.Controllers
{
    public class MonthController : Controller
    {
        public void _ViewBag()
        {

            UserManager Um = new UserManager(new EfUserDal());
            TaskImportanceManager Tm = new TaskImportanceManager(new EfTaskImportanceDal());
            TaskStatuseManager Ts = new TaskStatuseManager(new EfTaskStatuseDal());   

            List<SelectListItem> umValue = (from i in Um.TGetList()
                                            select new SelectListItem
                                            {
                                                Text = i.UserName,
                                                Value = i.UserID.ToString()
                                            }).ToList();
            ViewBag.Us = umValue;
            List<SelectListItem> tmValue = (from i in Tm.TGetList()
                                            select new SelectListItem
                                            {
                                                Text = i.TaskImportanceName,
                                                Value = i.TaskImportanceID.ToString()
                                            }).ToList();
            ViewBag.tm = tmValue;
            List<SelectListItem> tsValue = (from i in Ts.TGetList()
                                            select new SelectListItem
                                            {
                                                Text = i.TaskStatuseName,
                                                Value = i.TaskStatuseID.ToString()
                                            }).ToList();
            ViewBag.ts = tsValue;
        }
        MonthManager _monthManager = new MonthManager(new EfMonthDal());
        [Authorize]
        public IActionResult Index()
        {
            var obj = _monthManager.GetListMonth();
            return View(obj);
        }
        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            _ViewBag();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Month month)
        {
            _ViewBag();
            MonthValidator validations = new MonthValidator();
            ValidationResult results = validations.Validate(month);
            if (results.IsValid)
            {
                _monthManager.TAdd(month);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
         var values=   _monthManager.TGetByID(id);
            _monthManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [Authorize]
        [HttpGet]
        public IActionResult Details(int id)
        {
            _ViewBag();
            var values= _monthManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(Month month)
        {
            _ViewBag();
            MonthValidator validations = new MonthValidator();
            ValidationResult results = validations.Validate(month);
            if (results.IsValid)
            {
                _monthManager.TUpdate(month);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

    }
}
