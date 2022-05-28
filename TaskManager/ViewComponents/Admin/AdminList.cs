using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.ViewComponents.Admin
{
    public class AdminList:ViewComponent
    {
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        public IViewComponentResult Invoke()
        {
            var values = adminManager.TGetList();
            return View(values);
        }
    }
}
