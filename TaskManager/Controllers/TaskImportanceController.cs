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
            TaskImportanceValidator validations = new TaskImportanceValidator();
            ValidationResult results = validations.Validate(taskImportance);
            if (results.IsValid)
            {
                _taskImportanceManager.TAdd(taskImportance);
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
            TaskImportanceValidator validations = new TaskImportanceValidator();
            ValidationResult results = validations.Validate(taskImportance);
            if (results.IsValid)
            {
                _taskImportanceManager.TUpdate(taskImportance);
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
