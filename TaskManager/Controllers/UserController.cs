using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Cookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;

namespace TaskManager.Controllers
{
    public class UserController : Controller
    {
        UserManager _userManager = new UserManager(new EfUserDal());
        [Authorize]
        public IActionResult Index()
        {
            var values = _userManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            UserValidator validations = new UserValidator();
            ValidationResult results = validations.Validate(user);
            if (results.IsValid)
            {

                _userManager.TAdd(user);
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
            var values = _userManager.TGetByID(id);
            _userManager.TDelete(values);

            return RedirectToAction("Index");
        }
        [Authorize]
        [HttpGet]
        public IActionResult Details(int id)
        {
            var values = _userManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
            UserValidator validations = new UserValidator();
            ValidationResult results = validations.Validate(user);
            if (results.IsValid)
            {

                _userManager.TUpdate(user);
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
