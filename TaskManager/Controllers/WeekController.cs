﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            var obj = weekManager.GetListWeek();
            return View(obj);
        }
        [Authorize]
        [HttpGet]
        public IActionResult Create()
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
        [Authorize]
        [HttpGet]
        public IActionResult Details(int id)
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
