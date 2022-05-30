using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.ViewComponents.Day
{
    public class DayList:ViewComponent
    {
        DayManager dayManager = new DayManager(new EfDayDal());
        
        public IViewComponentResult Invoke()
        {
            
            var values = dayManager.GetListDay();
            return View(values);
        }
    }
}
