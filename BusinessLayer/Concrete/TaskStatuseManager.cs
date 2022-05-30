using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TaskStatuseManager:ITaskStatuseService
    {
        ITaskStatuseDal _taskStatuseDal;
        public TaskStatuseManager(ITaskStatuseDal TaskStatuseDal)
        {
            _taskStatuseDal = TaskStatuseDal;
        }

        public List<Day> GetListDayWithUser()
        {
            throw new NotImplementedException();
        }

        public void TAdd(TaskStatuse t)
        {
            _taskStatuseDal.Insert(t);
        }

        public void TDelete(TaskStatuse t)
        {
            _taskStatuseDal.Delete(t);
        }

        public TaskStatuse TGetByID(int id)
        {
            return _taskStatuseDal.GetById(id);
        }

        public List<TaskStatuse> TGetList()
        {
            return _taskStatuseDal.GetList();
        }

        public void TUpdate(TaskStatuse t)
        {
            _taskStatuseDal.Update(t);
        }
    }
}
