using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Controllers
{
    public class AdminController : Controller
    {
        AdminManager _adminManager = new AdminManager(new EfAdminDal());
        public IActionResult Index()
        {
            var values = _adminManager.TGetList();

            return View(values);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Admin admin)
        {
            _adminManager.TAdd(admin);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var values = _adminManager.TGetByID(id);
            _adminManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var values = _adminManager.TGetByID(id);

            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(Admin admin)
        {
            _adminManager.TUpdate(admin);
            return RedirectToAction("Index");
        }
    }
}
