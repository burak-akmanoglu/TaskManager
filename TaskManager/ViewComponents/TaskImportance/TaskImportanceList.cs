using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.ViewComponents.TaskImportance
{
    public class TaskImportanceList:ViewComponent
    {
        TaskImportanceManager taskImportanceManager = new TaskImportanceManager(new EfTaskImportanceDal());
        public IViewComponentResult Invoke()
        {
            var values = taskImportanceManager.TGetList();
            return View(values);
        }
    }
}
