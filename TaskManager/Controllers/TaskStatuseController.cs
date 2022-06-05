using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Controllers
{
    public class TaskStatuseController : Controller
    {
        TaskStatuseManager _taskStatuse = new TaskStatuseManager(new EfTaskStatuseDal());
        [Authorize]
        public IActionResult Index()
        {
            var values = _taskStatuse.TGetList();
            return View(values);
        }
        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TaskStatuse taskStatuse)
        {
            TaskStatuseValidator validations = new TaskStatuseValidator();
            ValidationResult results = validations.Validate(taskStatuse);
            if (results.IsValid)
            {

                _taskStatuse.TAdd(taskStatuse);
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
            var values = _taskStatuse.TGetByID(id);
            _taskStatuse.TDelete(values);
            return RedirectToAction("Index");
        }
        [Authorize]
        [HttpGet]
        public IActionResult Details(int id)
        {
            var values = _taskStatuse.TGetByID(id);

            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(TaskStatuse taskStatuse)
        {

            TaskStatuseValidator validations = new TaskStatuseValidator();
            ValidationResult results = validations.Validate(taskStatuse);
            if (results.IsValid)
            {
                _taskStatuse.TUpdate(taskStatuse);
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
