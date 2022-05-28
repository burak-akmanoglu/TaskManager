using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.ViewComponents.Week
{
    public class WeekList:ViewComponent
    {
        WeekManager weekManager = new WeekManager(new EfWeekDal());
        public IViewComponentResult Invoke()
        {
            var values = weekManager.TGetList();
            return View(values);
        }
    }
}
