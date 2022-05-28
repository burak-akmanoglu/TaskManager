using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.ViewComponents.TaskStatuse
{
    public class TaskStatuseList:ViewComponent
    {
        TaskStatuseManager taskStatuseManager = new TaskStatuseManager(new EfTaskStatuseDal());
        public IViewComponentResult Invoke()
        {
            var values = taskStatuseManager.TGetList();
            return View(values);
        }
    }
}
