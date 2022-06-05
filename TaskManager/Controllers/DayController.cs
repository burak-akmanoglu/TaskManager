using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TaskManager.Controllers
{

    public class DayController : Controller
    {
        DayManager dayManager = new DayManager(new EfDayDal());
        Context c = new Context();

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

            ViewBag.dayyear = (DateTime.Now.DayOfYear).ToString();
        }

        [Authorize]
        public IActionResult Index()
        {
            var obj = dayManager.GetListDay();
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
        public IActionResult Create(Day parametre)
        {
            _ViewBag();
            DayValidator validations = new DayValidator();
            ValidationResult results = validations.Validate(parametre);
            if (results.IsValid)
            {
                dayManager.TAdd(parametre);

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
            var values = dayManager.TGetByID(id);
            dayManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [Authorize]
        [HttpGet]
        public IActionResult Details(int id)
        {
            _ViewBag();
            var values = dayManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(Day day)
        {
            _ViewBag();
            DayValidator validations = new DayValidator();
            ValidationResult results = validations.Validate(day);
            if (results.IsValid)
            {
                dayManager.TUpdate(day);
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

