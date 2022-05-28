using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.ViewComponents.User
{
    public class UserList:ViewComponent
    {
        UserManager userManager = new UserManager(new EfUserDal());
        public IViewComponentResult Invoke()
        {
            var values = userManager.TGetList();
            return View(values);
        }
    }
}
