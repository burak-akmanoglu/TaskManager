using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Controllers
{
    public class ViewController : Controller
    {
       
        
        public IActionResult TaskFeature()
        {
            return View();
        }
        public IActionResult UserList()
        {
            return View();
        }

        public IActionResult Day()
        {
            return View();
        }
        public IActionResult Week()
        {
            return View();
        }
        public IActionResult Mounth()
        {
            return View();
        }
    }
}
