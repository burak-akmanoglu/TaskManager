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
            _userManager.TAdd(user);
          return RedirectToAction("Index");
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
            _userManager.TUpdate(user);
            return RedirectToAction("Index");

        }
    }
}
