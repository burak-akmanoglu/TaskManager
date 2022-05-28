using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.ViewComponents.Month
{
    public class MonthList:ViewComponent
    {
        MonthManager monthManager = new MonthManager(new EfMonthDal());
        public IViewComponentResult Invoke()
        {
            var values = monthManager.TGetList();
            return View(values);
        }
    }
}
